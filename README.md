# Apex Bow

A merged bow overhaul for Monster Hunter Wilds that combines the best features of [Better Bow](https://www.nexusmods.com/monsterhunterwilds/mods/539) and [Bow Plus Plus](https://www.nexusmods.com/monsterhunterwilds/mods/1905) into a single, conflict-free mod. Includes an integrated [AutoDodge](https://www.nexusmods.com/monsterhunterwilds/mods/32) wrapper with persistent English configuration.

![Cover](Cover.png)

Both Better Bow and Bow Plus Plus modify the same game file (`Wp11GlobalActionParam.user.3`), which means they conflict when loaded together through Fluffy Mod Manager. This project solves that by merging their changes at the parameter level using MHWS Editor scripting, producing a single file that carries all features from both mods with additional quality of life boosts on top.

This repo also serves as a reference for anyone looking to merge two conflicting `.user.3` mods. The full process, tools, and scripts are documented below.

## Quick install

1. Download the `release/` folder contents.
2. Place `natives/` and `reframework/` inside your Fluffy Mod Manager mods directory as a single mod.
3. Disable the standalone Better Bow, Bow Plus Plus, and AutoDodge mods to avoid conflicts.
4. Enable Apex Bow.

Requires [REFramework](https://www.nexusmods.com/monsterhunterwilds/mods/1) and LooseFileLoader to be active.

## What is in the merge

### From Better Bow (base file)

All nested object data is preserved from Better Bow 10x, which means multi-lockon and bottle structures remain intact at the binary level.

| Parameter | Value |
|---|---|
| Bottle SetNum (all 8 coating types) | 100 each |
| MultiLockonNum | 4 |
| MultiLockon nested struct | Fully preserved |

### From Bow Plus Plus (overlaid changes)

Bow Plus Plus contributes tighter shot grouping, faster charges, better dodge windows, and stronger coatings.

| Parameter | Value |
|---|---|
| All 22 scatter/spread lists | Halved (tighter shot grouping) |
| ChargeTimeLv2 / Lv3 / Lv4 | 0.8 / 1.6 / 2.4 |
| KyokushaChargeTimeLv2 / Lv3 / Lv4 | 0.4 / 0.8 / 1.2 |
| KyokushaAimSpeed | 20 |
| KyokushaAimMaxDistance | 20 |
| KyokushaHeight | 20 |
| KyokushaChildFallTime (arc drop speed) | 0.1 |
| KyokushaAimRadius (4 tiers) | 2.0 / 2.5 / 3.0 / 4.0 |
| SkillDodgeJudgeTimeRate (5 levels) | 1.2 / 1.4 / 1.6 / 1.8 / 2.0 |
| MiniTsugiyaNum (4 tiers) | 5 / 10 / 15 / 20 |
| MaxMiniTsugiyaNum | 20 |
| MiniTsugiyaInterval | 0.1 |
| MultiLockon MaxDetectionDist | 30 |
| MultiLockon FirstTargetAddTime | 0.4 |
| CloseBottleGravityRate | 6 |
| CloseBottleRangeRate | 0.5 |
| ParryHyperArmorDamageRate | 0.2 |
| MiniTsugiya scatter offsets | Tightened to ±0.2 |

### From Extra Spice (cherry picked)

| Parameter | Value |
|---|---|
| ShottingStaminaRecoverSpeedRate | 0.6 |
| QuickShotBottleEffectiveRate | 1.1 |

### Boosted beyond both mods

These values were pushed higher than either mod provides individually.

| Parameter | Value | Comparison |
|---|---|---|
| CloseBottleAttackUpRate | 1.7 | B++ had 1.6, BB had 1.4 |
| StrongBottleAttackUpRate | 1.6 | B++ had 1.5, BB had 1.35 |
| ParalyseBottleAtk | 20 | B++ had 15, BB had 10 |
| PoisonBottleAtk | 25 | B++ had 20, BB had 10 |
| SleepBottleAtk | 25 | ES had 20, BB had 10 |
| BlastBottleAtk | 25 | B++ had 20, BB had 10 |
| StaminaBottleAtk | 20 | B++ value |
| StaminaBottleStun | 25 | B++ had 20, BB had 5 |
| MikiriSuccessStaminaRecover | 120 | B++ had 100, BB had 60 |
| MikiriAddGauge | 25 | B++ had 20, BB had 10 |
| SuperMikiriSuccessStaminaRecover | 220 | B++ had 200, BB had 130 |
| SuperMikiriAddGauge | 55 | B++ had 50, BB had 25 |

### AutoDodge integration

The release includes the AutoDodge DLL plugin alongside a Lua wrapper (`auto_DualBlades_Dodge_entry.lua`) that provides:

- An English configuration panel in REFramework's Script Generated UI
- JSON based settings persistence at `reframework/data/auto_dodge_config.json`
- Configurable dodge threshold (default 0.1, tunable from the in-game panel)

The DLL's internal UI is in Chinese with a hardcoded 0.5 threshold. The wrapper bypasses both issues by injecting configuration at the REFramework level.

## Repo structure

```
├── release/                 # Drop this into Fluffy Mod Manager
│   ├── modinfo.ini
│   ├── natives/...          # Merged Wp11GlobalActionParam.user.3
│   └── reframework/         # AutoDodge plugin + Lua config wrapper
├── source/                  # Original unmodified mod files
│   ├── better-bow/          # Wp11GlobalActionParam.user.3 (10x bottles + multilockon)
│   ├── bow-plusplus/         # Wp11GlobalActionParam.user.3 (spread + coatings + dodge)
│   ├── extra-spice/         # Wp11GlobalActionParam.user.3 (stamina + damage tweaks)
│   └── autododge/           # DLL + Lua entry point
├── scripts/
│   ├── merge_script.cs      # MHWS Editor script that applies the merge
│   └── export_data.cs       # MHWS Editor script that exports .user.3 to JSON
├── exports/                 # JSON dumps of each source file for diffing
│   ├── better-bow.json
│   ├── bow-plusplus.json
│   └── extra-spice.json
├── Cover.png
└── README.md
```

## How the merge was done

This section documents the full process for anyone who wants to replicate it or merge other conflicting mods.

### Prerequisites

- [MHWS Editor](https://www.nexusmods.com/monsterhunterwilds/mods/32) (Synthlight's RE Engine .user file editor)
- The source `.user.3` files from each mod you want to merge

### Step 1: Export each mod's data to JSON

Open each `.user.3` file in MHWS Editor and use the Run Code feature to dump all parameters to a readable JSON file. The export script is at `scripts/export_data.cs`. Paste it into the Run Code window, hit Run, and it writes a JSON file to disk.

This gives you a complete, human readable view of every field and nested object, which is critical because `.user.3` files are binary RSZ format with nested structs that simple hex diffing will miss.

### Step 2: Diff the exports

Compare the JSON exports to identify which fields each mod changes. The key categories are:

1. **Scatter lists** (shot spread patterns, arrays of X/Y coordinates)
2. **Simple floats/ints** (charge times, damage rates, stamina values)
3. **Nested objects** (BottleParamData with SetNum per coating, MultiLockonParam with detection config)

A Python script or any JSON diff tool works for this.

### Step 3: Write a merge script

The merge script (`scripts/merge_script.cs`) is a C# snippet that runs inside MHWS Editor. It opens one mod's file as the base, then programmatically sets each field to the desired merged value. This approach is reliable because it uses the editor's own typed API, meaning it correctly handles nested RSZ objects, array indexing, and type casting.

Open the base file in MHWS Editor, paste the merge script into Run Code, run it, then save the result.

### Step 4: Verify

Export the merged file using the same JSON export script and diff it against your expectations. Every field should match your intended values.

### Why binary patching does not work for these files

Early attempts at merging via raw byte offset patching failed because `.user.3` files use RE Engine's RSZ serialization format. Fields are not at fixed offsets you can predict from the editor view. Nested objects ("Open" buttons in the editor) contain their own serialized data, and patching the wrong bytes corrupts the nested structures silently. The game loads the file without error but the values have no effect.

Using the MHWS Editor's scripting API avoids this entirely because it operates on the deserialized object model.

## Credits

- [Better Bow](https://www.nexusmods.com/monsterhunterwilds/mods/539) by its original author
- [Bow Plus Plus](https://www.nexusmods.com/monsterhunterwilds/mods/1905) by its original author
- [AutoDodge (auto_DualBlades_Dodge)](https://www.nexusmods.com/monsterhunterwilds/mods/32) by its original author
- [MHWS Editor](https://www.nexusmods.com/monsterhunterwilds/mods/32) by Synthlight
- Merge work and repo by Abeelha
