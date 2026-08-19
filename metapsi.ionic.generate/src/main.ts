import * as path from "path";
import { generateIonic } from "./index.js";
import * as ionic from "@ionic/core" //<- reference it even if not directly used

// main.ts only turns arguments into options - never any generation logic
const projectFolder = path.resolve(process.argv[2] ?? "generated");

await generateIonic({
    projectFolder,
    skipTags: ["ion-picker-legacy", "ion-select-modal"],
});
