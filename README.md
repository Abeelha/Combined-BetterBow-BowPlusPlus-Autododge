# Combined Weapon Mods — Bow & HBG for Monster Hunter Wilds

A collection of merged, conflict-free weapon overhauls for Monster Hunter Wilds. Each weapon gets its own combined mod that bundles multiple community mods into a single Fluffy Mod Manager install.

---

## [Bow — Combined-BetterBow-Bow++-Autododge](https://www.nexusmods.com/monsterhunterwilds/mods/4247)


<img width="4847" height="3823" alt="Bow_1" src="https://github.com/user-attachments/assets/fe2c49a9-48c2-4d73-9f21-ff9b35ad0142" />

Merges [Better Bow](https://www.nexusmods.com/monsterhunterwilds/mods/539) and [Bow Plus Plus](https://www.nexusmods.com/monsterhunterwilds/mods/1905) at the parameter level using MHWS Editor scripting, producing a single `Wp11GlobalActionParam.user.3` with all features from both mods plus additional QoL boosts.

### Quick install (Bow)

1. Download `release/Bow/`.
2. Place `natives/` inside your Fluffy Mod Manager mods directory as a single mod.
3. Disable standalone Better Bow and Bow Plus Plus to avoid conflicts.
4. Enable Combined-BetterBow-Bow++.

Requires [REFramework](https://www.nexusmods.com/monsterhunterwilds/mods/93)

### What is in the Bow merge

#### From Better Bow (base file)

All nested object data is preserved from Better Bow 10x, which means multi-lockon and bottle structures remain intact at the binary level.

| Parameter | Value |
|---|---|
| Bottle SetNum (all 8 coating types) | 100 each |
| MultiLockonNum | 4 |
| MultiLockon nested struct | Fully preserved |

#### From Bow Plus Plus (overlaid changes)

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
| ParryHyperArmorDamageRate | 0.2 |
| MiniTsugiya scatter offsets | Tightened to ±0.2 |

#### From Extra Spice (cherry picked)

| Parameter | Value |
|---|---|
| ShottingStaminaRecoverSpeedRate | 0.6 |
| QuickShotBottleEffectiveRate | 1.1 |

#### Boosted beyond all three mods

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

#### Added in v1.1

| Parameter | Value | Notes |
|---|---|---|
| MikiriSuccessHATime | 1.5 | Extended Just Dodge Hyper Armor duration |
| CloseBottleRangeRate | 0.75 | Extended close-range coating distance |
| MultiLockon_DegRange | 120 | Wider multi-lockon detection cone |

---

## [HBG — Combined-HBG-Enhanced](https://www.nexusmods.com/monsterhunterwilds/mods/4251)

<img width="2560" height="1440" alt="Cover" src="https://github.com/user-attachments/assets/355a10cd-3b9e-4f92-a3e9-4e3caeb7d009" />


Pure QoL and survivability overhaul for Heavy Bowgun. No damage multipliers — focused on guard effectiveness, energy recovery, special ammo accessibility, and mobility. Bundles five community mods into a single install alongside a custom `Wp12GlobalActionParam.user.3` produced with MHWS Editor scripting.

### Quick install (HBG)

1. Run `scripts/merge_hbg.cs` in MHWS Editor against `Wp12GlobalActionParam.user.3` and save the output to `release/HBG/natives/STM/GameDesign/Player/ActionData/Wp12/GlobalParam/`.
2. Download `release/HBG/`.
3. Place its contents into your Fluffy Mod Manager mods directory as a single mod.
4. Disable the standalone versions of all bundled mods listed below.
5. Enable Combined-HBG-Enhanced.

Requires [REFramework](https://www.nexusmods.com/monsterhunterwilds/mods/93)

### Bundled mods (HBG)

| Mod | Source | What it does |
|---|---|---|
| [Infinite Bowgun Ammo](https://www.nexusmods.com/monsterhunterwilds/mods/214) | `itemData.user.3` binary | All ammo types never deplete |
| [Bowgun Critical Distance Fixed](https://www.nexusmods.com/monsterhunterwilds/mods/3005) | `PlayerSkillParam.user.3` binary | Zero minimum critical distance — point blank shots deal full damage |
| [BG Ammo Tweaks](https://www.nexusmods.com/monsterhunterwilds/mods/3370) | Lua (15 cap + All SL Maxed) | Enables all ammo types on HBG, sets 15 round capacity, maxes shell levels |
| [Full-Auto Bowguns](https://www.nexusmods.com/monsterhunterwilds/mods/1126) | Lua | Hold trigger to auto-fire and auto-reload |
| [More Gatlin Fun](https://www.nexusmods.com/monsterhunterwilds/mods/1012) | Superseded by merge script | Original set MinUseEnergy to 0.01; our script uses 0.1 for balance |

### What the merge script changes (Wp12GlobalActionParam)

All changes are QoL only — no damage multipliers.

#### Guard / Shield

| Parameter | Vanilla | Ours |
|---|---|---|
| GuardPower_S | 14 | 35 |
| GuardPower_M | 20 | 50 |
| GuardDamageReduceRate_S | 0 | 0.6 |
| GuardDamageReduceRate_M | 0.1 | 0.7 |
| GuardDamageReduceRate_L | 0.2 | 0.8 |
| GuardDamageReduceRate_Tech | 0 | 0.6 |
| GuardDamageReduceRate_Tech_M | 0.2 | 0.8 |

#### Ammo capacity

| Parameter | Vanilla | Ours |
|---|---|---|
| AmmoLimit_Normal | 7 | 15 |
| AmmoLimit_Penetrate | 3 | 15 |
| AmmoLimit_ShotGun | 5 | 15 |

#### Energy / Wyvernheart recovery

| Parameter | Vanilla | Ours |
|---|---|---|
| Energy_AutoRecoverSpeed | 100 | 500 |
| Energy_AutoRecoverReserveRate | 0.2 | 0.01 |
| Energy_ShotGunShootRecover | 2.4 | 20 |
| Energy_StealthShotRecover | 30 | 100 |
| Energy_CustomEfficiency_Fast | 1.1 | 2.0 |
| Energy_CustomEfficiency_Slow | 0.9 | 1.5 |

#### Gatling (Wyvernheart fire mode)

| Parameter | Vanilla | MoreGatlinFun | Ours |
|---|---|---|---|
| GatlingBullet MinUseEnergy | 2.5 | 0.01 | 0.1 |
| GatlingBullet_ShootInterval | 0.1 | — | 0.085 |

#### Special ammo — energy cost & QoL

| Parameter | Vanilla | Ours |
|---|---|---|
| EnergyLaser MinUseEnergy | 20 | 8 |
| ParryBullet MinUseEnergy | 15 | 5 |
| ParryBulletRange | 7 | 12 |
| EnergyGrenade MinUseEnergy | 15 | 5 |
| EnergyGrenadeBullet_SpreadRange | 8 | 12 |
| EnergyGrenadeBullet_MaxRange | 15 | 20 |
| WeakPointSnipeBullet_MaxBulletNum | 3 | 5 |
| WeakPointSnipeBullet_AddBulletTime | 23 | 12 |
| RyuugekiChargeTimer | 1.5 | 0.8 |
| Ryuugeki_Range | 6.5 | 10 |

#### Parry (Focus Blast) energy recovery on hit

| Level | HitRecover vanilla → ours | SuccessRecover vanilla → ours |
|---|---|---|
| 0 | 10 → 20 | 25 → 60 |
| 1 | 10 → 20 | 25 → 60 |
| 2 | 15 → 25 | 30 → 70 |
| 3 | 20 → 30 | 35 → 80 |

#### Mobility

| Parameter | Vanilla | Ours |
|---|---|---|
| TurnSpeed | 400 | 600 |

---

## Repo structure

```
├── release/
│   ├── Bow/                         # Fluffy Mod Manager drop-in for Bow
│   │   ├── modinfo.ini
│   │   └── natives/                 # Merged Wp11GlobalActionParam.user.3
│   └── HBG/                         # Fluffy Mod Manager drop-in for HBG
│       ├── modinfo.ini
│       ├── natives/
│       │   └── STM/GameDesign/
│       │       ├── Common/Item/
│       │       │   └── itemData.user.3              # Infinite ammo
│       │       └── Player/ActionData/
│       │           ├── Common/GlobalParam/Part/
│       │           │   └── PlayerSkillParam.user.3  # Zero min crit distance
│       │           └── Wp12/GlobalParam/
│       │               └── Wp12GlobalActionParam.user.3  # Merge script output
│       └── reframework/autorun/
│           ├── fabg.lua + fabg/                     # Full-auto bowgun
│           ├── BG_Ammo_Tweaks_-_15_Ammo_Cap_(HeavyBowgun).lua
│           └── BG_Ammo_Tweaks_-_All_SL_Maxed_(HeavyBowgun).lua
├── source/
│   ├── BOW/
│   │   ├── better-bow/
│   │   ├── bow-plusplus/
│   │   └── extra-spice/
│   └── HBG/                         # Original source files for all bundled HBG mods
├── scripts/
│   ├── merge_script.cs              # Bow merge (MHWS Editor)
│   ├── merge_hbg.cs                 # HBG merge (MHWS Editor)
│   ├── export_data.cs               # Export Wp11 to JSON
│   └── export_hbg.cs                # Export Wp12 to JSON (filters WPF bloat)
├── exports/
│   ├── better-bow.json
│   ├── bow-plusplus.json
│   └── extra-spice.json
├── export.json                      # Current merged Bow params
├── export-hbg.json                  # Current merged HBG params
└── README.md
```

## How the merge was done

This section documents the full process for anyone who wants to replicate it or merge other conflicting mods.

### Prerequisites

- [MHWS Editor](https://www.nexusmods.com/monsterhunterwilds/mods/401) (Synthlight's RE Engine .user file editor)
- The source `.user.3` files from each mod you want to merge

### Step 1: Export each mod's data to JSON

Open each `.user.3` file in MHWS Editor and use the Run Code feature to dump all parameters to a readable JSON file. Scripts are at `scripts/export_data.cs` (Bow / Wp11) and `scripts/export_hbg.cs` (HBG / Wp12). The HBG script filters out WPF color metadata that would otherwise bloat the output to 500KB+.

Paste the script into the Run Code window, hit Run, and it writes a JSON file to disk.

### Step 2: Diff the exports

Compare JSON exports to identify which fields each mod changes. The key categories are:

1. **Scatter lists** (shot spread patterns, arrays of X/Y coordinates) — Bow only
2. **Simple floats/ints** (charge times, damage rates, energy costs)
3. **Nested objects** (BottleParamData, MultiLockonParam, special ammo ChargeInfo)

### Step 3: Write a merge script

The merge scripts (`scripts/merge_script.cs`, `scripts/merge_hbg.cs`) are C# snippets that run inside MHWS Editor. Open the base file, paste the script into Run Code, run it, then save. The editor's typed API correctly handles nested RSZ objects, array indexing, and type casting.

### Step 4: Verify

Export the merged file using the same JSON export script and diff it against your expectations.

### Why binary patching does not work

`.user.3` files use RE Engine's RSZ serialization format — fields are not at fixed offsets, and nested objects contain their own serialized data. Patching the wrong bytes corrupts nested structures silently. Using the MHWS Editor scripting API avoids this entirely.

---

## Credits

### Bow mod
- [Better Bow](https://www.nexusmods.com/monsterhunterwilds/mods/539) by its original author
- [Bow Plus Plus](https://www.nexusmods.com/monsterhunterwilds/mods/1905) by its original author

### HBG mod
- [Infinite Bowgun Ammo](https://www.nexusmods.com/monsterhunterwilds/mods/214) by its original author
- [Bowgun Critical Distance Fixed](https://www.nexusmods.com/monsterhunterwilds/mods/3005) by its original author
- [BG Ammo Tweaks](https://www.nexusmods.com/monsterhunterwilds/mods/3370) by LordGregory
- [Full-Auto Bowguns](https://www.nexusmods.com/monsterhunterwilds/mods/1126) by its original author
- [More Gatlin Fun](https://www.nexusmods.com/monsterhunterwilds/mods/1012) by its original author (energy cost rebalanced in our merge)

### Tools
- [MHWS Editor](https://www.nexusmods.com/monsterhunterwilds/mods/401) by Synthlight
- Merge work and repo by Abeelha

---

## Donation

If this saved your sanity, consider buying me a coffee:

```
Bitcoin  (BTC)  bc1qk5jlu7hk05uvfpt33pgeaf78lzvnkgjyur8q04
Ethereum (ETH)  0xd8834fc5330896405EC1A5db4bE997093E0408A7
USDC     (ETH)  0xd8834fc5330896405EC1A5db4bE997093E0408A7
```

---
