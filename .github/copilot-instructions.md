# GitHub Copilot Instructions for Storyteller Enhanced (Continued) Mod

## Mod Overview and Purpose
Storyteller Enhanced (Continued) is a RimWorld mod that updates Lanilors mod based on Neptimus7's update. The mod introduces new difficulties and storytellers to enhance the Rimworld experience by improving the threat cycles and story event triggers. It offers unique gameplay experiences with various challenges and customizable attributes.

## Key Features and Systems
- **New Difficulties**: Four new difficulties (Murderous, Post-Apocalyptic, Spoiled Life) are introduced to increase the challenge level.
- **Enhanced Storytellers**: Four storytellers (Calista Complex, Raya Relaxed, Matt Moody, Nora Nothing) with unique styles and event generation patterns.
- **Complex Threat Cycles**: More varied and less predictable threat cycles compared to vanilla storytellers.
- **Custom Attributes**: Custom attributes to create new challenges and unique gameplay experiences.

## Coding Patterns and Conventions
- **Harmony Patching**: The mod uses Harmony for patching RimWorld's code.
- **Mod Extensions**: Mod extensions are used to add new attributes and behaviors to RimWorld's existing classes.
- **XML Defs**: XML files are used to define new difficulties and storytellers.
- **C# Patches**: C# files contain the logic for Harmony patches.

## XML Integration
XML files are essential for defining new content in RimWorld. The mod uses XML files for:
- **DifficultyDefs**: Defining new difficulty levels.
- **Storytellers**: Defining new storytellers with unique event generation patterns.

## Harmony Patching
Harmony is used to patch RimWorld's code to modify its behavior. The mod includes several Harmony patches:
- **HarmonySetup.cs**: Contains the initialization logic for Harmony patches.
- **Need_Joy_FallPerInterval.cs**: Patches the `FallPerInterval` method of the `Need_Joy` class.
- **Need_Rest_RestFallFactor.cs**: Patches the `RestFallFactor` property of the `Need_Rest` class.
- **Pawn_ButcherProducts.cs**: Patches the `ButcherProducts` method of the `Pawn` class.

## Suggestions for Copilot
- **Use XML Snippets**: When generating XML files, suggest snippets that follow the RimWorld XML schema.
- **Harmony Patch Templates**: Provide templates for Harmony patches to ensure they follow the correct pattern.
- **Mod Extension Examples**: Show examples of how to create and use mod extensions for adding custom attributes.
- **Complex Threat Cycle Logic**: Offer guidance on implementing more complex threat cycle logic.

By following these instructions, you can effectively use GitHub Copilot to assist with developing and maintaining the Storyteller Enhanced (Continued) mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

