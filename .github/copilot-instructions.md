# GitHub Copilot Instructions for Storyteller Enhanced (Continued)

## Mod Overview and Purpose
Storyteller Enhanced is an updated version of the mod originally created by Lanilor, with Neptimus7's improvements. The mod aims to enhance the RimWorld experience by introducing new difficulties and storytellers with unique attributes and styles that bring a fresh set of challenges and gameplay experiences.

## Key Features and Systems
- **New Storytellers**: Four unique storytellers—Calista Complex, Raya Relaxed, Matt Moody, and Nora Nothing—each offering different styles of gameplay from unexpected challenges to a relaxed storytelling environment.
- **Enhanced Difficulty Levels**: The mod introduces new difficulties such as Murderous, Post-Apocalyptic, and Spoiled Life, each providing unique challenges that modify resource availability, threat levels, and colonist behavior.
  - **Murderous**: Intense with frequent and severe threats.
  - **Post-Apocalyptic**: Limited resources mixed with high enemy pressure.
  - **Spoiled Life**: Pawns demand more luxury and provide less productivity.

## Coding Patterns and Conventions
- **C# Class Definitions and Purpose**:
  - Classes follow the nomenclature of `Need_<RelatedFunction>`, `Thing_<RelatedFunction>`, `StatWorker_<FunctionName>`, etc.
  - All C# classes are crafted to serve specific needs such as managing fall factors for needs (`Need_Joy_FallPerInterval`, `Need_Rest_RestFallFactor`) as well as overriding product derivations (`Pawn_ButcherProducts`, `Thing_ButcherProducts`)
- **Conventions**:
  - Internal classes are generally used for setup and integration, leveraging the `HarmonySetup` class for patching purposes with Harmony.
  - Public classes are used to define new behavior, usually altering existing game systems like need fall rates or stat calculations.

## XML Integration
- **DefModExtension**: `ModExt_Difficulty` is used to extend RimWorld's XML definitions, allowing the introduction of new difficulties with their unique parameters.

## Harmony Patching
- Harmony is utilized to modify or extend the functionality of the base game. `HarmonySetup.cs` is a central piece in setting up these patches.
- Ensure Harmony prefixes and postfixes are used responsibly to avoid conflicts, especially when dealing with core game mechanics that influence storyteller and difficulty behaviors.

## Suggestions for Copilot
- Given the nature of RimWorld's modding environment, ensure generated methods are effective at handling custom logics and extensions via DefMod and Harmony.
- Use extensive inline comments to document the purpose of patches or class behaviors, especially when modifying fundamental storyteller events.
- Encourage Copilot to suggest pattern-based solutions, particularly useful when dealing with repeated or similar methods dealing with stats and needs.
- Copilot should be guided to suggest error-handling code blocks effectively, especially in the realms of resource manipulation and event triggers.

### Troubleshooting & Reporting
- Users are encouraged to troubleshoot by isolating the mod to check for errors.
- If issues continue, they should use the Log Uploader for logs or the Discord channel for error reporting. Avoid using discussion threads.
- Contribute solutions directly to the GitHub repository to assist in communal problem-solving.

For improved mod compatibility, maintain a well-sorted mod list using RimSort and ensure dependencies are updated.

---

This `.github/copilot-instructions.md` provides comprehensive guidance for developers working on enhancing the mod effectively while integrating Copilot suggestions seamlessly.
