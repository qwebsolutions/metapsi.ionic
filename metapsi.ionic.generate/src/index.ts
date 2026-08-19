import * as gen from "@qwebsolutions/metapsi-generator";
import * as ts from "typescript";

import { ionicConfig } from "./config.js";
import { readIonicDocs, IonicComponent, readIonicMetadata, IonicMetadata, IonicComponentMetadata } from "./readIonicDocs.js";
import { replacePropertyType, mapNumericMethodParameter, mapNumericMethodReturnType, mapNumericProperty } from "@qwebsolutions/metapsi-generator";

export type GenerateIonicOptions = {
    /** the C# project folder, e.g. ...\metapsi\Metapsi.Ionic */
    projectFolder: string;
    /** tags to skip, e.g. legacy controls */
    skipTags?: string[]; // "ion-picker-legacy"
};

export async function generateIonic(options: GenerateIonicOptions): Promise<void> {
    // 1. reflection: where is the pinned package actually installed, and at what version
    const packageRoot = gen.resolvePackageRoot(ionicConfig.packageName, import.meta.url);
    const manifest = gen.readPackageManifest(packageRoot);

    // 2. read the source of truth for the public API
    const docs = await readIonicMetadata(packageRoot);
    const skip = new Set(options.skipTags ?? []);
    const components = docs.components.filter(c => !skip.has(c.tag));

    const ctx = createIonicReadContext();

    // 3. transform - the part that still has to be written
    const csharpFiles = components.map(component => ({
        fileName: "/controls/" + gen.toCSharpValidName(component.tag) + ".cs",
        content: renderComponent(ctx, component),
    }));

    // 4. the "dist" equivalent, as embedded resources
    const assets = gen.collectAssets(packageRoot, ionicConfig.assetSources);


    csharpFiles.push(renderEventDetail(ctx, "ModalDragEventDetail"))
    csharpFiles.push(renderEventDetail(ctx, "RefresherPullEndEventDetail"))
    csharpFiles.push(renderEventDetail(ctx, "ReorderEndEventDetail"))
    csharpFiles.push(renderEventDetail(ctx, "ReorderMoveEventDetail"))

    csharpFiles.push(renderIonType(ctx, "HTMLTextAreaElement"))

    // 5. emit
    const projectOptions: gen.GeneratedProjectOptions = {
        projectFolder: options.projectFolder,
        csharpNamespace: ionicConfig.csharpNamespace,
        msBuildPropertyName: ionicConfig.msBuildPropertyName,
        targetFileName: ionicConfig.targetFileName,
        logicalNameScope: ionicConfig.logicalNameScope,
        version: manifest.version,
        csharpFiles,
        assets,
    };

    await gen.writeGeneratedProject(projectOptions);
}

function mapNumericProperties(model: gen.ApiUnionModel.Class) {
    if (model.name == "ModalDragEventDetail") {
        gen.mapNumericProperty(model.properties, "currentY", { kind: "decimal" })
        gen.mapNumericProperty(model.properties, "deltaY", { kind: "decimal" })
        gen.mapNumericProperty(model.properties, "velocityY", { kind: "decimal" })
        gen.mapNumericProperty(model.properties, "progress", { kind: "decimal" })
        gen.mapNumericProperty(model.properties, "snapBreakpoint", { kind: "decimal" })
    }
    if (model.name == "ReorderEndEventDetail") {
        gen.mapNumericProperty(model.properties, "from", { kind: "int" })
        gen.mapNumericProperty(model.properties, "to", { kind: "int" })
    }

    if (model.name == "ReorderMoveEventDetail") {
        gen.mapNumericProperty(model.properties, "from", { kind: "int" })
        gen.mapNumericProperty(model.properties, "to", { kind: "int" })
    }
}

function renderEventDetail(ctx: IonicReadContext, typeName: string): gen.GeneratedFile {
    var typeSymbol = ctx.topSymbols.find(x => x.name == typeName);
    if (!typeSymbol)
        throw new Error();

    const tsDefinition = gen.loadTsTypeDefinition(ctx.program, typeName);
    const unionModel = gen.typeScriptModelToUnionModel(tsDefinition);
    for (const property of unionModel.properties) {
        property.isReadonly = true;
    }
    mapNumericProperties(unionModel)

    const expanded = gen.toExpandedApiModel(unionModel);
    const resolver = gen.toResolverApiModel(expanded);

    const generatorModel = gen.toGeneratorApiModel(resolver);
    const file = gen.ToCSharpApiFileContent(generatorModel, "Metapsi.Ionic");
    var content = gen.fileToCSharp(file)
    return {
        fileName: `/eventDetails/${typeName}.cs`,
        content
    }
}

