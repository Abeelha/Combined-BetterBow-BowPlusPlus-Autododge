// MHWS Editor Merge Script - Paste into "Run Code on File"
// Open Better Bow 10x file first, then run this script.
// It applies Bow++ spread/dodge/coating changes + Extra Spice bonuses on top.

var root = file.rsz.GetEntryObject<App_user_data_Wp11ActionParam>();

// === ARC SHOT (Kyokusha) - use B++ values ===
root.KyokushaAimInputTime = 0.15f;     // B++ faster aim input
root.KyokushaAimSpeed = 20;            // B++ faster aim
root.KyokushaAimMaxDistance = 20;       // B++ longer range
root.KyokushaAimMinDistance = 4;        // B++ closer min
root.KyokushaHeight = 20;              // B++ taller arc
root.KyokushaChildFallTime = 0.1f;     // B++ fastest drop

// Arc charge times - B++ values (faster than BB)
root.KyokushaChargeTimeLv2 = 0.4f;     // B++
root.KyokushaChargeTimeLv3 = 0.8f;     // B++
root.KyokushaChargeTimeLv4 = 1.2f;     // B++

// === CHARGE TIMES - use B++ faster values ===
root.ChargeTimeLv2 = 0.8f;             // B++ faster
root.ChargeTimeLv3 = 1.6f;             // B++ faster
root.ChargeTimeLv4 = 2.4f;             // B++ faster

// === STAMINA - use Extra Spice (best recovery) ===
root.ShottingStaminaRecoverSpeedRate = 0.6f;  // ES (best: 50% penalty reduction)

// === COATING DAMAGE - boosted beyond all 3 ===
root.CloseBottleAttackUpRate = 1.7f;    // B++=1.6, ES=1.45, boosted
root.StrongBottleAttackUpRate = 1.6f;   // B++=1.5, boosted
root.CloseBottleGravityRate = 6;        // B++ more pierce procs
root.CloseBottleRangeRate = 0.5f;       // B++ tighter crit range
root.QuickShotBottleEffectiveRate = 1.1f; // ES value

// === STATUS BOTTLE ATK - boosted ===
root.ParalyseBottleAtk = 20;           // boosted
root.PoisonBottleAtk = 25;             // boosted
root.SleepBottleAtk = 25;              // ES had 20, boosted
root.BlastBottleAtk = 25;              // boosted
root.StaminaBottleAtk = 20;            // B++ value
root.StaminaBottleStun = 25;           // boosted beyond B++'s 20

// === MINI TSUGIYA (arc tracers) - B++ values ===
root.MaxMiniTsugiyaNum = 20;           // B++
root.MiniTsugiyaInterval = 0.1f;       // B++ fastest

// === DODGE I-FRAMES - B++ values (way better) ===
var dodgeRates = root.SkillDodgeJudgeTimeRate;
dodgeRates[0].Value = 1.2f;
dodgeRates[1].Value = 1.4f;
dodgeRates[2].Value = 1.6f;
dodgeRates[3].Value = 1.8f;
dodgeRates[4].Value = 2.0f;

// === MIKIRI / PERFECT DODGE - B++ values boosted ===
root.MikiriSuccessStaminaRecover = 120; // B++=100, boosted
root.MikiriAddGauge = 25;              // B++=20, boosted
root.SuperMikiriSuccessStaminaRecover = 220; // B++=200, boosted
root.SuperMikiriAddGauge = 55;         // B++=50, boosted

// === MULTILOCKON PARAM - B++ has better detection ===
var mlp = root.MultiLockonParam[0];
mlp.MaxDetectionDist = 30;             // B++ wider detection
mlp.FirstTargetAddTime = 0.4f;         // B++ faster first lock

// === MINI TSUGIYA NUM (per level) - B++ values ===
var mtNums = root.MiniTsugiyaNum;
mtNums[0].Value = 5;   // B++
mtNums[1].Value = 10;  // B++
mtNums[2].Value = 15;  // B++
mtNums[3].Value = 20;  // B++

