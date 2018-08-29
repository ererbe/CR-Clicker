using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {

	public static int PlayerLevel = 1;
	public static int Experience;

	public static float Elix;
	public static float Coins;
	public static float Gems;
	public static float Trophys;
	public static int Crowns;
	public static int ElixInt;
	public static int CoinsInt;
	public static int GemsInt;
	public static int TrophysInt;

	public static int Arena;

	public static float DefaultElixPerClick = 0.1f;
	public static float DefaultElixPerSecound = 0.5f;

	public static float ElixPerClick = 0.1f;
	public static float ElixPerSecound = 0.5f;

	//chests
	public static int ClanChestTier;
	public static int ClanChestCrowns;

	//----------spells----------
	// arena 0
	public static int ArrowsCards;
	public static int ArrowsLevel;
	public static int ArrowsTier;
	public static int ArrowsElixCost = 21;

	public static int FireballCards;
	public static int FireballLevel;
	public static int FireballTier;
	public static int FireballElixCost = 28;

	// arena 1
	public static int GoblinBarrelCards;
	public static int GoblinBarrelLevel;
	public static int GoblinBarrelTier;
	public static int GoblinBarrelElixCost = 21;

	public static int LightningCards;
	public static int LightningLevel;
	public static int LightningTier;
	public static int LightningElixCost = 42;

	// arena 3
	public static int RageCards;
	public static int RageLevel;
	public static int RageTier;
	public static int RageElixCost = 14;

	public static int RocketCards;
	public static int RocketLevel;
	public static int RocketTier;
	public static int RocketElixCost = 42;

	// arena 4
	public static int FreezeCards;
	public static int FreezeLevel;
	public static int FreezeTier;
	public static int FreezeElixCost = 28;

	// arena 5
	public static int ZapCards;
	public static int ZapLevel;
	public static int ZapTier;
	public static int ZapElixCost = 14;

	public static int PoisonCards;
	public static int PoisonLevel;
	public static int PoisonTier;
	public static int PoisonElixCost = 28;

	public static int GraveyardCards;
	public static int GraveyardLevel;
	public static int GraveyardTier;
	public static int GraveyardElixCost = 35;

	public static int MirrorCards;
	public static int MirrorLevel;
	public static int MirrorTier;
	public static int MirrorElixCost = 70;

	// arena 6
	public static int TheLogCards;
	public static int TheLogLevel;
	public static int TheLogTier;
	public static int TheLogElixCost = 14;

	public static int TornadoCards;
	public static int TornadoLevel;
	public static int TornadoTier;
	public static int TornadoElixCost = 21;

	// arena 8
	public static int CloneCards;
	public static int CloneLevel;
	public static int CloneTier;
	public static int CloneElixCost = 21;

	// arena 10
	public static int HealCards;
	public static int HealLevel;
	public static int HealTier;
	public static int HealElixCost = 21;

	public static int BarbarianBarrelCards;
	public static int BarbarianBarrelLevel;
	public static int BarbarianBarrelTier;
	public static int BarbarianBarrelElixCost = 21;

	//----------buildings----------
	// arena 1
	public static int GoblinHutCards;
	public static int GoblinHutLevel;
	public static int GoblinHutTier;
	public static int GoblinHutElixCost = 35;

	// arena 2
	public static int TombstoneCards;
	public static int TombstoneLevel;
	public static int TombstoneTier;
	public static int TombstoneElixCost = 21;

	public static int BombTowerCards;
	public static int BombTowerLevel;
	public static int BombTowerTier;
	public static int BombTowerElixCost = 35;

	// arena 3
	public static int CannonCards;
	public static int CannonLevel;
	public static int CannonTier;
	public static int CannonElixCost = 21;

	public static int BarbarianHutCards;
	public static int BarbarianHutLevel;
	public static int BarbarianHutTier;
	public static int BarbarianHutElixCost = 49;

	public static int XBowCards;
	public static int XBowLevel;
	public static int XBowTier;
	public static int XBowElixCost = 42;

	// arena 4
	public static int TeslaCards;
	public static int TeslaLevel;
	public static int TeslaTier;
	public static int TeslaElixCost = 28;

	public static int InfernoTowerCards;
	public static int InfernoTowerLevel;
	public static int InfernoTowerTier;
	public static int InfernoTowerElixCost = 35;

	// arena 5
	public static int FurnaceCards;
	public static int FurnaceLevel;
	public static int FurnaceTier;
	public static int FurnaceElixCost = 28;

	// arena 6
	public static int MortarCards;
	public static int MortarLevel;
	public static int MortarTier;
	public static int MortarElixCost = 28;

	public static int ElixirCollectorCards;
	public static int ElixirCollectorLevel;
	public static int ElixirCollectorTier;
	public static int ElixirCollectorElixCost = 42;

	//----------troops----------
	// arena 0
	public static int SkeletonCards = 1;
	public static int SkeletonLevel;
	public static int SkeletonTier = 1;
	public static int SkeletonElixCost = 7;

	public static int ArchersCards;
	public static int ArchersLevel;
	public static int ArchersTier;
	public static int ArchersElixCost = 21;

	public static int KnightCards;
	public static int KnightLevel;
	public static int KnightTier;
	public static int KnightElixCost = 21;

	public static int BomberCards;
	public static int BomberLevel;
	public static int BomberTier;
	public static int BomberElixCost = 21;

	public static int SkeletonArmyCards;
	public static int SkeletonArmyLevel;
	public static int SkeletonArmyTier;
	public static int SkeletonArmyElixCost = 21;

	public static int MusketeerCards;
	public static int MusketeerLevel;
	public static int MusketeerTier;
	public static int MusketeerElixCost = 28;

	public static int MiniPekkaCards;
	public static int MiniPekkaLevel;
	public static int MiniPekkaTier;
	public static int MiniPekkaElixCost = 28;

	public static int BabyDragonCards;
	public static int BabyDragonLevel;
	public static int BabyDragonTier;
	public static int BabyDragonElixCost = 28;

	public static int GiantCards;
	public static int GiantLevel;
	public static int GiantTier;
	public static int GiantElixCost = 35;

	public static int PrinceCards;
	public static int PrinceLevel;
	public static int PrinceTier;
	public static int PrinceElixCost = 35;

	public static int WitchCards;
	public static int WitchLevel;
	public static int WitchTier;
	public static int WitchElixCost = 35;

	//arena1

	public static int GoblinsCards;
	public static int GoblinsLevel;
	public static int GoblinsTier;
	public static int GoblinsElixCost = 14;

	public static int SpearGoblinsCards;
	public static int SpearGoblinsLevel;
	public static int SpearGoblinsTier;
	public static int SpearGoblinsElixCost = 14;

	public static int ValkyrieCards;
	public static int ValkyrieLevel;
	public static int ValkyrieTier;
	public static int ValkyrieElixCost = 28;

	//arena2

	public static int MinionsCards;
	public static int MinionsLevel;
	public static int MinionsTier;
	public static int MinionsElixCost = 21;

	public static int BallonCards;
	public static int BallonLevel;
	public static int BallonTier;
	public static int BallonElixCost = 35;

	public static int GiantSkeletonCards;
	public static int GiantSkeletonLevel;
	public static int GiantSkeletonTier;
	public static int GiantSkeletonElixCost = 42;

	//arena3

	public static int BabariansCards;
	public static int BabariansLevel;
	public static int BabariansTier;
	public static int BabariansElixCost = 35;

	//arena4

	public static int HogRaiderCards;
	public static int HogRaiderLevel;
	public static int HogRaiderTier;
	public static int HogRaiderElixCost = 28;

	public static int InfernoDragonCards;
	public static int InfernoDragonLevel;
	public static int InfernoDragonTier;
	public static int InfernoDragonElixCost = 28;

	public static int MinionHordeCards;
	public static int MinionHordeLevel;
	public static int MinionHordeTier;
	public static int MinionHordeElixCost = 35;

	public static int PekkaCards;
	public static int PekkaLevel;
	public static int PekkaTier;
	public static int PekkaElixCost = 49;

	public static int LavaHoundCards;
	public static int LavaHoundLevel;
	public static int LavaHoundTier;
	public static int LavaHoundElixCost = 49;

	//arena5

	public static int FireSpiritsCards;
	public static int FireSpiritsLevel;
	public static int FireSpiritsTier;
	public static int FireSpiritsElixCost = 13;

	public static int IceWizardCards;
	public static int IceWizardLevel;
	public static int IceWizardTier;
	public static int IceWizardElixCost = 21;

	public static int WizardCards;
	public static int WizardLevel;
	public static int WizardTier;
	public static int WizardElixCost = 35;

	//arena6

	public static int SkeletonBarrelCards;
	public static int SkeletonBarrelLevel;
	public static int SkeletonBarrelTier;
	public static int SkeletonBarrelElixCost = 21;

	public static int MinerCards;
	public static int MinerLevel;
	public static int MinerTier;
	public static int MinerElixCost = 21;

	public static int BattleRamCards;
	public static int BattleRamLevel;
	public static int BattleRamTier;
	public static int BattleRamElixCost = 28;

	public static int SparkyCards;
	public static int SparkyLevel;
	public static int SparkyTier;
	public static int SparkyElixCost = 42;

	public static int GolemCards;
	public static int GolemLevel;
	public static int GolemTier;
	public static int GolemElixCost = 56;

	//arena7

	public static int MegaMinionCards;
	public static int MegaMinionLevel;
	public static int MegaMinionTier;
	public static int MegaMinionElixCost = 21;

	public static int GuardsCards;
	public static int GuardsLevel;
	public static int GuardsTier;
	public static int GuardsElixCost = 21;

	public static int PrincessCards;
	public static int PrincessLevel;
	public static int PrincessTier;
	public static int PrincessElixCost = 21;

	public static int DarkPrinceCards;
	public static int DarkPrinceLevel;
	public static int DarkPrinceTier;
	public static int DarkPrinceElixCost = 28;

	public static int ElectroWizardCards;
	public static int ElectroWizardLevel;
	public static int ElectroWizardTier;
	public static int ElectroWizardElixCost = 28;

	public static int RoyalGiantCards;
	public static int RoyalGiantLevel;
	public static int RoyalGiantTier;
	public static int RoyalGiantElixCost = 42;

	public static int EliteBarbariansCards;
	public static int EliteBarbariansLevel;
	public static int EliteBarbariansTier;
	public static int EliteBarbariansElixCost = 42;

	public static int ThreeMusketeersCards;
	public static int ThreeMusketeersLevel;
	public static int ThreeMusketeersTier;
	public static int ThreeMusketeersElixCost = 63;

	//arena8

	public static int IceSpiritCards;
	public static int IceSpiritLevel;
	public static int IceSpiritTier;
	public static int IceSpiritElixCost = 7;

	public static int BatsCards;
	public static int BatsLevel;
	public static int BatsTier;
	public static int BatsElixCost = 14;

	public static int IceGolemCards;
	public static int IceGolemLevel;
	public static int IceGolemTier;
	public static int IceGolemElixCost = 14;

	public static int NightWitchCards;
	public static int NightWitchLevel;
	public static int NightWitchTier;
	public static int NightWitchElixCost =28;

	public static int LumberjackCards;
	public static int LumberjackLevel;
	public static int LumberjackTier;
	public static int LumberjackElixCost = 28;

	public static int BowlerCards;
	public static int BowlerLevel;
	public static int BowlerTier;
	public static int BowlerElixCost = 35;

	//arena9

	public static int GoblinGangCards;
	public static int GoblinGangLevel;
	public static int GoblinGangTier;
	public static int GoblinGangElixCost = 21;

	public static int DartGoblinCards;
	public static int DartGoblinLevel;
	public static int DartGoblinTier;
	public static int DartGoblinElixCost = 21;

	public static int BanditCards;
	public static int BanditLevel;
	public static int BanditTier;
	public static int BanditElixCost = 21;

	public static int FlyingMachineCards;
	public static int FlyingMachineLevel;
	public static int FlyingMachineTier;
	public static int FlyingMachineElixCost = 28;

	public static int HunterCards;
	public static int HunterLevel;
	public static int HunterTier;
	public static int HunterElixCost = 28;

	public static int ExecutionerCards;
	public static int ExecutionerLevel;
	public static int ExecutionerTier;
	public static int ExecutionerElixCost = 35;

	//arena10

	public static int RoyalGhostCards;
	public static int RoyalGhostLevel;
	public static int RoyalGhostTier;
	public static int RoyalGhostElixCost = 21;

	public static int CannonCartCards;
	public static int CannonCartLevel;
	public static int CannonCartTier;
	public static int CannonCartElixCost = 35;

	public static int MegaKnightCards;
	public static int MegaKnightLevel;
	public static int MegaKnightTier;
	public static int MegaKnightElixCost = 49;

	//arena11

	public static int ZappiesCards;
	public static int ZappiesLevel;
	public static int ZappiesTier;
	public static int ZappiesElixCost = 28;

	public static int MagicalArcherCards;
	public static int MagicalArcherLevel;
	public static int MagicalArcherTier;
	public static int MagicalArcherElixCost = 28;

	// Tiers
	public static int CardsToTier1 = 1;
	public static int CardsToTier2 = 2;
	public static int CardsToTier3 = 4;
	public static int CardsToTier4 = 10;
	public static int CardsToTier5 = 20;
	public static int CardsToTier6 = 50;
	public static int CardsToTier7 = 100;
	public static int CardsToTier8 = 200;
	public static int CardsToTier9 = 400;
	public static int CardsToTier10 = 800;
	public static int CardsToTier11 = 1000;
	public static int CardsToTier12 = 2000;
	public static int CardsToTier13 = 5000;

	//stats
	public static int ElixClicks;
	public static float CollectedElix;
	public static float CollectedCoins;
	public static float CollectedJewels;
	public static int CollectedExperience;
	public static int CollectedCrowns;

	public static int SkeletonCoinTimes;
	public static int ArchersCoinTimes;
	public static int KnightCoinTimes;
	public static int BomberCoinTimes;
	public static int SkeletonArmyCoinTimes;
	public static int MusketeerCoinTimes;
	public static int MiniPekkaCoinTimes;
	public static int BabyDragonCoinTimes;
	public static int GiantCoinTimes;
	public static int PrinceCoinTimes;
	public static int WitchCoinTimes;
	public static int GoblinsCoinTimes;
	public static int SpearGoblinsCoinTimes;
	public static int ValkyrieCoinTimes;
	public static int MinionsCoinTimes;
	public static int BallonCoinTimes;
	public static int GiantSkeletonCoinTimes;
	public static int BabariansCoinTimes;
	public static int HogRaiderCoinTimes;
	public static int InfernoDragonCoinTimes;
	public static int MinionHordeCoinTimes;
	public static int PekkaCoinTimes;
	public static int LavaHoundCoinTimes;
	public static int FireSpiritsCoinTimes;
	public static int IceWizardCoinTimes;
	public static int WizardCoinTimes;
	public static int SkeletonBarrelCoinTimes;
	public static int MinerCoinTimes;
	public static int BattleRamCoinTimes;
	public static int SparkyCoinTimes;
	public static int GolemCoinTimes;
	public static int MegaMinionCoinTimes;
	public static int GuardsCoinTimes;
	public static int PrincessCoinTimes;
	public static int DarkPrinceCoinTimes;
	public static int ElectroWizardCoinTimes;
	public static int RoyalGiantCoinTimes;
	public static int EliteBarbariansCoinTimes;
	public static int ThreeMusketeersCoinTimes;
	public static int IceSpiritCoinTimes;
	public static int BatsCoinTimes;
	public static int IceGolemCoinTimes;
	public static int NightWitchCoinTimes;
	public static int LumberjackCoinTimes;
	public static int BowlerCoinTimes;
	public static int GoblinGangCoinTimes;
	public static int DartGoblinCoinTimes;
	public static int BanditCoinTimes;
	public static int FlyingMachineCoinTimes;
	public static int HunterCoinTimes;
	public static int ExecutionerCoinTimes;
	public static int RoyalGhostCoinTimes;
	public static int CannonCartCoinTimes;
	public static int MegaKnightCoinTimes;
	public static int ZappiesCoinTimes;
	public static int MagicalArcherCoinTimes;

	public static int UsedArrows;
	public static int UsedFireball;
	public static int UsedGoblinBarrel;
	public static int UsedLightning;
	public static int UsedRage;
	public static int UsedRocket;
	public static int UsedFreeze;
	public static int UsedZap;
	public static int UsedPoison;
	public static int UsedMirror;
	public static int UsedGraveyard;
	public static int UsedTheLog;
	public static int UsedTornado;
	public static int UsedClone;
	public static int UsedHeal;
	public static int UsedBarbarianBarrel;

	public static int FrozenElixClicks;

	//options
	public static int Language = 1;
	public static int CrownParticles = 1; //(1 Default, 2-3 special, 4 off)
	public static bool ShowParticles = true;
	public static bool ShowChestParticles = true;
	public static int GemParticleNumber = 1;
	public static int LegendaryParticleNumber = 1;
	public static int EpicParticleNumber = 1;
	public static int RareParticleNumber = 1;
	public static int CommonParticleNumber = 1;
	public static bool ShowChestTexture = true;
	public static bool ShowElixAnimation = true;
	public static bool ShowSpellOutput = true;
	public static bool ShowSpellParticle = true;

	//skills
	public static float RageMulti = 1f;
	public static int FreezeTouchCount = 0;
	public static float MirrorMulti = 1f;
	public static float TornadoMulti = 1f;
	public static float CloneMulti = 1f;
	public static bool HealIsActive = false;

	//other stuff
	public static bool FinishedControl = false;
}
