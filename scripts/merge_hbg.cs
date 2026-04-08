// MHWS Editor Merge Script - HBG Enhancement
// Open Wp12GlobalActionParam.user.3 (vanilla extract) first, then run this script.
// QoL only: guard, gatling cost, special ammo. No damage multipliers, no energy recovery changes.

var root = file.rsz.GetEntryObject<App_user_data_Wp12ActionParam>();

// === RESET PREVIOUSLY MODIFIED PARAMS TO TRUE VANILLA ===
// Vanilla values confirmed from fresh PAK extract (re_chunk_000.pak.patch_012.pak).
// Safe to run on any version of the file — previous sessions used wrong vanilla values.
root.TurnSpeed = 400;                          // vanilla
root.AmmoLimit_Normal = 7;                     // vanilla (ammo handled by BG Ammo Tweaks lua)
root.AmmoLimit_Penetrate = 3;                  // vanilla
root.AmmoLimit_ShotGun = 5;                    // vanilla
root.Energy_AutoRecoverSpeed = 3.0f;           // vanilla=1.9 (buffed ~58% faster regen; 100 was MoreGatlinFun and caused crashes)
root.Energy_AutoRecoverReserveRate = 0.2f;     // vanilla
root.Energy_ShotGunShootRecover = 2.4f;        // vanilla
root.Energy_StealthShotRecover = 30;           // vanilla
root.Energy_CustomEfficiency_Fast = 1.1f;      // vanilla
root.Energy_CustomEfficiency_Slow = 0.9f;      // vanilla
root.GatlingBullet_ShootInterval = 0.18f;      // TRUE vanilla (0.1 was MoreGatlinFun, not vanilla)
var parryReset = root.EnergyParryHitRecoverData;
parryReset[0].HitRecover = 10;  parryReset[0].SuccessRecover = 25;  // vanilla
parryReset[1].HitRecover = 10;  parryReset[1].SuccessRecover = 25;  // vanilla
parryReset[2].HitRecover = 15;  parryReset[2].SuccessRecover = 30;  // vanilla
parryReset[3].HitRecover = 20;  parryReset[3].SuccessRecover = 35;  // vanilla
var snipeReset = root.WeakPointSnipeBulletHitRecoverData;
snipeReset[0].Value = 15;  snipeReset[1].Value = 40;  snipeReset[2].Value = 45;  snipeReset[3].Value = 50;  // vanilla

// === GUARD / SHIELD ===
root.GuardPower_S = 25;                        // vanilla=14
root.GuardPower_M = 35;                        // vanilla=20
root.GuardDamageReduceRate_S = 0.4f;           // vanilla=0
root.GuardDamageReduceRate_M = 0.5f;           // vanilla=0.1
root.GuardDamageReduceRate_L = 0.6f;           // vanilla=0.2
root.GuardDamageReduceRate_Tech = 0.4f;        // vanilla=0
root.GuardDamageReduceRate_Tech_M = 0.6f;      // vanilla=0.2

// === GATLING (WYVERNHEART FIRE MODE) ===
// All regen params at true vanilla. Only per-shot cost reduced.
root.GatlingBullet_BasicData[0].MinUseEnergy = 1.0f;    // vanilla=2.5

// === ENERGY LASER ===
root.EnergyLaserBullet_BasicData[0].MinUseEnergy = 12f; // vanilla=20

// === PARRY BULLET (FOCUS BLAST) ===
root.ParryBullet_BasicData[0].MinUseEnergy = 8f;        // vanilla=15
root.ParryBulletRange = 9f;                              // vanilla=7

// === ENERGY GRENADE ===
root.EnergyGrenadeBullet_BasicData[0].MinUseEnergy = 8f;    // vanilla=15
root.EnergyGrenadeBullet_SpreadRange = 10f;                  // vanilla=8
root.EnergyGrenadeBullet_MaxRange = 18f;                     // vanilla=15

// === WEAKPOINT SNIPE ===
root.WeakPointSnipeBullet_MaxBulletNum = 4;                  // vanilla=3
root.WeakPointSnipeBullet_AddBulletTime = 18f;               // vanilla=23

// === RYUUGEKI (FOCUS BLAST BURST) ===
root.RyuugekiChargeTimer = 1.1f;   // vanilla=1.5
root.Ryuugeki_Range = 8f;          // vanilla=6.5

System.Windows.MessageBox.Show("HBG merge complete! Now save the file (Ctrl+S).");