function renderIonType(ctx: IonicReadContext, typeName: string): gen.GeneratedFile {
    var typeSymbol = ctx.topSymbols.find(x => x.name == typeName);
    if (!typeSymbol)
        throw new Error();

    const tsDefinition = gen.loadTsTypeDefinition(ctx.program, typeName);
    const unionModel = gen.typeScriptModelToUnionModel(tsDefinition);
    mapNumericProperties(unionModel)

    const expanded = gen.toExpandedApiModel(unionModel);
    const resolver = gen.toResolverApiModel(expanded);

    // The web component path does this inside toResolverWebComponentModel;
    // the API path leaves even string/bool unresolved until you ask.
    //resolveObviousTypeMappings(resolver);

    // // toResolverApiModel calls it `name`, the web component path calls
    // // it `className`. Shim it across, then copy the filtered members
    // // back - resolveModel reassigns the arrays, it does not splice them.
    // const shim = {
    //     className: resolver.name,
    //     properties: resolver.properties,
    //     methods: resolver.methods,
    // };
    // const dropped = resolveModel(shim, unresolved);
    // resolver.properties = shim.properties;
    // resolver.methods = shim.methods;

    const generatorModel = gen.toGeneratorApiModel(resolver);
    const file = gen.ToCSharpApiFileContent(generatorModel, "Metapsi.Ionic");
    return {
        fileName: "/types/" + typeName + ".cs",
        content: gen.fileToCSharp(file)
    }
}

/**
 * Everything the reader needs, created per run instead of at module load.
 *
 * These used to be module-scope constants, which meant merely importing this
 * file executed loadProject() - so the failure happened on `import`, before
 * generateIonic was ever called. It also meant allNumerics accumulated across
 * calls within one process.
 */
type IonicReadContext = {
    program: ts.Program;
    checker: ts.TypeChecker;
    /** symbols of the interfaces inside the `Components` namespace */
    componentSymbols: ts.Symbol[];
    topSymbols: ts.Symbol[];
    allNumerics: gen.RawNumericInstance[];
};

function createIonicReadContext(): IonicReadContext {
    // FIXME: resolved against process.cwd(), so this only works when the cwd is
    // the folder holding the tsconfig. Left as-is deliberately.
    const tsconfigPath = "./tsconfig.json";

    const program = gen.loadProject(tsconfigPath);
    const checker = program.getTypeChecker();

    return {
        program,
        checker,
        componentSymbols: gen.getAllExportedSymbolsInNamespace(program, checker, "Components"),
        topSymbols: gen.getAllExportedSymbols(program, checker),
        allNumerics: [],
    };
}

