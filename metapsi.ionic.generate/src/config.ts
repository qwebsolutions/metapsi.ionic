import { AssetSource } from "@qwebsolutions/metapsi-generator";

export const ionicConfig = {
    /** pinned in this project's package.json - the installed version is read at run time */
    packageName: "@ionic/core",
    csharpNamespace: "Metapsi.Ionic",
    projectFileName: "Metapsi.Ionic.csproj",
    msBuildPropertyName: "IonicVersion",
    targetFileName: "ionic.target",
    /** LogicalName becomes `ionic@<version>/<path>` */
    logicalNameScope: "ionic",
    /** what "dist" means for this package */
    assetSources: [
        { from: "dist/ionic" },
        { from: "css/ionic.bundle.css" }
    ] as AssetSource[],
};