// === KYOKUSHA AIM RADIUS - B++ values ===
var aimR = root.KyokushaAimRadius;
aimR[0].Value = 2.0f;   // B++
aimR[1].Value = 2.5f;   // B++
aimR[2].Value = 3.0f;   // B++
aimR[3].Value = 4.0f;   // B++

// === SCATTER LISTS - Apply B++ tighter spreads ===
// QuickShot
root.QuickShot_ScatterList[1].X = -6;
root.QuickShot_ScatterList[1].Y = -0.1f;
root.QuickShot_ScatterList[2].X = 6;
root.QuickShot_ScatterList[2].Y = 0.1f;

// QuickShotHoming
root.QuickShotHoming_ScatterList[1].X = -6;
root.QuickShotHoming_ScatterList[2].X = 6;

// Gosha
root.Gosha_ScatterList[1].X = 3;
root.Gosha_ScatterList[1].Y = -0.1f;
root.Gosha_ScatterList[2].X = 6;
root.Gosha_ScatterList[2].Y = 0.1f;

// GoshaLv2
root.GoshaLv2_ScatterList[1].X = 3;
root.GoshaLv2_ScatterList[1].Y = -0.1f;
root.GoshaLv2_ScatterList[2].X = 6;
root.GoshaLv2_ScatterList[3].X = -3;
root.GoshaLv2_ScatterList[3].Y = 0.1f;

// GoshaLv3
root.GoshaLv3_ScatterList[1].X = 3;
root.GoshaLv3_ScatterList[1].Y = -0.1f;
root.GoshaLv3_ScatterList[2].X = 6;
root.GoshaLv3_ScatterList[2].Y = -0.5f;
root.GoshaLv3_ScatterList[3].X = -3;
root.GoshaLv3_ScatterList[3].Y = 0.1f;
root.GoshaLv3_ScatterList[4].X = -6;
root.GoshaLv3_ScatterList[4].Y = -0.5f;

// GoshaLv4 (same as Lv3)
root.GoshaLv4_ScatterList[1].X = 3;
root.GoshaLv4_ScatterList[1].Y = -0.1f;
root.GoshaLv4_ScatterList[2].X = 6;
root.GoshaLv4_ScatterList[2].Y = -0.5f;
root.GoshaLv4_ScatterList[3].X = -3;
root.GoshaLv4_ScatterList[3].Y = 0.1f;
root.GoshaLv4_ScatterList[4].X = -6;
root.GoshaLv4_ScatterList[4].Y = -0.5f;

// GoshaHoming
root.GoshaHoming_ScatterList[0].X = 1;
root.GoshaHoming_ScatterList[1].X = 6;
root.GoshaHoming_ScatterList[2].X = 12;
root.GoshaHoming_ScatterList[2].Y = 1;
root.GoshaHoming_ScatterList[3].X = -1;
root.GoshaHoming_ScatterList[4].X = -6;

// GoshaRapid
root.GoshaRapid_ScatterList[1].X = 3;
root.GoshaRapid_ScatterList[1].Y = -0.1f;
root.GoshaRapid_ScatterList[2].X = 6;
root.GoshaRapid_ScatterList[3].X = -3;
root.GoshaRapid_ScatterList[3].Y = 0.1f;

// GoshaRapidLv2
root.GoshaRapidLv2_ScatterList[1].X = 3;
root.GoshaRapidLv2_ScatterList[1].Y = -0.1f;
root.GoshaRapidLv2_ScatterList[2].X = 6;
root.GoshaRapidLv2_ScatterList[3].X = -6;
root.GoshaRapidLv2_ScatterList[3].Y = -0.5f;
root.GoshaRapidLv2_ScatterList[4].X = -3;
root.GoshaRapidLv2_ScatterList[4].Y = 0.1f;