function loadUnionWebComponent(ctx: IonicReadContext, def: IonicComponentMetadata): gen.WebComponentUnionModel.WebComponent {
    var outComponent: gen.WebComponentUnionModel.WebComponent = {
        className: gen.toCSharpValidName(def.tag),
        tag: def.tag,
        attributes: [],
        comment: "",
        events: [],
        methods: [],
        properties: [],
        slots: []
    }

    var componentSymbol = ctx.componentSymbols.find(x => x.name == outComponent.className);
    const componentType: ts.Type = ctx.checker.getDeclaredTypeOfSymbol(componentSymbol!);
    var componentInterface = gen.getTsTypeDefinition(componentType, ctx.checker);

    // var allExported = tsTypes.getAllExportedSymbols(program, program.getTypeChecker());
    // var ionic = allExported.filter(x => x.name.toLowerCase().includes("overlay"));

    if (def.slots) {
        for (const slot of def.slots) {
            outComponent.slots.push({ name: slot.name ?? "", comment: slot.docs })
        }
    }

    if (def.methods) {
        for (const method of def.methods) {
            const outMethod: gen.UnionModel.Method = { name: method.name, comment: method.docs, isStatic: false, overloads: [] };
            var tsMethod = componentType.getProperty(method.name);
            //var tsMethod = componentInterface.methods.find(x => x.name == method.name);
            if (tsMethod) {
                var methodType = ctx.checker.getTypeOfSymbol(tsMethod);
                var methodTypeReference = gen.getTsTypeReference(methodType, ctx.checker);
                var unionType = gen.toUnionModelType(methodTypeReference);
                if (unionType.kind == "function") {
                    outMethod.overloads.push(...unionType.overloads);
                }
            }

            outComponent.methods.push(outMethod)
        }
    }

    if (def.props) {
        for (const property of def.props) {
            const tsProperty: ts.Symbol | undefined = componentType.getProperty(property.name);
            if (tsProperty) {
                if (tsProperty.name == "buttons") {
                    console.log("buttons")
                }
                var tsPropertyType = ctx.checker.getTypeOfSymbol(tsProperty);
                var tsTypeReference = gen.getTsTypeReference(tsPropertyType, ctx.checker);
                var unionPropertyType = gen.toUnionModelType(tsTypeReference)
                const outProperty: gen.UnionModel.Property = { name: property.name, comment: property.docs, isStatic: false, isReadonly: false, type: unionPropertyType };
                outComponent.properties.push(outProperty);

                if (property.attr) {
                    let usesBoolean = false;
                    let stringVariants: string[] = [];
                    if (unionPropertyType.kind == "boolean") {
                        usesBoolean = true;
                    }
                    else if (unionPropertyType.kind == "union") {
                        if (unionPropertyType.types.some(x => x.kind == "boolean")) {
                            usesBoolean = true;
                        }
                        stringVariants = unionPropertyType.types.filter(x => x.kind == "stringLiteral").map(x => x.value);
                    }

                    if (usesBoolean) {
                        outComponent.attributes.push({ name: property.attr, comment: property.docs, type: { kind: "boolean" } })
                    }
                    else if (stringVariants.length > 0) {
                        for (const stringVariant of stringVariants) {
                            outComponent.attributes.push({ name: property.attr, comment: property.docs, type: { kind: "stringLiteral", value: stringVariant } })
                        }
                    } else {
                        // Do I really need string only if not boolean or variants? 
                        outComponent.attributes.push({ name: property.attr, comment: property.docs, type: { kind: "string" } })
                    }
                    // TODO
                    // const expandedType = gen.expandTypes(outProperty.type);
                    // if (expandedType.some(x => x.kind == "boolean")) {
                    //     outComponent.attributes.push({ name: property.attr, comment: property.docs, type: { kind: "boolean" } })
                    // }
                    // else {
                    //     outComponent.attributes.push({ name: property.attr, comment: property.docs, type: { kind: "string" } })
                    // }
                }
            }
            else {
                throw new Error("Property not found")
            }
            //const outProperty: gen.UnionModel.Property = { name: property.name, comment: property.docs, isStatic: false, isReadonly: false, type: { kind: "any" } };
        }
    }

    if (def.events) {
        for (var event of def.events) {
            if (event.event == "ionSplitPaneVisible") {
                outComponent.events.push({ comment: event.docs ?? "", name: event.event, detailType: { kind: "namedType", name: "SplitPaneVisibleEventDetail", typeArguments: [] } })
                continue;
            }

            if (event.event == "ionTabsDidChange") {
                outComponent.events.push({ comment: event.docs ?? "", name: event.event, detailType: { kind: "namedType", name: "TabsDidChangeEventDetail", typeArguments: [] } })
                continue;
            }

            if (event.event == "ionTabsWillChange") {
                outComponent.events.push({ comment: event.docs ?? "", name: event.event, detailType: { kind: "namedType", name: "TabsWillChangeEventDetail", typeArguments: [] } })
                continue;
            }
            var detailType = event.complexType.resolved;
            if (detailType == "void") {
                detailType = "";
                outComponent.events.push({ comment: event.docs ?? "", name: event.event })
            }
            else if (detailType == "any") {
                detailType = "";
                outComponent.events.push({ comment: event.docs ?? "", name: event.event })
            }
            else {
                var eventDetailSymbol = ctx.topSymbols.find(x => x.name == event.complexType.original);
                var eventType = gen.getTsType(ctx.program, eventDetailSymbol!.name);
                if (eventType) {
                    var tsTypeReference = gen.getTsTypeReference(eventType, ctx.checker);
                    let unionModelType = gen.toUnionModelType(tsTypeReference)
                    if (unionModelType.kind == "namedType" && unionModelType.typeArguments.length == 1 && unionModelType.typeArguments[0].kind == "typeParameter") {
                        unionModelType = { kind: "namedType", name: unionModelType.name, typeArguments: [] }
                    }
                    else if (unionModelType.kind != "namedType") {
                        throw new Error("What is this?")
                    }
                    outComponent.events.push({ comment: event.docs ?? "", name: event.event, detailType: unionModelType })
                    console.log(eventDetailSymbol);
                }
                else throw Error("Event type not found")
            }
            console.log(detailType);
            // outComponent.events.push({comment:  event.docs ?? "", name: event.event, detailType: detailType})
            // outEntities.push({ kind: "event", name: event.event, description: event.docs ?? "", customDetailType: detailType })
        }
    }

    return outComponent;
}


