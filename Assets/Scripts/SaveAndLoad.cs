using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BayatGames.SaveGameFree;

public class SaveAndLoad : MonoBehaviour {

	public CooldownArrows cooldownArrows;
	public CooldownFireball cooldownFireball;
	public CooldownGoblinBarrel cooldownGoblinBarrel;
	public CooldownLightning cooldownLightning;
	public CooldownRage cooldownRage;
	public CooldownRocket cooldownRocket;
	public CooldownFreeze cooldownFreeze;
	public CooldownZap cooldownZap;
	public CooldownPoison cooldownPoison;
	public CooldownGraveyard cooldownGraveyard;
	public CooldownMirror cooldownMirror;
	public CooldownTheLog cooldownTheLog;
	public CooldownTornado cooldownTornado;
	public CooldownClone cooldownClone;
	public CooldownHeal cooldownHeal;
	public CooldownBarbarianBarrel cooldownBarbarianBarrel;

	public void SaveAndCloseTheGame () {
		SaveTheGame ();
		Application.Quit ();
	}

	void Awake () {
		LoadTheGame ();
	}

	void OnApplicationQuit () {
		SaveTheGame ();
	}

	public void LoadTheGame () {
		Player.PlayerLevel = SaveGame.Load<int> ( "PlayerLevel", 1 );
		Player.Experience = SaveGame.Load<int> ( "Experience", 0 );

		Player.Elix = SaveGame.Load<float> ( "Elix", 0f );
		Player.Coins = SaveGame.Load<float> ( "Coins", 0f );
		Player.Gems = SaveGame.Load<float> ( "Gems", 0f );
		Player.Trophys = SaveGame.Load<float> ( "Trophys", 0f );
		Player.Crowns = SaveGame.Load<int> ( "Crowns", 0 );

		Player.ClanChestTier = SaveGame.Load<int> ( "ClanChestTier", 0 );
		Player.ClanChestCrowns = SaveGame.Load<int> ( "ClanChestCrowns", 0 );

		//---spells---
		Player.ArrowsCards = SaveGame.Load<int> ( "ArrowsCards", 0 );
		Player.ArrowsLevel = SaveGame.Load<int> ( "ArrowsLevel", 0 );
		Player.ArrowsTier = SaveGame.Load<int> ( "ArrowsTier", 0 );

		Player.FireballCards = SaveGame.Load<int> ( "FireballCards", 0 );
		Player.FireballLevel = SaveGame.Load<int> ( "FireballLevel", 0 );
		Player.FireballTier = SaveGame.Load<int> ( "FireballTier", 0 );

		Player.GoblinBarrelCards = SaveGame.Load<int> ( "GoblinBarrelCards", 0 );
		Player.GoblinBarrelLevel = SaveGame.Load<int> ( "GoblinBarrelLevel", 0 );
		Player.GoblinBarrelTier = SaveGame.Load<int> ( "GoblinBarrelTier", 0 );

		Player.LightningCards = SaveGame.Load<int> ( "LightningCards", 0 );
		Player.LightningLevel = SaveGame.Load<int> ( "LightningLevel", 0 );
		Player.LightningTier = SaveGame.Load<int> ( "LightningTier", 0 );

		Player.RageCards = SaveGame.Load<int> ( "RageCards", 0 );
		Player.RageLevel = SaveGame.Load<int> ( "RageLevel", 0 );
		Player.RageTier = SaveGame.Load<int> ( "RageTier", 0 );

		Player.RocketCards = SaveGame.Load<int> ( "RocketCards", 0 );
		Player.RocketLevel = SaveGame.Load<int> ( "RocketLevel", 0 );
		Player.RocketTier = SaveGame.Load<int> ( "RocketTier", 0 );

		Player.FreezeCards = SaveGame.Load<int> ( "FreezeCards", 0 );
		Player.FreezeLevel = SaveGame.Load<int> ( "FreezeLevel", 0 );
		Player.FreezeTier = SaveGame.Load<int> ( "FreezeTier", 0 );

		Player.ZapCards = SaveGame.Load<int> ( "ZapCards", 0 );
		Player.ZapLevel = SaveGame.Load<int> ( "ZapLevel", 0 );
		Player.ZapTier = SaveGame.Load<int> ( "ZapTier", 0 );

		Player.PoisonCards = SaveGame.Load<int> ( "PoisonCards", 0 );
		Player.PoisonLevel = SaveGame.Load<int> ( "PoisonLevel", 0 );
		Player.PoisonTier = SaveGame.Load<int> ( "PoisonTier", 0 );

		Player.MirrorCards = SaveGame.Load<int> ( "MirrorCards", 0 );
		Player.MirrorLevel = SaveGame.Load<int> ( "MirrorLevel", 0 );
		Player.MirrorTier = SaveGame.Load<int> ( "MirrorTier", 0 );

		Player.GraveyardCards = SaveGame.Load<int> ( "GraveyardCards", 0 );
		Player.GraveyardLevel = SaveGame.Load<int> ( "GraveyardLevel", 0 );
		Player.GraveyardTier = SaveGame.Load<int> ( "GraveyardTier", 0 );

		Player.TheLogCards = SaveGame.Load<int> ( "TheLogCards", 0 );
		Player.TheLogLevel = SaveGame.Load<int> ( "TheLogLevel", 0 );
		Player.TheLogTier = SaveGame.Load<int> ( "TheLogTier", 0 );

		Player.TornadoCards = SaveGame.Load<int> ( "TornadoCards", 0 );
		Player.TornadoLevel = SaveGame.Load<int> ( "TornadoLevel", 0 );
		Player.TornadoTier = SaveGame.Load<int> ( "TornadoTier", 0 );

		Player.CloneCards = SaveGame.Load<int> ( "CloneCards", 0 );
		Player.CloneLevel = SaveGame.Load<int> ( "CloneLevel", 0 );
		Player.CloneTier = SaveGame.Load<int> ( "CloneTier", 0 );

		Player.HealCards = SaveGame.Load<int> ( "HealCards", 0 );
		Player.HealLevel = SaveGame.Load<int> ( "HealLevel", 0 );
		Player.HealTier = SaveGame.Load<int> ( "HealTier", 0 );

		Player.BarbarianBarrelCards = SaveGame.Load<int> ( "BarbarianBarrelCards", 0 );
		Player.BarbarianBarrelLevel = SaveGame.Load<int> ( "BarbarianBarrelLevel", 0 );
		Player.BarbarianBarrelTier = SaveGame.Load<int> ( "BarbarianBarrelTier", 0 );

		//spellcooldown
		cooldownArrows.GetCooldown ();
		cooldownArrows.CooldownTime = SaveGame.Load<float> ( "ArrowsCooldownTime",0f);
		cooldownFireball.GetCooldown ();
		cooldownFireball.CooldownTime = SaveGame.Load<float> ( "FireballCooldownTime",0f);
		cooldownGoblinBarrel.GetCooldown ();
		cooldownGoblinBarrel.CooldownTime = SaveGame.Load<float> ( "GoblinBarrelCooldownTime",0f);
		cooldownLightning.GetCooldown ();
		cooldownLightning.CooldownTime = SaveGame.Load<float> ( "LightningCooldownTime",0f);
		cooldownRage.GetCooldown ();
		cooldownRage.CooldownTime = SaveGame.Load<float> ( "RageCooldownTime",0f);
		cooldownRocket.GetCooldown ();
		cooldownRocket.CooldownTime = SaveGame.Load<float> ( "RocketCooldownTime",0f);
		cooldownFreeze.GetCooldown ();
		cooldownFreeze.CooldownTime = SaveGame.Load<float> ( "FreezeCooldownTime",0f);
		cooldownZap.GetCooldown ();
		cooldownZap.CooldownTime = SaveGame.Load<float> ( "ZapCooldownTime",0f);
		cooldownPoison.GetCooldown ();
		cooldownPoison.CooldownTime = SaveGame.Load<float> ( "PoisonCooldownTime",0f);
		cooldownGraveyard.GetCooldown ();
		cooldownGraveyard.CooldownTime = SaveGame.Load<float> ( "GraveyardCooldownTime",0f);
		cooldownMirror.GetCooldown ();
		cooldownMirror.CooldownTime = SaveGame.Load<float> ( "MirrorCooldownTime",0f);
		cooldownTheLog.GetCooldown ();
		cooldownTheLog.CooldownTime = SaveGame.Load<float> ( "TheLogCooldownTime",0f);
		cooldownTornado.GetCooldown ();
		cooldownTornado.CooldownTime = SaveGame.Load<float> ( "TornadoCooldownTime",0f);
		cooldownClone.GetCooldown ();
		cooldownClone.CooldownTime = SaveGame.Load<float> ( "CloneCooldownTime",0f);
		cooldownHeal.GetCooldown ();
		cooldownHeal.CooldownTime = SaveGame.Load<float> ( "HealCooldownTime",0f);
		cooldownBarbarianBarrel.GetCooldown ();
		cooldownBarbarianBarrel.CooldownTime = SaveGame.Load<float> ( "BarbarianBarrelCooldownTime",0f);

		//---buildings--
		//arena 1
		Player.GoblinHutCards = SaveGame.Load<int> ( "GoblinHutCards", 0 );
		Player.GoblinHutLevel = SaveGame.Load<int> ( "GoblinHutLevel", 0 );
		Player.GoblinHutTier = SaveGame.Load<int> ( "GoblinHutTier", 0 );

		//arena 2
		Player.TombstoneCards = SaveGame.Load<int> ( "TombstoneCards", 0 );
		Player.TombstoneLevel = SaveGame.Load<int> ( "TombstoneLevel", 0 );
		Player.TombstoneTier = SaveGame.Load<int> ( "TombstoneTier", 0 );

		Player.BombTowerCards = SaveGame.Load<int> ( "BombTowerCards", 0 );
		Player.BombTowerLevel = SaveGame.Load<int> ( "BombTowerLevel", 0 );
		Player.BombTowerTier = SaveGame.Load<int> ( "BombTowerTier", 0 );

		//arena 3
		Player.CannonCards = SaveGame.Load<int> ( "CannonCards", 0 );
		Player.CannonLevel = SaveGame.Load<int> ( "CannonLevel", 0 );
		Player.CannonTier = SaveGame.Load<int> ( "CannonTier", 0 );

		Player.BarbarianHutCards = SaveGame.Load<int> ( "BarbarianHutCards", 0 );
		Player.BarbarianHutLevel = SaveGame.Load<int> ( "BarbarianHutLevel", 0 );
		Player.BarbarianHutTier = SaveGame.Load<int> ( "BarbarianHutTier", 0 );

		Player.XBowCards = SaveGame.Load<int> ( "XBowCards", 0 );
		Player.XBowLevel = SaveGame.Load<int> ( "XBowLevel", 0 );
		Player.XBowTier = SaveGame.Load<int> ( "XBowTier", 0 );

		//arena 4
		Player.TeslaCards = SaveGame.Load<int> ( "TeslaCards", 0 );
		Player.TeslaLevel = SaveGame.Load<int> ( "TeslaLevel", 0 );
		Player.TeslaTier = SaveGame.Load<int> ( "TeslaTier", 0 );

		Player.InfernoTowerCards = SaveGame.Load<int> ( "InfernoTowerCards", 0 );
		Player.InfernoTowerLevel = SaveGame.Load<int> ( "InfernoTowerLevel", 0 );
		Player.InfernoTowerTier = SaveGame.Load<int> ( "InfernoTowerTier", 0 );

		//arena 5
		Player.FurnaceCards = SaveGame.Load<int> ( "FurnaceCards", 0 );
		Player.FurnaceLevel = SaveGame.Load<int> ( "FurnaceLevel", 0 );
		Player.FurnaceTier = SaveGame.Load<int> ( "FurnaceTier", 0 );

		//arena 6
		Player.MortarCards = SaveGame.Load<int> ( "MortarCards", 0 );
		Player.MortarLevel = SaveGame.Load<int> ( "MortarLevel", 0 );
		Player.MortarTier = SaveGame.Load<int> ( "MortarTier", 0 );

		Player.ElixirCollectorCards = SaveGame.Load<int> ( "ElixirCollectorCards", 0 );
		Player.ElixirCollectorLevel = SaveGame.Load<int> ( "ElixirCollectorLevel", 0 );
		Player.ElixirCollectorTier = SaveGame.Load<int> ( "ElixirCollectorTier", 0 );

		//---troops--
		//arena 0
		Player.SkeletonCards = SaveGame.Load<int> ( "SkeletonCards", 1 );
		Player.SkeletonLevel = SaveGame.Load<int> ( "SkeletonLevel", 0 );
		Player.SkeletonTier = SaveGame.Load<int> ( "SkeletonTier", 1 );

		Player.ArchersCards = SaveGame.Load<int> ( "ArchersCards", 0 );
		Player.ArchersLevel = SaveGame.Load<int> ( "ArchersLevel", 0 );
		Player.ArchersTier = SaveGame.Load<int> ( "ArchersTier", 0 );

		Player.KnightCards = SaveGame.Load<int> ( "KnightCards", 0 );
		Player.KnightLevel = SaveGame.Load<int> ( "KnightLevel", 0 );
		Player.KnightTier = SaveGame.Load<int> ( "KnightTier", 0 );

		Player.BomberCards = SaveGame.Load<int> ( "BomberCards", 0 );
		Player.BomberLevel = SaveGame.Load<int> ( "BomberLevel", 0 );
		Player.BomberTier = SaveGame.Load<int> ( "BomberTier", 0 );

		Player.SkeletonArmyCards = SaveGame.Load<int> ( "SkeletonArmyCards", 0 );
		Player.SkeletonArmyLevel = SaveGame.Load<int> ( "SkeletonArmyLevel", 0 );
		Player.SkeletonArmyTier = SaveGame.Load<int> ( "SkeletonArmyTier", 0 );

		Player.MusketeerCards = SaveGame.Load<int> ( "MusketeerCards", 0 );
		Player.MusketeerLevel = SaveGame.Load<int> ( "MusketeerLevel", 0 );
		Player.MusketeerTier = SaveGame.Load<int> ( "MusketeerTier", 0 );

		Player.MiniPekkaCards = SaveGame.Load<int> ( "MiniPekkaCards", 0 );
		Player.MiniPekkaLevel = SaveGame.Load<int> ( "MiniPekkaLevel", 0 );
		Player.MiniPekkaTier = SaveGame.Load<int> ( "MiniPekkaTier", 0 );

		Player.BabyDragonCards = SaveGame.Load<int> ( "BabyDragonCards", 0 );
		Player.BabyDragonLevel = SaveGame.Load<int> ( "BabyDragonLevel", 0 );
		Player.BabyDragonTier = SaveGame.Load<int> ( "BabyDragonTier", 0 );

		Player.GiantCards = SaveGame.Load<int> ( "GiantCards", 0 );
		Player.GiantLevel = SaveGame.Load<int> ( "GiantLevel", 0 );
		Player.GiantTier = SaveGame.Load<int> ( "GiantTier", 0 );

		Player.PrinceCards = SaveGame.Load<int> ( "PrinceCards", 0 );
		Player.PrinceLevel = SaveGame.Load<int> ( "PrinceLevel", 0 );
		Player.PrinceTier = SaveGame.Load<int> ( "PrinceTier", 0 );

		Player.WitchCards = SaveGame.Load<int> ( "WitchCards", 0 );
		Player.WitchLevel = SaveGame.Load<int> ( "WitchLevel", 0 );
		Player.WitchTier = SaveGame.Load<int> ( "WitchTier", 0 );

		//arena 1
		Player.GoblinsCards = SaveGame.Load<int> ( "GoblinsCards", 0 );
		Player.GoblinsLevel = SaveGame.Load<int> ( "GoblinsLevel", 0 );
		Player.GoblinsTier = SaveGame.Load<int> ( "GoblinsTier", 0 );

		Player.SpearGoblinsCards = SaveGame.Load<int> ( "SpearGoblinsCards", 0 );
		Player.SpearGoblinsLevel = SaveGame.Load<int> ( "SpearGoblinsLevel", 0 );
		Player.SpearGoblinsTier = SaveGame.Load<int> ( "SpearGoblinsTier", 0 );

		Player.ValkyrieCards = SaveGame.Load<int> ( "ValkyrieCards", 0 );
		Player.ValkyrieLevel = SaveGame.Load<int> ( "ValkyrieLevel", 0 );
		Player.ValkyrieTier = SaveGame.Load<int> ( "ValkyrieTier", 0 );

		//arena 2

		Player.MinionsCards = SaveGame.Load<int> ( "MinionsCards", 0 );
		Player.MinionsLevel = SaveGame.Load<int> ( "MinionsLevel", 0 );
		Player.MinionsTier = SaveGame.Load<int> ( "MinionsTier", 0 );

		Player.BallonCards = SaveGame.Load<int> ( "BallonCards", 0 );
		Player.BallonLevel = SaveGame.Load<int> ( "BallonLevel", 0 );
		Player.BallonTier = SaveGame.Load<int> ( "BallonTier", 0 );

		Player.GiantSkeletonCards = SaveGame.Load<int> ( "GiantSkeletonCards", 0 );
		Player.GiantSkeletonLevel = SaveGame.Load<int> ( "GiantSkeletonLevel", 0 );
		Player.GiantSkeletonTier = SaveGame.Load<int> ( "GiantSkeletonTier", 0 );

		//arena 3

		Player.BabariansCards = SaveGame.Load<int> ( "BabariansCards", 0 );
		Player.BabariansLevel = SaveGame.Load<int> ( "BabariansLevel", 0 );
		Player.BabariansTier = SaveGame.Load<int> ( "BabariansTier", 0 );

		//arena 4

		Player.HogRaiderCards = SaveGame.Load<int> ( "HogRaiderCards", 0 );
		Player.HogRaiderLevel = SaveGame.Load<int> ( "HogRaiderLevel", 0 );
		Player.HogRaiderTier = SaveGame.Load<int> ( "HogRaiderTier", 0 );

		Player.InfernoDragonCards = SaveGame.Load<int> ( "InfernoDragonCards", 0 );
		Player.InfernoDragonLevel = SaveGame.Load<int> ( "InfernoDragonLevel", 0 );
		Player.InfernoDragonTier = SaveGame.Load<int> ( "InfernoDragonTier", 0 );

		Player.MinionHordeCards = SaveGame.Load<int> ( "MinionHordeCards", 0 );
		Player.MinionHordeLevel = SaveGame.Load<int> ( "MinionHordeLevel", 0 );
		Player.MinionHordeTier = SaveGame.Load<int> ( "MinionHordeTier", 0 );

		Player.PekkaCards = SaveGame.Load<int> ( "PekkaCards", 0 );
		Player.PekkaLevel = SaveGame.Load<int> ( "PekkaLevel", 0 );
		Player.PekkaTier = SaveGame.Load<int> ( "PekkaTier", 0 );

		Player.LavaHoundCards = SaveGame.Load<int> ( "LavaHoundCards", 0 );
		Player.LavaHoundLevel = SaveGame.Load<int> ( "LavaHoundLevel", 0 );
		Player.LavaHoundTier = SaveGame.Load<int> ( "LavaHoundTier", 0 );

		//arena 5

		Player.FireSpiritsCards = SaveGame.Load<int> ( "FireSpiritsCards", 0 );
		Player.FireSpiritsLevel = SaveGame.Load<int> ( "FireSpiritsLevel", 0 );
		Player.FireSpiritsTier = SaveGame.Load<int> ( "FireSpiritsTier", 0 );

		Player.IceWizardCards = SaveGame.Load<int> ( "IceWizardCards", 0 );
		Player.IceWizardLevel = SaveGame.Load<int> ( "IceWizardLevel", 0 );
		Player.IceWizardTier = SaveGame.Load<int> ( "IceWizardTier", 0 );

		Player.WizardCards = SaveGame.Load<int> ( "WizardCards", 0 );
		Player.WizardLevel = SaveGame.Load<int> ( "WizardLevel", 0 );
		Player.WizardTier = SaveGame.Load<int> ( "WizardTier", 0 );

		//arena 6

		Player.SkeletonBarrelCards = SaveGame.Load<int> ( "SkeletonBarrelCards", 0 );
		Player.SkeletonBarrelLevel = SaveGame.Load<int> ( "SkeletonBarrelLevel", 0 );
		Player.SkeletonBarrelTier = SaveGame.Load<int> ( "SkeletonBarrelTier", 0 );

		Player.MinerCards = SaveGame.Load<int> ( "MinerCards", 0 );
		Player.MinerLevel = SaveGame.Load<int> ( "MinerLevel", 0 );
		Player.MinerTier = SaveGame.Load<int> ( "MinerTier", 0 );

		Player.BattleRamCards = SaveGame.Load<int> ( "BattleRamCards", 0 );
		Player.BattleRamLevel = SaveGame.Load<int> ( "BattleRamLevel", 0 );
		Player.BattleRamTier = SaveGame.Load<int> ( "BattleRamTier", 0 );

		Player.SparkyCards = SaveGame.Load<int> ( "SparkyCards", 0 );
		Player.SparkyLevel = SaveGame.Load<int> ( "SparkyLevel", 0 );
		Player.SparkyTier = SaveGame.Load<int> ( "SparkyTier", 0 );

		Player.GolemCards = SaveGame.Load<int> ( "GolemCards", 0 );
		Player.GolemLevel = SaveGame.Load<int> ( "GolemLevel", 0 );
		Player.GolemTier = SaveGame.Load<int> ( "GolemTier", 0 );

		//arena 7

		Player.MegaMinionCards = SaveGame.Load<int> ( "MegaMinionCards", 0 );
		Player.MegaMinionLevel = SaveGame.Load<int> ( "MegaMinionLevel", 0 );
		Player.MegaMinionTier = SaveGame.Load<int> ( "MegaMinionTier", 0 );

		Player.GuardsCards = SaveGame.Load<int> ( "GuardsCards", 0 );
		Player.GuardsLevel = SaveGame.Load<int> ( "GuardsLevel", 0 );
		Player.GuardsTier = SaveGame.Load<int> ( "GuardsTier", 0 );

		Player.PrincessCards = SaveGame.Load<int> ( "PrincessCards", 0 );
		Player.PrincessLevel = SaveGame.Load<int> ( "PrincessLevel", 0 );
		Player.PrincessTier = SaveGame.Load<int> ( "PrincessTier", 0 );

		Player.DarkPrinceCards = SaveGame.Load<int> ( "DarkPrinceCards", 0 );
		Player.DarkPrinceLevel = SaveGame.Load<int> ( "DarkPrinceLevel", 0 );
		Player.DarkPrinceTier = SaveGame.Load<int> ( "DarkPrinceTier", 0 );

		Player.ElectroWizardCards = SaveGame.Load<int> ( "ElectroWizardCards", 0 );
		Player.ElectroWizardLevel = SaveGame.Load<int> ( "ElectroWizardLevel", 0 );
		Player.ElectroWizardTier = SaveGame.Load<int> ( "ElectroWizardTier", 0 );

		Player.RoyalGiantCards = SaveGame.Load<int> ( "RoyalGiantCards", 0 );
		Player.RoyalGiantLevel = SaveGame.Load<int> ( "RoyalGiantLevel", 0 );
		Player.RoyalGiantTier = SaveGame.Load<int> ( "RoyalGiantTier", 0 );

		Player.EliteBarbariansCards = SaveGame.Load<int> ( "EliteBarbariansCards", 0 );
		Player.EliteBarbariansLevel = SaveGame.Load<int> ( "EliteBarbariansLevel", 0 );
		Player.EliteBarbariansTier = SaveGame.Load<int> ( "EliteBarbariansTier", 0 );

		Player.ThreeMusketeersCards = SaveGame.Load<int> ( "ThreeMusketeersCards", 0 );
		Player.ThreeMusketeersLevel = SaveGame.Load<int> ( "ThreeMusketeersLevel", 0 );
		Player.ThreeMusketeersTier = SaveGame.Load<int> ( "ThreeMusketeersTier", 0 );

		//arena 8

		Player.IceSpiritCards = SaveGame.Load<int> ( "IceSpiritCards", 0 );
		Player.IceSpiritLevel = SaveGame.Load<int> ( "IceSpiritLevel", 0 );
		Player.IceSpiritTier = SaveGame.Load<int> ( "IceSpiritTier", 0 );

		Player.BatsCards = SaveGame.Load<int> ( "BatsCards", 0 );
		Player.BatsLevel = SaveGame.Load<int> ( "BatsLevel", 0 );
		Player.BatsTier = SaveGame.Load<int> ( "BatsTier", 0 );

		Player.IceGolemCards = SaveGame.Load<int> ( "IceGolemCards", 0 );
		Player.IceGolemLevel = SaveGame.Load<int> ( "IceGolemLevel", 0 );
		Player.IceGolemTier = SaveGame.Load<int> ( "IceGolemTier", 0 );

		Player.NightWitchCards = SaveGame.Load<int> ( "NightWitchCards", 0 );
		Player.NightWitchLevel = SaveGame.Load<int> ( "NightWitchLevel", 0 );
		Player.NightWitchTier = SaveGame.Load<int> ( "NightWitchTier", 0 );

		Player.LumberjackCards = SaveGame.Load<int> ( "LumberjackCards", 0 );
		Player.LumberjackLevel = SaveGame.Load<int> ( "LumberjackLevel", 0 );
		Player.LumberjackTier = SaveGame.Load<int> ( "LumberjackTier", 0 );

		Player.BowlerCards = SaveGame.Load<int> ( "BowlerCards", 0 );
		Player.BowlerLevel = SaveGame.Load<int> ( "BowlerLevel", 0 );
		Player.BowlerTier = SaveGame.Load<int> ( "BowlerTier", 0 );

		//arena 9

		Player.GoblinGangCards = SaveGame.Load<int> ( "GoblinGangCards", 0 );
		Player.GoblinGangLevel = SaveGame.Load<int> ( "GoblinGangLevel", 0 );
		Player.GoblinGangTier = SaveGame.Load<int> ( "GoblinGangTier", 0 );

		Player.DartGoblinCards = SaveGame.Load<int> ( "DartGoblinCards", 0 );
		Player.DartGoblinLevel = SaveGame.Load<int> ( "DartGoblinLevel", 0 );
		Player.DartGoblinTier = SaveGame.Load<int> ( "DartGoblinTier", 0 );

		Player.BanditCards = SaveGame.Load<int> ( "BanditCards", 0 );
		Player.BanditLevel = SaveGame.Load<int> ( "BanditLevel", 0 );
		Player.BanditTier = SaveGame.Load<int> ( "BanditTier", 0 );

		Player.FlyingMachineCards = SaveGame.Load<int> ( "FlyingMachineCards", 0 );
		Player.FlyingMachineLevel = SaveGame.Load<int> ( "FlyingMachineLevel", 0 );
		Player.FlyingMachineTier = SaveGame.Load<int> ( "FlyingMachineTier", 0 );

		Player.HunterCards = SaveGame.Load<int> ( "HunterCards", 0 );
		Player.HunterLevel = SaveGame.Load<int> ( "HunterLevel", 0 );
		Player.HunterTier = SaveGame.Load<int> ( "HunterTier", 0 );

		Player.ExecutionerCards = SaveGame.Load<int> ( "ExecutionerCards", 0 );
		Player.ExecutionerLevel = SaveGame.Load<int> ( "ExecutionerLevel", 0 );
		Player.ExecutionerTier = SaveGame.Load<int> ( "ExecutionerTier", 0 );

		//arena 10

		Player.RoyalGhostCards = SaveGame.Load<int> ( "RoyalGhostCards", 0 );
		Player.RoyalGhostLevel = SaveGame.Load<int> ( "RoyalGhostLevel", 0 );
		Player.RoyalGhostTier = SaveGame.Load<int> ( "RoyalGhostTier", 0 );

		Player.CannonCartCards = SaveGame.Load<int> ( "CannonCartCards", 0 );
		Player.CannonCartLevel = SaveGame.Load<int> ( "CannonCartLevel", 0 );
		Player.CannonCartTier = SaveGame.Load<int> ( "CannonCartTier", 0 );

		Player.MegaKnightCards = SaveGame.Load<int> ( "MegaKnightCards", 0 );
		Player.MegaKnightLevel = SaveGame.Load<int> ( "MegaKnightLevel", 0 );
		Player.MegaKnightTier = SaveGame.Load<int> ( "MegaKnightTier", 0 );

		//arena 11

		Player.ZappiesCards = SaveGame.Load<int> ( "ZappiesCards", 0 );
		Player.ZappiesLevel = SaveGame.Load<int> ( "ZappiesLevel", 0 );
		Player.ZappiesTier = SaveGame.Load<int> ( "ZappiesTier", 0 );

		Player.MagicalArcherCards = SaveGame.Load<int> ( "MagicalArcherCards", 0 );
		Player.MagicalArcherLevel = SaveGame.Load<int> ( "MagicalArcherLevel", 0 );
		Player.MagicalArcherTier = SaveGame.Load<int> ( "MagicalArcherTier", 0 );

		//---stats---

		Player.ElixClicks = SaveGame.Load<int> ( "ElixClicks", 0 );
		Player.CollectedElix = SaveGame.Load<float> ( "CollectedElix", 0f );
		Player.CollectedCoins = SaveGame.Load<float> ( "CollectedCoins", 0f );
		Player.CollectedJewels = SaveGame.Load<float> ( "CollectedJewels", 0f );
		Player.CollectedJewels = SaveGame.Load<int> ( "CollectedExperience", 0 );
		Player.CollectedCrowns = SaveGame.Load<int> ("CollectedCrowns", 0);

		Player.SkeletonCoinTimes = SaveGame.Load<int> ( "SkeletonCoinTimes", 0 );
		Player.ArchersCoinTimes = SaveGame.Load<int> ( "ArchersCoinTimes", 0 );
		Player.KnightCoinTimes = SaveGame.Load<int> ( "KnightCoinTimes", 0 );
		Player.BomberCoinTimes = SaveGame.Load<int> ( "BomberCoinTimes", 0 );
		Player.SkeletonArmyCoinTimes = SaveGame.Load<int> ( "SkeletonArmyCoinTimes", 0 );
		Player.MusketeerCoinTimes = SaveGame.Load<int> ( "MusketeerCoinTimes", 0 );
		Player.MiniPekkaCoinTimes = SaveGame.Load<int> ( "MiniPekkaCoinTimes", 0 );
		Player.BabyDragonCoinTimes = SaveGame.Load<int> ( "BabyDragonCoinTimes", 0 );
		Player.GiantCoinTimes = SaveGame.Load<int> ( "GiantCoinTimes", 0 );
		Player.PrinceCoinTimes = SaveGame.Load<int> ( "PrinceCoinTimes", 0 );
		Player.WitchCoinTimes = SaveGame.Load<int> ( "WitchCoinTimes", 0 );
		Player.GoblinsCoinTimes = SaveGame.Load<int> ( "GoblinsCoinTimes", 0 );
		Player.SpearGoblinsCoinTimes = SaveGame.Load<int> ( "SpearGoblinsCoinTimes", 0 );
		Player.ValkyrieCoinTimes = SaveGame.Load<int> ( "ValkyrieCoinTimes", 0 );
		Player.MinionsCoinTimes = SaveGame.Load<int> ( "MinionsCoinTimes", 0 );
		Player.BallonCoinTimes = SaveGame.Load<int> ( "BallonCoinTimes", 0 );
		Player.GiantSkeletonCoinTimes = SaveGame.Load<int> ( "GiantSkeletonCoinTimes", 0 );
		Player.BabariansCoinTimes = SaveGame.Load<int> ( "BabariansCoinTimes", 0 );
		Player.HogRaiderCoinTimes = SaveGame.Load<int> ( "HogRaiderCoinTimes", 0 );
		Player.InfernoDragonCoinTimes = SaveGame.Load<int> ( "InfernoDragonCoinTimes", 0 );
		Player.MinionHordeCoinTimes = SaveGame.Load<int> ( "MinionHordeCoinTimes", 0 );
		Player.PekkaCoinTimes = SaveGame.Load<int> ( "PekkaCoinTimes", 0 );
		Player.LavaHoundCoinTimes = SaveGame.Load<int> ( "LavaHoundCoinTimes", 0 );
		Player.FireSpiritsCoinTimes = SaveGame.Load<int> ( "FireSpiritsCoinTimes", 0 );
		Player.IceWizardCoinTimes = SaveGame.Load<int> ( "IceWizardCoinTimes", 0 );
		Player.WizardCoinTimes = SaveGame.Load<int> ( "WizardCoinTimes", 0 );
		Player.SkeletonBarrelCoinTimes = SaveGame.Load<int> ( "SkeletonBarrelCoinTimes", 0 );
		Player.MinerCoinTimes = SaveGame.Load<int> ( "MinerCoinTimes", 0 );
		Player.BattleRamCoinTimes = SaveGame.Load<int> ( "BattleRamCoinTimes", 0 );
		Player.SparkyCoinTimes = SaveGame.Load<int> ( "SparkyCoinTimes", 0 );
		Player.GolemCoinTimes = SaveGame.Load<int> ( "GolemCoinTimes", 0 );
		Player.MegaMinionCoinTimes = SaveGame.Load<int> ( "MegaMinionCoinTimes", 0 );
		Player.GuardsCoinTimes = SaveGame.Load<int> ( "GuardsCoinTimes", 0 );
		Player.PrincessCoinTimes = SaveGame.Load<int> ( "PrincessCoinTimes", 0 );
		Player.DarkPrinceCoinTimes = SaveGame.Load<int> ( "DarkPrinceCoinTimes", 0 );
		Player.ElectroWizardCoinTimes = SaveGame.Load<int> ( "ElectroWizardCoinTimes", 0 );
		Player.RoyalGiantCoinTimes = SaveGame.Load<int> ( "RoyalGiantCoinTimes", 0 );
		Player.EliteBarbariansCoinTimes = SaveGame.Load<int> ( "EliteBarbariansCoinTimes", 0 );
		Player.ThreeMusketeersCoinTimes = SaveGame.Load<int> ( "ThreeMusketeersCoinTimes", 0 );
		Player.IceSpiritCoinTimes = SaveGame.Load<int> ( "IceSpiritCoinTimes", 0 );
		Player.BatsCoinTimes = SaveGame.Load<int> ( "BatsCoinTimes", 0 );
		Player.IceGolemCoinTimes = SaveGame.Load<int> ( "IceGolemCoinTimes",0 );
		Player.NightWitchCoinTimes = SaveGame.Load<int> ( "NightWitchCoinTimes", 0 );
		Player.LumberjackCoinTimes = SaveGame.Load<int> ( "LumberjackCoinTimes", 0 );
		Player.BowlerCoinTimes = SaveGame.Load<int> ( "BowlerCoinTimes", 0 );
		Player.GoblinGangCoinTimes = SaveGame.Load<int> ( "GoblinGangCoinTimes", 0 );
		Player.DartGoblinCoinTimes = SaveGame.Load<int> ( "DartGoblinCoinTimes", 0 );
		Player.BanditCoinTimes = SaveGame.Load<int> ( "BanditCoinTimes", 0 );
		Player.FlyingMachineCoinTimes = SaveGame.Load<int> ( "FlyingMachineCoinTimes", 0 );
		Player.HunterCoinTimes = SaveGame.Load<int> ( "HunterCoinTimes", 0 );
		Player.ExecutionerCoinTimes = SaveGame.Load<int> ( "ExecutionerCoinTimes", 0 );
		Player.RoyalGhostCoinTimes = SaveGame.Load<int> ( "RoyalGhostCoinTimes", 0 );
		Player.CannonCartCoinTimes = SaveGame.Load<int> ( "CannonCartCoinTimes", 0 );
		Player.MegaKnightCoinTimes = SaveGame.Load<int> ( "MegaKnightCoinTimes", 0 );
		Player.ZappiesCoinTimes = SaveGame.Load<int> ( "ZappiesCoinTimes", 0 );
		Player.MagicalArcherCoinTimes = SaveGame.Load<int> ( "MagicalArcherCoinTimes", 0 );
		//---options---
		Player.Language = SaveGame.Load<int> ( "Language", 1 );
		Player.CrownParticles = SaveGame.Load<int> ( "CrownParticles", 1 );
		Player.LegendaryParticleNumber = SaveGame.Load<int> ("LegendaryParticleNumber", 1);
		Player.EpicParticleNumber = SaveGame.Load<int> ("EpicParticleNumber", 1);
		Player.RareParticleNumber = SaveGame.Load<int> ("RareParticleNumber", 1);
		Player.CommonParticleNumber = SaveGame.Load<int> ("CommonParticleNumber", 1);
		Player.ShowParticles = SaveGame.Load<bool> ( "ShowParticles", true );
		Player.ShowChestParticles = SaveGame.Load<bool> ( "ShowChestParticles", true );
		Player.GemParticleNumber = SaveGame.Load<int> ( "GemParticleNumber", 1);
		Player.ShowChestTexture = SaveGame.Load<bool> ( "ShowChestTexture", true );
		Player.ShowElixAnimation = SaveGame.Load<bool> ( "ShowElixAnimation", true );
		Player.ShowSpellOutput = SaveGame.Load<bool> ("ShowSpellOutput", true);
		Player.ShowSpellParticle = SaveGame.Load<bool> ("ShowSpellParticle", true);
	}

