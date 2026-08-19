import * as fsp from "fs/promises";
import * as path from "path";

/**
 * Ionic is a Stencil project, so `dist/docs.json` is the docs-json output target:
 * the public API only (no @internal members), with typed method signatures,
 * event detail types and a typeLibrary of every referenced named type.
 *
 * Only the fields this generator consumes are declared here.
 */
export type IonicDocs = {
    components: IonicComponent[];
    typeLibrary: Record<string, { path: string; declaration: string; docstring: string }>;
};

export type IonicComponent = {
    tag: string;
    docs: string;
    props: { name: string; attr?: string; type: string; docs: string; default?: string; required: boolean }[];
    methods: { name: string; docs: string; signature: string }[];
    events: { event: string; detail: string; docs: string }[];
    slots: { name: string; docs: string }[];
};



export type IonicMetadata = {
    components: IonicComponentMetadata[];
    typeLibrary?: Record<string, IonicLibraryInterface>;
};

export type IonicTypeOptions = {
    IsCollection: boolean;
    IsLiteral: boolean;
    IsFunction: boolean;
    LeafType: string;
    Options: IonicTypeOptions[];
};

export type IonicComponentMetadata = {
    tag: string;
    docs: string;
    props: IonicPropMetadata[];
    events: IonicEventMetadata[];
    slots: IonicSlotMetadata[];
    methods: IonicMethodMetadata[];
};

export type IonicPropMetadata = {
    name: string;
    attr: string;
    type: string;
    docs: string;
    default?: string;   // 'default' is a reserved word, but allowed as a property
    optional: boolean;
    required: boolean;
};

export type IonicEventMetadata = {
    event: string;  // '@event' in C# mapped to 'event' here
    detail: string;
    docs: string;
    complexType: IonicEventTypeMetadata;
};

export type IonicEventTypeMetadata = {
    original: string;
    resolved: string;
};

export type IonicSlotMetadata = {
    name: string;
    docs: string;
};

export type IonicMethodMetadata = {
    name: string;
    docs: string;
    complexType: IonicMethodType;
};

export type IonicMethodType = {
    signature: string;
    parameters: IonicMethodParameter[];
};

export type IonicMethodParameter = {
    name: string;
    type: string;
    docs: string;
};

export type IonicLibraryInterface = {
    declaration: string;
};

export async function readIonicDocs(packageRoot: string): Promise<IonicDocs> {
    const docsPath = path.join(packageRoot, "dist", "docs.json");
    return JSON.parse(await fsp.readFile(docsPath, "utf-8")) as IonicDocs;
}

export async function readIonicMetadata(packageRoot: string): Promise<IonicMetadata> {
    const docsPath = path.join(packageRoot, "dist", "docs.json");
    return JSON.parse(await fsp.readFile(docsPath, "utf-8")) as IonicMetadata;
}