function renderComponent(ctx: IonicReadContext, component: IonicComponentMetadata): string {

    const unionComponent = loadUnionWebComponent(ctx, component);

    if (component.tag == "ion-action-sheet") {
        replacePropertyType(
            unionComponent.properties,
            "buttons",
            {
                kind: "array",
                type: {
                    kind: "union",
                    types: [
                        { kind: "string" },
                        { kind: "namedType", name: "ActionSheetButton", typeArguments: [] }
                    ]
                }
            })
    }

    if (component.tag == "ion-breadcrumbs") {
        mapNumericProperty(unionComponent.properties, "itemsAfterCollapse", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "itemsBeforeCollapse", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "maxItems", { kind: "int" })
    }
    if (component.tag == "ion-datetime") {
        mapNumericProperty(unionComponent.properties, "firstDayOfWeek", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "dayValues", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "hourValues", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "minuteValues", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "monthValues", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "yearValues", { kind: "int" })
        const formatOptions = unionComponent.properties.find(x => x.name == "formatOptions");
        if (formatOptions) {
            formatOptions.type = { kind: "namedType", name: "FormatOptions", module: "Metapsi.Ionic", typeArguments: [] }
        }
    }
    if (component.tag == "ion-input") {
        mapNumericProperty(unionComponent.properties, "debounce", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "max", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "maxlength", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "min", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "minlength", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "value", [{ kind: "int" }, { kind: "decimal" }])
        mapNumericProperty(unionComponent.properties, "counterFormatter", { kind: "int" })
    }
    if (component.tag == "ion-input-otp") {
        mapNumericProperty(unionComponent.properties, "length", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "separators", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "value", { kind: "int" })
    }

    if (component.tag == "ion-loading") {
        mapNumericProperty(unionComponent.properties, "duration", { kind: "int" })
    }

    if (component.tag == "ion-menu") {
        mapNumericProperty(unionComponent.properties, "maxEdgeStart", { kind: "int" })
    }

    if (component.tag == "ion-modal") {
        mapNumericProperty(unionComponent.properties, "backdropBreakpoint", { kind: "decimal" })
        mapNumericProperty(unionComponent.properties, "breakpoints", { kind: "decimal" })
        mapNumericProperty(unionComponent.properties, "initialBreakpoint", { kind: "decimal" })
        mapNumericMethodReturnType(unionComponent.methods, "getCurrentBreakpoint", { kind: "decimal" })
        mapNumericMethodParameter(unionComponent.methods, "setCurrentBreakpoint", "breakpoint", { kind: "decimal" })
    }

    if (component.tag == "ion-picker-column") {
        mapNumericProperty(unionComponent.properties, "value", { kind: "int" })
    }

    if (component.tag == "ion-progress-bar") {
        mapNumericProperty(unionComponent.properties, "value", { kind: "decimal" })
        mapNumericProperty(unionComponent.properties, "buffer", { kind: "decimal" })
    }

    if (component.tag == "ion-range") {
        mapNumericProperty(unionComponent.properties, "activeBarStart", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "debounce", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "max", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "min", { kind: "int" })

        mapNumericProperty(unionComponent.properties, "value", [{ kind: "int" }, { kind: "decimal" }])
        mapNumericProperty(unionComponent.properties, "step", [{ kind: "int" }, { kind: "decimal" }])
        const valueProperty = unionComponent.properties.find(x => x.name == "value")!;
        valueProperty.type = {
            kind: "union", types: [
                { kind: "numberType", type: { kind: "int" } },
                { kind: "numberType", type: { kind: "decimal" } },
                { kind: "namedType", name: "RangeValues", module: "Ionic", typeArguments: [] },
            ]
        };

        const pinFormatter = unionComponent.properties.find(x => x.name == "pinFormatter")!;
        if (pinFormatter.type.kind == "function") {
            pinFormatter.type.overloads[0].parameters[0].type = gen.transformRawNumericType(pinFormatter.type.overloads[0].parameters[0].type, [{ kind: "decimal" }, { kind: "int" }])
            pinFormatter.type.overloads[0].returnType = gen.transformRawNumericType(pinFormatter.type.overloads[0].returnType, [{ kind: "int" }])
        }

        console.log();
        //mapNumericProperty(unionComponent.properties, "pinFormatter", { kind: "decimal" })
    }

    if (component.tag == "ion-refresher") {
        mapNumericProperty(unionComponent.properties, "pullFactor", { kind: "decimal" })
        mapNumericProperty(unionComponent.properties, "pullMax", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "pullMin", { kind: "int" })
        mapNumericMethodReturnType(unionComponent.methods, "getProgress", { kind: "decimal" })
    }

    if (component.tag == "ion-searchbar") {
        mapNumericProperty(unionComponent.properties, "debounce", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "maxlength", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "minlength", { kind: "int" })
    }

    if (component.tag == "ion-segment") {
        mapNumericProperty(unionComponent.properties, "value", { kind: "int" })
    }

    if (component.tag == "ion-segment-button") {
        mapNumericProperty(unionComponent.properties, "value", { kind: "int" })
    }

    if (component.tag == "ion-spinner") {
        mapNumericProperty(unionComponent.properties, "duration", { kind: "int" })
    }

    if (component.tag == "ion-textarea") {
        mapNumericProperty(unionComponent.properties, "cols", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "counterFormatter", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "debounce", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "maxlength", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "minlength", { kind: "int" })
        mapNumericProperty(unionComponent.properties, "rows", { kind: "int" })
    }

    if (component.tag == "ion-toast") {
        mapNumericProperty(unionComponent.properties, "duration", { kind: "int" })
    }

    if (component.tag == "ion-content") {
        mapNumericMethodParameter(unionComponent.methods, "scrollByPoint", "x", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "scrollByPoint", "y", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "scrollByPoint", "duration", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "scrollToBottom", "duration", { kind: "int" })

        mapNumericMethodParameter(unionComponent.methods, "scrollToPoint", "x", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "scrollToPoint", "y", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "scrollToPoint", "duration", { kind: "int" })

        mapNumericMethodParameter(unionComponent.methods, "scrollToTop", "duration", { kind: "int" })
    }

    if (component.tag == "ion-input-otp") {
        mapNumericMethodParameter(unionComponent.methods, "setFocus", "index", { kind: "int" })
    }

    if (component.tag == "ion-item-sliding") {
        mapNumericMethodReturnType(unionComponent.methods, "getOpenAmount", { kind: "int" })
        mapNumericMethodReturnType(unionComponent.methods, "getSlidingRatio", { kind: "decimal" })
    }

    if (component.tag == "ion-nav") {
        mapNumericMethodParameter(unionComponent.methods, "getByIndex", "index", { kind: "int" })
        mapNumericMethodReturnType(unionComponent.methods, "getLength", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "insert", "insertIndex", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "insertPages", "insertIndex", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "popTo", "indexOrViewCtrl", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "removeIndex", "startIndex", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "removeIndex", "removeCount", { kind: "int" })
        const insertPages = unionComponent.methods.find(x => x.name == "insertPages");
        if (insertPages?.overloads) {
            for (const overload of insertPages?.overloads) {
                const insertComponentsParameter = overload.parameters.find(x => x.name == "insertComponents");
                if (insertComponentsParameter?.type.kind == "union") {
                    for (const unionType of insertComponentsParameter.type.types) {
                        if (unionType.kind == "array") {
                            if (unionType.type.kind == "namedType") {
                                if (unionType.type.name == "NavComponentWithProps") {
                                    unionType.type = { kind: "namedType", name: "NavComponentWithProps", typeArguments: [] }
                                }
                            }
                        }
                    }
                }
            }
        }

        const setPages = unionComponent.methods.find(x => x.name == "setPages");
        if (setPages?.overloads) {
            for (const overload of setPages?.overloads) {
                const viewsParameter = overload.parameters.find(x => x.name == "views");
                if (viewsParameter?.type.kind == "union") {
                    for (const unionType of viewsParameter.type.types) {
                        if (unionType.kind == "array") {
                            if (unionType.type.kind == "namedType") {
                                if (unionType.type.name == "NavComponentWithProps") {
                                    unionType.type = { kind: "namedType", name: "NavComponentWithProps", typeArguments: [] }
                                }
                            }
                        }
                    }
                }
            }
        }

        toObjectComponentProps(unionComponent.methods, "setRoot", "componentProps");
        toObjectComponentProps(unionComponent.methods, "insert", "componentProps");
        toObjectComponentProps(unionComponent.methods, "push", "componentProps");
    }

    if (component.tag == "ion-ripple-effect") {
        mapNumericMethodParameter(unionComponent.methods, "addRipple", "x", { kind: "int" })
        mapNumericMethodParameter(unionComponent.methods, "addRipple", "y", { kind: "int" })
    }


    UnGenericPromiseOverlayEventDetail(unionComponent.methods, "onWillDismiss");
    UnGenericPromiseOverlayEventDetail(unionComponent.methods, "onDidDismiss");


    var rawNumeric = gen.getRawNumericTypeUsage(unionComponent);
    ctx.allNumerics.push(...rawNumeric);
    console.log(JSON.stringify(rawNumeric));
    if (rawNumeric.length > 0) {
        throw new Error(`Component ${unionComponent.className} contains raw numeric types`)
    }

    var expanded = gen.toExpandedWebComponentModel(unionComponent);
    var resolver = gen.toResolverWebComponentModel(expanded);
    gen.resolvePropertyModelType(resolver.properties, "buttons", { ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString] })
    var generator = gen.toGeneratorWebComponentModel(resolver);
    var fileContent = gen.toWebComponentFileContent(generator, "Metapsi.Ionic", "IonicNode", "IonicTag");
    const stringFile = gen.fileToCSharp(fileContent)
    return stringFile;
    // try {
    //     fs.mkdirSync("generated", { recursive: true });
    //     fs.writeFileSync("generated/" + unionComponent.className + ".cs", gen.fileToCSharp(fileContent), "utf8");
    //     // test diff with the largest component
    //     if (component.tag == "ion-input") {
    //         fs.writeFileSync("c:/github/qwebsolutions/metapsi/Metapsi.Ionic/generated/controls/" + unionComponent.className + ".cs", gen.fileToCSharp(fileContent), "utf8");
    //     }
    // }
    // catch (ex) {
    //     console.log(ex)
    // }
}