	public void SaveTheGame () {
		//---genric---
		SaveGame.Save<int> ( "PlayerLevel", Player.PlayerLevel );
		SaveGame.Save<int> ( "Experience", Player.Experience );

		SaveGame.Save<float> ( "Elix", Player.Elix );
		SaveGame.Save<float> ( "Coins", Player.Coins );
		SaveGame.Save<float> ( "Gems", Player.Gems );
		SaveGame.Save<float> ( "Trophys", Player.Trophys );
		SaveGame.Save<int> ( "Crowns", Player.Crowns );

		SaveGame.Save<int> ( "ClanChestTier", Player.ClanChestTier);
		SaveGame.Save<int> ( "ClanChestCrowns", Player.ClanChestCrowns );

		//---spells---
		SaveGame.Save<int> ( "ArrowsCards", Player.ArrowsCards );
		SaveGame.Save<int> ( "ArrowsLevel", Player.ArrowsLevel );
		SaveGame.Save<int> ( "ArrowsTier", Player.ArrowsTier );

		SaveGame.Save<int> ( "FireballCards", Player.FireballCards );
		SaveGame.Save<int> ( "FireballLevel", Player.FireballLevel );
		SaveGame.Save<int> ( "FireballTier", Player.FireballTier );

		SaveGame.Save<int> ( "GoblinBarrelCards", Player.GoblinBarrelCards );
		SaveGame.Save<int> ( "GoblinBarrelLevel", Player.GoblinBarrelLevel );
		SaveGame.Save<int> ( "GoblinBarrelTier", Player.GoblinBarrelTier );

		SaveGame.Save<int> ( "LightningCards", Player.LightningCards );
		SaveGame.Save<int> ( "LightningLevel", Player.LightningLevel );
		SaveGame.Save<int> ( "LightningTier", Player.LightningTier );

		SaveGame.Save<int> ( "RageCards", Player.RageCards );
		SaveGame.Save<int> ( "RageLevel", Player.RageLevel );
		SaveGame.Save<int> ( "RageTier", Player.RageTier );

		SaveGame.Save<int> ( "RocketCards", Player.RocketCards );
		SaveGame.Save<int> ( "RocketLevel", Player.RocketLevel );
		SaveGame.Save<int> ( "RocketTier", Player.RocketTier );

		SaveGame.Save<int> ( "FreezeCards", Player.FreezeCards );
		SaveGame.Save<int> ( "FreezeLevel", Player.FreezeLevel );
		SaveGame.Save<int> ( "FreezeTier", Player.FreezeTier );

		SaveGame.Save<int> ( "ZapCards", Player.ZapCards );
		SaveGame.Save<int> ( "ZapLevel", Player.ZapLevel );
		SaveGame.Save<int> ( "ZapTier", Player.ZapTier );

		SaveGame.Save<int> ( "PoisonCards", Player.PoisonCards );
		SaveGame.Save<int> ( "PoisonLevel", Player.PoisonLevel );
		SaveGame.Save<int> ( "PoisonTier", Player.PoisonTier );

		SaveGame.Save<int> ( "MirrorCards", Player.MirrorCards );
		SaveGame.Save<int> ( "MirrorLevel", Player.MirrorLevel );
		SaveGame.Save<int> ( "MirrorTier", Player.MirrorTier );

		SaveGame.Save<int> ( "GraveyardCards", Player.GraveyardCards );
		SaveGame.Save<int> ( "GraveyardLevel", Player.GraveyardLevel );
		SaveGame.Save<int> ( "GraveyardTier", Player.GraveyardTier );

		SaveGame.Save<int> ( "TheLogCards", Player.TheLogCards );
		SaveGame.Save<int> ( "TheLogLevel", Player.TheLogLevel );
		SaveGame.Save<int> ( "TheLogTier", Player.TheLogTier );

		SaveGame.Save<int> ( "TornadoCards", Player.TornadoCards );
		SaveGame.Save<int> ( "TornadoLevel", Player.TornadoLevel );
		SaveGame.Save<int> ( "TornadoTier", Player.TornadoTier );

		SaveGame.Save<int> ( "CloneCards", Player.CloneCards );
		SaveGame.Save<int> ( "CloneLevel", Player.CloneLevel );
		SaveGame.Save<int> ( "CloneTier", Player.CloneTier );

		SaveGame.Save<int> ( "HealCards", Player.HealCards );
		SaveGame.Save<int> ( "HealLevel", Player.HealLevel );
		SaveGame.Save<int> ( "HealTier", Player.HealTier );

		SaveGame.Save<int> ( "BarbarianBarrelCards", Player.BarbarianBarrelCards );
		SaveGame.Save<int> ( "BarbarianBarrelLevel", Player.BarbarianBarrelLevel );
		SaveGame.Save<int> ( "BarbarianBarrelTier", Player.BarbarianBarrelTier );

		//spellcooldown
		SaveGame.Save<float> ( "ArrowsCooldownTime",cooldownArrows.CooldownTime);
		SaveGame.Save<float> ( "FireballCooldownTime",cooldownFireball.CooldownTime);
		SaveGame.Save<float> ( "GoblinBarrelCooldownTime",cooldownGoblinBarrel.CooldownTime);
		SaveGame.Save<float> ( "LightningCooldownTime",cooldownLightning.CooldownTime);
		SaveGame.Save<float> ( "RageCooldownTime",cooldownRage.CooldownTime);
		SaveGame.Save<float> ( "RocketCooldownTime",cooldownRocket.CooldownTime);
		SaveGame.Save<float> ( "FreezeCooldownTime",cooldownFreeze.CooldownTime);
		SaveGame.Save<float> ( "ZapCooldownTime",cooldownZap.CooldownTime);
		SaveGame.Save<float> ( "PoisonCooldownTime",cooldownPoison.CooldownTime);
		SaveGame.Save<float> ( "GraveyardCooldownTime",cooldownGraveyard.CooldownTime);
		SaveGame.Save<float> ( "MirrorCooldownTime",cooldownMirror.CooldownTime);
		SaveGame.Save<float> ( "TheLogCooldownTime",cooldownTheLog.CooldownTime);
		SaveGame.Save<float> ( "TornadoCooldownTime",cooldownTornado.CooldownTime);
		SaveGame.Save<float> ( "CloneCooldownTime",cooldownClone.CooldownTime);
		SaveGame.Save<float> ( "HealCooldownTime",cooldownHeal.CooldownTime);
		SaveGame.Save<float> ( "BarbarianBarrelCooldownTime",cooldownGoblinBarrel.CooldownTime);

		//---buildings---
		//arena 1
		SaveGame.Save<int> ( "GoblinHutCards", Player.GoblinHutCards );
		SaveGame.Save<int> ( "GoblinHutLevel", Player.GoblinHutLevel );
		SaveGame.Save<int> ( "GoblinHutTier", Player.GoblinHutTier );

		//arena 2
		SaveGame.Save<int> ( "TombstoneCards", Player.TombstoneCards );
		SaveGame.Save<int> ( "TombstoneLevel", Player.TombstoneLevel );
		SaveGame.Save<int> ( "TombstoneTier", Player.TombstoneTier );

		SaveGame.Save<int> ( "BombTowerCards", Player.BombTowerCards );
		SaveGame.Save<int> ( "BombTowerLevel", Player.BombTowerLevel );
		SaveGame.Save<int> ( "BombTowerTier", Player.BombTowerTier );

		//arena 3
		SaveGame.Save<int> ( "CannonCards", Player.CannonCards );
		SaveGame.Save<int> ( "CannonLevel", Player.CannonLevel );
		SaveGame.Save<int> ( "CannonTier", Player.CannonTier );

		SaveGame.Save<int> ( "BarbarianHutCards", Player.BarbarianHutCards );
		SaveGame.Save<int> ( "BarbarianHutLevel", Player.BarbarianHutLevel );
		SaveGame.Save<int> ( "BarbarianHutTier", Player.BarbarianHutTier );

		SaveGame.Save<int> ( "XBowCards", Player.XBowCards );
		SaveGame.Save<int> ( "XBowLevel", Player.XBowLevel );
		SaveGame.Save<int> ( "XBowTier", Player.XBowTier );

		//arena 4
		SaveGame.Save<int> ( "TeslaCards", Player.TeslaCards );
		SaveGame.Save<int> ( "TeslaLevel", Player.TeslaLevel );
		SaveGame.Save<int> ( "TeslaTier", Player.TeslaTier );

		SaveGame.Save<int> ( "InfernoTowerCards", Player.InfernoTowerCards );
		SaveGame.Save<int> ( "InfernoTowerLevel", Player.InfernoTowerLevel );
		SaveGame.Save<int> ( "InfernoTowerTier", Player.InfernoTowerTier );

		//arena 5
		SaveGame.Save<int> ( "FurnaceCards", Player.FurnaceCards );
		SaveGame.Save<int> ( "FurnaceLevel", Player.FurnaceLevel );
		SaveGame.Save<int> ( "FurnaceTier", Player.FurnaceTier );

		//arena 6
		SaveGame.Save<int> ( "MortarCards", Player.MortarCards );
		SaveGame.Save<int> ( "MortarLevel", Player.MortarLevel );
		SaveGame.Save<int> ( "MortarTier", Player.MortarTier );

		SaveGame.Save<int> ( "ElixirCollectorCards", Player.ElixirCollectorCards );
		SaveGame.Save<int> ( "ElixirCollectorLevel", Player.ElixirCollectorLevel );
		SaveGame.Save<int> ( "ElixirCollectorTier", Player.ElixirCollectorTier );

		//---troops--
		//arena 0
		SaveGame.Save<int> ( "SkeletonCards", Player.SkeletonCards );
		SaveGame.Save<int> ( "SkeletonLevel", Player.SkeletonLevel );
		SaveGame.Save<int> ( "SkeletonTier", Player.SkeletonTier );

		SaveGame.Save<int> ( "ArchersCards", Player.ArchersCards );
		SaveGame.Save<int> ( "ArchersLevel", Player.ArchersLevel );
		SaveGame.Save<int> ( "ArchersTier", Player.ArchersTier );

		SaveGame.Save<int> ( "KnightCards", Player.KnightCards );
		SaveGame.Save<int> ( "KnightLevel", Player.KnightLevel );
		SaveGame.Save<int> ( "KnightTier", Player.KnightTier );

		SaveGame.Save<int> ( "BomberCards", Player.BomberCards );
		SaveGame.Save<int> ( "BomberLevel", Player.BomberLevel );
		SaveGame.Save<int> ( "BomberTier", Player.BomberTier );

		SaveGame.Save<int> ( "SkeletonArmyCards", Player.SkeletonArmyCards );
		SaveGame.Save<int> ( "SkeletonArmyLevel", Player.SkeletonArmyLevel );
		SaveGame.Save<int> ( "SkeletonArmyTier", Player.SkeletonArmyTier );

		SaveGame.Save<int> ( "MusketeerCards", Player.MusketeerCards );
		SaveGame.Save<int> ( "MusketeerLevel", Player.MusketeerLevel );
		SaveGame.Save<int> ( "MusketeerTier", Player.MusketeerTier );

		SaveGame.Save<int> ( "MiniPekkaCards", Player.MiniPekkaCards );
		SaveGame.Save<int> ( "MiniPekkaLevel", Player.MiniPekkaLevel );
		SaveGame.Save<int> ( "MiniPekkaTier", Player.MiniPekkaTier );

		SaveGame.Save<int> ( "BabyDragonCards", Player.BabyDragonCards );
		SaveGame.Save<int> ( "BabyDragonLevel", Player.BabyDragonLevel );
		SaveGame.Save<int> ( "BabyDragonTier", Player.BabyDragonTier );

		SaveGame.Save<int> ( "GiantCards", Player.GiantCards );
		SaveGame.Save<int> ( "GiantLevel", Player.GiantLevel );
		SaveGame.Save<int> ( "GiantTier", Player.GiantTier );

		SaveGame.Save<int> ( "PrinceCards", Player.PrinceCards );
		SaveGame.Save<int> ( "PrinceLevel", Player.PrinceLevel );
		SaveGame.Save<int> ( "PrinceTier", Player.PrinceTier );

		SaveGame.Save<int> ( "WitchCards", Player.WitchCards );
		SaveGame.Save<int> ( "WitchLevel", Player.WitchLevel );
		SaveGame.Save<int> ( "WitchTier", Player.WitchTier );

		//arena 1

		SaveGame.Save<int> ( "GoblinsCards", Player.GoblinsCards );
		SaveGame.Save<int> ( "GoblinsLevel", Player.GoblinsLevel );
		SaveGame.Save<int> ( "GoblinsTier", Player.GoblinsTier );

		SaveGame.Save<int> ( "SpearGoblinsCards", Player.SpearGoblinsCards );
		SaveGame.Save<int> ( "SpearGoblinsLevel", Player.SpearGoblinsLevel );
		SaveGame.Save<int> ( "SpearGoblinsTier", Player.SpearGoblinsTier );

		SaveGame.Save<int> ( "ValkyrieCards", Player.ValkyrieCards );
		SaveGame.Save<int> ( "ValkyrieLevel", Player.ValkyrieLevel );
		SaveGame.Save<int> ( "ValkyrieTier", Player.ValkyrieTier );

		//arena 2

		SaveGame.Save<int> ( "MinionsCards", Player.MinionsCards );
		SaveGame.Save<int> ( "MinionsLevel", Player.MinionsLevel );
		SaveGame.Save<int> ( "MinionsTier", Player.MinionsTier );

		SaveGame.Save<int> ( "BallonCards", Player.BallonCards );
		SaveGame.Save<int> ( "BallonLevel", Player.BallonLevel );
		SaveGame.Save<int> ( "BallonTier", Player.BallonTier );

		SaveGame.Save<int> ( "GiantSkeletonCards", Player.GiantSkeletonCards );
		SaveGame.Save<int> ( "GiantSkeletonLevel", Player.GiantSkeletonLevel );
		SaveGame.Save<int> ( "GiantSkeletonTier", Player.GiantSkeletonTier );

		//arena 3

		SaveGame.Save<int> ( "BabariansCards", Player.BabariansCards );
		SaveGame.Save<int> ( "BabariansLevel", Player.BabariansLevel );
		SaveGame.Save<int> ( "BabariansTier", Player.BabariansTier );

		//arena 4

		SaveGame.Save<int> ( "HogRaiderCards", Player.HogRaiderCards );
		SaveGame.Save<int> ( "HogRaiderLevel", Player.HogRaiderLevel );
		SaveGame.Save<int> ( "HogRaiderTier", Player.HogRaiderTier );

		SaveGame.Save<int> ( "InfernoDragonCards", Player.InfernoDragonCards );
		SaveGame.Save<int> ( "InfernoDragonLevel", Player.InfernoDragonLevel );
		SaveGame.Save<int> ( "InfernoDragonTier", Player.InfernoDragonTier );

		SaveGame.Save<int> ( "MinionHordeCards", Player.MinionHordeCards );
		SaveGame.Save<int> ( "MinionHordeLevel", Player.MinionHordeLevel );
		SaveGame.Save<int> ( "MinionHordeTier", Player.MinionHordeTier );

		SaveGame.Save<int> ( "PekkaCards", Player.PekkaCards );
		SaveGame.Save<int> ( "PekkaLevel", Player.PekkaLevel );
		SaveGame.Save<int> ( "PekkaTier", Player.PekkaTier );

		SaveGame.Save<int> ( "LavaHoundCards", Player.LavaHoundCards );
		SaveGame.Save<int> ( "LavaHoundLevel", Player.LavaHoundLevel );
		SaveGame.Save<int> ( "LavaHoundTier", Player.LavaHoundTier );

		//arena 5

		SaveGame.Save<int> ( "FireSpiritsCards", Player.FireSpiritsCards );
		SaveGame.Save<int> ( "FireSpiritsLevel", Player.FireSpiritsLevel );
		SaveGame.Save<int> ( "FireSpiritsTier", Player.FireSpiritsTier );

		SaveGame.Save<int> ( "IceWizardCards", Player.IceWizardCards );
		SaveGame.Save<int> ( "IceWizardLevel", Player.IceWizardLevel );
		SaveGame.Save<int> ( "IceWizardTier", Player.IceWizardTier );

		SaveGame.Save<int> ( "WizardCards", Player.WizardCards );
		SaveGame.Save<int> ( "WizardLevel", Player.WizardLevel );
		SaveGame.Save<int> ( "WizardTier", Player.WizardTier );

		//arena 6

		SaveGame.Save<int> ( "SkeletonBarrelCards", Player.SkeletonBarrelCards );
		SaveGame.Save<int> ( "SkeletonBarrelLevel", Player.SkeletonBarrelLevel );
		SaveGame.Save<int> ( "SkeletonBarrelTier", Player.SkeletonBarrelTier );

		SaveGame.Save<int> ( "MinerCards", Player.MinerCards );
		SaveGame.Save<int> ( "MinerLevel", Player.MinerLevel );
		SaveGame.Save<int> ( "MinerTier", Player.MinerTier );

		SaveGame.Save<int> ( "BattleRamCards", Player.BattleRamCards );
		SaveGame.Save<int> ( "BattleRamLevel", Player.BattleRamLevel );
		SaveGame.Save<int> ( "BattleRamTier", Player.BattleRamTier );

		SaveGame.Save<int> ( "SparkyCards", Player.SparkyCards );
		SaveGame.Save<int> ( "SparkyLevel", Player.SparkyLevel );
		SaveGame.Save<int> ( "SparkyTier", Player.SparkyTier );

		SaveGame.Save<int> ( "GolemCards", Player.GolemCards );
		SaveGame.Save<int> ( "GolemLevel", Player.GolemLevel );
		SaveGame.Save<int> ( "GolemTier", Player.GolemTier );

		//arena 7

		SaveGame.Save<int> ( "MegaMinionCards", Player.MegaMinionCards );
		SaveGame.Save<int> ( "MegaMinionLevel", Player.MegaMinionLevel );
		SaveGame.Save<int> ( "MegaMinionTier", Player.MegaMinionTier );

		SaveGame.Save<int> ( "GuardsCards", Player.GuardsCards );
		SaveGame.Save<int> ( "GuardsLevel", Player.GuardsLevel );
		SaveGame.Save<int> ( "GuardsTier", Player.GuardsTier );

		SaveGame.Save<int> ( "PrincessCards", Player.PrincessCards );
		SaveGame.Save<int> ( "PrincessLevel", Player.PrincessLevel );
		SaveGame.Save<int> ( "PrincessTier", Player.PrincessTier );

		SaveGame.Save<int> ( "DarkPrinceCards", Player.DarkPrinceCards );
		SaveGame.Save<int> ( "DarkPrinceLevel", Player.DarkPrinceLevel );
		SaveGame.Save<int> ( "DarkPrinceTier", Player.DarkPrinceTier );

		SaveGame.Save<int> ( "ElectroWizardCards", Player.ElectroWizardCards );
		SaveGame.Save<int> ( "ElectroWizardLevel", Player.ElectroWizardLevel );
		SaveGame.Save<int> ( "ElectroWizardTier", Player.ElectroWizardTier );

		SaveGame.Save<int> ( "RoyalGiantCards", Player.RoyalGiantCards );
		SaveGame.Save<int> ( "RoyalGiantLevel", Player.RoyalGiantLevel );
		SaveGame.Save<int> ( "RoyalGiantTier", Player.RoyalGiantTier );

		SaveGame.Save<int> ( "EliteBarbariansCards", Player.EliteBarbariansCards );
		SaveGame.Save<int> ( "EliteBarbariansLevel", Player.EliteBarbariansLevel );
		SaveGame.Save<int> ( "EliteBarbariansTier", Player.EliteBarbariansTier );

		SaveGame.Save<int> ( "ThreeMusketeersCards", Player.ThreeMusketeersCards );
		SaveGame.Save<int> ( "ThreeMusketeersLevel", Player.ThreeMusketeersLevel );
		SaveGame.Save<int> ( "ThreeMusketeersTier", Player.ThreeMusketeersTier );

		//arena 8

		SaveGame.Save<int> ( "IceSpiritCards", Player.IceSpiritCards );
		SaveGame.Save<int> ( "IceSpiritLevel", Player.IceSpiritLevel );
		SaveGame.Save<int> ( "IceSpiritTier", Player.IceSpiritTier );

		SaveGame.Save<int> ( "BatsCards", Player.BatsCards );
		SaveGame.Save<int> ( "BatsLevel", Player.BatsLevel );
		SaveGame.Save<int> ( "BatsTier", Player.BatsTier );

		SaveGame.Save<int> ( "IceGolemCards", Player.IceGolemCards );
		SaveGame.Save<int> ( "IceGolemLevel", Player.IceGolemLevel );
		SaveGame.Save<int> ( "IceGolemTier", Player.IceGolemTier );

		SaveGame.Save<int> ( "NightWitchCards", Player.NightWitchCards );
		SaveGame.Save<int> ( "NightWitchLevel", Player.NightWitchLevel );
		SaveGame.Save<int> ( "NightWitchTier", Player.NightWitchTier );

		SaveGame.Save<int> ( "LumberjackCards", Player.LumberjackCards );
		SaveGame.Save<int> ( "LumberjackLevel", Player.LumberjackLevel );
		SaveGame.Save<int> ( "LumberjackTier", Player.LumberjackTier );

		SaveGame.Save<int> ( "BowlerCards", Player.BowlerCards );
		SaveGame.Save<int> ( "BowlerLevel", Player.BowlerLevel );
		SaveGame.Save<int> ( "BowlerTier", Player.BowlerTier );

		//arena 9

		SaveGame.Save<int> ( "GoblinGangCards", Player.GoblinGangCards );
		SaveGame.Save<int> ( "GoblinGangLevel", Player.GoblinGangLevel );
		SaveGame.Save<int> ( "GoblinGangTier", Player.GoblinGangTier );

		SaveGame.Save<int> ( "DartGoblinCards", Player.DartGoblinCards );
		SaveGame.Save<int> ( "DartGoblinLevel", Player.DartGoblinLevel );
		SaveGame.Save<int> ( "DartGoblinTier", Player.DartGoblinTier );

		SaveGame.Save<int> ( "BanditCards", Player.BanditCards );
		SaveGame.Save<int> ( "BanditLevel", Player.BanditLevel );
		SaveGame.Save<int> ( "BanditTier", Player.BanditTier );

		SaveGame.Save<int> ( "FlyingMachineCards", Player.FlyingMachineCards );
		SaveGame.Save<int> ( "FlyingMachineLevel", Player.FlyingMachineLevel );
		SaveGame.Save<int> ( "FlyingMachineTier", Player.FlyingMachineTier );

		SaveGame.Save<int> ( "HunterCards", Player.HunterCards );
		SaveGame.Save<int> ( "HunterLevel", Player.HunterLevel );
		SaveGame.Save<int> ( "HunterTier", Player.HunterTier );

		SaveGame.Save<int> ( "ExecutionerCards", Player.ExecutionerCards );
		SaveGame.Save<int> ( "ExecutionerLevel", Player.ExecutionerLevel );
		SaveGame.Save<int> ( "ExecutionerTier", Player.ExecutionerTier );

		//arena 10

		SaveGame.Save<int> ( "RoyalGhostCards", Player.RoyalGhostCards );
		SaveGame.Save<int> ( "RoyalGhostLevel", Player.RoyalGhostLevel );
		SaveGame.Save<int> ( "RoyalGhostTier", Player.RoyalGhostTier );

		SaveGame.Save<int> ( "CannonCartCards", Player.CannonCartCards );
		SaveGame.Save<int> ( "CannonCartLevel", Player.CannonCartLevel );
		SaveGame.Save<int> ( "CannonCartTier", Player.CannonCartTier );

		SaveGame.Save<int> ( "MegaKnightCards", Player.MegaKnightCards );
		SaveGame.Save<int> ( "MegaKnightLevel", Player.MegaKnightLevel );
		SaveGame.Save<int> ( "MegaKnightTier", Player.MegaKnightTier );

		//arena 11

		SaveGame.Save<int> ( "ZappiesCards", Player.ZappiesCards );
		SaveGame.Save<int> ( "ZappiesLevel", Player.ZappiesLevel );
		SaveGame.Save<int> ( "ZappiesTier", Player.ZappiesTier );

		SaveGame.Save<int> ( "MagicalArcherCards", Player.MagicalArcherCards );
		SaveGame.Save<int> ( "MagicalArcherLevel", Player.MagicalArcherLevel );
		SaveGame.Save<int> ( "MagicalArcherTier", Player.MagicalArcherTier );

		//---stats---

		SaveGame.Save<int> ( "ElixClicks", Player.ElixClicks );
		SaveGame.Save<float> ( "CollectedElix", Player.CollectedElix );
		SaveGame.Save<float> ( "CollectedCoins", Player.CollectedCoins );
		SaveGame.Save<float> ( "CollectedJewels", Player.CollectedJewels );
		SaveGame.Save<int> ( "CollectedExperience", Player.CollectedExperience );
		SaveGame.Save<int> ("CollectedCrowns", Player.CollectedCrowns);

		SaveGame.Save<int> ( "SkeletonCoinTimes", Player.SkeletonCoinTimes );
		SaveGame.Save<int> ( "ArchersCoinTimes", Player.ArchersCoinTimes );
		SaveGame.Save<int> ( "KnightCoinTimes", Player.KnightCoinTimes );
		SaveGame.Save<int> ( "BomberCoinTimes", Player.BomberCoinTimes );
		SaveGame.Save<int> ( "SkeletonArmyCoinTimes", Player.SkeletonArmyCoinTimes );
		SaveGame.Save<int> ( "MusketeerCoinTimes", Player.MusketeerCoinTimes );
		SaveGame.Save<int> ( "MiniPekkaCoinTimes", Player.MiniPekkaCoinTimes );
		SaveGame.Save<int> ( "BabyDragonCoinTimes", Player.BabyDragonCoinTimes );
		SaveGame.Save<int> ( "GiantCoinTimes", Player.GiantCoinTimes );
		SaveGame.Save<int> ( "PrinceCoinTimes", Player.PrinceCoinTimes );
		SaveGame.Save<int> ( "WitchCoinTimes", Player.WitchCoinTimes );
		SaveGame.Save<int> ( "GoblinsCoinTimes", Player.GoblinsCoinTimes );
		SaveGame.Save<int> ( "SpearGoblinsCoinTimes", Player.SpearGoblinsCoinTimes );
		SaveGame.Save<int> ( "ValkyrieCoinTimes", Player.ValkyrieCoinTimes );
		SaveGame.Save<int> ( "MinionsCoinTimes", Player.MinionsCoinTimes );
		SaveGame.Save<int> ( "BallonCoinTimes", Player.BallonCoinTimes );
		SaveGame.Save<int> ( "GiantSkeletonCoinTimes", Player.GiantSkeletonCoinTimes );
		SaveGame.Save<int> ( "BabariansCoinTimes", Player.BabariansCoinTimes );
		SaveGame.Save<int> ( "HogRaiderCoinTimes", Player.HogRaiderCoinTimes );
		SaveGame.Save<int> ( "InfernoDragonCoinTimes", Player.InfernoDragonCoinTimes );
		SaveGame.Save<int> ( "MinionHordeCoinTimes", Player.MinionHordeCoinTimes );
		SaveGame.Save<int> ( "PekkaCoinTimes", Player.PekkaCoinTimes );
		SaveGame.Save<int> ( "LavaHoundCoinTimes", Player.LavaHoundCoinTimes );
		SaveGame.Save<int> ( "FireSpiritsCoinTimes", Player.FireSpiritsCoinTimes );
		SaveGame.Save<int> ( "IceWizardCoinTimes", Player.IceWizardCoinTimes );
		SaveGame.Save<int> ( "WizardCoinTimes", Player.WizardCoinTimes );
		SaveGame.Save<int> ( "SkeletonBarrelCoinTimes", Player.SkeletonBarrelCoinTimes );
		SaveGame.Save<int> ( "MinerCoinTimes", Player.MinerCoinTimes );
		SaveGame.Save<int> ( "BattleRamCoinTimes", Player.BattleRamCoinTimes );
		SaveGame.Save<int> ( "SparkyCoinTimes", Player.SparkyCoinTimes );
		SaveGame.Save<int> ( "GolemCoinTimes", Player.GolemCoinTimes );
		SaveGame.Save<int> ( "MegaMinionCoinTimes", Player.MegaMinionCoinTimes );
		SaveGame.Save<int> ( "GuardsCoinTimes", Player.GuardsCoinTimes );
		SaveGame.Save<int> ( "PrincessCoinTimes", Player.PrincessCoinTimes );
		SaveGame.Save<int> ( "DarkPrinceCoinTimes", Player.DarkPrinceCoinTimes );
		SaveGame.Save<int> ( "ElectroWizardCoinTimes", Player.ElectroWizardCoinTimes );
		SaveGame.Save<int> ( "RoyalGiantCoinTimes", Player.RoyalGiantCoinTimes );
		SaveGame.Save<int> ( "EliteBarbariansCoinTimes", Player.EliteBarbariansCoinTimes );
		SaveGame.Save<int> ( "ThreeMusketeersCoinTimes", Player.ThreeMusketeersCoinTimes );
		SaveGame.Save<int> ( "IceSpiritCoinTimes", Player.IceSpiritCoinTimes );
		SaveGame.Save<int> ( "BatsCoinTimes", Player.BatsCoinTimes );
		SaveGame.Save<int> ( "IceGolemCoinTimes", Player.IceGolemCoinTimes );
		SaveGame.Save<int> ( "NightWitchCoinTimes", Player.NightWitchCoinTimes );
		SaveGame.Save<int> ( "LumberjackCoinTimes", Player.LumberjackCoinTimes );
		SaveGame.Save<int> ( "BowlerCoinTimes", Player.BowlerCoinTimes );
		SaveGame.Save<int> ( "GoblinGangCoinTimes", Player.GoblinGangCoinTimes );
		SaveGame.Save<int> ( "DartGoblinCoinTimes", Player.DartGoblinCoinTimes );
		SaveGame.Save<int> ( "BanditCoinTimes", Player.BanditCoinTimes );
		SaveGame.Save<int> ( "FlyingMachineCoinTimes", Player.FlyingMachineCoinTimes );
		SaveGame.Save<int> ( "HunterCoinTimes", Player.HunterCoinTimes );
		SaveGame.Save<int> ( "ExecutionerCoinTimes", Player.ExecutionerCoinTimes );
		SaveGame.Save<int> ( "RoyalGhostCoinTimes", Player.RoyalGhostCoinTimes );
		SaveGame.Save<int> ( "CannonCartCoinTimes", Player.CannonCartCoinTimes );
		SaveGame.Save<int> ( "MegaKnightCoinTimes", Player.MegaKnightCoinTimes );
		SaveGame.Save<int> ( "ZappiesCoinTimes", Player.ZappiesCoinTimes );
		SaveGame.Save<int> ( "MagicalArcherCoinTimes", Player.MagicalArcherCoinTimes );

		//---options---
		SaveGame.Save<int> ( "Language", Player.Language );
		SaveGame.Save<int> ( "CrownParticles", Player.CrownParticles );
		SaveGame.Save<int> ( "LegendaryParticleNumber", Player.LegendaryParticleNumber );
		SaveGame.Save<int> ( "EpicParticleNumber", Player.EpicParticleNumber );
		SaveGame.Save<int> ( "RareParticleNumber", Player.RareParticleNumber );
		SaveGame.Save<int> ( "CommonParticleNumber", Player.CommonParticleNumber );
		SaveGame.Save<bool> ( "ShowParticles", Player.ShowParticles );
		SaveGame.Save<bool> ( "ShowChestParticles", Player.ShowChestParticles );
		SaveGame.Save<int> ( "GemParticleNumber", Player.GemParticleNumber );
		SaveGame.Save<bool> ( "ShowChestTexture", Player.ShowChestTexture );
		SaveGame.Save<bool> ( "ShowElixAnimation", Player.ShowElixAnimation );
		SaveGame.Save<bool> ( "ShowSpellOutput", Player.ShowSpellOutput );
		SaveGame.Save<bool> ( "ShowSpellParticle", Player.ShowSpellParticle );
	}
}