// GoshaRapidLv3
root.GoshaRapidLv3_ScatterList[0].X = 0.5f;
root.GoshaRapidLv3_ScatterList[1].X = 3;
root.GoshaRapidLv3_ScatterList[1].Y = -0.1f;
root.GoshaRapidLv3_ScatterList[2].X = 6;
root.GoshaRapidLv3_ScatterList[2].Y = 0.5f;
root.GoshaRapidLv3_ScatterList[3].X = -0.5f;
root.GoshaRapidLv3_ScatterList[4].X = -3;
root.GoshaRapidLv3_ScatterList[4].Y = 0.1f;
root.GoshaRapidLv3_ScatterList[5].X = -6;
root.GoshaRapidLv3_ScatterList[5].Y = -0.5f;

// GoshaRapidLv4 (same as Lv3)
root.GoshaRapidLv4_ScatterList[0].X = 0.5f;
root.GoshaRapidLv4_ScatterList[1].X = 3;
root.GoshaRapidLv4_ScatterList[1].Y = -0.1f;
root.GoshaRapidLv4_ScatterList[2].X = 6;
root.GoshaRapidLv4_ScatterList[2].Y = 0.5f;
root.GoshaRapidLv4_ScatterList[3].X = -0.5f;
root.GoshaRapidLv4_ScatterList[4].X = -3;
root.GoshaRapidLv4_ScatterList[4].Y = 0.1f;
root.GoshaRapidLv4_ScatterList[5].X = -6;
root.GoshaRapidLv4_ScatterList[5].Y = -0.5f;

// GoshaRapidHoming
root.GoshaRapidHoming_ScatterList[0].X = 1;
root.GoshaRapidHoming_ScatterList[1].X = 6;
root.GoshaRapidHoming_ScatterList[2].X = 12;
root.GoshaRapidHoming_ScatterList[2].Y = 1;
root.GoshaRapidHoming_ScatterList[3].X = -1;
root.GoshaRapidHoming_ScatterList[4].X = -6;
root.GoshaRapidHoming_ScatterList[5].X = -12;
root.GoshaRapidHoming_ScatterList[5].Y = -1;

// Jump scatter - B++ halved values
root.Jump_ScatterList[1].X = 1.5f;
root.Jump_ScatterList[1].Y = 1.6f;
root.Jump_ScatterList[2].X = -1.5f;
root.Jump_ScatterList[2].Y = 1.4f;

root.JumpLv2_ScatterList[1].X = 1.5f;
root.JumpLv2_ScatterList[1].Y = 1.6f;
root.JumpLv2_ScatterList[2].X = -1.5f;
root.JumpLv2_ScatterList[2].Y = 1.4f;
root.JumpLv2_ScatterList[3].X = -3;
root.JumpLv2_ScatterList[3].Y = 3;

root.JumpLv3_ScatterList[1].X = 1.5f;
root.JumpLv3_ScatterList[1].Y = 1.6f;
root.JumpLv3_ScatterList[2].X = -1.5f;
root.JumpLv3_ScatterList[2].Y = 1.4f;
root.JumpLv3_ScatterList[3].X = -3;
root.JumpLv3_ScatterList[3].Y = 3;
root.JumpLv3_ScatterList[4].X = 3;
root.JumpLv3_ScatterList[4].Y = 3.1f;

root.JumpLv4_ScatterList[1].X = 1.5f;
root.JumpLv4_ScatterList[1].Y = 1.6f;
root.JumpLv4_ScatterList[2].X = -1.5f;
root.JumpLv4_ScatterList[2].Y = 1.4f;
root.JumpLv4_ScatterList[3].X = -3;
root.JumpLv4_ScatterList[3].Y = 3;
root.JumpLv4_ScatterList[4].X = 3;
root.JumpLv4_ScatterList[4].Y = 3.1f;

// JumpHoming
root.JumpHoming_ScatterList[1].X = 3;
root.JumpHoming_ScatterList[2].X = 6;
root.JumpHoming_ScatterList[2].Y = -1;
root.JumpHoming_ScatterList[3].X = 9;
root.JumpHoming_ScatterList[3].Y = -3;
root.JumpHoming_ScatterList[4].X = -3;