function UnGenericPromiseOverlayEventDetail(methods: gen.UnionModel.Method[], methodName: string) {
    const method = methods.find(x => x.name == methodName)
    if (method) {
        if (method.overloads.length != 1)
            throw new Error("That's not what I was expecting");
        if (method.overloads[0].returnType.kind == "namedType") {
            var promiseReturnType = method.overloads[0].returnType;
            if (promiseReturnType) {
                if (promiseReturnType.name == "Promise") {
                    if (promiseReturnType.typeArguments.length == 1) {
                        promiseReturnType.typeArguments[0] = { kind: "namedType", name: "OverlayEventDetail", typeArguments: [] }
                    }
                }
            }
        }
    }
}

function toObjectComponentProps(methods: gen.UnionModel.Method[], methodName: string, parameterName: string) {
    const method = methods.find(x => x.name == methodName)
    if (method) {
        for (const overload of method.overloads) {
            for (const parameter of overload.parameters) {
                if (parameter.name == parameterName) {
                    parameter.type = { kind: "union", types: [{ kind: "any" }, { kind: "empty", value: "undefined" }] }

                }
            }
        }
    }
}
/**
 * Because this just results in <T> 
 * @param methods 
 * @param methodName 
 * @param parameterName 
 */
function setUnionComponentType(methods: gen.UnionModel.Method[], methodName: string, parameterName: string) {
    const method = methods.find(x => x.name == methodName)
    if (method) {
        for (const overload of method.overloads) {
            for (const parameter of overload.parameters) {
                if (parameter.name == parameterName) {
                    parameter.type = { kind: "union", types: [{ kind: "namedType", name: "", typeArguments: [] },] }

                }
            }
        }
    }
}