// NormalHoming
root.NormalHoming_ScatterList[1].X = 2.5f;
root.NormalHoming_ScatterList[1].Y = -2.5f;
root.NormalHoming_ScatterList[2].X = -2.5f;
root.NormalHoming_ScatterList[2].Y = -2.5f;

// Twin
root.Twin_ScatterList[0].X = 0.5f;
root.Twin_ScatterList[1].X = 4;
root.Twin_ScatterList[2].X = 8;
root.Twin_ScatterList[2].Y = -0.5f;
root.Twin_ScatterList[3].X = -0.5f;
root.Twin_ScatterList[4].X = -4;
root.Twin_ScatterList[5].X = -8;
root.Twin_ScatterList[5].Y = -0.5f;

// TwinHoming (same as Twin)
root.TwinHoming_ScatterList[0].X = 0.5f;
root.TwinHoming_ScatterList[1].X = 4;
root.TwinHoming_ScatterList[2].X = 8;
root.TwinHoming_ScatterList[2].Y = -0.5f;
root.TwinHoming_ScatterList[3].X = -0.5f;
root.TwinHoming_ScatterList[4].X = -4;
root.TwinHoming_ScatterList[5].X = -8;
root.TwinHoming_ScatterList[5].Y = -0.5f;

// DashClimb
root.DashClimb_ScatterList[1].X = 2.5f;
root.DashClimb_ScatterList[1].Y = 2.5f;
root.DashClimb_ScatterList[2].X = 5;
root.DashClimb_ScatterList[2].Y = 5;
root.DashClimb_ScatterList[3].X = 10;
root.DashClimb_ScatterList[3].Y = 10;
root.DashClimb_ScatterList[4].X = -2.5f;
root.DashClimb_ScatterList[4].Y = 2.5f;
root.DashClimb_ScatterList[5].X = -5;
root.DashClimb_ScatterList[5].Y = 5;
root.DashClimb_ScatterList[6].X = -10;
root.DashClimb_ScatterList[6].Y = 10;

// DashClimbHoming
root.DashClimbHoming_ScatterList[1].X = 2.5f;
root.DashClimbHoming_ScatterList[1].Y = 2.5f;
root.DashClimbHoming_ScatterList[2].X = 5;
root.DashClimbHoming_ScatterList[2].Y = 5;
root.DashClimbHoming_ScatterList[3].X = 10;
root.DashClimbHoming_ScatterList[3].Y = 10;
root.DashClimbHoming_ScatterList[4].X = 2.5f;
root.DashClimbHoming_ScatterList[4].Y = -2.5f;
root.DashClimbHoming_ScatterList[5].X = 5;
root.DashClimbHoming_ScatterList[5].Y = -5;
root.DashClimbHoming_ScatterList[6].X = 10;
root.DashClimbHoming_ScatterList[6].Y = -10;

// MiniTsugiya scatter - B++ values
root.MiniTsugiya_ScatterList[1].X = 0.2f;
root.MiniTsugiya_ScatterList[1].Y = 0.2f;
root.MiniTsugiya_ScatterList[2].X = 0.2f;
root.MiniTsugiya_ScatterList[2].Y = -0.2f;
root.MiniTsugiya_ScatterList[3].X = -0.2f;
root.MiniTsugiya_ScatterList[3].Y = -0.2f;
root.MiniTsugiya_ScatterList[4].X = -0.2f;
root.MiniTsugiya_ScatterList[4].Y = 0.2f;

// === PARRY DAMAGE RATE - B++ value ===
root.ParryHyperArmorDamageRate = 0.2f;

System.Windows.MessageBox.Show("Merge complete! Now save the file (Ctrl+S) to:\nC:\\Users\\Abeelha\\Desktop\\mods\\combined_mod\\natives\\STM\\GameDesign\\Player\\ActionData\\Wp11\\GlobalParam\\Wp11GlobalActionParam.user.3");
