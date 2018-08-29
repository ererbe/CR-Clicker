using System.Collections;
using UnityEngine;

public class Kasern : MonoBehaviour {

	public KasernUI kasernUI;
	public TroopManager troopManager;
	public ArenaTextUI arenaTextUI;
	public ExperienceUI experienceUI;

	public OpenCloseKasern openCloseKasern;

	public Skeleton skeleton;
	public Archers archers;
	public Knight knight;
	public Bomber bomber;
	public SkeletonArmy skeletonArmy;
	public Musketeer musketeer;
	public MiniPekka miniPekka;
	public BabyDragon babyDragon;
	public Giant giant;
	public Prince prince;
	public Witch witch;

	public Goblins goblins;
	public SpearGoblins spearGoblins;
	public Valkyrie valkyrie;

	public Minions minions;
	public Ballon ballon;
	public GiantSkeleton giantSkeleton;

	public Babarians barbarians;

	public HogRaider hogRaider;
	public InfernoDragon infernoDragon;
	public MinionHorde minionHorde;
	public Pekka pekka;
	public LavaHound lavaHound;

	public FireSpirits fireSpirits;
	public IceWizard iceWizard;
	public Wizard wizard;

	public SkeletonBarrel skeletonBarrel;
	public Miner miner;
	public BattleRam battleRam;
	public Sparky sparky;
	public Golem golem;

	public MegaMinion megaMinion;
	public Guards guards;
	public Princess princess;
	public DarkPrince darkPrince;
	public ElectroWizard electroWizard;
	public RoyalGiant royalGiant;
	public EliteBarbarians eliteBarbarians;
	public ThreeMusketeers threeMusketeers;

	public IceSpirit iceSpirit;
	public Bats bats;
	public IceGolem iceGolem;
	public NightWitch nightWitch;
	public Lumberjack lumberjack;
	public Bowler bowler;

	public GoblinGang goblinGang;
	public DartGoblin dartGoblin;
	public Bandit bandit;
	public FlyingMachine flyingMachine;
	public Hunter hunter;
	public Executioner executioner;

	public RoyalGhost royalGhost;
	public CannonCart cannonCart;
	public MegaKnight megaKnight;

	public Zappies zappies;
	public MagicalArcher magicalArcher;

	public static int SkeletonNextTierCards;
	public static int ArchersNextTierCards;
	public static int KnightNextTierCards;
	public static int BomberNextTierCards;
	public static int SkeletonArmyNextTierCards;
	public static int MusketeerNextTierCards;
	public static int MiniPekkaNextTierCards;
	public static int BabyDragonNextTierCards;
	public static int GiantNextTierCards;
	public static int PrinceNextTierCards;
	public static int WitchNextTierCards;
	public static int GoblinsNextTierCards;
	public static int SpearGoblinsNextTierCards;
	public static int ValkyrieNextTierCards;
	public static int MinionsNextTierCards;
	public static int BallonNextTierCards;
	public static int GiantSkeletonNextTierCards;
	public static int BabariansNextTierCards;
	public static int HogRaiderNextTierCards;
	public static int InfernoDragonNextTierCards;
	public static int MinionHordeNextTierCards;
	public static int PekkaNextTierCards;
	public static int LavaHoundNextTierCards;
	public static int FireSpiritsNextTierCards;
	public static int IceWizardNextTierCards;
	public static int WizardNextTierCards;
	public static int SkeletonBarrelNextTierCards;
	public static int MinerNextTierCards;
	public static int BattleRamNextTierCards;
	public static int SparkyNextTierCards;
	public static int GolemNextTierCards;
	public static int MegaMinionNextTierCards;
	public static int GuardsNextTierCards;
	public static int PrincessNextTierCards;
	public static int DarkPrinceNextTierCards;
	public static int ElectroWizardNextTierCards;
	public static int RoyalGiantNextTierCards;
	public static int EliteBarbariansNextTierCards;
	public static int ThreeMusketeersNextTierCards;
	public static int IceSpiritNextTierCards;
	public static int BatsNextTierCards;
	public static int IceGolemNextTierCards;
	public static int NightWitchNextTierCards;
	public static int LumberjackNextTierCards;
	public static int BowlerNextTierCards;
	public static int GoblinGangNextTierCards;
	public static int DartGoblinNextTierCards;
	public static int BanditNextTierCards;
	public static int FlyingMachineNextTierCards;
	public static int HunterNextTierCards;
	public static int ExecutionerNextTierCards;
	public static int RoyalGhostNextTierCards;
	public static int CannonCartNextTierCards;
	public static int MegaKnightNextTierCards;
	public static int ZappiesNextTierCards;
	public static int MagicalArcherNextTierCards;

	private float x;

	void Awake () {
		UpdateTroopStatistics ();
	}

	void UpdateTroopStatistics () {
		CalculateSkeletonStats ();
		CalculateArchersStats ();
		CalculateKnightStats ();
		CalculateBomberStats ();
		CalculateSkeletonArmyStats ();
		CalculateMusketeerStats ();
		CalculateMiniPekkaStats ();
		CalculateBabyDragonStats ();
		CalculateGiantStats ();
		CalculatePrinceStats ();
		CalculateWitchStats ();
		CalculateGoblinsStats ();
		CalculateSpearGoblinsStats ();
		CalculateValkyrieStats ();
		CalculateMinionsStats ();
		CalculateBallonStats ();
		CalculateGiantSkeletonStats ();
		CalculateBabariansStats ();
		CalculateHogRaiderStats ();
		CalculateInfernoDragonStats ();
		CalculateMinionHordeStats ();
		CalculatePekkaStats ();
		CalculateLavaHoundStats ();
		CalculateFireSpiritsStats ();
		CalculateIceWizardStats ();
		CalculateWizardStats ();
		CalculateSkeletonBarrelStats ();
		CalculateMinerStats ();
		CalculateBattleRamStats ();
		CalculateSparkyStats ();
		CalculateGolemStats ();
		CalculateMegaMinionStats ();
		CalculateGuardsStats ();
		CalculatePrincessStats ();
		CalculateDarkPrinceStats ();
		CalculateElectroWizardStats ();
		CalculateRoyalGiantStats ();
		CalculateEliteBarbariansStats ();
		CalculateThreeMusketeersStats ();
		CalculateIceSpiritStats ();
		CalculateBatsStats ();
		CalculateIceGolemStats ();
		CalculateNightWitchStats ();
		CalculateLumberjackStats ();
		CalculateBowlerStats ();
		CalculateGoblinGangStats ();
		CalculateDartGoblinStats ();
		CalculateBanditStats ();
		CalculateFlyingMachineStats ();
		CalculateHunterStats ();
		CalculateExecutionerStats ();
		CalculateRoyalGhostStats ();
		CalculateCannonCartStats ();
		CalculateMegaKnightStats ();
		CalculateZappiesStats ();
		CalculateMagicalArcherStats ();

		CheckSkeletonTierCards ();
		CheckArchersTierCards ();
		CheckKnightTierCards ();
		CheckBomberTierCards ();
		CheckSkeletonArmyTierCards ();
		CheckMusketeerTierCards ();
		CheckMiniPekkaTierCards ();
		CheckBabyDragonTierCards ();
		CheckGiantTierCards ();
		CheckPrinceTierCards ();
		CheckWitchTierCards ();
		CheckGoblinsTierCards ();
		CheckSpearGoblinsTierCards ();
		CheckValkyrieTierCards ();
		CheckMinionsTierCards ();
		CheckBallonTierCards ();
		CheckGiantSkeletonTierCards ();
		CheckBabariansTierCards ();
		CheckHogRaiderTierCards ();
		CheckInfernoDragonTierCards ();
		CheckMinionHordeTierCards ();
		CheckPekkaTierCards ();
		CheckLavaHoundTierCards ();
		CheckFireSpiritsTierCards ();
		CheckIceWizardTierCards ();
		CheckWizardTierCards ();
		CheckSkeletonBarrelTierCards ();
		CheckMinerTierCards ();
		CheckBattleRamTierCards ();
		CheckSparkyTierCards ();
		CheckGolemTierCards ();
		CheckMegaMinionTierCards ();
		CheckGuardsTierCards ();
		CheckPrincessTierCards ();
		CheckDarkPrinceTierCards ();
		CheckElectroWizardTierCards ();
		CheckRoyalGiantTierCards ();
		CheckEliteBarbariansTierCards ();
		CheckThreeMusketeersTierCards ();
		CheckIceSpiritTierCards ();
		CheckBatsTierCards ();
		CheckIceGolemTierCards ();
		CheckNightWitchTierCards ();
		CheckLumberjackTierCards ();
		CheckBowlerTierCards ();
		CheckGoblinGangTierCards ();
		CheckDartGoblinTierCards ();
		CheckBanditTierCards ();
		CheckFlyingMachineTierCards ();
		CheckHunterTierCards ();
		CheckExecutionerTierCards ();
		CheckRoyalGhostTierCards ();
		CheckCannonCartTierCards ();
		CheckMegaKnightTierCards ();
		CheckZappiesTierCards ();
		CheckMagicalArcherTierCards ();

		CalculateNewSkeletonCost ();
		CalculateNewArchersCost ();
		CalculateNewKnightCost ();
		CalculateNewBomberCost ();
		CalculateNewSkeletonArmyCost ();
		CalculateNewMusketeerCost ();
		CalculateNewMiniPekkaCost ();
		CalculateNewBabyDragonCost ();
		CalculateNewGiantCost ();
		CalculateNewPrinceCost ();
		CalculateNewWitchCost ();
		CalculateNewGoblinsCost ();
		CalculateNewSpearGoblinsCost ();
		CalculateNewValkyrieCost ();
		CalculateNewMinionsCost ();
		CalculateNewBallonCost ();
		CalculateNewGiantSkeletonCost ();
		CalculateNewBabariansCost ();
		CalculateNewHogRaiderCost ();
		CalculateNewInfernoDragonCost ();
		CalculateNewMinionHordeCost ();
		CalculateNewPekkaCost ();
		CalculateNewLavaHoundCost ();
		CalculateNewFireSpiritsCost ();
		CalculateNewIceWizardCost ();
		CalculateNewWizardCost ();
		CalculateNewSkeletonBarrelCost ();
		CalculateNewMinerCost ();
		CalculateNewBattleRamCost ();
		CalculateNewSparkyCost ();
		CalculateNewGolemCost ();
		CalculateNewMegaMinionCost ();
		CalculateNewGuardsCost ();
		CalculateNewPrincessCost ();
		CalculateNewDarkPrinceCost ();
		CalculateNewElectroWizardCost ();
		CalculateNewRoyalGiantCost ();
		CalculateNewEliteBarbariansCost ();
		CalculateNewThreeMusketeersCost ();
		CalculateNewIceSpiritCost ();
		CalculateNewBatsCost ();
		CalculateNewIceGolemCost ();
		CalculateNewNightWitchCost ();
		CalculateNewLumberjackCost ();
		CalculateNewBowlerCost ();
		CalculateNewGoblinGangCost ();
		CalculateNewDartGoblinCost ();
		CalculateNewBanditCost ();
		CalculateNewFlyingMachineCost ();
		CalculateNewHunterCost ();
		CalculateNewExecutionerCost ();
		CalculateNewRoyalGhostCost ();
		CalculateNewCannonCartCost ();
		CalculateNewMegaKnightCost ();
		CalculateNewZappiesCost ();
		CalculateNewMagicalArcherCost ();
	}

	//arena 0

	public void UpgradeSkeleton () {
		if (Player.Elix >= Player.SkeletonElixCost) {
			Player.Elix -= Player.SkeletonElixCost;
			Player.SkeletonLevel += 1;
			Player.Experience += troopManager.Skeleton.ExperiencePerLevel;
			Player.Trophys += troopManager.Skeleton.TrophysPerLevel;
			CalculateSkeletonStats ();
			CalculateNewSkeletonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateSkeletonStats () {
		troopManager.Skeleton.CoinsPerTime = (float) troopManager.Skeleton.DefaultCoinsPerTime + (troopManager.Skeleton.CoinsPerTimeAddPerLevel * Player.SkeletonLevel) + (troopManager.Skeleton.CoinsPerTimeAddPerTier * Player.SkeletonTier);
		troopManager.Skeleton.CoinCollectDuration = (float) troopManager.Skeleton.DefaultCoinCollectDuration + (troopManager.Skeleton.CoinsCollectDurationChangePerTier * Player.SkeletonTier);
		skeleton.NewStats ();
	}

	public void CalculateNewSkeletonCost() {
		x = (float) Mathf.Pow(1.15f , Player.SkeletonLevel);
		Player.SkeletonElixCost = Mathf.FloorToInt((float) troopManager.Skeleton.DefaultElixCost * x);
		kasernUI.UpgradeSkeletonUI ();
	}

	public void CheckSkeletonTierCards () {
		if (Player.SkeletonTier == 1) {
			SkeletonNextTierCards = Player.CardsToTier2;
		} else if (Player.SkeletonTier == 2) {
			SkeletonNextTierCards = Player.CardsToTier3;
		} else if (Player.SkeletonTier == 3) {
			SkeletonNextTierCards = Player.CardsToTier4;
		} else if (Player.SkeletonTier == 4) {
			SkeletonNextTierCards = Player.CardsToTier5;
		} else if (Player.SkeletonTier == 5) {
			SkeletonNextTierCards = Player.CardsToTier6;
		} else if (Player.SkeletonTier == 6) {
			SkeletonNextTierCards = Player.CardsToTier7;
		} else if (Player.SkeletonTier == 7) {
			SkeletonNextTierCards = Player.CardsToTier8;
		} else if (Player.SkeletonTier == 8) {
			SkeletonNextTierCards = Player.CardsToTier9;
		} else if (Player.SkeletonTier == 9) {
			SkeletonNextTierCards = Player.CardsToTier10;
		} else if (Player.SkeletonTier == 10) {
			SkeletonNextTierCards = Player.CardsToTier11;
		} else if (Player.SkeletonTier == 11) {
			SkeletonNextTierCards = Player.CardsToTier12;
		} else if (Player.SkeletonTier == 12) {
			SkeletonNextTierCards = Player.CardsToTier13;
		} else if (Player.SkeletonTier == 13) {
			SkeletonNextTierCards = 0;
		} else {
			SkeletonNextTierCards = 0;
		}
	}

	public void UpgradeTierSkeleton () {
		if (Player.SkeletonCards >= SkeletonNextTierCards && Player.SkeletonTier <= 12) {
			Player.SkeletonCards -= SkeletonNextTierCards;
			Player.SkeletonTier += 1;
			Player.Experience += troopManager.Skeleton.ExperiencePerTier;
			Player.Trophys += troopManager.Skeleton.TrophysPerTier;
			kasernUI.UpgradeTierSkeletonUI ();
			CheckSkeletonTierCards ();
			CalculateSkeletonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeArchers () {
		if (Player.Elix >= Player.ArchersElixCost) {
			Player.Elix -= Player.ArchersElixCost;
			Player.ArchersLevel += 1;
			Player.Experience += troopManager.Archers.ExperiencePerLevel;
			Player.Trophys += troopManager.Archers.TrophysPerLevel;
			CalculateArchersStats ();
			CalculateNewArchersCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateArchersStats () {
		troopManager.Archers.CoinsPerTime = (float) troopManager.Archers.DefaultCoinsPerTime + (troopManager.Archers.CoinsPerTimeAddPerLevel * Player.ArchersLevel) + (troopManager.Archers.CoinsPerTimeAddPerTier * Player.ArchersTier);
		troopManager.Archers.CoinCollectDuration = (float) troopManager.Archers.DefaultCoinCollectDuration + (troopManager.Archers.CoinsCollectDurationChangePerTier * Player.ArchersTier);
		archers.NewStats ();
	}

	public void CalculateNewArchersCost() {
		x = (float) Mathf.Pow(1.15f , Player.ArchersLevel);
		Player.ArchersElixCost = Mathf.FloorToInt((float) troopManager.Archers.DefaultElixCost * x);
		kasernUI.UpgradeArchersUI ();
	}

	public void CheckArchersTierCards () {
		if (Player.ArchersTier == 0) {
			ArchersNextTierCards = Player.CardsToTier1;
		}else if (Player.ArchersTier == 1) {
			ArchersNextTierCards = Player.CardsToTier2;
		} else if (Player.ArchersTier == 2) {
			ArchersNextTierCards = Player.CardsToTier3;
		} else if (Player.ArchersTier == 3) {
			ArchersNextTierCards = Player.CardsToTier4;
		} else if (Player.ArchersTier == 4) {
			ArchersNextTierCards = Player.CardsToTier5;
		} else if (Player.ArchersTier == 5) {
			ArchersNextTierCards = Player.CardsToTier6;
		} else if (Player.ArchersTier == 6) {
			ArchersNextTierCards = Player.CardsToTier7;
		} else if (Player.ArchersTier == 7) {
			ArchersNextTierCards = Player.CardsToTier8;
		} else if (Player.ArchersTier == 8) {
			ArchersNextTierCards = Player.CardsToTier9;
		} else if (Player.ArchersTier == 9) {
			ArchersNextTierCards = Player.CardsToTier10;
		} else if (Player.ArchersTier == 10) {
			ArchersNextTierCards = Player.CardsToTier11;
		} else if (Player.ArchersTier == 11) {
			ArchersNextTierCards = Player.CardsToTier12;
		} else if (Player.ArchersTier == 12) {
			ArchersNextTierCards = Player.CardsToTier13;
		} else if (Player.ArchersTier == 13) {
			ArchersNextTierCards = 0;
		} else {
			ArchersNextTierCards = 0;
		}
	}

	public void UpgradeTierArchers () {
		if (Player.ArchersCards >= ArchersNextTierCards && Player.ArchersTier <= 12) {
			Player.ArchersCards -= ArchersNextTierCards;
			Player.ArchersTier += 1;
			Player.Experience += troopManager.Archers.ExperiencePerTier;
			Player.Trophys += troopManager.Archers.TrophysPerTier;
			kasernUI.UpgradeTierArchersUI ();
			CheckArchersTierCards ();
			CalculateArchersStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeKnight () {
		if (Player.Elix >= Player.KnightElixCost) {
			Player.Elix -= Player.KnightElixCost;
			Player.KnightLevel += 1;
			Player.Experience += troopManager.Knight.ExperiencePerLevel;
			Player.Trophys += troopManager.Knight.TrophysPerLevel;
			CalculateKnightStats ();
			CalculateNewKnightCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateKnightStats () {
		troopManager.Knight.CoinsPerTime = (float) troopManager.Knight.DefaultCoinsPerTime + (troopManager.Knight.CoinsPerTimeAddPerLevel * Player.KnightLevel) + (troopManager.Knight.CoinsPerTimeAddPerTier * Player.KnightTier);
		troopManager.Knight.CoinCollectDuration = (float) troopManager.Knight.DefaultCoinCollectDuration + (troopManager.Knight.CoinsCollectDurationChangePerTier * Player.KnightTier);
		knight.NewStats ();
	}

	public void CalculateNewKnightCost() {
		x = (float) Mathf.Pow(1.15f , Player.KnightLevel);
		Player.KnightElixCost = Mathf.FloorToInt((float) troopManager.Knight.DefaultElixCost * x);
		kasernUI.UpgradeKnightUI ();
	}

	public void CheckKnightTierCards () {
		if (Player.KnightTier == 0) {
			KnightNextTierCards = Player.CardsToTier1;
		}else if (Player.KnightTier == 1) {
			KnightNextTierCards = Player.CardsToTier2;
		} else if (Player.KnightTier == 2) {
			KnightNextTierCards = Player.CardsToTier3;
		} else if (Player.KnightTier == 3) {
			KnightNextTierCards = Player.CardsToTier4;
		} else if (Player.KnightTier == 4) {
			KnightNextTierCards = Player.CardsToTier5;
		} else if (Player.KnightTier == 5) {
			KnightNextTierCards = Player.CardsToTier6;
		} else if (Player.KnightTier == 6) {
			KnightNextTierCards = Player.CardsToTier7;
		} else if (Player.KnightTier == 7) {
			KnightNextTierCards = Player.CardsToTier8;
		} else if (Player.KnightTier == 8) {
			KnightNextTierCards = Player.CardsToTier9;
		} else if (Player.KnightTier == 9) {
			KnightNextTierCards = Player.CardsToTier10;
		} else if (Player.KnightTier == 10) {
			KnightNextTierCards = Player.CardsToTier11;
		} else if (Player.KnightTier == 11) {
			KnightNextTierCards = Player.CardsToTier12;
		} else if (Player.KnightTier == 12) {
			KnightNextTierCards = Player.CardsToTier13;
		} else if (Player.KnightTier == 13) {
			KnightNextTierCards = 0;
		} else {
			KnightNextTierCards = 0;
		}
	}

	public void UpgradeTierKnight () {
		if (Player.KnightCards >= KnightNextTierCards && Player.KnightTier <= 12) {
			Player.KnightCards -= KnightNextTierCards;
			Player.KnightTier += 1;
			Player.Experience += troopManager.Knight.ExperiencePerTier;
			Player.Trophys += troopManager.Knight.TrophysPerTier;
			kasernUI.UpgradeTierKnightUI ();
			CheckKnightTierCards ();
			CalculateKnightStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBomber () {
		if (Player.Elix >= Player.BomberElixCost) {
			Player.Elix -= Player.BomberElixCost;
			Player.BomberLevel += 1;
			Player.Experience += troopManager.Bomber.ExperiencePerLevel;
			Player.Trophys += troopManager.Bomber.TrophysPerLevel;
			CalculateBomberStats ();
			CalculateNewBomberCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBomberStats () {
		troopManager.Bomber.CoinsPerTime = (float) troopManager.Bomber.DefaultCoinsPerTime + (troopManager.Bomber.CoinsPerTimeAddPerLevel * Player.BomberLevel) + (troopManager.Bomber.CoinsPerTimeAddPerTier * Player.BomberTier);
		troopManager.Bomber.CoinCollectDuration = (float) troopManager.Bomber.DefaultCoinCollectDuration + (troopManager.Bomber.CoinsCollectDurationChangePerTier * Player.BomberTier);
		bomber.NewStats ();
	}

	public void CalculateNewBomberCost() {
		x = (float) Mathf.Pow(1.15f , Player.BomberLevel);
		Player.BomberElixCost = Mathf.FloorToInt((float) troopManager.Bomber.DefaultElixCost * x);
		kasernUI.UpgradeBomberUI ();
	}

	public void CheckBomberTierCards () {
		if (Player.BomberTier == 0) {
			BomberNextTierCards = Player.CardsToTier1;
		}else if (Player.BomberTier == 1) {
			BomberNextTierCards = Player.CardsToTier2;
		} else if (Player.BomberTier == 2) {
			BomberNextTierCards = Player.CardsToTier3;
		} else if (Player.BomberTier == 3) {
			BomberNextTierCards = Player.CardsToTier4;
		} else if (Player.BomberTier == 4) {
			BomberNextTierCards = Player.CardsToTier5;
		} else if (Player.BomberTier == 5) {
			BomberNextTierCards = Player.CardsToTier6;
		} else if (Player.BomberTier == 6) {
			BomberNextTierCards = Player.CardsToTier7;
		} else if (Player.BomberTier == 7) {
			BomberNextTierCards = Player.CardsToTier8;
		} else if (Player.BomberTier == 8) {
			BomberNextTierCards = Player.CardsToTier9;
		} else if (Player.BomberTier == 9) {
			BomberNextTierCards = Player.CardsToTier10;
		} else if (Player.BomberTier == 10) {
			BomberNextTierCards = Player.CardsToTier11;
		} else if (Player.BomberTier == 11) {
			BomberNextTierCards = Player.CardsToTier12;
		} else if (Player.BomberTier == 12) {
			BomberNextTierCards = Player.CardsToTier13;
		} else if (Player.BomberTier == 13) {
			BomberNextTierCards = 0;
		} else {
			BomberNextTierCards = 0;
		}
	}

	public void UpgradeTierBomber () {
		if (Player.BomberCards >= BomberNextTierCards && Player.BomberTier <= 12) {
			Player.BomberCards -= BomberNextTierCards;
			Player.BomberTier += 1;
			Player.Experience += troopManager.Bomber.ExperiencePerTier;
			Player.Trophys += troopManager.Bomber.TrophysPerTier;
			kasernUI.UpgradeTierBomberUI ();
			CheckBomberTierCards ();
			CalculateBomberStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeSkeletonArmy () {
		if (Player.Elix >= Player.SkeletonArmyElixCost) {
			Player.Elix -= Player.SkeletonArmyElixCost;
			Player.SkeletonArmyLevel += 1;
			Player.Experience += troopManager.SkeletonArmy.ExperiencePerLevel;
			Player.Trophys += troopManager.SkeletonArmy.TrophysPerLevel;
			CalculateSkeletonArmyStats ();
			CalculateNewSkeletonArmyCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateSkeletonArmyStats () {
		troopManager.SkeletonArmy.CoinsPerTime = (float) troopManager.SkeletonArmy.DefaultCoinsPerTime + (troopManager.SkeletonArmy.CoinsPerTimeAddPerLevel * Player.SkeletonArmyLevel) + (troopManager.SkeletonArmy.CoinsPerTimeAddPerTier * Player.SkeletonArmyTier);
		troopManager.SkeletonArmy.CoinCollectDuration = (float) troopManager.SkeletonArmy.DefaultCoinCollectDuration + (troopManager.SkeletonArmy.CoinsCollectDurationChangePerTier * Player.SkeletonArmyTier);
		skeletonArmy.NewStats ();
	}

	public void CalculateNewSkeletonArmyCost() {
		x = (float) Mathf.Pow(1.15f , Player.SkeletonArmyLevel);
		Player.SkeletonArmyElixCost = Mathf.FloorToInt((float) troopManager.SkeletonArmy.DefaultElixCost * x);
		kasernUI.UpgradeSkeletonArmyUI ();
	}

	public void CheckSkeletonArmyTierCards () {
		if (Player.SkeletonArmyTier == 0) {
			SkeletonArmyNextTierCards = Player.CardsToTier1;
		} else if (Player.SkeletonArmyTier == 1) {
			SkeletonArmyNextTierCards = Player.CardsToTier2;
		} else if (Player.SkeletonArmyTier == 2) {
			SkeletonArmyNextTierCards = Player.CardsToTier3;
		} else if (Player.SkeletonArmyTier == 3) {
			SkeletonArmyNextTierCards = Player.CardsToTier4;
		} else if (Player.SkeletonArmyTier == 4) {
			SkeletonArmyNextTierCards = Player.CardsToTier5;
		} else if (Player.SkeletonArmyTier == 5) {
			SkeletonArmyNextTierCards = Player.CardsToTier6;
		} else if (Player.SkeletonArmyTier == 6) {
			SkeletonArmyNextTierCards = Player.CardsToTier7;
		} else if (Player.SkeletonArmyTier == 7) {
			SkeletonArmyNextTierCards = Player.CardsToTier8;
		} else if (Player.SkeletonArmyTier == 8) {
			SkeletonArmyNextTierCards = Player.CardsToTier9;
		} else if (Player.SkeletonArmyTier == 9) {
			SkeletonArmyNextTierCards = Player.CardsToTier10;
		} else if (Player.SkeletonArmyTier == 10) {
			SkeletonArmyNextTierCards = Player.CardsToTier11;
		} else if (Player.SkeletonArmyTier == 11) {
			SkeletonArmyNextTierCards = Player.CardsToTier12;
		} else if (Player.SkeletonArmyTier == 12) {
			SkeletonArmyNextTierCards = Player.CardsToTier13;
		} else if (Player.SkeletonArmyTier == 13) {
			SkeletonArmyNextTierCards = 0;
		} else {
			SkeletonArmyNextTierCards = 0;
		}
	}

	public void UpgradeTierSkeletonArmy () {
		if (Player.SkeletonArmyCards >= SkeletonArmyNextTierCards && Player.SkeletonArmyTier <= 12) {
			Player.SkeletonArmyCards -= SkeletonArmyNextTierCards;
			Player.SkeletonArmyTier += 1;
			Player.Experience += troopManager.SkeletonArmy.ExperiencePerTier;
			Player.Trophys += troopManager.SkeletonArmy.TrophysPerTier;
			kasernUI.UpgradeTierSkeletonArmyUI ();
			CheckSkeletonArmyTierCards ();
			CalculateSkeletonArmyStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMusketeer () {
		if (Player.Elix >= Player.MusketeerElixCost) {
			Player.Elix -= Player.MusketeerElixCost;
			Player.MusketeerLevel += 1;
			Player.Experience += troopManager.Musketeer.ExperiencePerLevel;
			Player.Trophys += troopManager.Musketeer.TrophysPerLevel;
			CalculateMusketeerStats ();
			CalculateNewMusketeerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMusketeerStats () {
		troopManager.Musketeer.CoinsPerTime = (float) troopManager.Musketeer.DefaultCoinsPerTime + (troopManager.Musketeer.CoinsPerTimeAddPerLevel * Player.MusketeerLevel) + (troopManager.Musketeer.CoinsPerTimeAddPerTier * Player.MusketeerTier);
		troopManager.Musketeer.CoinCollectDuration = (float) troopManager.Musketeer.DefaultCoinCollectDuration + (troopManager.Musketeer.CoinsCollectDurationChangePerTier * Player.MusketeerTier);
		musketeer.NewStats ();
	}

	public void CalculateNewMusketeerCost() {
		x = (float) Mathf.Pow(1.15f , Player.MusketeerLevel);
		Player.MusketeerElixCost = Mathf.FloorToInt((float) troopManager.Musketeer.DefaultElixCost * x);
		kasernUI.UpgradeMusketeerUI ();
	}

	public void CheckMusketeerTierCards () {
		if (Player.MusketeerTier == 0) {
			MusketeerNextTierCards = Player.CardsToTier1;
		} else if (Player.MusketeerTier == 1) {
			MusketeerNextTierCards = Player.CardsToTier2;
		} else if (Player.MusketeerTier == 2) {
			MusketeerNextTierCards = Player.CardsToTier3;
		} else if (Player.MusketeerTier == 3) {
			MusketeerNextTierCards = Player.CardsToTier4;
		} else if (Player.MusketeerTier == 4) {
			MusketeerNextTierCards = Player.CardsToTier5;
		} else if (Player.MusketeerTier == 5) {
			MusketeerNextTierCards = Player.CardsToTier6;
		} else if (Player.MusketeerTier == 6) {
			MusketeerNextTierCards = Player.CardsToTier7;
		} else if (Player.MusketeerTier == 7) {
			MusketeerNextTierCards = Player.CardsToTier8;
		} else if (Player.MusketeerTier == 8) {
			MusketeerNextTierCards = Player.CardsToTier9;
		} else if (Player.MusketeerTier == 9) {
			MusketeerNextTierCards = Player.CardsToTier10;
		} else if (Player.MusketeerTier == 10) {
			MusketeerNextTierCards = Player.CardsToTier11;
		} else if (Player.MusketeerTier == 11) {
			MusketeerNextTierCards = Player.CardsToTier12;
		} else if (Player.MusketeerTier == 12) {
			MusketeerNextTierCards = Player.CardsToTier13;
		} else if (Player.MusketeerTier == 13) {
			MusketeerNextTierCards = 0;
		} else {
			MusketeerNextTierCards = 0;
		}
	}

	public void UpgradeTierMusketeer () {
		if (Player.MusketeerCards >= MusketeerNextTierCards && Player.MusketeerTier <= 12) {
			Player.MusketeerCards -= MusketeerNextTierCards;
			Player.MusketeerTier += 1;
			Player.Experience += troopManager.Musketeer.ExperiencePerTier;
			Player.Trophys += troopManager.Musketeer.TrophysPerTier;
			kasernUI.UpgradeTierMusketeerUI ();
			CheckMusketeerTierCards ();
			CalculateMusketeerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMiniPekka () {
		if (Player.Elix >= Player.MiniPekkaElixCost) {
			Player.Elix -= Player.MiniPekkaElixCost;
			Player.MiniPekkaLevel += 1;
			Player.Experience += troopManager.MiniPekka.ExperiencePerLevel;
			Player.Trophys += troopManager.MiniPekka.TrophysPerLevel;
			CalculateMiniPekkaStats ();
			CalculateNewMiniPekkaCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMiniPekkaStats () {
		troopManager.MiniPekka.CoinsPerTime = (float) troopManager.MiniPekka.DefaultCoinsPerTime + (troopManager.MiniPekka.CoinsPerTimeAddPerLevel * Player.MiniPekkaLevel) + (troopManager.MiniPekka.CoinsPerTimeAddPerTier * Player.MiniPekkaTier);
		troopManager.MiniPekka.CoinCollectDuration = (float) troopManager.MiniPekka.DefaultCoinCollectDuration + (troopManager.MiniPekka.CoinsCollectDurationChangePerTier * Player.MiniPekkaTier);
		miniPekka.NewStats ();
	}

	public void CalculateNewMiniPekkaCost() {
		x = (float) Mathf.Pow(1.15f , Player.MiniPekkaLevel);
		Player.MiniPekkaElixCost = Mathf.FloorToInt((float) troopManager.MiniPekka.DefaultElixCost * x);
		kasernUI.UpgradeMiniPekkaUI ();
	}

	public void CheckMiniPekkaTierCards () {
		if (Player.MiniPekkaTier == 0) {
			MiniPekkaNextTierCards = Player.CardsToTier1;
		} else if (Player.MiniPekkaTier == 1) {
			MiniPekkaNextTierCards = Player.CardsToTier2;
		} else if (Player.MiniPekkaTier == 2) {
			MiniPekkaNextTierCards = Player.CardsToTier3;
		} else if (Player.MiniPekkaTier == 3) {
			MiniPekkaNextTierCards = Player.CardsToTier4;
		} else if (Player.MiniPekkaTier == 4) {
			MiniPekkaNextTierCards = Player.CardsToTier5;
		} else if (Player.MiniPekkaTier == 5) {
			MiniPekkaNextTierCards = Player.CardsToTier6;
		} else if (Player.MiniPekkaTier == 6) {
			MiniPekkaNextTierCards = Player.CardsToTier7;
		} else if (Player.MiniPekkaTier == 7) {
			MiniPekkaNextTierCards = Player.CardsToTier8;
		} else if (Player.MiniPekkaTier == 8) {
			MiniPekkaNextTierCards = Player.CardsToTier9;
		} else if (Player.MiniPekkaTier == 9) {
			MiniPekkaNextTierCards = Player.CardsToTier10;
		} else if (Player.MiniPekkaTier == 10) {
			MiniPekkaNextTierCards = Player.CardsToTier11;
		} else if (Player.MiniPekkaTier == 11) {
			MiniPekkaNextTierCards = Player.CardsToTier12;
		} else if (Player.MiniPekkaTier == 12) {
			MiniPekkaNextTierCards = Player.CardsToTier13;
		} else if (Player.MiniPekkaTier == 13) {
			MiniPekkaNextTierCards = 0;
		} else {
			MiniPekkaNextTierCards = 0;
		}
	}

	public void UpgradeTierMiniPekka () {
		if (Player.MiniPekkaCards >= MiniPekkaNextTierCards && Player.MiniPekkaTier <= 12) {
			Player.MiniPekkaCards -= MiniPekkaNextTierCards;
			Player.MiniPekkaTier += 1;
			Player.Experience += troopManager.MiniPekka.ExperiencePerTier;
			Player.Trophys += troopManager.MiniPekka.TrophysPerTier;
			kasernUI.UpgradeTierMiniPekkaUI ();
			CheckMiniPekkaTierCards ();
			CalculateMiniPekkaStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBabyDragon () {
		if (Player.Elix >= Player.BabyDragonElixCost) {
			Player.Elix -= Player.BabyDragonElixCost;
			Player.BabyDragonLevel += 1;
			Player.Experience += troopManager.BabyDragon.ExperiencePerLevel;
			Player.Trophys += troopManager.BabyDragon.TrophysPerLevel;
			CalculateBabyDragonStats ();
			CalculateNewBabyDragonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBabyDragonStats () {
		troopManager.BabyDragon.CoinsPerTime = (float) troopManager.BabyDragon.DefaultCoinsPerTime + (troopManager.BabyDragon.CoinsPerTimeAddPerLevel * Player.BabyDragonLevel) + (troopManager.BabyDragon.CoinsPerTimeAddPerTier * Player.BabyDragonTier);
		troopManager.BabyDragon.CoinCollectDuration = (float) troopManager.BabyDragon.DefaultCoinCollectDuration + (troopManager.BabyDragon.CoinsCollectDurationChangePerTier * Player.BabyDragonTier);
		babyDragon.NewStats ();
	}

	public void CalculateNewBabyDragonCost() {
		x = (float) Mathf.Pow(1.15f , Player.BabyDragonLevel);
		Player.BabyDragonElixCost = Mathf.FloorToInt((float) troopManager.BabyDragon.DefaultElixCost * x);
		kasernUI.UpgradeBabyDragonUI ();
	}

	public void CheckBabyDragonTierCards () {
		if (Player.BabyDragonTier == 0) {
			BabyDragonNextTierCards = Player.CardsToTier1;
		} else if (Player.BabyDragonTier == 1) {
			BabyDragonNextTierCards = Player.CardsToTier2;
		} else if (Player.BabyDragonTier == 2) {
			BabyDragonNextTierCards = Player.CardsToTier3;
		} else if (Player.BabyDragonTier == 3) {
			BabyDragonNextTierCards = Player.CardsToTier4;
		} else if (Player.BabyDragonTier == 4) {
			BabyDragonNextTierCards = Player.CardsToTier5;
		} else if (Player.BabyDragonTier == 5) {
			BabyDragonNextTierCards = Player.CardsToTier6;
		} else if (Player.BabyDragonTier == 6) {
			BabyDragonNextTierCards = Player.CardsToTier7;
		} else if (Player.BabyDragonTier == 7) {
			BabyDragonNextTierCards = Player.CardsToTier8;
		} else if (Player.BabyDragonTier == 8) {
			BabyDragonNextTierCards = Player.CardsToTier9;
		} else if (Player.BabyDragonTier == 9) {
			BabyDragonNextTierCards = Player.CardsToTier10;
		} else if (Player.BabyDragonTier == 10) {
			BabyDragonNextTierCards = Player.CardsToTier11;
		} else if (Player.BabyDragonTier == 11) {
			BabyDragonNextTierCards = Player.CardsToTier12;
		} else if (Player.BabyDragonTier == 12) {
			BabyDragonNextTierCards = Player.CardsToTier13;
		} else if (Player.BabyDragonTier == 13) {
			BabyDragonNextTierCards = 0;
		} else {
			BabyDragonNextTierCards = 0;
		}
	}

	public void UpgradeTierBabyDragon () {
		if (Player.BabyDragonCards >= BabyDragonNextTierCards && Player.BabyDragonTier <= 12) {
			Player.BabyDragonCards -= BabyDragonNextTierCards;
			Player.BabyDragonTier += 1;
			Player.Experience += troopManager.BabyDragon.ExperiencePerTier;
			Player.Trophys += troopManager.BabyDragon.TrophysPerTier;
			kasernUI.UpgradeTierBabyDragonUI ();
			CheckBabyDragonTierCards ();
			CalculateBabyDragonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeGiant () {
		if (Player.Elix >= Player.GiantElixCost) {
			Player.Elix -= Player.GiantElixCost;
			Player.GiantLevel += 1;
			Player.Experience += troopManager.Giant.ExperiencePerLevel;
			Player.Trophys += troopManager.Giant.TrophysPerLevel;
			CalculateGiantStats ();
			CalculateNewGiantCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGiantStats () {
		troopManager.Giant.CoinsPerTime = (float) troopManager.Giant.DefaultCoinsPerTime + (troopManager.Giant.CoinsPerTimeAddPerLevel * Player.GiantLevel) + (troopManager.Giant.CoinsPerTimeAddPerTier * Player.GiantTier);
		troopManager.Giant.CoinCollectDuration = (float) troopManager.Giant.DefaultCoinCollectDuration + (troopManager.Giant.CoinsCollectDurationChangePerTier * Player.GiantTier);
		giant.NewStats ();
	}

	public void CalculateNewGiantCost() {
		x = (float) Mathf.Pow(1.15f , Player.GiantLevel);
		Player.GiantElixCost = Mathf.FloorToInt((float) troopManager.Giant.DefaultElixCost * x);
		kasernUI.UpgradeGiantUI ();
	}

	public void CheckGiantTierCards () {
		if (Player.GiantTier == 0) {
			GiantNextTierCards = Player.CardsToTier1;
		} else if (Player.GiantTier == 1) {
			GiantNextTierCards = Player.CardsToTier2;
		} else if (Player.GiantTier == 2) {
			GiantNextTierCards = Player.CardsToTier3;
		} else if (Player.GiantTier == 3) {
			GiantNextTierCards = Player.CardsToTier4;
		} else if (Player.GiantTier == 4) {
			GiantNextTierCards = Player.CardsToTier5;
		} else if (Player.GiantTier == 5) {
			GiantNextTierCards = Player.CardsToTier6;
		} else if (Player.GiantTier == 6) {
			GiantNextTierCards = Player.CardsToTier7;
		} else if (Player.GiantTier == 7) {
			GiantNextTierCards = Player.CardsToTier8;
		} else if (Player.GiantTier == 8) {
			GiantNextTierCards = Player.CardsToTier9;
		} else if (Player.GiantTier == 9) {
			GiantNextTierCards = Player.CardsToTier10;
		} else if (Player.GiantTier == 10) {
			GiantNextTierCards = Player.CardsToTier11;
		} else if (Player.GiantTier == 11) {
			GiantNextTierCards = Player.CardsToTier12;
		} else if (Player.GiantTier == 12) {
			GiantNextTierCards = Player.CardsToTier13;
		} else if (Player.GiantTier == 13) {
			GiantNextTierCards = 0;
		} else {
			GiantNextTierCards = 0;
		}
	}

	public void UpgradeTierGiant () {
		if (Player.GiantCards >= GiantNextTierCards && Player.GiantTier <= 12) {
			Player.GiantCards -= GiantNextTierCards;
			Player.GiantTier += 1;
			Player.Experience += troopManager.Giant.ExperiencePerTier;
			Player.Trophys += troopManager.Giant.TrophysPerTier;
			kasernUI.UpgradeTierGiantUI ();
			CheckGiantTierCards ();
			CalculateGiantStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradePrince () {
		if (Player.Elix >= Player.PrinceElixCost) {
			Player.Elix -= Player.PrinceElixCost;
			Player.PrinceLevel += 1;
			Player.Experience += troopManager.Prince.ExperiencePerLevel;
			Player.Trophys += troopManager.Prince.TrophysPerLevel;
			CalculatePrinceStats ();
			CalculateNewPrinceCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculatePrinceStats () {
		troopManager.Prince.CoinsPerTime = (float) troopManager.Prince.DefaultCoinsPerTime + (troopManager.Prince.CoinsPerTimeAddPerLevel * Player.PrinceLevel) + (troopManager.Prince.CoinsPerTimeAddPerTier * Player.PrinceTier);
		troopManager.Prince.CoinCollectDuration = (float) troopManager.Prince.DefaultCoinCollectDuration + (troopManager.Prince.CoinsCollectDurationChangePerTier * Player.PrinceTier);
		prince.NewStats ();
	}

	public void CalculateNewPrinceCost() {
		x = (float) Mathf.Pow(1.15f , Player.PrinceLevel);
		Player.PrinceElixCost = Mathf.FloorToInt((float) troopManager.Prince.DefaultElixCost * x);
		kasernUI.UpgradePrinceUI ();
	}

	public void CheckPrinceTierCards () {
		if (Player.PrinceTier == 0) {
			PrinceNextTierCards = Player.CardsToTier1;
		} else if (Player.PrinceTier == 1) {
			PrinceNextTierCards = Player.CardsToTier2;
		} else if (Player.PrinceTier == 2) {
			PrinceNextTierCards = Player.CardsToTier3;
		} else if (Player.PrinceTier == 3) {
			PrinceNextTierCards = Player.CardsToTier4;
		} else if (Player.PrinceTier == 4) {
			PrinceNextTierCards = Player.CardsToTier5;
		} else if (Player.PrinceTier == 5) {
			PrinceNextTierCards = Player.CardsToTier6;
		} else if (Player.PrinceTier == 6) {
			PrinceNextTierCards = Player.CardsToTier7;
		} else if (Player.PrinceTier == 7) {
			PrinceNextTierCards = Player.CardsToTier8;
		} else if (Player.PrinceTier == 8) {
			PrinceNextTierCards = Player.CardsToTier9;
		} else if (Player.PrinceTier == 9) {
			PrinceNextTierCards = Player.CardsToTier10;
		} else if (Player.PrinceTier == 10) {
			PrinceNextTierCards = Player.CardsToTier11;
		} else if (Player.PrinceTier == 11) {
			PrinceNextTierCards = Player.CardsToTier12;
		} else if (Player.PrinceTier == 12) {
			PrinceNextTierCards = Player.CardsToTier13;
		} else if (Player.PrinceTier == 13) {
			PrinceNextTierCards = 0;
		} else {
			PrinceNextTierCards = 0;
		}
	}

	public void UpgradeTierPrince () {
		if (Player.PrinceCards >= PrinceNextTierCards && Player.PrinceTier <= 12) {
			Player.PrinceCards -= PrinceNextTierCards;
			Player.PrinceTier += 1;
			Player.Experience += troopManager.Prince.ExperiencePerTier;
			Player.Trophys += troopManager.Prince.TrophysPerTier;
			kasernUI.UpgradeTierPrinceUI ();
			CheckPrinceTierCards ();
			CalculatePrinceStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeWitch () {
		if (Player.Elix >= Player.WitchElixCost) {
			Player.Elix -= Player.WitchElixCost;
			Player.WitchLevel += 1;
			Player.Experience += troopManager.Witch.ExperiencePerLevel;
			Player.Trophys += troopManager.Witch.TrophysPerLevel;
			CalculateWitchStats ();
			CalculateNewWitchCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateWitchStats () {
		troopManager.Witch.CoinsPerTime = (float) troopManager.Witch.DefaultCoinsPerTime + (troopManager.Witch.CoinsPerTimeAddPerLevel * Player.WitchLevel) + (troopManager.Witch.CoinsPerTimeAddPerTier * Player.WitchTier);
		troopManager.Witch.CoinCollectDuration = (float) troopManager.Witch.DefaultCoinCollectDuration + (troopManager.Witch.CoinsCollectDurationChangePerTier * Player.WitchTier);
		witch.NewStats ();
	}

	public void CalculateNewWitchCost() {
		x = (float) Mathf.Pow(1.15f , Player.WitchLevel);
		Player.WitchElixCost = Mathf.FloorToInt((float) troopManager.Witch.DefaultElixCost * x);
		kasernUI.UpgradeWitchUI ();
	}

	public void CheckWitchTierCards () {
		if (Player.WitchTier == 0) {
			WitchNextTierCards = Player.CardsToTier1;
		} else if (Player.WitchTier == 1) {
			WitchNextTierCards = Player.CardsToTier2;
		} else if (Player.WitchTier == 2) {
			WitchNextTierCards = Player.CardsToTier3;
		} else if (Player.WitchTier == 3) {
			WitchNextTierCards = Player.CardsToTier4;
		} else if (Player.WitchTier == 4) {
			WitchNextTierCards = Player.CardsToTier5;
		} else if (Player.WitchTier == 5) {
			WitchNextTierCards = Player.CardsToTier6;
		} else if (Player.WitchTier == 6) {
			WitchNextTierCards = Player.CardsToTier7;
		} else if (Player.WitchTier == 7) {
			WitchNextTierCards = Player.CardsToTier8;
		} else if (Player.WitchTier == 8) {
			WitchNextTierCards = Player.CardsToTier9;
		} else if (Player.WitchTier == 9) {
			WitchNextTierCards = Player.CardsToTier10;
		} else if (Player.WitchTier == 10) {
			WitchNextTierCards = Player.CardsToTier11;
		} else if (Player.WitchTier == 11) {
			WitchNextTierCards = Player.CardsToTier12;
		} else if (Player.WitchTier == 12) {
			WitchNextTierCards = Player.CardsToTier13;
		} else if (Player.WitchTier == 13) {
			WitchNextTierCards = 0;
		} else {
			WitchNextTierCards = 0;
		}
	}

	public void UpgradeTierWitch () {
		if (Player.WitchCards >= WitchNextTierCards && Player.WitchTier <= 12) {
			Player.WitchCards -= WitchNextTierCards;
			Player.WitchTier += 1;
			Player.Experience += troopManager.Witch.ExperiencePerTier;
			Player.Trophys += troopManager.Witch.TrophysPerTier;
			kasernUI.UpgradeTierWitchUI ();
			CheckWitchTierCards ();
			CalculateWitchStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 1

	public void UpgradeGoblins () {
		if (Player.Elix >= Player.GoblinsElixCost) {
			Player.Elix -= Player.GoblinsElixCost;
			Player.GoblinsLevel += 1;
			Player.Experience += troopManager.Goblins.ExperiencePerLevel;
			Player.Trophys += troopManager.Goblins.TrophysPerLevel;
			CalculateGoblinsStats ();
			CalculateNewGoblinsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGoblinsStats () {
		troopManager.Goblins.CoinsPerTime = (float) troopManager.Goblins.DefaultCoinsPerTime + (troopManager.Goblins.CoinsPerTimeAddPerLevel * Player.GoblinsLevel) + (troopManager.Goblins.CoinsPerTimeAddPerTier * Player.GoblinsTier);
		troopManager.Goblins.CoinCollectDuration = (float) troopManager.Goblins.DefaultCoinCollectDuration + (troopManager.Goblins.CoinsCollectDurationChangePerTier * Player.GoblinsTier);
		goblins.NewStats ();
	}

	public void CalculateNewGoblinsCost() {
		x = (float) Mathf.Pow(1.15f , Player.GoblinsLevel);
		Player.GoblinsElixCost = Mathf.FloorToInt((float) troopManager.Goblins.DefaultElixCost * x);
		kasernUI.UpgradeGoblinsUI ();
	}

	public void CheckGoblinsTierCards () {
		if (Player.GoblinsTier == 0) {
			GoblinsNextTierCards = Player.CardsToTier1;
		} else if (Player.GoblinsTier == 1) {
			GoblinsNextTierCards = Player.CardsToTier2;
		} else if (Player.GoblinsTier == 2) {
			GoblinsNextTierCards = Player.CardsToTier3;
		} else if (Player.GoblinsTier == 3) {
			GoblinsNextTierCards = Player.CardsToTier4;
		} else if (Player.GoblinsTier == 4) {
			GoblinsNextTierCards = Player.CardsToTier5;
		} else if (Player.GoblinsTier == 5) {
			GoblinsNextTierCards = Player.CardsToTier6;
		} else if (Player.GoblinsTier == 6) {
			GoblinsNextTierCards = Player.CardsToTier7;
		} else if (Player.GoblinsTier == 7) {
			GoblinsNextTierCards = Player.CardsToTier8;
		} else if (Player.GoblinsTier == 8) {
			GoblinsNextTierCards = Player.CardsToTier9;
		} else if (Player.GoblinsTier == 9) {
			GoblinsNextTierCards = Player.CardsToTier10;
		} else if (Player.GoblinsTier == 10) {
			GoblinsNextTierCards = Player.CardsToTier11;
		} else if (Player.GoblinsTier == 11) {
			GoblinsNextTierCards = Player.CardsToTier12;
		} else if (Player.GoblinsTier == 12) {
			GoblinsNextTierCards = Player.CardsToTier13;
		} else if (Player.GoblinsTier == 13) {
			GoblinsNextTierCards = 0;
		} else {
			GoblinsNextTierCards = 0;
		}
	}

	public void UpgradeTierGoblins () {
		if (Player.GoblinsCards >= GoblinsNextTierCards && Player.GoblinsTier <= 12) {
			Player.GoblinsCards -= GoblinsNextTierCards;
			Player.GoblinsTier += 1;
			Player.Experience += troopManager.Goblins.ExperiencePerTier;
			Player.Trophys += troopManager.Goblins.TrophysPerTier;
			kasernUI.UpgradeTierGoblinsUI ();
			CheckGoblinsTierCards ();
			CalculateGoblinsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeSpearGoblins () {
		if (Player.Elix >= Player.SpearGoblinsElixCost) {
			Player.Elix -= Player.SpearGoblinsElixCost;
			Player.SpearGoblinsLevel += 1;
			Player.Experience += troopManager.SpearGoblins.ExperiencePerLevel;
			Player.Trophys += troopManager.SpearGoblins.TrophysPerLevel;
			CalculateSpearGoblinsStats ();
			CalculateNewSpearGoblinsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateSpearGoblinsStats () {
		troopManager.SpearGoblins.CoinsPerTime = (float) troopManager.SpearGoblins.DefaultCoinsPerTime + (troopManager.SpearGoblins.CoinsPerTimeAddPerLevel * Player.SpearGoblinsLevel) + (troopManager.SpearGoblins.CoinsPerTimeAddPerTier * Player.SpearGoblinsTier);
		troopManager.SpearGoblins.CoinCollectDuration = (float) troopManager.SpearGoblins.DefaultCoinCollectDuration + (troopManager.SpearGoblins.CoinsCollectDurationChangePerTier * Player.SpearGoblinsTier);
		spearGoblins.NewStats ();
	}

	public void CalculateNewSpearGoblinsCost() {
		x = (float) Mathf.Pow(1.15f , Player.SpearGoblinsLevel);
		Player.SpearGoblinsElixCost = Mathf.FloorToInt((float) troopManager.SpearGoblins.DefaultElixCost * x);
		kasernUI.UpgradeSpearGoblinsUI ();
	}

	public void CheckSpearGoblinsTierCards () {
		if (Player.SpearGoblinsTier == 0) {
			SpearGoblinsNextTierCards = Player.CardsToTier1;
		} else if (Player.SpearGoblinsTier == 1) {
			SpearGoblinsNextTierCards = Player.CardsToTier2;
		} else if (Player.SpearGoblinsTier == 2) {
			SpearGoblinsNextTierCards = Player.CardsToTier3;
		} else if (Player.SpearGoblinsTier == 3) {
			SpearGoblinsNextTierCards = Player.CardsToTier4;
		} else if (Player.SpearGoblinsTier == 4) {
			SpearGoblinsNextTierCards = Player.CardsToTier5;
		} else if (Player.SpearGoblinsTier == 5) {
			SpearGoblinsNextTierCards = Player.CardsToTier6;
		} else if (Player.SpearGoblinsTier == 6) {
			SpearGoblinsNextTierCards = Player.CardsToTier7;
		} else if (Player.SpearGoblinsTier == 7) {
			SpearGoblinsNextTierCards = Player.CardsToTier8;
		} else if (Player.SpearGoblinsTier == 8) {
			SpearGoblinsNextTierCards = Player.CardsToTier9;
		} else if (Player.SpearGoblinsTier == 9) {
			SpearGoblinsNextTierCards = Player.CardsToTier10;
		} else if (Player.SpearGoblinsTier == 10) {
			SpearGoblinsNextTierCards = Player.CardsToTier11;
		} else if (Player.SpearGoblinsTier == 11) {
			SpearGoblinsNextTierCards = Player.CardsToTier12;
		} else if (Player.SpearGoblinsTier == 12) {
			SpearGoblinsNextTierCards = Player.CardsToTier13;
		} else if (Player.SpearGoblinsTier == 13) {
			SpearGoblinsNextTierCards = 0;
		} else {
			SpearGoblinsNextTierCards = 0;
		}
	}

	public void UpgradeTierSpearGoblins () {
		if (Player.SpearGoblinsCards >= SpearGoblinsNextTierCards && Player.SpearGoblinsTier <= 12) {
			Player.SpearGoblinsCards -= SpearGoblinsNextTierCards;
			Player.SpearGoblinsTier += 1;
			Player.Experience += troopManager.SpearGoblins.ExperiencePerTier;
			Player.Trophys += troopManager.SpearGoblins.TrophysPerTier;
			kasernUI.UpgradeTierSpearGoblinsUI ();
			CheckSpearGoblinsTierCards ();
			CalculateSpearGoblinsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeValkyrie () {
		if (Player.Elix >= Player.ValkyrieElixCost) {
			Player.Elix -= Player.ValkyrieElixCost;
			Player.ValkyrieLevel += 1;
			Player.Experience += troopManager.Valkyrie.ExperiencePerLevel;
			Player.Trophys += troopManager.Valkyrie.TrophysPerLevel;
			CalculateValkyrieStats ();
			CalculateNewValkyrieCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateValkyrieStats () {
		troopManager.Valkyrie.CoinsPerTime = (float) troopManager.Valkyrie.DefaultCoinsPerTime + (troopManager.Valkyrie.CoinsPerTimeAddPerLevel * Player.ValkyrieLevel) + (troopManager.Valkyrie.CoinsPerTimeAddPerTier * Player.ValkyrieTier);
		troopManager.Valkyrie.CoinCollectDuration = (float) troopManager.Valkyrie.DefaultCoinCollectDuration + (troopManager.Valkyrie.CoinsCollectDurationChangePerTier * Player.ValkyrieTier);
		valkyrie.NewStats ();
	}

	public void CalculateNewValkyrieCost() {
		x = (float) Mathf.Pow(1.15f , Player.ValkyrieLevel);
		Player.ValkyrieElixCost = Mathf.FloorToInt((float) troopManager.Valkyrie.DefaultElixCost * x);
		kasernUI.UpgradeValkyrieUI ();
	}

	public void CheckValkyrieTierCards () {
		if (Player.ValkyrieTier == 0) {
			ValkyrieNextTierCards = Player.CardsToTier1;
		} else if (Player.ValkyrieTier == 1) {
			ValkyrieNextTierCards = Player.CardsToTier2;
		} else if (Player.ValkyrieTier == 2) {
			ValkyrieNextTierCards = Player.CardsToTier3;
		} else if (Player.ValkyrieTier == 3) {
			ValkyrieNextTierCards = Player.CardsToTier4;
		} else if (Player.ValkyrieTier == 4) {
			ValkyrieNextTierCards = Player.CardsToTier5;
		} else if (Player.ValkyrieTier == 5) {
			ValkyrieNextTierCards = Player.CardsToTier6;
		} else if (Player.ValkyrieTier == 6) {
			ValkyrieNextTierCards = Player.CardsToTier7;
		} else if (Player.ValkyrieTier == 7) {
			ValkyrieNextTierCards = Player.CardsToTier8;
		} else if (Player.ValkyrieTier == 8) {
			ValkyrieNextTierCards = Player.CardsToTier9;
		} else if (Player.ValkyrieTier == 9) {
			ValkyrieNextTierCards = Player.CardsToTier10;
		} else if (Player.ValkyrieTier == 10) {
			ValkyrieNextTierCards = Player.CardsToTier11;
		} else if (Player.ValkyrieTier == 11) {
			ValkyrieNextTierCards = Player.CardsToTier12;
		} else if (Player.ValkyrieTier == 12) {
			ValkyrieNextTierCards = Player.CardsToTier13;
		} else if (Player.ValkyrieTier == 13) {
			ValkyrieNextTierCards = 0;
		} else {
			ValkyrieNextTierCards = 0;
		}
	}

	public void UpgradeTierValkyrie () {
		if (Player.ValkyrieCards >= ValkyrieNextTierCards && Player.ValkyrieTier <= 12) {
			Player.ValkyrieCards -= ValkyrieNextTierCards;
			Player.ValkyrieTier += 1;
			Player.Experience += troopManager.Valkyrie.ExperiencePerTier;
			Player.Trophys += troopManager.Valkyrie.TrophysPerTier;
			kasernUI.UpgradeTierValkyrieUI ();
			CheckValkyrieTierCards ();
			CalculateValkyrieStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 2

	public void UpgradeMinions () {
		if (Player.Elix >= Player.MinionsElixCost) {
			Player.Elix -= Player.MinionsElixCost;
			Player.MinionsLevel += 1;
			Player.Experience += troopManager.Minions.ExperiencePerLevel;
			Player.Trophys += troopManager.Minions.TrophysPerLevel;
			CalculateMinionsStats ();
			CalculateNewMinionsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMinionsStats () {
		troopManager.Minions.CoinsPerTime = (float) troopManager.Minions.DefaultCoinsPerTime + (troopManager.Minions.CoinsPerTimeAddPerLevel * Player.MinionsLevel) + (troopManager.Minions.CoinsPerTimeAddPerTier * Player.MinionsTier);
		troopManager.Minions.CoinCollectDuration = (float) troopManager.Minions.DefaultCoinCollectDuration + (troopManager.Minions.CoinsCollectDurationChangePerTier * Player.MinionsTier);
		minions.NewStats ();
	}

	public void CalculateNewMinionsCost() {
		x = (float) Mathf.Pow(1.15f , Player.MinionsLevel);
		Player.MinionsElixCost = Mathf.FloorToInt((float) troopManager.Minions.DefaultElixCost * x);
		kasernUI.UpgradeMinionsUI ();
	}

	public void CheckMinionsTierCards () {
		if (Player.MinionsTier == 0) {
			MinionsNextTierCards = Player.CardsToTier1;
		} else if (Player.MinionsTier == 1) {
			MinionsNextTierCards = Player.CardsToTier2;
		} else if (Player.MinionsTier == 2) {
			MinionsNextTierCards = Player.CardsToTier3;
		} else if (Player.MinionsTier == 3) {
			MinionsNextTierCards = Player.CardsToTier4;
		} else if (Player.MinionsTier == 4) {
			MinionsNextTierCards = Player.CardsToTier5;
		} else if (Player.MinionsTier == 5) {
			MinionsNextTierCards = Player.CardsToTier6;
		} else if (Player.MinionsTier == 6) {
			MinionsNextTierCards = Player.CardsToTier7;
		} else if (Player.MinionsTier == 7) {
			MinionsNextTierCards = Player.CardsToTier8;
		} else if (Player.MinionsTier == 8) {
			MinionsNextTierCards = Player.CardsToTier9;
		} else if (Player.MinionsTier == 9) {
			MinionsNextTierCards = Player.CardsToTier10;
		} else if (Player.MinionsTier == 10) {
			MinionsNextTierCards = Player.CardsToTier11;
		} else if (Player.MinionsTier == 11) {
			MinionsNextTierCards = Player.CardsToTier12;
		} else if (Player.MinionsTier == 12) {
			MinionsNextTierCards = Player.CardsToTier13;
		} else if (Player.MinionsTier == 13) {
			MinionsNextTierCards = 0;
		} else {
			MinionsNextTierCards = 0;
		}
	}

	public void UpgradeTierMinions () {
		if (Player.MinionsCards >= MinionsNextTierCards && Player.MinionsTier <= 12) {
			Player.MinionsCards -= MinionsNextTierCards;
			Player.MinionsTier += 1;
			Player.Experience += troopManager.Minions.ExperiencePerTier;
			Player.Trophys += troopManager.Minions.TrophysPerTier;
			kasernUI.UpgradeTierMinionsUI ();
			CheckMinionsTierCards ();
			CalculateMinionsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBallon () {
		if (Player.Elix >= Player.BallonElixCost) {
			Player.Elix -= Player.BallonElixCost;
			Player.BallonLevel += 1;
			Player.Experience += troopManager.Ballon.ExperiencePerLevel;
			Player.Trophys += troopManager.Ballon.TrophysPerLevel;
			CalculateBallonStats ();
			CalculateNewBallonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBallonStats () {
		troopManager.Ballon.CoinsPerTime = (float) troopManager.Ballon.DefaultCoinsPerTime + (troopManager.Ballon.CoinsPerTimeAddPerLevel * Player.BallonLevel) + (troopManager.Ballon.CoinsPerTimeAddPerTier * Player.BallonTier);
		troopManager.Ballon.CoinCollectDuration = (float) troopManager.Ballon.DefaultCoinCollectDuration + (troopManager.Ballon.CoinsCollectDurationChangePerTier * Player.BallonTier);
		ballon.NewStats ();
	}

	public void CalculateNewBallonCost() {
		x = (float) Mathf.Pow(1.15f , Player.BallonLevel);
		Player.BallonElixCost = Mathf.FloorToInt((float) troopManager.Ballon.DefaultElixCost * x);
		kasernUI.UpgradeBallonUI ();
	}

	public void CheckBallonTierCards () {
		if (Player.BallonTier == 0) {
			BallonNextTierCards = Player.CardsToTier1;
		} else if (Player.BallonTier == 1) {
			BallonNextTierCards = Player.CardsToTier2;
		} else if (Player.BallonTier == 2) {
			BallonNextTierCards = Player.CardsToTier3;
		} else if (Player.BallonTier == 3) {
			BallonNextTierCards = Player.CardsToTier4;
		} else if (Player.BallonTier == 4) {
			BallonNextTierCards = Player.CardsToTier5;
		} else if (Player.BallonTier == 5) {
			BallonNextTierCards = Player.CardsToTier6;
		} else if (Player.BallonTier == 6) {
			BallonNextTierCards = Player.CardsToTier7;
		} else if (Player.BallonTier == 7) {
			BallonNextTierCards = Player.CardsToTier8;
		} else if (Player.BallonTier == 8) {
			BallonNextTierCards = Player.CardsToTier9;
		} else if (Player.BallonTier == 9) {
			BallonNextTierCards = Player.CardsToTier10;
		} else if (Player.BallonTier == 10) {
			BallonNextTierCards = Player.CardsToTier11;
		} else if (Player.BallonTier == 11) {
			BallonNextTierCards = Player.CardsToTier12;
		} else if (Player.BallonTier == 12) {
			BallonNextTierCards = Player.CardsToTier13;
		} else if (Player.BallonTier == 13) {
			BallonNextTierCards = 0;
		} else {
			BallonNextTierCards = 0;
		}
	}

	public void UpgradeTierBallon () {
		if (Player.BallonCards >= BallonNextTierCards && Player.BallonTier <= 12) {
			Player.BallonCards -= BallonNextTierCards;
			Player.BallonTier += 1;
			Player.Experience += troopManager.Ballon.ExperiencePerTier;
			Player.Trophys += troopManager.Ballon.TrophysPerTier;
			kasernUI.UpgradeTierBallonUI ();
			CheckBallonTierCards ();
			CalculateBallonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeGiantSkeleton () {
		if (Player.Elix >= Player.GiantSkeletonElixCost) {
			Player.Elix -= Player.GiantSkeletonElixCost;
			Player.GiantSkeletonLevel += 1;
			Player.Experience += troopManager.GiantSkeleton.ExperiencePerLevel;
			Player.Trophys += troopManager.GiantSkeleton.TrophysPerLevel;
			CalculateGiantSkeletonStats ();
			CalculateNewGiantSkeletonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGiantSkeletonStats () {
		troopManager.GiantSkeleton.CoinsPerTime = (float) troopManager.GiantSkeleton.DefaultCoinsPerTime + (troopManager.GiantSkeleton.CoinsPerTimeAddPerLevel * Player.GiantSkeletonLevel) + (troopManager.GiantSkeleton.CoinsPerTimeAddPerTier * Player.GiantSkeletonTier);
		troopManager.GiantSkeleton.CoinCollectDuration = (float) troopManager.GiantSkeleton.DefaultCoinCollectDuration + (troopManager.GiantSkeleton.CoinsCollectDurationChangePerTier * Player.GiantSkeletonTier);
		giantSkeleton.NewStats ();
	}

	public void CalculateNewGiantSkeletonCost() {
		x = (float) Mathf.Pow(1.15f , Player.GiantSkeletonLevel);
		Player.GiantSkeletonElixCost = Mathf.FloorToInt((float) troopManager.GiantSkeleton.DefaultElixCost * x);
		kasernUI.UpgradeGiantSkeletonUI ();
	}

	public void CheckGiantSkeletonTierCards () {
		if (Player.GiantSkeletonTier == 0) {
			GiantSkeletonNextTierCards = Player.CardsToTier1;
		} else if (Player.GiantSkeletonTier == 1) {
			GiantSkeletonNextTierCards = Player.CardsToTier2;
		} else if (Player.GiantSkeletonTier == 2) {
			GiantSkeletonNextTierCards = Player.CardsToTier3;
		} else if (Player.GiantSkeletonTier == 3) {
			GiantSkeletonNextTierCards = Player.CardsToTier4;
		} else if (Player.GiantSkeletonTier == 4) {
			GiantSkeletonNextTierCards = Player.CardsToTier5;
		} else if (Player.GiantSkeletonTier == 5) {
			GiantSkeletonNextTierCards = Player.CardsToTier6;
		} else if (Player.GiantSkeletonTier == 6) {
			GiantSkeletonNextTierCards = Player.CardsToTier7;
		} else if (Player.GiantSkeletonTier == 7) {
			GiantSkeletonNextTierCards = Player.CardsToTier8;
		} else if (Player.GiantSkeletonTier == 8) {
			GiantSkeletonNextTierCards = Player.CardsToTier9;
		} else if (Player.GiantSkeletonTier == 9) {
			GiantSkeletonNextTierCards = Player.CardsToTier10;
		} else if (Player.GiantSkeletonTier == 10) {
			GiantSkeletonNextTierCards = Player.CardsToTier11;
		} else if (Player.GiantSkeletonTier == 11) {
			GiantSkeletonNextTierCards = Player.CardsToTier12;
		} else if (Player.GiantSkeletonTier == 12) {
			GiantSkeletonNextTierCards = Player.CardsToTier13;
		} else if (Player.GiantSkeletonTier == 13) {
			GiantSkeletonNextTierCards = 0;
		} else {
			GiantSkeletonNextTierCards = 0;
		}
	}

	public void UpgradeTierGiantSkeleton () {
		if (Player.GiantSkeletonCards >= GiantSkeletonNextTierCards && Player.GiantSkeletonTier <= 12) {
			Player.GiantSkeletonCards -= GiantSkeletonNextTierCards;
			Player.GiantSkeletonTier += 1;
			Player.Experience += troopManager.GiantSkeleton.ExperiencePerTier;
			Player.Trophys += troopManager.GiantSkeleton.TrophysPerTier;
			kasernUI.UpgradeTierGiantSkeletonUI ();
			CheckGiantSkeletonTierCards ();
			CalculateGiantSkeletonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 3

	public void UpgradeBabarians () {
		if (Player.Elix >= Player.BabariansElixCost) {
			Player.Elix -= Player.BabariansElixCost;
			Player.BabariansLevel += 1;
			Player.Experience += troopManager.Babarians.ExperiencePerLevel;
			Player.Trophys += troopManager.Babarians.TrophysPerLevel;
			CalculateBabariansStats ();
			CalculateNewBabariansCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBabariansStats () {
		troopManager.Babarians.CoinsPerTime = (float) troopManager.Babarians.DefaultCoinsPerTime + (troopManager.Babarians.CoinsPerTimeAddPerLevel * Player.BabariansLevel) + (troopManager.Babarians.CoinsPerTimeAddPerTier * Player.BabariansTier);
		troopManager.Babarians.CoinCollectDuration = (float) troopManager.Babarians.DefaultCoinCollectDuration + (troopManager.Babarians.CoinsCollectDurationChangePerTier * Player.BabariansTier);
		barbarians.NewStats ();
	}

	public void CalculateNewBabariansCost() {
		x = (float) Mathf.Pow(1.15f , Player.BabariansLevel);
		Player.BabariansElixCost = Mathf.FloorToInt((float) troopManager.Babarians.DefaultElixCost * x);
		kasernUI.UpgradeBabariansUI ();
	}

	public void CheckBabariansTierCards () {
		if (Player.BabariansTier == 0) {
			BabariansNextTierCards = Player.CardsToTier1;
		} else if (Player.BabariansTier == 1) {
			BabariansNextTierCards = Player.CardsToTier2;
		} else if (Player.BabariansTier == 2) {
			BabariansNextTierCards = Player.CardsToTier3;
		} else if (Player.BabariansTier == 3) {
			BabariansNextTierCards = Player.CardsToTier4;
		} else if (Player.BabariansTier == 4) {
			BabariansNextTierCards = Player.CardsToTier5;
		} else if (Player.BabariansTier == 5) {
			BabariansNextTierCards = Player.CardsToTier6;
		} else if (Player.BabariansTier == 6) {
			BabariansNextTierCards = Player.CardsToTier7;
		} else if (Player.BabariansTier == 7) {
			BabariansNextTierCards = Player.CardsToTier8;
		} else if (Player.BabariansTier == 8) {
			BabariansNextTierCards = Player.CardsToTier9;
		} else if (Player.BabariansTier == 9) {
			BabariansNextTierCards = Player.CardsToTier10;
		} else if (Player.BabariansTier == 10) {
			BabariansNextTierCards = Player.CardsToTier11;
		} else if (Player.BabariansTier == 11) {
			BabariansNextTierCards = Player.CardsToTier12;
		} else if (Player.BabariansTier == 12) {
			BabariansNextTierCards = Player.CardsToTier13;
		} else if (Player.BabariansTier == 13) {
			BabariansNextTierCards = 0;
		} else {
			BabariansNextTierCards = 0;
		}
	}

	public void UpgradeTierBabarians () {
		if (Player.BabariansCards >= BabariansNextTierCards && Player.BabariansTier <= 12) {
			Player.BabariansCards -= BabariansNextTierCards;
			Player.BabariansTier += 1;
			Player.Experience += troopManager.Babarians.ExperiencePerTier;
			Player.Trophys += troopManager.Babarians.TrophysPerTier;
			kasernUI.UpgradeTierBabariansUI ();
			CheckBabariansTierCards ();
			CalculateBabariansStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 4

	public void UpgradeHogRaider () {
		if (Player.Elix >= Player.HogRaiderElixCost) {
			Player.Elix -= Player.HogRaiderElixCost;
			Player.HogRaiderLevel += 1;
			Player.Experience += troopManager.HogRaider.ExperiencePerLevel;
			Player.Trophys += troopManager.HogRaider.TrophysPerLevel;
			CalculateHogRaiderStats ();
			CalculateNewHogRaiderCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateHogRaiderStats () {
		troopManager.HogRaider.CoinsPerTime = (float) troopManager.HogRaider.DefaultCoinsPerTime + (troopManager.HogRaider.CoinsPerTimeAddPerLevel * Player.HogRaiderLevel) + (troopManager.HogRaider.CoinsPerTimeAddPerTier * Player.HogRaiderTier);
		troopManager.HogRaider.CoinCollectDuration = (float) troopManager.HogRaider.DefaultCoinCollectDuration + (troopManager.HogRaider.CoinsCollectDurationChangePerTier * Player.HogRaiderTier);
		hogRaider.NewStats ();
	}

	public void CalculateNewHogRaiderCost() {
		x = (float) Mathf.Pow(1.15f , Player.HogRaiderLevel);
		Player.HogRaiderElixCost = Mathf.FloorToInt((float) troopManager.HogRaider.DefaultElixCost * x);
		kasernUI.UpgradeHogRaiderUI ();
	}

	public void CheckHogRaiderTierCards () {
		if (Player.HogRaiderTier == 0) {
			HogRaiderNextTierCards = Player.CardsToTier1;
		} else if (Player.HogRaiderTier == 1) {
			HogRaiderNextTierCards = Player.CardsToTier2;
		} else if (Player.HogRaiderTier == 2) {
			HogRaiderNextTierCards = Player.CardsToTier3;
		} else if (Player.HogRaiderTier == 3) {
			HogRaiderNextTierCards = Player.CardsToTier4;
		} else if (Player.HogRaiderTier == 4) {
			HogRaiderNextTierCards = Player.CardsToTier5;
		} else if (Player.HogRaiderTier == 5) {
			HogRaiderNextTierCards = Player.CardsToTier6;
		} else if (Player.HogRaiderTier == 6) {
			HogRaiderNextTierCards = Player.CardsToTier7;
		} else if (Player.HogRaiderTier == 7) {
			HogRaiderNextTierCards = Player.CardsToTier8;
		} else if (Player.HogRaiderTier == 8) {
			HogRaiderNextTierCards = Player.CardsToTier9;
		} else if (Player.HogRaiderTier == 9) {
			HogRaiderNextTierCards = Player.CardsToTier10;
		} else if (Player.HogRaiderTier == 10) {
			HogRaiderNextTierCards = Player.CardsToTier11;
		} else if (Player.HogRaiderTier == 11) {
			HogRaiderNextTierCards = Player.CardsToTier12;
		} else if (Player.HogRaiderTier == 12) {
			HogRaiderNextTierCards = Player.CardsToTier13;
		} else if (Player.HogRaiderTier == 13) {
			HogRaiderNextTierCards = 0;
		} else {
			HogRaiderNextTierCards = 0;
		}
	}

	public void UpgradeTierHogRaider () {
		if (Player.HogRaiderCards >= HogRaiderNextTierCards && Player.HogRaiderTier <= 12) {
			Player.HogRaiderCards -= HogRaiderNextTierCards;
			Player.HogRaiderTier += 1;
			Player.Experience += troopManager.HogRaider.ExperiencePerTier;
			Player.Trophys += troopManager.HogRaider.TrophysPerTier;
			kasernUI.UpgradeTierHogRaiderUI ();
			CheckHogRaiderTierCards ();
			CalculateHogRaiderStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeInfernoDragon () {
		if (Player.Elix >= Player.InfernoDragonElixCost) {
			Player.Elix -= Player.InfernoDragonElixCost;
			Player.InfernoDragonLevel += 1;
			Player.Experience += troopManager.InfernoDragon.ExperiencePerLevel;
			Player.Trophys += troopManager.InfernoDragon.TrophysPerLevel;
			CalculateInfernoDragonStats ();
			CalculateNewInfernoDragonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateInfernoDragonStats () {
		troopManager.InfernoDragon.CoinsPerTime = (float) troopManager.InfernoDragon.DefaultCoinsPerTime + (troopManager.InfernoDragon.CoinsPerTimeAddPerLevel * Player.InfernoDragonLevel) + (troopManager.InfernoDragon.CoinsPerTimeAddPerTier * Player.InfernoDragonTier);
		troopManager.InfernoDragon.CoinCollectDuration = (float) troopManager.InfernoDragon.DefaultCoinCollectDuration + (troopManager.InfernoDragon.CoinsCollectDurationChangePerTier * Player.InfernoDragonTier);
		infernoDragon.NewStats ();
	}

	public void CalculateNewInfernoDragonCost() {
		x = (float) Mathf.Pow(1.15f , Player.InfernoDragonLevel);
		Player.InfernoDragonElixCost = Mathf.FloorToInt((float) troopManager.InfernoDragon.DefaultElixCost * x);
		kasernUI.UpgradeInfernoDragonUI ();
	}

	public void CheckInfernoDragonTierCards () {
		if (Player.InfernoDragonTier == 0) {
			InfernoDragonNextTierCards = Player.CardsToTier1;
		} else if (Player.InfernoDragonTier == 1) {
			InfernoDragonNextTierCards = Player.CardsToTier2;
		} else if (Player.InfernoDragonTier == 2) {
			InfernoDragonNextTierCards = Player.CardsToTier3;
		} else if (Player.InfernoDragonTier == 3) {
			InfernoDragonNextTierCards = Player.CardsToTier4;
		} else if (Player.InfernoDragonTier == 4) {
			InfernoDragonNextTierCards = Player.CardsToTier5;
		} else if (Player.InfernoDragonTier == 5) {
			InfernoDragonNextTierCards = Player.CardsToTier6;
		} else if (Player.InfernoDragonTier == 6) {
			InfernoDragonNextTierCards = Player.CardsToTier7;
		} else if (Player.InfernoDragonTier == 7) {
			InfernoDragonNextTierCards = Player.CardsToTier8;
		} else if (Player.InfernoDragonTier == 8) {
			InfernoDragonNextTierCards = Player.CardsToTier9;
		} else if (Player.InfernoDragonTier == 9) {
			InfernoDragonNextTierCards = Player.CardsToTier10;
		} else if (Player.InfernoDragonTier == 10) {
			InfernoDragonNextTierCards = Player.CardsToTier11;
		} else if (Player.InfernoDragonTier == 11) {
			InfernoDragonNextTierCards = Player.CardsToTier12;
		} else if (Player.InfernoDragonTier == 12) {
			InfernoDragonNextTierCards = Player.CardsToTier13;
		} else if (Player.InfernoDragonTier == 13) {
			InfernoDragonNextTierCards = 0;
		} else {
			InfernoDragonNextTierCards = 0;
		}
	}

	public void UpgradeTierInfernoDragon () {
		if (Player.InfernoDragonCards >= InfernoDragonNextTierCards && Player.InfernoDragonTier <= 12) {
			Player.InfernoDragonCards -= InfernoDragonNextTierCards;
			Player.InfernoDragonTier += 1;
			Player.Experience += troopManager.InfernoDragon.ExperiencePerTier;
			Player.Trophys += troopManager.InfernoDragon.TrophysPerTier;
			kasernUI.UpgradeTierInfernoDragonUI ();
			CheckInfernoDragonTierCards ();
			CalculateInfernoDragonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMinionHorde () {
		if (Player.Elix >= Player.MinionHordeElixCost) {
			Player.Elix -= Player.MinionHordeElixCost;
			Player.MinionHordeLevel += 1;
			Player.Experience += troopManager.MinionHorde.ExperiencePerLevel;
			Player.Trophys += troopManager.MinionHorde.TrophysPerLevel;
			CalculateMinionHordeStats ();
			CalculateNewMinionHordeCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMinionHordeStats () {
		troopManager.MinionHorde.CoinsPerTime = (float) troopManager.MinionHorde.DefaultCoinsPerTime + (troopManager.MinionHorde.CoinsPerTimeAddPerLevel * Player.MinionHordeLevel) + (troopManager.MinionHorde.CoinsPerTimeAddPerTier * Player.MinionHordeTier);
		troopManager.MinionHorde.CoinCollectDuration = (float) troopManager.MinionHorde.DefaultCoinCollectDuration + (troopManager.MinionHorde.CoinsCollectDurationChangePerTier * Player.MinionHordeTier);
		minionHorde.NewStats ();
	}

	public void CalculateNewMinionHordeCost() {
		x = (float) Mathf.Pow(1.15f , Player.MinionHordeLevel);
		Player.MinionHordeElixCost = Mathf.FloorToInt((float) troopManager.MinionHorde.DefaultElixCost * x);
		kasernUI.UpgradeMinionHordeUI ();
	}

	public void CheckMinionHordeTierCards () {
		if (Player.MinionHordeTier == 0) {
			MinionHordeNextTierCards = Player.CardsToTier1;
		} else if (Player.MinionHordeTier == 1) {
			MinionHordeNextTierCards = Player.CardsToTier2;
		} else if (Player.MinionHordeTier == 2) {
			MinionHordeNextTierCards = Player.CardsToTier3;
		} else if (Player.MinionHordeTier == 3) {
			MinionHordeNextTierCards = Player.CardsToTier4;
		} else if (Player.MinionHordeTier == 4) {
			MinionHordeNextTierCards = Player.CardsToTier5;
		} else if (Player.MinionHordeTier == 5) {
			MinionHordeNextTierCards = Player.CardsToTier6;
		} else if (Player.MinionHordeTier == 6) {
			MinionHordeNextTierCards = Player.CardsToTier7;
		} else if (Player.MinionHordeTier == 7) {
			MinionHordeNextTierCards = Player.CardsToTier8;
		} else if (Player.MinionHordeTier == 8) {
			MinionHordeNextTierCards = Player.CardsToTier9;
		} else if (Player.MinionHordeTier == 9) {
			MinionHordeNextTierCards = Player.CardsToTier10;
		} else if (Player.MinionHordeTier == 10) {
			MinionHordeNextTierCards = Player.CardsToTier11;
		} else if (Player.MinionHordeTier == 11) {
			MinionHordeNextTierCards = Player.CardsToTier12;
		} else if (Player.MinionHordeTier == 12) {
			MinionHordeNextTierCards = Player.CardsToTier13;
		} else if (Player.MinionHordeTier == 13) {
			MinionHordeNextTierCards = 0;
		} else {
			MinionHordeNextTierCards = 0;
		}
	}

	public void UpgradeTierMinionHorde () {
		if (Player.MinionHordeCards >= MinionHordeNextTierCards && Player.MinionHordeTier <= 12) {
			Player.MinionHordeCards -= MinionHordeNextTierCards;
			Player.MinionHordeTier += 1;
			Player.Experience += troopManager.MinionHorde.ExperiencePerTier;
			Player.Trophys += troopManager.MinionHorde.TrophysPerTier;
			kasernUI.UpgradeTierMinionHordeUI ();
			CheckMinionHordeTierCards ();
			CalculateMinionHordeStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradePekka () {
		if (Player.Elix >= Player.PekkaElixCost) {
			Player.Elix -= Player.PekkaElixCost;
			Player.PekkaLevel += 1;
			Player.Experience += troopManager.Pekka.ExperiencePerLevel;
			Player.Trophys += troopManager.Pekka.TrophysPerLevel;
			CalculatePekkaStats ();
			CalculateNewPekkaCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculatePekkaStats () {
		troopManager.Pekka.CoinsPerTime = (float) troopManager.Pekka.DefaultCoinsPerTime + (troopManager.Pekka.CoinsPerTimeAddPerLevel * Player.PekkaLevel) + (troopManager.Pekka.CoinsPerTimeAddPerTier * Player.PekkaTier);
		troopManager.Pekka.CoinCollectDuration = (float) troopManager.Pekka.DefaultCoinCollectDuration + (troopManager.Pekka.CoinsCollectDurationChangePerTier * Player.PekkaTier);
		pekka.NewStats ();
	}

	public void CalculateNewPekkaCost() {
		x = (float) Mathf.Pow(1.15f , Player.PekkaLevel);
		Player.PekkaElixCost = Mathf.FloorToInt((float) troopManager.Pekka.DefaultElixCost * x);
		kasernUI.UpgradePekkaUI ();
	}

	public void CheckPekkaTierCards () {
		if (Player.PekkaTier == 0) {
			PekkaNextTierCards = Player.CardsToTier1;
		} else if (Player.PekkaTier == 1) {
			PekkaNextTierCards = Player.CardsToTier2;
		} else if (Player.PekkaTier == 2) {
			PekkaNextTierCards = Player.CardsToTier3;
		} else if (Player.PekkaTier == 3) {
			PekkaNextTierCards = Player.CardsToTier4;
		} else if (Player.PekkaTier == 4) {
			PekkaNextTierCards = Player.CardsToTier5;
		} else if (Player.PekkaTier == 5) {
			PekkaNextTierCards = Player.CardsToTier6;
		} else if (Player.PekkaTier == 6) {
			PekkaNextTierCards = Player.CardsToTier7;
		} else if (Player.PekkaTier == 7) {
			PekkaNextTierCards = Player.CardsToTier8;
		} else if (Player.PekkaTier == 8) {
			PekkaNextTierCards = Player.CardsToTier9;
		} else if (Player.PekkaTier == 9) {
			PekkaNextTierCards = Player.CardsToTier10;
		} else if (Player.PekkaTier == 10) {
			PekkaNextTierCards = Player.CardsToTier11;
		} else if (Player.PekkaTier == 11) {
			PekkaNextTierCards = Player.CardsToTier12;
		} else if (Player.PekkaTier == 12) {
			PekkaNextTierCards = Player.CardsToTier13;
		} else if (Player.PekkaTier == 13) {
			PekkaNextTierCards = 0;
		} else {
			PekkaNextTierCards = 0;
		}
	}

	public void UpgradeTierPekka () {
		if (Player.PekkaCards >= PekkaNextTierCards && Player.PekkaTier <= 12) {
			Player.PekkaCards -= PekkaNextTierCards;
			Player.PekkaTier += 1;
			Player.Experience += troopManager.Pekka.ExperiencePerTier;
			Player.Trophys += troopManager.Pekka.TrophysPerTier;
			kasernUI.UpgradeTierPekkaUI ();
			CheckPekkaTierCards ();
			CalculatePekkaStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeLavaHound () {
		if (Player.Elix >= Player.LavaHoundElixCost) {
			Player.Elix -= Player.LavaHoundElixCost;
			Player.LavaHoundLevel += 1;
			Player.Experience += troopManager.LavaHound.ExperiencePerLevel;
			Player.Trophys += troopManager.LavaHound.TrophysPerLevel;
			CalculateLavaHoundStats ();
			CalculateNewLavaHoundCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateLavaHoundStats () {
		troopManager.LavaHound.CoinsPerTime = (float) troopManager.LavaHound.DefaultCoinsPerTime + (troopManager.LavaHound.CoinsPerTimeAddPerLevel * Player.LavaHoundLevel) + (troopManager.LavaHound.CoinsPerTimeAddPerTier * Player.LavaHoundTier);
		troopManager.LavaHound.CoinCollectDuration = (float) troopManager.LavaHound.DefaultCoinCollectDuration + (troopManager.LavaHound.CoinsCollectDurationChangePerTier * Player.LavaHoundTier);
		lavaHound.NewStats ();
	}

	public void CalculateNewLavaHoundCost() {
		x = (float) Mathf.Pow(1.15f , Player.LavaHoundLevel);
		Player.LavaHoundElixCost = Mathf.FloorToInt((float) troopManager.LavaHound.DefaultElixCost * x);
		kasernUI.UpgradeLavaHoundUI ();
	}

	public void CheckLavaHoundTierCards () {
		if (Player.LavaHoundTier == 0) {
			LavaHoundNextTierCards = Player.CardsToTier1;
		} else if (Player.LavaHoundTier == 1) {
			LavaHoundNextTierCards = Player.CardsToTier2;
		} else if (Player.LavaHoundTier == 2) {
			LavaHoundNextTierCards = Player.CardsToTier3;
		} else if (Player.LavaHoundTier == 3) {
			LavaHoundNextTierCards = Player.CardsToTier4;
		} else if (Player.LavaHoundTier == 4) {
			LavaHoundNextTierCards = Player.CardsToTier5;
		} else if (Player.LavaHoundTier == 5) {
			LavaHoundNextTierCards = Player.CardsToTier6;
		} else if (Player.LavaHoundTier == 6) {
			LavaHoundNextTierCards = Player.CardsToTier7;
		} else if (Player.LavaHoundTier == 7) {
			LavaHoundNextTierCards = Player.CardsToTier8;
		} else if (Player.LavaHoundTier == 8) {
			LavaHoundNextTierCards = Player.CardsToTier9;
		} else if (Player.LavaHoundTier == 9) {
			LavaHoundNextTierCards = Player.CardsToTier10;
		} else if (Player.LavaHoundTier == 10) {
			LavaHoundNextTierCards = Player.CardsToTier11;
		} else if (Player.LavaHoundTier == 11) {
			LavaHoundNextTierCards = Player.CardsToTier12;
		} else if (Player.LavaHoundTier == 12) {
			LavaHoundNextTierCards = Player.CardsToTier13;
		} else if (Player.LavaHoundTier == 13) {
			LavaHoundNextTierCards = 0;
		} else {
			LavaHoundNextTierCards = 0;
		}
	}

	public void UpgradeTierLavaHound () {
		if (Player.LavaHoundCards >= LavaHoundNextTierCards && Player.LavaHoundTier <= 12) {
			Player.LavaHoundCards -= LavaHoundNextTierCards;
			Player.LavaHoundTier += 1;
			Player.Experience += troopManager.LavaHound.ExperiencePerTier;
			Player.Trophys += troopManager.LavaHound.TrophysPerTier;
			kasernUI.UpgradeTierLavaHoundUI ();
			CheckLavaHoundTierCards ();
			CalculateLavaHoundStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 5

	public void UpgradeFireSpirits () {
		if (Player.Elix >= Player.FireSpiritsElixCost) {
			Player.Elix -= Player.FireSpiritsElixCost;
			Player.FireSpiritsLevel += 1;
			Player.Experience += troopManager.FireSpirits.ExperiencePerLevel;
			Player.Trophys += troopManager.FireSpirits.TrophysPerLevel;
			CalculateFireSpiritsStats ();
			CalculateNewFireSpiritsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateFireSpiritsStats () {
		troopManager.FireSpirits.CoinsPerTime = (float) troopManager.FireSpirits.DefaultCoinsPerTime + (troopManager.FireSpirits.CoinsPerTimeAddPerLevel * Player.FireSpiritsLevel) + (troopManager.FireSpirits.CoinsPerTimeAddPerTier * Player.FireSpiritsTier);
		troopManager.FireSpirits.CoinCollectDuration = (float) troopManager.FireSpirits.DefaultCoinCollectDuration + (troopManager.FireSpirits.CoinsCollectDurationChangePerTier * Player.FireSpiritsTier);
		fireSpirits.NewStats ();
	}

	public void CalculateNewFireSpiritsCost() {
		x = (float) Mathf.Pow(1.15f , Player.FireSpiritsLevel);
		Player.FireSpiritsElixCost = Mathf.FloorToInt((float) troopManager.FireSpirits.DefaultElixCost * x);
		kasernUI.UpgradeFireSpiritsUI ();
	}

	public void CheckFireSpiritsTierCards () {
		if (Player.FireSpiritsTier == 0) {
			FireSpiritsNextTierCards = Player.CardsToTier1;
		} else if (Player.FireSpiritsTier == 1) {
			FireSpiritsNextTierCards = Player.CardsToTier2;
		} else if (Player.FireSpiritsTier == 2) {
			FireSpiritsNextTierCards = Player.CardsToTier3;
		} else if (Player.FireSpiritsTier == 3) {
			FireSpiritsNextTierCards = Player.CardsToTier4;
		} else if (Player.FireSpiritsTier == 4) {
			FireSpiritsNextTierCards = Player.CardsToTier5;
		} else if (Player.FireSpiritsTier == 5) {
			FireSpiritsNextTierCards = Player.CardsToTier6;
		} else if (Player.FireSpiritsTier == 6) {
			FireSpiritsNextTierCards = Player.CardsToTier7;
		} else if (Player.FireSpiritsTier == 7) {
			FireSpiritsNextTierCards = Player.CardsToTier8;
		} else if (Player.FireSpiritsTier == 8) {
			FireSpiritsNextTierCards = Player.CardsToTier9;
		} else if (Player.FireSpiritsTier == 9) {
			FireSpiritsNextTierCards = Player.CardsToTier10;
		} else if (Player.FireSpiritsTier == 10) {
			FireSpiritsNextTierCards = Player.CardsToTier11;
		} else if (Player.FireSpiritsTier == 11) {
			FireSpiritsNextTierCards = Player.CardsToTier12;
		} else if (Player.FireSpiritsTier == 12) {
			FireSpiritsNextTierCards = Player.CardsToTier13;
		} else if (Player.FireSpiritsTier == 13) {
			FireSpiritsNextTierCards = 0;
		} else {
			FireSpiritsNextTierCards = 0;
		}
	}

	public void UpgradeTierFireSpirits () {
		if (Player.FireSpiritsCards >= FireSpiritsNextTierCards && Player.FireSpiritsTier <= 12) {
			Player.FireSpiritsCards -= FireSpiritsNextTierCards;
			Player.FireSpiritsTier += 1;
			Player.Experience += troopManager.FireSpirits.ExperiencePerTier;
			Player.Trophys += troopManager.FireSpirits.TrophysPerTier;
			kasernUI.UpgradeTierFireSpiritsUI ();
			CheckFireSpiritsTierCards ();
			CalculateFireSpiritsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeIceWizard () {
		if (Player.Elix >= Player.IceWizardElixCost) {
			Player.Elix -= Player.IceWizardElixCost;
			Player.IceWizardLevel += 1;
			Player.Experience += troopManager.IceWizard.ExperiencePerLevel;
			Player.Trophys += troopManager.IceWizard.TrophysPerLevel;
			CalculateIceWizardStats ();
			CalculateNewIceWizardCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateIceWizardStats () {
		troopManager.IceWizard.CoinsPerTime = (float) troopManager.IceWizard.DefaultCoinsPerTime + (troopManager.IceWizard.CoinsPerTimeAddPerLevel * Player.IceWizardLevel) + (troopManager.IceWizard.CoinsPerTimeAddPerTier * Player.IceWizardTier);
		troopManager.IceWizard.CoinCollectDuration = (float) troopManager.IceWizard.DefaultCoinCollectDuration + (troopManager.IceWizard.CoinsCollectDurationChangePerTier * Player.IceWizardTier);
		iceWizard.NewStats ();
	}

	public void CalculateNewIceWizardCost() {
		x = (float) Mathf.Pow(1.15f , Player.IceWizardLevel);
		Player.IceWizardElixCost = Mathf.FloorToInt((float) troopManager.IceWizard.DefaultElixCost * x);
		kasernUI.UpgradeIceWizardUI ();
	}

	public void CheckIceWizardTierCards () {
		if (Player.IceWizardTier == 0) {
			IceWizardNextTierCards = Player.CardsToTier1;
		} else if (Player.IceWizardTier == 1) {
			IceWizardNextTierCards = Player.CardsToTier2;
		} else if (Player.IceWizardTier == 2) {
			IceWizardNextTierCards = Player.CardsToTier3;
		} else if (Player.IceWizardTier == 3) {
			IceWizardNextTierCards = Player.CardsToTier4;
		} else if (Player.IceWizardTier == 4) {
			IceWizardNextTierCards = Player.CardsToTier5;
		} else if (Player.IceWizardTier == 5) {
			IceWizardNextTierCards = Player.CardsToTier6;
		} else if (Player.IceWizardTier == 6) {
			IceWizardNextTierCards = Player.CardsToTier7;
		} else if (Player.IceWizardTier == 7) {
			IceWizardNextTierCards = Player.CardsToTier8;
		} else if (Player.IceWizardTier == 8) {
			IceWizardNextTierCards = Player.CardsToTier9;
		} else if (Player.IceWizardTier == 9) {
			IceWizardNextTierCards = Player.CardsToTier10;
		} else if (Player.IceWizardTier == 10) {
			IceWizardNextTierCards = Player.CardsToTier11;
		} else if (Player.IceWizardTier == 11) {
			IceWizardNextTierCards = Player.CardsToTier12;
		} else if (Player.IceWizardTier == 12) {
			IceWizardNextTierCards = Player.CardsToTier13;
		} else if (Player.IceWizardTier == 13) {
			IceWizardNextTierCards = 0;
		} else {
			IceWizardNextTierCards = 0;
		}
	}

	public void UpgradeTierIceWizard () {
		if (Player.IceWizardCards >= IceWizardNextTierCards && Player.IceWizardTier <= 12) {
			Player.IceWizardCards -= IceWizardNextTierCards;
			Player.IceWizardTier += 1;
			Player.Experience += troopManager.IceWizard.ExperiencePerTier;
			Player.Trophys += troopManager.IceWizard.TrophysPerTier;
			kasernUI.UpgradeTierIceWizardUI ();
			CheckIceWizardTierCards ();
			CalculateIceWizardStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeWizard () {
		if (Player.Elix >= Player.WizardElixCost) {
			Player.Elix -= Player.WizardElixCost;
			Player.WizardLevel += 1;
			Player.Experience += troopManager.Wizard.ExperiencePerLevel;
			Player.Trophys += troopManager.Wizard.TrophysPerLevel;
			CalculateWizardStats ();
			CalculateNewWizardCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateWizardStats () {
		troopManager.Wizard.CoinsPerTime = (float) troopManager.Wizard.DefaultCoinsPerTime + (troopManager.Wizard.CoinsPerTimeAddPerLevel * Player.WizardLevel) + (troopManager.Wizard.CoinsPerTimeAddPerTier * Player.WizardTier);
		troopManager.Wizard.CoinCollectDuration = (float) troopManager.Wizard.DefaultCoinCollectDuration + (troopManager.Wizard.CoinsCollectDurationChangePerTier * Player.WizardTier);
		wizard.NewStats ();
	}

	public void CalculateNewWizardCost() {
		x = (float) Mathf.Pow(1.15f , Player.WizardLevel);
		Player.WizardElixCost = Mathf.FloorToInt((float) troopManager.Wizard.DefaultElixCost * x);
		kasernUI.UpgradeWizardUI ();
	}

	public void CheckWizardTierCards () {
		if (Player.WizardTier == 0) {
			WizardNextTierCards = Player.CardsToTier1;
		} else if (Player.WizardTier == 1) {
			WizardNextTierCards = Player.CardsToTier2;
		} else if (Player.WizardTier == 2) {
			WizardNextTierCards = Player.CardsToTier3;
		} else if (Player.WizardTier == 3) {
			WizardNextTierCards = Player.CardsToTier4;
		} else if (Player.WizardTier == 4) {
			WizardNextTierCards = Player.CardsToTier5;
		} else if (Player.WizardTier == 5) {
			WizardNextTierCards = Player.CardsToTier6;
		} else if (Player.WizardTier == 6) {
			WizardNextTierCards = Player.CardsToTier7;
		} else if (Player.WizardTier == 7) {
			WizardNextTierCards = Player.CardsToTier8;
		} else if (Player.WizardTier == 8) {
			WizardNextTierCards = Player.CardsToTier9;
		} else if (Player.WizardTier == 9) {
			WizardNextTierCards = Player.CardsToTier10;
		} else if (Player.WizardTier == 10) {
			WizardNextTierCards = Player.CardsToTier11;
		} else if (Player.WizardTier == 11) {
			WizardNextTierCards = Player.CardsToTier12;
		} else if (Player.WizardTier == 12) {
			WizardNextTierCards = Player.CardsToTier13;
		} else if (Player.WizardTier == 13) {
			WizardNextTierCards = 0;
		} else {
			WizardNextTierCards = 0;
		}
	}

	public void UpgradeTierWizard () {
		if (Player.WizardCards >= WizardNextTierCards && Player.WizardTier <= 12) {
			Player.WizardCards -= WizardNextTierCards;
			Player.WizardTier += 1;
			Player.Experience += troopManager.Wizard.ExperiencePerTier;
			Player.Trophys += troopManager.Wizard.TrophysPerTier;
			kasernUI.UpgradeTierWizardUI ();
			CheckWizardTierCards ();
			CalculateWizardStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 6

	public void UpgradeSkeletonBarrel () {
		if (Player.Elix >= Player.SkeletonBarrelElixCost) {
			Player.Elix -= Player.SkeletonBarrelElixCost;
			Player.SkeletonBarrelLevel += 1;
			Player.Experience += troopManager.SkeletonBarrel.ExperiencePerLevel;
			Player.Trophys += troopManager.SkeletonBarrel.TrophysPerLevel;
			CalculateSkeletonBarrelStats ();
			CalculateNewSkeletonBarrelCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateSkeletonBarrelStats () {
		troopManager.SkeletonBarrel.CoinsPerTime = (float) troopManager.SkeletonBarrel.DefaultCoinsPerTime + (troopManager.SkeletonBarrel.CoinsPerTimeAddPerLevel * Player.SkeletonBarrelLevel) + (troopManager.SkeletonBarrel.CoinsPerTimeAddPerTier * Player.SkeletonBarrelTier);
		troopManager.SkeletonBarrel.CoinCollectDuration = (float) troopManager.SkeletonBarrel.DefaultCoinCollectDuration + (troopManager.SkeletonBarrel.CoinsCollectDurationChangePerTier * Player.SkeletonBarrelTier);
		skeletonBarrel.NewStats ();
	}

	public void CalculateNewSkeletonBarrelCost() {
		x = (float) Mathf.Pow(1.15f , Player.SkeletonBarrelLevel);
		Player.SkeletonBarrelElixCost = Mathf.FloorToInt((float) troopManager.SkeletonBarrel.DefaultElixCost * x);
		kasernUI.UpgradeSkeletonBarrelUI ();
	}

	public void CheckSkeletonBarrelTierCards () {
		if (Player.SkeletonBarrelTier == 0) {
			SkeletonBarrelNextTierCards = Player.CardsToTier1;
		} else if (Player.SkeletonBarrelTier == 1) {
			SkeletonBarrelNextTierCards = Player.CardsToTier2;
		} else if (Player.SkeletonBarrelTier == 2) {
			SkeletonBarrelNextTierCards = Player.CardsToTier3;
		} else if (Player.SkeletonBarrelTier == 3) {
			SkeletonBarrelNextTierCards = Player.CardsToTier4;
		} else if (Player.SkeletonBarrelTier == 4) {
			SkeletonBarrelNextTierCards = Player.CardsToTier5;
		} else if (Player.SkeletonBarrelTier == 5) {
			SkeletonBarrelNextTierCards = Player.CardsToTier6;
		} else if (Player.SkeletonBarrelTier == 6) {
			SkeletonBarrelNextTierCards = Player.CardsToTier7;
		} else if (Player.SkeletonBarrelTier == 7) {
			SkeletonBarrelNextTierCards = Player.CardsToTier8;
		} else if (Player.SkeletonBarrelTier == 8) {
			SkeletonBarrelNextTierCards = Player.CardsToTier9;
		} else if (Player.SkeletonBarrelTier == 9) {
			SkeletonBarrelNextTierCards = Player.CardsToTier10;
		} else if (Player.SkeletonBarrelTier == 10) {
			SkeletonBarrelNextTierCards = Player.CardsToTier11;
		} else if (Player.SkeletonBarrelTier == 11) {
			SkeletonBarrelNextTierCards = Player.CardsToTier12;
		} else if (Player.SkeletonBarrelTier == 12) {
			SkeletonBarrelNextTierCards = Player.CardsToTier13;
		} else if (Player.SkeletonBarrelTier == 13) {
			SkeletonBarrelNextTierCards = 0;
		} else {
			SkeletonBarrelNextTierCards = 0;
		}
	}

	public void UpgradeTierSkeletonBarrel () {
		if (Player.SkeletonBarrelCards >= SkeletonBarrelNextTierCards && Player.SkeletonBarrelTier <= 12) {
			Player.SkeletonBarrelCards -= SkeletonBarrelNextTierCards;
			Player.SkeletonBarrelTier += 1;
			Player.Experience += troopManager.SkeletonBarrel.ExperiencePerTier;
			Player.Trophys += troopManager.SkeletonBarrel.TrophysPerTier;
			kasernUI.UpgradeTierSkeletonBarrelUI ();
			CheckSkeletonBarrelTierCards ();
			CalculateSkeletonBarrelStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMiner () {
		if (Player.Elix >= Player.MinerElixCost) {
			Player.Elix -= Player.MinerElixCost;
			Player.MinerLevel += 1;
			Player.Experience += troopManager.Miner.ExperiencePerLevel;
			Player.Trophys += troopManager.Miner.TrophysPerLevel;
			CalculateMinerStats ();
			CalculateNewMinerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMinerStats () {
		troopManager.Miner.CoinsPerTime = (float) troopManager.Miner.DefaultCoinsPerTime + (troopManager.Miner.CoinsPerTimeAddPerLevel * Player.MinerLevel) + (troopManager.Miner.CoinsPerTimeAddPerTier * Player.MinerTier);
		troopManager.Miner.CoinCollectDuration = (float) troopManager.Miner.DefaultCoinCollectDuration + (troopManager.Miner.CoinsCollectDurationChangePerTier * Player.MinerTier);
		miner.NewStats ();
	}

	public void CalculateNewMinerCost() {
		x = (float) Mathf.Pow(1.15f , Player.MinerLevel);
		Player.MinerElixCost = Mathf.FloorToInt((float) troopManager.Miner.DefaultElixCost * x);
		kasernUI.UpgradeMinerUI ();
	}

	public void CheckMinerTierCards () {
		if (Player.MinerTier == 0) {
			MinerNextTierCards = Player.CardsToTier1;
		} else if (Player.MinerTier == 1) {
			MinerNextTierCards = Player.CardsToTier2;
		} else if (Player.MinerTier == 2) {
			MinerNextTierCards = Player.CardsToTier3;
		} else if (Player.MinerTier == 3) {
			MinerNextTierCards = Player.CardsToTier4;
		} else if (Player.MinerTier == 4) {
			MinerNextTierCards = Player.CardsToTier5;
		} else if (Player.MinerTier == 5) {
			MinerNextTierCards = Player.CardsToTier6;
		} else if (Player.MinerTier == 6) {
			MinerNextTierCards = Player.CardsToTier7;
		} else if (Player.MinerTier == 7) {
			MinerNextTierCards = Player.CardsToTier8;
		} else if (Player.MinerTier == 8) {
			MinerNextTierCards = Player.CardsToTier9;
		} else if (Player.MinerTier == 9) {
			MinerNextTierCards = Player.CardsToTier10;
		} else if (Player.MinerTier == 10) {
			MinerNextTierCards = Player.CardsToTier11;
		} else if (Player.MinerTier == 11) {
			MinerNextTierCards = Player.CardsToTier12;
		} else if (Player.MinerTier == 12) {
			MinerNextTierCards = Player.CardsToTier13;
		} else if (Player.MinerTier == 13) {
			MinerNextTierCards = 0;
		} else {
			MinerNextTierCards = 0;
		}
	}

	public void UpgradeTierMiner () {
		if (Player.MinerCards >= MinerNextTierCards && Player.MinerTier <= 12) {
			Player.MinerCards -= MinerNextTierCards;
			Player.MinerTier += 1;
			Player.Experience += troopManager.Miner.ExperiencePerTier;
			Player.Trophys += troopManager.Miner.TrophysPerTier;
			kasernUI.UpgradeTierMinerUI ();
			CheckMinerTierCards ();
			CalculateMinerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBattleRam () {
		if (Player.Elix >= Player.BattleRamElixCost) {
			Player.Elix -= Player.BattleRamElixCost;
			Player.BattleRamLevel += 1;
			Player.Experience += troopManager.BattleRam.ExperiencePerLevel;
			Player.Trophys += troopManager.BattleRam.TrophysPerLevel;
			CalculateBattleRamStats ();
			CalculateNewBattleRamCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBattleRamStats () {
		troopManager.BattleRam.CoinsPerTime = (float) troopManager.BattleRam.DefaultCoinsPerTime + (troopManager.BattleRam.CoinsPerTimeAddPerLevel * Player.BattleRamLevel) + (troopManager.BattleRam.CoinsPerTimeAddPerTier * Player.BattleRamTier);
		troopManager.BattleRam.CoinCollectDuration = (float) troopManager.BattleRam.DefaultCoinCollectDuration + (troopManager.BattleRam.CoinsCollectDurationChangePerTier * Player.BattleRamTier);
		battleRam.NewStats ();
	}

	public void CalculateNewBattleRamCost() {
		x = (float) Mathf.Pow(1.15f , Player.BattleRamLevel);
		Player.BattleRamElixCost = Mathf.FloorToInt((float) troopManager.BattleRam.DefaultElixCost * x);
		kasernUI.UpgradeBattleRamUI ();
	}

	public void CheckBattleRamTierCards () {
		if (Player.BattleRamTier == 0) {
			BattleRamNextTierCards = Player.CardsToTier1;
		} else if (Player.BattleRamTier == 1) {
			BattleRamNextTierCards = Player.CardsToTier2;
		} else if (Player.BattleRamTier == 2) {
			BattleRamNextTierCards = Player.CardsToTier3;
		} else if (Player.BattleRamTier == 3) {
			BattleRamNextTierCards = Player.CardsToTier4;
		} else if (Player.BattleRamTier == 4) {
			BattleRamNextTierCards = Player.CardsToTier5;
		} else if (Player.BattleRamTier == 5) {
			BattleRamNextTierCards = Player.CardsToTier6;
		} else if (Player.BattleRamTier == 6) {
			BattleRamNextTierCards = Player.CardsToTier7;
		} else if (Player.BattleRamTier == 7) {
			BattleRamNextTierCards = Player.CardsToTier8;
		} else if (Player.BattleRamTier == 8) {
			BattleRamNextTierCards = Player.CardsToTier9;
		} else if (Player.BattleRamTier == 9) {
			BattleRamNextTierCards = Player.CardsToTier10;
		} else if (Player.BattleRamTier == 10) {
			BattleRamNextTierCards = Player.CardsToTier11;
		} else if (Player.BattleRamTier == 11) {
			BattleRamNextTierCards = Player.CardsToTier12;
		} else if (Player.BattleRamTier == 12) {
			BattleRamNextTierCards = Player.CardsToTier13;
		} else if (Player.BattleRamTier == 13) {
			BattleRamNextTierCards = 0;
		} else {
			BattleRamNextTierCards = 0;
		}
	}

	public void UpgradeTierBattleRam () {
		if (Player.BattleRamCards >= BattleRamNextTierCards && Player.BattleRamTier <= 12) {
			Player.BattleRamCards -= BattleRamNextTierCards;
			Player.BattleRamTier += 1;
			Player.Experience += troopManager.BattleRam.ExperiencePerTier;
			Player.Trophys += troopManager.BattleRam.TrophysPerTier;
			kasernUI.UpgradeTierBattleRamUI ();
			CheckBattleRamTierCards ();
			CalculateBattleRamStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeSparky () {
		if (Player.Elix >= Player.SparkyElixCost) {
			Player.Elix -= Player.SparkyElixCost;
			Player.SparkyLevel += 1;
			Player.Experience += troopManager.Sparky.ExperiencePerLevel;
			Player.Trophys += troopManager.Sparky.TrophysPerLevel;
			CalculateSparkyStats ();
			CalculateNewSparkyCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateSparkyStats () {
		troopManager.Sparky.CoinsPerTime = (float) troopManager.Sparky.DefaultCoinsPerTime + (troopManager.Sparky.CoinsPerTimeAddPerLevel * Player.SparkyLevel) + (troopManager.Sparky.CoinsPerTimeAddPerTier * Player.SparkyTier);
		troopManager.Sparky.CoinCollectDuration = (float) troopManager.Sparky.DefaultCoinCollectDuration + (troopManager.Sparky.CoinsCollectDurationChangePerTier * Player.SparkyTier);
		sparky.NewStats ();
	}

	public void CalculateNewSparkyCost() {
		x = (float) Mathf.Pow(1.15f , Player.SparkyLevel);
		Player.SparkyElixCost = Mathf.FloorToInt((float) troopManager.Sparky.DefaultElixCost * x);
		kasernUI.UpgradeSparkyUI ();
	}

	public void CheckSparkyTierCards () {
		if (Player.SparkyTier == 0) {
			SparkyNextTierCards = Player.CardsToTier1;
		} else if (Player.SparkyTier == 1) {
			SparkyNextTierCards = Player.CardsToTier2;
		} else if (Player.SparkyTier == 2) {
			SparkyNextTierCards = Player.CardsToTier3;
		} else if (Player.SparkyTier == 3) {
			SparkyNextTierCards = Player.CardsToTier4;
		} else if (Player.SparkyTier == 4) {
			SparkyNextTierCards = Player.CardsToTier5;
		} else if (Player.SparkyTier == 5) {
			SparkyNextTierCards = Player.CardsToTier6;
		} else if (Player.SparkyTier == 6) {
			SparkyNextTierCards = Player.CardsToTier7;
		} else if (Player.SparkyTier == 7) {
			SparkyNextTierCards = Player.CardsToTier8;
		} else if (Player.SparkyTier == 8) {
			SparkyNextTierCards = Player.CardsToTier9;
		} else if (Player.SparkyTier == 9) {
			SparkyNextTierCards = Player.CardsToTier10;
		} else if (Player.SparkyTier == 10) {
			SparkyNextTierCards = Player.CardsToTier11;
		} else if (Player.SparkyTier == 11) {
			SparkyNextTierCards = Player.CardsToTier12;
		} else if (Player.SparkyTier == 12) {
			SparkyNextTierCards = Player.CardsToTier13;
		} else if (Player.SparkyTier == 13) {
			SparkyNextTierCards = 0;
		} else {
			SparkyNextTierCards = 0;
		}
	}

	public void UpgradeTierSparky () {
		if (Player.SparkyCards >= SparkyNextTierCards && Player.SparkyTier <= 12) {
			Player.SparkyCards -= SparkyNextTierCards;
			Player.SparkyTier += 1;
			Player.Experience += troopManager.Sparky.ExperiencePerTier;
			Player.Trophys += troopManager.Sparky.TrophysPerTier;
			kasernUI.UpgradeTierSparkyUI ();
			CheckSparkyTierCards ();
			CalculateSparkyStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeGolem () {
		if (Player.Elix >= Player.GolemElixCost) {
			Player.Elix -= Player.GolemElixCost;
			Player.GolemLevel += 1;
			Player.Experience += troopManager.Golem.ExperiencePerLevel;
			Player.Trophys += troopManager.Golem.TrophysPerLevel;
			CalculateGolemStats ();
			CalculateNewGolemCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGolemStats () {
		troopManager.Golem.CoinsPerTime = (float) troopManager.Golem.DefaultCoinsPerTime + (troopManager.Golem.CoinsPerTimeAddPerLevel * Player.GolemLevel) + (troopManager.Golem.CoinsPerTimeAddPerTier * Player.GolemTier);
		troopManager.Golem.CoinCollectDuration = (float) troopManager.Golem.DefaultCoinCollectDuration + (troopManager.Golem.CoinsCollectDurationChangePerTier * Player.GolemTier);
		golem.NewStats ();
	}

	public void CalculateNewGolemCost() {
		x = (float) Mathf.Pow(1.15f , Player.GolemLevel);
		Player.GolemElixCost = Mathf.FloorToInt((float) troopManager.Golem.DefaultElixCost * x);
		kasernUI.UpgradeGolemUI ();
	}

	public void CheckGolemTierCards () {
		if (Player.GolemTier == 0) {
			GolemNextTierCards = Player.CardsToTier1;
		} else if (Player.GolemTier == 1) {
			GolemNextTierCards = Player.CardsToTier2;
		} else if (Player.GolemTier == 2) {
			GolemNextTierCards = Player.CardsToTier3;
		} else if (Player.GolemTier == 3) {
			GolemNextTierCards = Player.CardsToTier4;
		} else if (Player.GolemTier == 4) {
			GolemNextTierCards = Player.CardsToTier5;
		} else if (Player.GolemTier == 5) {
			GolemNextTierCards = Player.CardsToTier6;
		} else if (Player.GolemTier == 6) {
			GolemNextTierCards = Player.CardsToTier7;
		} else if (Player.GolemTier == 7) {
			GolemNextTierCards = Player.CardsToTier8;
		} else if (Player.GolemTier == 8) {
			GolemNextTierCards = Player.CardsToTier9;
		} else if (Player.GolemTier == 9) {
			GolemNextTierCards = Player.CardsToTier10;
		} else if (Player.GolemTier == 10) {
			GolemNextTierCards = Player.CardsToTier11;
		} else if (Player.GolemTier == 11) {
			GolemNextTierCards = Player.CardsToTier12;
		} else if (Player.GolemTier == 12) {
			GolemNextTierCards = Player.CardsToTier13;
		} else if (Player.GolemTier == 13) {
			GolemNextTierCards = 0;
		} else {
			GolemNextTierCards = 0;
		}
	}

	public void UpgradeTierGolem () {
		if (Player.GolemCards >= GolemNextTierCards && Player.GolemTier <= 12) {
			Player.GolemCards -= GolemNextTierCards;
			Player.GolemTier += 1;
			Player.Experience += troopManager.Golem.ExperiencePerTier;
			Player.Trophys += troopManager.Golem.TrophysPerTier;
			kasernUI.UpgradeTierGolemUI ();
			CheckGolemTierCards ();
			CalculateGolemStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 7

	public void UpgradeMegaMinion () {
		if (Player.Elix >= Player.MegaMinionElixCost) {
			Player.Elix -= Player.MegaMinionElixCost;
			Player.MegaMinionLevel += 1;
			Player.Experience += troopManager.MegaMinion.ExperiencePerLevel;
			Player.Trophys += troopManager.MegaMinion.TrophysPerLevel;
			CalculateMegaMinionStats ();
			CalculateNewMegaMinionCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMegaMinionStats () {
		troopManager.MegaMinion.CoinsPerTime = (float) troopManager.MegaMinion.DefaultCoinsPerTime + (troopManager.MegaMinion.CoinsPerTimeAddPerLevel * Player.MegaMinionLevel) + (troopManager.MegaMinion.CoinsPerTimeAddPerTier * Player.MegaMinionTier);
		troopManager.MegaMinion.CoinCollectDuration = (float) troopManager.MegaMinion.DefaultCoinCollectDuration + (troopManager.MegaMinion.CoinsCollectDurationChangePerTier * Player.MegaMinionTier);
		megaMinion.NewStats ();
	}

	public void CalculateNewMegaMinionCost() {
		x = (float) Mathf.Pow(1.15f , Player.MegaMinionLevel);
		Player.MegaMinionElixCost = Mathf.FloorToInt((float) troopManager.MegaMinion.DefaultElixCost * x);
		kasernUI.UpgradeMegaMinionUI ();
	}

	public void CheckMegaMinionTierCards () {
		if (Player.MegaMinionTier == 0) {
			MegaMinionNextTierCards = Player.CardsToTier1;
		} else if (Player.MegaMinionTier == 1) {
			MegaMinionNextTierCards = Player.CardsToTier2;
		} else if (Player.MegaMinionTier == 2) {
			MegaMinionNextTierCards = Player.CardsToTier3;
		} else if (Player.MegaMinionTier == 3) {
			MegaMinionNextTierCards = Player.CardsToTier4;
		} else if (Player.MegaMinionTier == 4) {
			MegaMinionNextTierCards = Player.CardsToTier5;
		} else if (Player.MegaMinionTier == 5) {
			MegaMinionNextTierCards = Player.CardsToTier6;
		} else if (Player.MegaMinionTier == 6) {
			MegaMinionNextTierCards = Player.CardsToTier7;
		} else if (Player.MegaMinionTier == 7) {
			MegaMinionNextTierCards = Player.CardsToTier8;
		} else if (Player.MegaMinionTier == 8) {
			MegaMinionNextTierCards = Player.CardsToTier9;
		} else if (Player.MegaMinionTier == 9) {
			MegaMinionNextTierCards = Player.CardsToTier10;
		} else if (Player.MegaMinionTier == 10) {
			MegaMinionNextTierCards = Player.CardsToTier11;
		} else if (Player.MegaMinionTier == 11) {
			MegaMinionNextTierCards = Player.CardsToTier12;
		} else if (Player.MegaMinionTier == 12) {
			MegaMinionNextTierCards = Player.CardsToTier13;
		} else if (Player.MegaMinionTier == 13) {
			MegaMinionNextTierCards = 0;
		} else {
			MegaMinionNextTierCards = 0;
		}
	}

	public void UpgradeTierMegaMinion () {
		if (Player.MegaMinionCards >= MegaMinionNextTierCards && Player.MegaMinionTier <= 12) {
			Player.MegaMinionCards -= MegaMinionNextTierCards;
			Player.MegaMinionTier += 1;
			Player.Experience += troopManager.MegaMinion.ExperiencePerTier;
			Player.Trophys += troopManager.MegaMinion.TrophysPerTier;
			kasernUI.UpgradeTierMegaMinionUI ();
			CheckMegaMinionTierCards ();
			CalculateMegaMinionStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeGuards () {
		if (Player.Elix >= Player.GuardsElixCost) {
			Player.Elix -= Player.GuardsElixCost;
			Player.GuardsLevel += 1;
			Player.Experience += troopManager.Guards.ExperiencePerLevel;
			Player.Trophys += troopManager.Guards.TrophysPerLevel;
			CalculateGuardsStats ();
			CalculateNewGuardsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGuardsStats () {
		troopManager.Guards.CoinsPerTime = (float) troopManager.Guards.DefaultCoinsPerTime + (troopManager.Guards.CoinsPerTimeAddPerLevel * Player.GuardsLevel) + (troopManager.Guards.CoinsPerTimeAddPerTier * Player.GuardsTier);
		troopManager.Guards.CoinCollectDuration = (float) troopManager.Guards.DefaultCoinCollectDuration + (troopManager.Guards.CoinsCollectDurationChangePerTier * Player.GuardsTier);
		guards.NewStats ();
	}

	public void CalculateNewGuardsCost() {
		x = (float) Mathf.Pow(1.15f , Player.GuardsLevel);
		Player.GuardsElixCost = Mathf.FloorToInt((float) troopManager.Guards.DefaultElixCost * x);
		kasernUI.UpgradeGuardsUI ();
	}

	public void CheckGuardsTierCards () {
		if (Player.GuardsTier == 0) {
			GuardsNextTierCards = Player.CardsToTier1;
		} else if (Player.GuardsTier == 1) {
			GuardsNextTierCards = Player.CardsToTier2;
		} else if (Player.GuardsTier == 2) {
			GuardsNextTierCards = Player.CardsToTier3;
		} else if (Player.GuardsTier == 3) {
			GuardsNextTierCards = Player.CardsToTier4;
		} else if (Player.GuardsTier == 4) {
			GuardsNextTierCards = Player.CardsToTier5;
		} else if (Player.GuardsTier == 5) {
			GuardsNextTierCards = Player.CardsToTier6;
		} else if (Player.GuardsTier == 6) {
			GuardsNextTierCards = Player.CardsToTier7;
		} else if (Player.GuardsTier == 7) {
			GuardsNextTierCards = Player.CardsToTier8;
		} else if (Player.GuardsTier == 8) {
			GuardsNextTierCards = Player.CardsToTier9;
		} else if (Player.GuardsTier == 9) {
			GuardsNextTierCards = Player.CardsToTier10;
		} else if (Player.GuardsTier == 10) {
			GuardsNextTierCards = Player.CardsToTier11;
		} else if (Player.GuardsTier == 11) {
			GuardsNextTierCards = Player.CardsToTier12;
		} else if (Player.GuardsTier == 12) {
			GuardsNextTierCards = Player.CardsToTier13;
		} else if (Player.GuardsTier == 13) {
			GuardsNextTierCards = 0;
		} else {
			GuardsNextTierCards = 0;
		}
	}

	public void UpgradeTierGuards () {
		if (Player.GuardsCards >= GuardsNextTierCards && Player.GuardsTier <= 12) {
			Player.GuardsCards -= GuardsNextTierCards;
			Player.GuardsTier += 1;
			Player.Experience += troopManager.Guards.ExperiencePerTier;
			Player.Trophys += troopManager.Guards.TrophysPerTier;
			kasernUI.UpgradeTierGuardsUI ();
			CheckGuardsTierCards ();
			CalculateGuardsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradePrincess () {
		if (Player.Elix >= Player.PrincessElixCost) {
			Player.Elix -= Player.PrincessElixCost;
			Player.PrincessLevel += 1;
			Player.Experience += troopManager.Princess.ExperiencePerLevel;
			Player.Trophys += troopManager.Princess.TrophysPerLevel;
			CalculatePrincessStats ();
			CalculateNewPrincessCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculatePrincessStats () {
		troopManager.Princess.CoinsPerTime = (float) troopManager.Princess.DefaultCoinsPerTime + (troopManager.Princess.CoinsPerTimeAddPerLevel * Player.PrincessLevel) + (troopManager.Princess.CoinsPerTimeAddPerTier * Player.PrincessTier);
		troopManager.Princess.CoinCollectDuration = (float) troopManager.Princess.DefaultCoinCollectDuration + (troopManager.Princess.CoinsCollectDurationChangePerTier * Player.PrincessTier);
		princess.NewStats ();
	}

	public void CalculateNewPrincessCost() {
		x = (float) Mathf.Pow(1.15f , Player.PrincessLevel);
		Player.PrincessElixCost = Mathf.FloorToInt((float) troopManager.Princess.DefaultElixCost * x);
		kasernUI.UpgradePrincessUI ();
	}

	public void CheckPrincessTierCards () {
		if (Player.PrincessTier == 0) {
			PrincessNextTierCards = Player.CardsToTier1;
		} else if (Player.PrincessTier == 1) {
			PrincessNextTierCards = Player.CardsToTier2;
		} else if (Player.PrincessTier == 2) {
			PrincessNextTierCards = Player.CardsToTier3;
		} else if (Player.PrincessTier == 3) {
			PrincessNextTierCards = Player.CardsToTier4;
		} else if (Player.PrincessTier == 4) {
			PrincessNextTierCards = Player.CardsToTier5;
		} else if (Player.PrincessTier == 5) {
			PrincessNextTierCards = Player.CardsToTier6;
		} else if (Player.PrincessTier == 6) {
			PrincessNextTierCards = Player.CardsToTier7;
		} else if (Player.PrincessTier == 7) {
			PrincessNextTierCards = Player.CardsToTier8;
		} else if (Player.PrincessTier == 8) {
			PrincessNextTierCards = Player.CardsToTier9;
		} else if (Player.PrincessTier == 9) {
			PrincessNextTierCards = Player.CardsToTier10;
		} else if (Player.PrincessTier == 10) {
			PrincessNextTierCards = Player.CardsToTier11;
		} else if (Player.PrincessTier == 11) {
			PrincessNextTierCards = Player.CardsToTier12;
		} else if (Player.PrincessTier == 12) {
			PrincessNextTierCards = Player.CardsToTier13;
		} else if (Player.PrincessTier == 13) {
			PrincessNextTierCards = 0;
		} else {
			PrincessNextTierCards = 0;
		}
	}

	public void UpgradeTierPrincess () {
		if (Player.PrincessCards >= PrincessNextTierCards && Player.PrincessTier <= 12) {
			Player.PrincessCards -= PrincessNextTierCards;
			Player.PrincessTier += 1;
			Player.Experience += troopManager.Princess.ExperiencePerTier;
			Player.Trophys += troopManager.Princess.TrophysPerTier;
			kasernUI.UpgradeTierPrincessUI ();
			CheckPrincessTierCards ();
			CalculatePrincessStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeDarkPrince () {
		if (Player.Elix >= Player.DarkPrinceElixCost) {
			Player.Elix -= Player.DarkPrinceElixCost;
			Player.DarkPrinceLevel += 1;
			Player.Experience += troopManager.DarkPrince.ExperiencePerLevel;
			Player.Trophys += troopManager.DarkPrince.TrophysPerLevel;
			CalculateDarkPrinceStats ();
			CalculateNewDarkPrinceCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateDarkPrinceStats () {
		troopManager.DarkPrince.CoinsPerTime = (float) troopManager.DarkPrince.DefaultCoinsPerTime + (troopManager.DarkPrince.CoinsPerTimeAddPerLevel * Player.DarkPrinceLevel) + (troopManager.DarkPrince.CoinsPerTimeAddPerTier * Player.DarkPrinceTier);
		troopManager.DarkPrince.CoinCollectDuration = (float) troopManager.DarkPrince.DefaultCoinCollectDuration + (troopManager.DarkPrince.CoinsCollectDurationChangePerTier * Player.DarkPrinceTier);
		darkPrince.NewStats ();
	}

	public void CalculateNewDarkPrinceCost() {
		x = (float) Mathf.Pow(1.15f , Player.DarkPrinceLevel);
		Player.DarkPrinceElixCost = Mathf.FloorToInt((float) troopManager.DarkPrince.DefaultElixCost * x);
		kasernUI.UpgradeDarkPrinceUI ();
	}

	public void CheckDarkPrinceTierCards () {
		if (Player.DarkPrinceTier == 0) {
			DarkPrinceNextTierCards = Player.CardsToTier1;
		} else if (Player.DarkPrinceTier == 1) {
			DarkPrinceNextTierCards = Player.CardsToTier2;
		} else if (Player.DarkPrinceTier == 2) {
			DarkPrinceNextTierCards = Player.CardsToTier3;
		} else if (Player.DarkPrinceTier == 3) {
			DarkPrinceNextTierCards = Player.CardsToTier4;
		} else if (Player.DarkPrinceTier == 4) {
			DarkPrinceNextTierCards = Player.CardsToTier5;
		} else if (Player.DarkPrinceTier == 5) {
			DarkPrinceNextTierCards = Player.CardsToTier6;
		} else if (Player.DarkPrinceTier == 6) {
			DarkPrinceNextTierCards = Player.CardsToTier7;
		} else if (Player.DarkPrinceTier == 7) {
			DarkPrinceNextTierCards = Player.CardsToTier8;
		} else if (Player.DarkPrinceTier == 8) {
			DarkPrinceNextTierCards = Player.CardsToTier9;
		} else if (Player.DarkPrinceTier == 9) {
			DarkPrinceNextTierCards = Player.CardsToTier10;
		} else if (Player.DarkPrinceTier == 10) {
			DarkPrinceNextTierCards = Player.CardsToTier11;
		} else if (Player.DarkPrinceTier == 11) {
			DarkPrinceNextTierCards = Player.CardsToTier12;
		} else if (Player.DarkPrinceTier == 12) {
			DarkPrinceNextTierCards = Player.CardsToTier13;
		} else if (Player.DarkPrinceTier == 13) {
			DarkPrinceNextTierCards = 0;
		} else {
			DarkPrinceNextTierCards = 0;
		}
	}

	public void UpgradeTierDarkPrince () {
		if (Player.DarkPrinceCards >= DarkPrinceNextTierCards && Player.DarkPrinceTier <= 12) {
			Player.DarkPrinceCards -= DarkPrinceNextTierCards;
			Player.DarkPrinceTier += 1;
			Player.Experience += troopManager.DarkPrince.ExperiencePerTier;
			Player.Trophys += troopManager.DarkPrince.TrophysPerTier;
			kasernUI.UpgradeTierDarkPrinceUI ();
			CheckDarkPrinceTierCards ();
			CalculateDarkPrinceStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeElectroWizard () {
		if (Player.Elix >= Player.ElectroWizardElixCost) {
			Player.Elix -= Player.ElectroWizardElixCost;
			Player.ElectroWizardLevel += 1;
			Player.Experience += troopManager.ElectroWizard.ExperiencePerLevel;
			Player.Trophys += troopManager.ElectroWizard.TrophysPerLevel;
			CalculateElectroWizardStats ();
			CalculateNewElectroWizardCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateElectroWizardStats () {
		troopManager.ElectroWizard.CoinsPerTime = (float) troopManager.ElectroWizard.DefaultCoinsPerTime + (troopManager.ElectroWizard.CoinsPerTimeAddPerLevel * Player.ElectroWizardLevel) + (troopManager.ElectroWizard.CoinsPerTimeAddPerTier * Player.ElectroWizardTier);
		troopManager.ElectroWizard.CoinCollectDuration = (float) troopManager.ElectroWizard.DefaultCoinCollectDuration + (troopManager.ElectroWizard.CoinsCollectDurationChangePerTier * Player.ElectroWizardTier);
		electroWizard.NewStats ();
	}

	public void CalculateNewElectroWizardCost() {
		x = (float) Mathf.Pow(1.15f , Player.ElectroWizardLevel);
		Player.ElectroWizardElixCost = Mathf.FloorToInt((float) troopManager.ElectroWizard.DefaultElixCost * x);
		kasernUI.UpgradeElectroWizardUI ();
	}

	public void CheckElectroWizardTierCards () {
		if (Player.ElectroWizardTier == 0) {
			ElectroWizardNextTierCards = Player.CardsToTier1;
		} else if (Player.ElectroWizardTier == 1) {
			ElectroWizardNextTierCards = Player.CardsToTier2;
		} else if (Player.ElectroWizardTier == 2) {
			ElectroWizardNextTierCards = Player.CardsToTier3;
		} else if (Player.ElectroWizardTier == 3) {
			ElectroWizardNextTierCards = Player.CardsToTier4;
		} else if (Player.ElectroWizardTier == 4) {
			ElectroWizardNextTierCards = Player.CardsToTier5;
		} else if (Player.ElectroWizardTier == 5) {
			ElectroWizardNextTierCards = Player.CardsToTier6;
		} else if (Player.ElectroWizardTier == 6) {
			ElectroWizardNextTierCards = Player.CardsToTier7;
		} else if (Player.ElectroWizardTier == 7) {
			ElectroWizardNextTierCards = Player.CardsToTier8;
		} else if (Player.ElectroWizardTier == 8) {
			ElectroWizardNextTierCards = Player.CardsToTier9;
		} else if (Player.ElectroWizardTier == 9) {
			ElectroWizardNextTierCards = Player.CardsToTier10;
		} else if (Player.ElectroWizardTier == 10) {
			ElectroWizardNextTierCards = Player.CardsToTier11;
		} else if (Player.ElectroWizardTier == 11) {
			ElectroWizardNextTierCards = Player.CardsToTier12;
		} else if (Player.ElectroWizardTier == 12) {
			ElectroWizardNextTierCards = Player.CardsToTier13;
		} else if (Player.ElectroWizardTier == 13) {
			ElectroWizardNextTierCards = 0;
		} else {
			ElectroWizardNextTierCards = 0;
		}
	}

	public void UpgradeTierElectroWizard () {
		if (Player.ElectroWizardCards >= ElectroWizardNextTierCards && Player.ElectroWizardTier <= 12) {
			Player.ElectroWizardCards -= ElectroWizardNextTierCards;
			Player.ElectroWizardTier += 1;
			Player.Experience += troopManager.ElectroWizard.ExperiencePerTier;
			Player.Trophys += troopManager.ElectroWizard.TrophysPerTier;
			kasernUI.UpgradeTierElectroWizardUI ();
			CheckElectroWizardTierCards ();
			CalculateElectroWizardStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeRoyalGiant () {
		if (Player.Elix >= Player.RoyalGiantElixCost) {
			Player.Elix -= Player.RoyalGiantElixCost;
			Player.RoyalGiantLevel += 1;
			Player.Experience += troopManager.RoyalGiant.ExperiencePerLevel;
			Player.Trophys += troopManager.RoyalGiant.TrophysPerLevel;
			CalculateRoyalGiantStats ();
			CalculateNewRoyalGiantCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateRoyalGiantStats () {
		troopManager.RoyalGiant.CoinsPerTime = (float) troopManager.RoyalGiant.DefaultCoinsPerTime + (troopManager.RoyalGiant.CoinsPerTimeAddPerLevel * Player.RoyalGiantLevel) + (troopManager.RoyalGiant.CoinsPerTimeAddPerTier * Player.RoyalGiantTier);
		troopManager.RoyalGiant.CoinCollectDuration = (float) troopManager.RoyalGiant.DefaultCoinCollectDuration + (troopManager.RoyalGiant.CoinsCollectDurationChangePerTier * Player.RoyalGiantTier);
		royalGiant.NewStats ();
	}

	public void CalculateNewRoyalGiantCost() {
		x = (float) Mathf.Pow(1.15f , Player.RoyalGiantLevel);
		Player.RoyalGiantElixCost = Mathf.FloorToInt((float) troopManager.RoyalGiant.DefaultElixCost * x);
		kasernUI.UpgradeRoyalGiantUI ();
	}

	public void CheckRoyalGiantTierCards () {
		if (Player.RoyalGiantTier == 0) {
			RoyalGiantNextTierCards = Player.CardsToTier1;
		} else if (Player.RoyalGiantTier == 1) {
			RoyalGiantNextTierCards = Player.CardsToTier2;
		} else if (Player.RoyalGiantTier == 2) {
			RoyalGiantNextTierCards = Player.CardsToTier3;
		} else if (Player.RoyalGiantTier == 3) {
			RoyalGiantNextTierCards = Player.CardsToTier4;
		} else if (Player.RoyalGiantTier == 4) {
			RoyalGiantNextTierCards = Player.CardsToTier5;
		} else if (Player.RoyalGiantTier == 5) {
			RoyalGiantNextTierCards = Player.CardsToTier6;
		} else if (Player.RoyalGiantTier == 6) {
			RoyalGiantNextTierCards = Player.CardsToTier7;
		} else if (Player.RoyalGiantTier == 7) {
			RoyalGiantNextTierCards = Player.CardsToTier8;
		} else if (Player.RoyalGiantTier == 8) {
			RoyalGiantNextTierCards = Player.CardsToTier9;
		} else if (Player.RoyalGiantTier == 9) {
			RoyalGiantNextTierCards = Player.CardsToTier10;
		} else if (Player.RoyalGiantTier == 10) {
			RoyalGiantNextTierCards = Player.CardsToTier11;
		} else if (Player.RoyalGiantTier == 11) {
			RoyalGiantNextTierCards = Player.CardsToTier12;
		} else if (Player.RoyalGiantTier == 12) {
			RoyalGiantNextTierCards = Player.CardsToTier13;
		} else if (Player.RoyalGiantTier == 13) {
			RoyalGiantNextTierCards = 0;
		} else {
			RoyalGiantNextTierCards = 0;
		}
	}

	public void UpgradeTierRoyalGiant () {
		if (Player.RoyalGiantCards >= RoyalGiantNextTierCards && Player.RoyalGiantTier <= 12) {
			Player.RoyalGiantCards -= RoyalGiantNextTierCards;
			Player.RoyalGiantTier += 1;
			Player.Experience += troopManager.RoyalGiant.ExperiencePerTier;
			Player.Trophys += troopManager.RoyalGiant.TrophysPerTier;
			kasernUI.UpgradeTierRoyalGiantUI ();
			CheckRoyalGiantTierCards ();
			CalculateRoyalGiantStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeEliteBarbarians () {
		if (Player.Elix >= Player.EliteBarbariansElixCost) {
			Player.Elix -= Player.EliteBarbariansElixCost;
			Player.EliteBarbariansLevel += 1;
			Player.Experience += troopManager.EliteBarbarians.ExperiencePerLevel;
			Player.Trophys += troopManager.EliteBarbarians.TrophysPerLevel;
			CalculateEliteBarbariansStats ();
			CalculateNewEliteBarbariansCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateEliteBarbariansStats () {
		troopManager.EliteBarbarians.CoinsPerTime = (float) troopManager.EliteBarbarians.DefaultCoinsPerTime + (troopManager.EliteBarbarians.CoinsPerTimeAddPerLevel * Player.EliteBarbariansLevel) + (troopManager.EliteBarbarians.CoinsPerTimeAddPerTier * Player.EliteBarbariansTier);
		troopManager.EliteBarbarians.CoinCollectDuration = (float) troopManager.EliteBarbarians.DefaultCoinCollectDuration + (troopManager.EliteBarbarians.CoinsCollectDurationChangePerTier * Player.EliteBarbariansTier);
		eliteBarbarians.NewStats ();
	}

	public void CalculateNewEliteBarbariansCost() {
		x = (float) Mathf.Pow(1.15f , Player.EliteBarbariansLevel);
		Player.EliteBarbariansElixCost = Mathf.FloorToInt((float) troopManager.EliteBarbarians.DefaultElixCost * x);
		kasernUI.UpgradeEliteBarbariansUI ();
	}

	public void CheckEliteBarbariansTierCards () {
		if (Player.EliteBarbariansTier == 0) {
			EliteBarbariansNextTierCards = Player.CardsToTier1;
		} else if (Player.EliteBarbariansTier == 1) {
			EliteBarbariansNextTierCards = Player.CardsToTier2;
		} else if (Player.EliteBarbariansTier == 2) {
			EliteBarbariansNextTierCards = Player.CardsToTier3;
		} else if (Player.EliteBarbariansTier == 3) {
			EliteBarbariansNextTierCards = Player.CardsToTier4;
		} else if (Player.EliteBarbariansTier == 4) {
			EliteBarbariansNextTierCards = Player.CardsToTier5;
		} else if (Player.EliteBarbariansTier == 5) {
			EliteBarbariansNextTierCards = Player.CardsToTier6;
		} else if (Player.EliteBarbariansTier == 6) {
			EliteBarbariansNextTierCards = Player.CardsToTier7;
		} else if (Player.EliteBarbariansTier == 7) {
			EliteBarbariansNextTierCards = Player.CardsToTier8;
		} else if (Player.EliteBarbariansTier == 8) {
			EliteBarbariansNextTierCards = Player.CardsToTier9;
		} else if (Player.EliteBarbariansTier == 9) {
			EliteBarbariansNextTierCards = Player.CardsToTier10;
		} else if (Player.EliteBarbariansTier == 10) {
			EliteBarbariansNextTierCards = Player.CardsToTier11;
		} else if (Player.EliteBarbariansTier == 11) {
			EliteBarbariansNextTierCards = Player.CardsToTier12;
		} else if (Player.EliteBarbariansTier == 12) {
			EliteBarbariansNextTierCards = Player.CardsToTier13;
		} else if (Player.EliteBarbariansTier == 13) {
			EliteBarbariansNextTierCards = 0;
		} else {
			EliteBarbariansNextTierCards = 0;
		}
	}

	public void UpgradeTierEliteBarbarians () {
		if (Player.EliteBarbariansCards >= EliteBarbariansNextTierCards && Player.EliteBarbariansTier <= 12) {
			Player.EliteBarbariansCards -= EliteBarbariansNextTierCards;
			Player.EliteBarbariansTier += 1;
			Player.Experience += troopManager.EliteBarbarians.ExperiencePerTier;
			Player.Trophys += troopManager.EliteBarbarians.TrophysPerTier;
			kasernUI.UpgradeTierEliteBarbariansUI ();
			CheckEliteBarbariansTierCards ();
			CalculateEliteBarbariansStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeThreeMusketeers () {
		if (Player.Elix >= Player.ThreeMusketeersElixCost) {
			Player.Elix -= Player.ThreeMusketeersElixCost;
			Player.ThreeMusketeersLevel += 1;
			Player.Experience += troopManager.ThreeMusketeers.ExperiencePerLevel;
			Player.Trophys += troopManager.ThreeMusketeers.TrophysPerLevel;
			CalculateThreeMusketeersStats ();
			CalculateNewThreeMusketeersCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateThreeMusketeersStats () {
		troopManager.ThreeMusketeers.CoinsPerTime = (float) troopManager.ThreeMusketeers.DefaultCoinsPerTime + (troopManager.ThreeMusketeers.CoinsPerTimeAddPerLevel * Player.ThreeMusketeersLevel) + (troopManager.ThreeMusketeers.CoinsPerTimeAddPerTier * Player.ThreeMusketeersTier);
		troopManager.ThreeMusketeers.CoinCollectDuration = (float) troopManager.ThreeMusketeers.DefaultCoinCollectDuration + (troopManager.ThreeMusketeers.CoinsCollectDurationChangePerTier * Player.ThreeMusketeersTier);
		threeMusketeers.NewStats ();
	}

	public void CalculateNewThreeMusketeersCost() {
		x = (float) Mathf.Pow(1.15f , Player.ThreeMusketeersLevel);
		Player.ThreeMusketeersElixCost = Mathf.FloorToInt((float) troopManager.ThreeMusketeers.DefaultElixCost * x);
		kasernUI.UpgradeThreeMusketeersUI ();
	}

	public void CheckThreeMusketeersTierCards () {
		if (Player.ThreeMusketeersTier == 0) {
			ThreeMusketeersNextTierCards = Player.CardsToTier1;
		} else if (Player.ThreeMusketeersTier == 1) {
			ThreeMusketeersNextTierCards = Player.CardsToTier2;
		} else if (Player.ThreeMusketeersTier == 2) {
			ThreeMusketeersNextTierCards = Player.CardsToTier3;
		} else if (Player.ThreeMusketeersTier == 3) {
			ThreeMusketeersNextTierCards = Player.CardsToTier4;
		} else if (Player.ThreeMusketeersTier == 4) {
			ThreeMusketeersNextTierCards = Player.CardsToTier5;
		} else if (Player.ThreeMusketeersTier == 5) {
			ThreeMusketeersNextTierCards = Player.CardsToTier6;
		} else if (Player.ThreeMusketeersTier == 6) {
			ThreeMusketeersNextTierCards = Player.CardsToTier7;
		} else if (Player.ThreeMusketeersTier == 7) {
			ThreeMusketeersNextTierCards = Player.CardsToTier8;
		} else if (Player.ThreeMusketeersTier == 8) {
			ThreeMusketeersNextTierCards = Player.CardsToTier9;
		} else if (Player.ThreeMusketeersTier == 9) {
			ThreeMusketeersNextTierCards = Player.CardsToTier10;
		} else if (Player.ThreeMusketeersTier == 10) {
			ThreeMusketeersNextTierCards = Player.CardsToTier11;
		} else if (Player.ThreeMusketeersTier == 11) {
			ThreeMusketeersNextTierCards = Player.CardsToTier12;
		} else if (Player.ThreeMusketeersTier == 12) {
			ThreeMusketeersNextTierCards = Player.CardsToTier13;
		} else if (Player.ThreeMusketeersTier == 13) {
			ThreeMusketeersNextTierCards = 0;
		} else {
			ThreeMusketeersNextTierCards = 0;
		}
	}

	public void UpgradeTierThreeMusketeers () {
		if (Player.ThreeMusketeersCards >= ThreeMusketeersNextTierCards && Player.ThreeMusketeersTier <= 12) {
			Player.ThreeMusketeersCards -= ThreeMusketeersNextTierCards;
			Player.ThreeMusketeersTier += 1;
			Player.Experience += troopManager.ThreeMusketeers.ExperiencePerTier;
			Player.Trophys += troopManager.ThreeMusketeers.TrophysPerTier;
			kasernUI.UpgradeTierThreeMusketeersUI ();
			CheckThreeMusketeersTierCards ();
			CalculateThreeMusketeersStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 8

	public void UpgradeIceSpirit () {
		if (Player.Elix >= Player.IceSpiritElixCost) {
			Player.Elix -= Player.IceSpiritElixCost;
			Player.IceSpiritLevel += 1;
			Player.Experience += troopManager.IceSpirit.ExperiencePerLevel;
			Player.Trophys += troopManager.IceSpirit.TrophysPerLevel;
			CalculateIceSpiritStats ();
			CalculateNewIceSpiritCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateIceSpiritStats () {
		troopManager.IceSpirit.CoinsPerTime = (float) troopManager.IceSpirit.DefaultCoinsPerTime + (troopManager.IceSpirit.CoinsPerTimeAddPerLevel * Player.IceSpiritLevel) + (troopManager.IceSpirit.CoinsPerTimeAddPerTier * Player.IceSpiritTier);
		troopManager.IceSpirit.CoinCollectDuration = (float) troopManager.IceSpirit.DefaultCoinCollectDuration + (troopManager.IceSpirit.CoinsCollectDurationChangePerTier * Player.IceSpiritTier);
		iceSpirit.NewStats ();
	}

	public void CalculateNewIceSpiritCost() {
		x = (float) Mathf.Pow(1.15f , Player.IceSpiritLevel);
		Player.IceSpiritElixCost = Mathf.FloorToInt((float) troopManager.IceSpirit.DefaultElixCost * x);
		kasernUI.UpgradeIceSpiritUI ();
	}

	public void CheckIceSpiritTierCards () {
		if (Player.IceSpiritTier == 0) {
			IceSpiritNextTierCards = Player.CardsToTier1;
		} else if (Player.IceSpiritTier == 1) {
			IceSpiritNextTierCards = Player.CardsToTier2;
		} else if (Player.IceSpiritTier == 2) {
			IceSpiritNextTierCards = Player.CardsToTier3;
		} else if (Player.IceSpiritTier == 3) {
			IceSpiritNextTierCards = Player.CardsToTier4;
		} else if (Player.IceSpiritTier == 4) {
			IceSpiritNextTierCards = Player.CardsToTier5;
		} else if (Player.IceSpiritTier == 5) {
			IceSpiritNextTierCards = Player.CardsToTier6;
		} else if (Player.IceSpiritTier == 6) {
			IceSpiritNextTierCards = Player.CardsToTier7;
		} else if (Player.IceSpiritTier == 7) {
			IceSpiritNextTierCards = Player.CardsToTier8;
		} else if (Player.IceSpiritTier == 8) {
			IceSpiritNextTierCards = Player.CardsToTier9;
		} else if (Player.IceSpiritTier == 9) {
			IceSpiritNextTierCards = Player.CardsToTier10;
		} else if (Player.IceSpiritTier == 10) {
			IceSpiritNextTierCards = Player.CardsToTier11;
		} else if (Player.IceSpiritTier == 11) {
			IceSpiritNextTierCards = Player.CardsToTier12;
		} else if (Player.IceSpiritTier == 12) {
			IceSpiritNextTierCards = Player.CardsToTier13;
		} else if (Player.IceSpiritTier == 13) {
			IceSpiritNextTierCards = 0;
		} else {
			IceSpiritNextTierCards = 0;
		}
	}

	public void UpgradeTierIceSpirit () {
		if (Player.IceSpiritCards >= IceSpiritNextTierCards && Player.IceSpiritTier <= 12) {
			Player.IceSpiritCards -= IceSpiritNextTierCards;
			Player.IceSpiritTier += 1;
			Player.Experience += troopManager.IceSpirit.ExperiencePerTier;
			Player.Trophys += troopManager.IceSpirit.TrophysPerTier;
			kasernUI.UpgradeTierIceSpiritUI ();
			CheckIceSpiritTierCards ();
			CalculateIceSpiritStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBats () {
		if (Player.Elix >= Player.BatsElixCost) {
			Player.Elix -= Player.BatsElixCost;
			Player.BatsLevel += 1;
			Player.Experience += troopManager.Bats.ExperiencePerLevel;
			Player.Trophys += troopManager.Bats.TrophysPerLevel;
			CalculateBatsStats ();
			CalculateNewBatsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBatsStats () {
		troopManager.Bats.CoinsPerTime = (float) troopManager.Bats.DefaultCoinsPerTime + (troopManager.Bats.CoinsPerTimeAddPerLevel * Player.BatsLevel) + (troopManager.Bats.CoinsPerTimeAddPerTier * Player.BatsTier);
		troopManager.Bats.CoinCollectDuration = (float) troopManager.Bats.DefaultCoinCollectDuration + (troopManager.Bats.CoinsCollectDurationChangePerTier * Player.BatsTier);
		bats.NewStats ();
	}

	public void CalculateNewBatsCost() {
		x = (float) Mathf.Pow(1.15f , Player.BatsLevel);
		Player.BatsElixCost = Mathf.FloorToInt((float) troopManager.Bats.DefaultElixCost * x);
		kasernUI.UpgradeBatsUI ();
	}

	public void CheckBatsTierCards () {
		if (Player.BatsTier == 0) {
			BatsNextTierCards = Player.CardsToTier1;
		} else if (Player.BatsTier == 1) {
			BatsNextTierCards = Player.CardsToTier2;
		} else if (Player.BatsTier == 2) {
			BatsNextTierCards = Player.CardsToTier3;
		} else if (Player.BatsTier == 3) {
			BatsNextTierCards = Player.CardsToTier4;
		} else if (Player.BatsTier == 4) {
			BatsNextTierCards = Player.CardsToTier5;
		} else if (Player.BatsTier == 5) {
			BatsNextTierCards = Player.CardsToTier6;
		} else if (Player.BatsTier == 6) {
			BatsNextTierCards = Player.CardsToTier7;
		} else if (Player.BatsTier == 7) {
			BatsNextTierCards = Player.CardsToTier8;
		} else if (Player.BatsTier == 8) {
			BatsNextTierCards = Player.CardsToTier9;
		} else if (Player.BatsTier == 9) {
			BatsNextTierCards = Player.CardsToTier10;
		} else if (Player.BatsTier == 10) {
			BatsNextTierCards = Player.CardsToTier11;
		} else if (Player.BatsTier == 11) {
			BatsNextTierCards = Player.CardsToTier12;
		} else if (Player.BatsTier == 12) {
			BatsNextTierCards = Player.CardsToTier13;
		} else if (Player.BatsTier == 13) {
			BatsNextTierCards = 0;
		} else {
			BatsNextTierCards = 0;
		}
	}

	public void UpgradeTierBats () {
		if (Player.BatsCards >= BatsNextTierCards && Player.BatsTier <= 12) {
			Player.BatsCards -= BatsNextTierCards;
			Player.BatsTier += 1;
			Player.Experience += troopManager.Bats.ExperiencePerTier;
			Player.Trophys += troopManager.Bats.TrophysPerTier;
			kasernUI.UpgradeTierBatsUI ();
			CheckBatsTierCards ();
			CalculateBatsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeIceGolem () {
		if (Player.Elix >= Player.IceGolemElixCost) {
			Player.Elix -= Player.IceGolemElixCost;
			Player.IceGolemLevel += 1;
			Player.Experience += troopManager.IceGolem.ExperiencePerLevel;
			Player.Trophys += troopManager.IceGolem.TrophysPerLevel;
			CalculateIceGolemStats ();
			CalculateNewIceGolemCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateIceGolemStats () {
		troopManager.IceGolem.CoinsPerTime = (float) troopManager.IceGolem.DefaultCoinsPerTime + (troopManager.IceGolem.CoinsPerTimeAddPerLevel * Player.IceGolemLevel) + (troopManager.IceGolem.CoinsPerTimeAddPerTier * Player.IceGolemTier);
		troopManager.IceGolem.CoinCollectDuration = (float) troopManager.IceGolem.DefaultCoinCollectDuration + (troopManager.IceGolem.CoinsCollectDurationChangePerTier * Player.IceGolemTier);
		iceGolem.NewStats ();
	}

	public void CalculateNewIceGolemCost() {
		x = (float) Mathf.Pow(1.15f , Player.IceGolemLevel);
		Player.IceGolemElixCost = Mathf.FloorToInt((float) troopManager.IceGolem.DefaultElixCost * x);
		kasernUI.UpgradeIceGolemUI ();
	}

	public void CheckIceGolemTierCards () {
		if (Player.IceGolemTier == 0) {
			IceGolemNextTierCards = Player.CardsToTier1;
		} else if (Player.IceGolemTier == 1) {
			IceGolemNextTierCards = Player.CardsToTier2;
		} else if (Player.IceGolemTier == 2) {
			IceGolemNextTierCards = Player.CardsToTier3;
		} else if (Player.IceGolemTier == 3) {
			IceGolemNextTierCards = Player.CardsToTier4;
		} else if (Player.IceGolemTier == 4) {
			IceGolemNextTierCards = Player.CardsToTier5;
		} else if (Player.IceGolemTier == 5) {
			IceGolemNextTierCards = Player.CardsToTier6;
		} else if (Player.IceGolemTier == 6) {
			IceGolemNextTierCards = Player.CardsToTier7;
		} else if (Player.IceGolemTier == 7) {
			IceGolemNextTierCards = Player.CardsToTier8;
		} else if (Player.IceGolemTier == 8) {
			IceGolemNextTierCards = Player.CardsToTier9;
		} else if (Player.IceGolemTier == 9) {
			IceGolemNextTierCards = Player.CardsToTier10;
		} else if (Player.IceGolemTier == 10) {
			IceGolemNextTierCards = Player.CardsToTier11;
		} else if (Player.IceGolemTier == 11) {
			IceGolemNextTierCards = Player.CardsToTier12;
		} else if (Player.IceGolemTier == 12) {
			IceGolemNextTierCards = Player.CardsToTier13;
		} else if (Player.IceGolemTier == 13) {
			IceGolemNextTierCards = 0;
		} else {
			IceGolemNextTierCards = 0;
		}
	}

	public void UpgradeTierIceGolem () {
		if (Player.IceGolemCards >= IceGolemNextTierCards && Player.IceGolemTier <= 12) {
			Player.IceGolemCards -= IceGolemNextTierCards;
			Player.IceGolemTier += 1;
			Player.Experience += troopManager.IceGolem.ExperiencePerTier;
			Player.Trophys += troopManager.IceGolem.TrophysPerTier;
			kasernUI.UpgradeTierIceGolemUI ();
			CheckIceGolemTierCards ();
			CalculateIceGolemStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeNightWitch () {
		if (Player.Elix >= Player.NightWitchElixCost) {
			Player.Elix -= Player.NightWitchElixCost;
			Player.NightWitchLevel += 1;
			Player.Experience += troopManager.NightWitch.ExperiencePerLevel;
			Player.Trophys += troopManager.NightWitch.TrophysPerLevel;
			CalculateNightWitchStats ();
			CalculateNewNightWitchCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateNightWitchStats () {
		troopManager.NightWitch.CoinsPerTime = (float) troopManager.NightWitch.DefaultCoinsPerTime + (troopManager.NightWitch.CoinsPerTimeAddPerLevel * Player.NightWitchLevel) + (troopManager.NightWitch.CoinsPerTimeAddPerTier * Player.NightWitchTier);
		troopManager.NightWitch.CoinCollectDuration = (float) troopManager.NightWitch.DefaultCoinCollectDuration + (troopManager.NightWitch.CoinsCollectDurationChangePerTier * Player.NightWitchTier);
		nightWitch.NewStats ();
	}

	public void CalculateNewNightWitchCost() {
		x = (float) Mathf.Pow(1.15f , Player.NightWitchLevel);
		Player.NightWitchElixCost = Mathf.FloorToInt((float) troopManager.NightWitch.DefaultElixCost * x);
		kasernUI.UpgradeNightWitchUI ();
	}

	public void CheckNightWitchTierCards () {
		if (Player.NightWitchTier == 0) {
			NightWitchNextTierCards = Player.CardsToTier1;
		} else if (Player.NightWitchTier == 1) {
			NightWitchNextTierCards = Player.CardsToTier2;
		} else if (Player.NightWitchTier == 2) {
			NightWitchNextTierCards = Player.CardsToTier3;
		} else if (Player.NightWitchTier == 3) {
			NightWitchNextTierCards = Player.CardsToTier4;
		} else if (Player.NightWitchTier == 4) {
			NightWitchNextTierCards = Player.CardsToTier5;
		} else if (Player.NightWitchTier == 5) {
			NightWitchNextTierCards = Player.CardsToTier6;
		} else if (Player.NightWitchTier == 6) {
			NightWitchNextTierCards = Player.CardsToTier7;
		} else if (Player.NightWitchTier == 7) {
			NightWitchNextTierCards = Player.CardsToTier8;
		} else if (Player.NightWitchTier == 8) {
			NightWitchNextTierCards = Player.CardsToTier9;
		} else if (Player.NightWitchTier == 9) {
			NightWitchNextTierCards = Player.CardsToTier10;
		} else if (Player.NightWitchTier == 10) {
			NightWitchNextTierCards = Player.CardsToTier11;
		} else if (Player.NightWitchTier == 11) {
			NightWitchNextTierCards = Player.CardsToTier12;
		} else if (Player.NightWitchTier == 12) {
			NightWitchNextTierCards = Player.CardsToTier13;
		} else if (Player.NightWitchTier == 13) {
			NightWitchNextTierCards = 0;
		} else {
			NightWitchNextTierCards = 0;
		}
	}

	public void UpgradeTierNightWitch () {
		if (Player.NightWitchCards >= NightWitchNextTierCards && Player.NightWitchTier <= 12) {
			Player.NightWitchCards -= NightWitchNextTierCards;
			Player.NightWitchTier += 1;
			Player.Experience += troopManager.NightWitch.ExperiencePerTier;
			Player.Trophys += troopManager.NightWitch.TrophysPerTier;
			kasernUI.UpgradeTierNightWitchUI ();
			CheckNightWitchTierCards ();
			CalculateNightWitchStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeLumberjack () {
		if (Player.Elix >= Player.LumberjackElixCost) {
			Player.Elix -= Player.LumberjackElixCost;
			Player.LumberjackLevel += 1;
			Player.Experience += troopManager.Lumberjack.ExperiencePerLevel;
			Player.Trophys += troopManager.Lumberjack.TrophysPerLevel;
			CalculateLumberjackStats ();
			CalculateNewLumberjackCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateLumberjackStats () {
		troopManager.Lumberjack.CoinsPerTime = (float) troopManager.Lumberjack.DefaultCoinsPerTime + (troopManager.Lumberjack.CoinsPerTimeAddPerLevel * Player.LumberjackLevel) + (troopManager.Lumberjack.CoinsPerTimeAddPerTier * Player.LumberjackTier);
		troopManager.Lumberjack.CoinCollectDuration = (float) troopManager.Lumberjack.DefaultCoinCollectDuration + (troopManager.Lumberjack.CoinsCollectDurationChangePerTier * Player.LumberjackTier);
		lumberjack.NewStats ();
	}

	public void CalculateNewLumberjackCost() {
		x = (float) Mathf.Pow(1.15f , Player.LumberjackLevel);
		Player.LumberjackElixCost = Mathf.FloorToInt((float) troopManager.Lumberjack.DefaultElixCost * x);
		kasernUI.UpgradeLumberjackUI ();
	}

	public void CheckLumberjackTierCards () {
		if (Player.LumberjackTier == 0) {
			LumberjackNextTierCards = Player.CardsToTier1;
		} else if (Player.LumberjackTier == 1) {
			LumberjackNextTierCards = Player.CardsToTier2;
		} else if (Player.LumberjackTier == 2) {
			LumberjackNextTierCards = Player.CardsToTier3;
		} else if (Player.LumberjackTier == 3) {
			LumberjackNextTierCards = Player.CardsToTier4;
		} else if (Player.LumberjackTier == 4) {
			LumberjackNextTierCards = Player.CardsToTier5;
		} else if (Player.LumberjackTier == 5) {
			LumberjackNextTierCards = Player.CardsToTier6;
		} else if (Player.LumberjackTier == 6) {
			LumberjackNextTierCards = Player.CardsToTier7;
		} else if (Player.LumberjackTier == 7) {
			LumberjackNextTierCards = Player.CardsToTier8;
		} else if (Player.LumberjackTier == 8) {
			LumberjackNextTierCards = Player.CardsToTier9;
		} else if (Player.LumberjackTier == 9) {
			LumberjackNextTierCards = Player.CardsToTier10;
		} else if (Player.LumberjackTier == 10) {
			LumberjackNextTierCards = Player.CardsToTier11;
		} else if (Player.LumberjackTier == 11) {
			LumberjackNextTierCards = Player.CardsToTier12;
		} else if (Player.LumberjackTier == 12) {
			LumberjackNextTierCards = Player.CardsToTier13;
		} else if (Player.LumberjackTier == 13) {
			LumberjackNextTierCards = 0;
		} else {
			LumberjackNextTierCards = 0;
		}
	}

	public void UpgradeTierLumberjack () {
		if (Player.LumberjackCards >= LumberjackNextTierCards && Player.LumberjackTier <= 12) {
			Player.LumberjackCards -= LumberjackNextTierCards;
			Player.LumberjackTier += 1;
			Player.Experience += troopManager.Lumberjack.ExperiencePerTier;
			Player.Trophys += troopManager.Lumberjack.TrophysPerTier;
			kasernUI.UpgradeTierLumberjackUI ();
			CheckLumberjackTierCards ();
			CalculateLumberjackStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBowler () {
		if (Player.Elix >= Player.BowlerElixCost) {
			Player.Elix -= Player.BowlerElixCost;
			Player.BowlerLevel += 1;
			Player.Experience += troopManager.Bowler.ExperiencePerLevel;
			Player.Trophys += troopManager.Bowler.TrophysPerLevel;
			CalculateBowlerStats ();
			CalculateNewBowlerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBowlerStats () {
		troopManager.Bowler.CoinsPerTime = (float) troopManager.Bowler.DefaultCoinsPerTime + (troopManager.Bowler.CoinsPerTimeAddPerLevel * Player.BowlerLevel) + (troopManager.Bowler.CoinsPerTimeAddPerTier * Player.BowlerTier);
		troopManager.Bowler.CoinCollectDuration = (float) troopManager.Bowler.DefaultCoinCollectDuration + (troopManager.Bowler.CoinsCollectDurationChangePerTier * Player.BowlerTier);
		bowler.NewStats ();
	}

	public void CalculateNewBowlerCost() {
		x = (float) Mathf.Pow(1.15f , Player.BowlerLevel);
		Player.BowlerElixCost = Mathf.FloorToInt((float) troopManager.Bowler.DefaultElixCost * x);
		kasernUI.UpgradeBowlerUI ();
	}

	public void CheckBowlerTierCards () {
		if (Player.BowlerTier == 0) {
			BowlerNextTierCards = Player.CardsToTier1;
		} else if (Player.BowlerTier == 1) {
			BowlerNextTierCards = Player.CardsToTier2;
		} else if (Player.BowlerTier == 2) {
			BowlerNextTierCards = Player.CardsToTier3;
		} else if (Player.BowlerTier == 3) {
			BowlerNextTierCards = Player.CardsToTier4;
		} else if (Player.BowlerTier == 4) {
			BowlerNextTierCards = Player.CardsToTier5;
		} else if (Player.BowlerTier == 5) {
			BowlerNextTierCards = Player.CardsToTier6;
		} else if (Player.BowlerTier == 6) {
			BowlerNextTierCards = Player.CardsToTier7;
		} else if (Player.BowlerTier == 7) {
			BowlerNextTierCards = Player.CardsToTier8;
		} else if (Player.BowlerTier == 8) {
			BowlerNextTierCards = Player.CardsToTier9;
		} else if (Player.BowlerTier == 9) {
			BowlerNextTierCards = Player.CardsToTier10;
		} else if (Player.BowlerTier == 10) {
			BowlerNextTierCards = Player.CardsToTier11;
		} else if (Player.BowlerTier == 11) {
			BowlerNextTierCards = Player.CardsToTier12;
		} else if (Player.BowlerTier == 12) {
			BowlerNextTierCards = Player.CardsToTier13;
		} else if (Player.BowlerTier == 13) {
			BowlerNextTierCards = 0;
		} else {
			BowlerNextTierCards = 0;
		}
	}

	public void UpgradeTierBowler () {
		if (Player.BowlerCards >= BowlerNextTierCards && Player.BowlerTier <= 12) {
			Player.BowlerCards -= BowlerNextTierCards;
			Player.BowlerTier += 1;
			Player.Experience += troopManager.Bowler.ExperiencePerTier;
			Player.Trophys += troopManager.Bowler.TrophysPerTier;
			kasernUI.UpgradeTierBowlerUI ();
			CheckBowlerTierCards ();
			CalculateBowlerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 9

	public void UpgradeGoblinGang () {
		if (Player.Elix >= Player.GoblinGangElixCost) {
			Player.Elix -= Player.GoblinGangElixCost;
			Player.GoblinGangLevel += 1;
			Player.Experience += troopManager.GoblinGang.ExperiencePerLevel;
			Player.Trophys += troopManager.GoblinGang.TrophysPerLevel;
			CalculateGoblinGangStats ();
			CalculateNewGoblinGangCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGoblinGangStats () {
		troopManager.GoblinGang.CoinsPerTime = (float) troopManager.GoblinGang.DefaultCoinsPerTime + (troopManager.GoblinGang.CoinsPerTimeAddPerLevel * Player.GoblinGangLevel) + (troopManager.GoblinGang.CoinsPerTimeAddPerTier * Player.GoblinGangTier);
		troopManager.GoblinGang.CoinCollectDuration = (float) troopManager.GoblinGang.DefaultCoinCollectDuration + (troopManager.GoblinGang.CoinsCollectDurationChangePerTier * Player.GoblinGangTier);
		goblinGang.NewStats ();
	}

	public void CalculateNewGoblinGangCost() {
		x = (float) Mathf.Pow(1.15f , Player.GoblinGangLevel);
		Player.GoblinGangElixCost = Mathf.FloorToInt((float) troopManager.GoblinGang.DefaultElixCost * x);
		kasernUI.UpgradeGoblinGangUI ();
	}

	public void CheckGoblinGangTierCards () {
		if (Player.GoblinGangTier == 0) {
			GoblinGangNextTierCards = Player.CardsToTier1;
		} else if (Player.GoblinGangTier == 1) {
			GoblinGangNextTierCards = Player.CardsToTier2;
		} else if (Player.GoblinGangTier == 2) {
			GoblinGangNextTierCards = Player.CardsToTier3;
		} else if (Player.GoblinGangTier == 3) {
			GoblinGangNextTierCards = Player.CardsToTier4;
		} else if (Player.GoblinGangTier == 4) {
			GoblinGangNextTierCards = Player.CardsToTier5;
		} else if (Player.GoblinGangTier == 5) {
			GoblinGangNextTierCards = Player.CardsToTier6;
		} else if (Player.GoblinGangTier == 6) {
			GoblinGangNextTierCards = Player.CardsToTier7;
		} else if (Player.GoblinGangTier == 7) {
			GoblinGangNextTierCards = Player.CardsToTier8;
		} else if (Player.GoblinGangTier == 8) {
			GoblinGangNextTierCards = Player.CardsToTier9;
		} else if (Player.GoblinGangTier == 9) {
			GoblinGangNextTierCards = Player.CardsToTier10;
		} else if (Player.GoblinGangTier == 10) {
			GoblinGangNextTierCards = Player.CardsToTier11;
		} else if (Player.GoblinGangTier == 11) {
			GoblinGangNextTierCards = Player.CardsToTier12;
		} else if (Player.GoblinGangTier == 12) {
			GoblinGangNextTierCards = Player.CardsToTier13;
		} else if (Player.GoblinGangTier == 13) {
			GoblinGangNextTierCards = 0;
		} else {
			GoblinGangNextTierCards = 0;
		}
	}

	public void UpgradeTierGoblinGang () {
		if (Player.GoblinGangCards >= GoblinGangNextTierCards && Player.GoblinGangTier <= 12) {
			Player.GoblinGangCards -= GoblinGangNextTierCards;
			Player.GoblinGangTier += 1;
			Player.Experience += troopManager.GoblinGang.ExperiencePerTier;
			Player.Trophys += troopManager.GoblinGang.TrophysPerTier;
			kasernUI.UpgradeTierGoblinGangUI ();
			CheckGoblinGangTierCards ();
			CalculateGoblinGangStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeDartGoblin () {
		if (Player.Elix >= Player.DartGoblinElixCost) {
			Player.Elix -= Player.DartGoblinElixCost;
			Player.DartGoblinLevel += 1;
			Player.Experience += troopManager.DartGoblin.ExperiencePerLevel;
			Player.Trophys += troopManager.DartGoblin.TrophysPerLevel;
			CalculateDartGoblinStats ();
			CalculateNewDartGoblinCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateDartGoblinStats () {
		troopManager.DartGoblin.CoinsPerTime = (float) troopManager.DartGoblin.DefaultCoinsPerTime + (troopManager.DartGoblin.CoinsPerTimeAddPerLevel * Player.DartGoblinLevel) + (troopManager.DartGoblin.CoinsPerTimeAddPerTier * Player.DartGoblinTier);
		troopManager.DartGoblin.CoinCollectDuration = (float) troopManager.DartGoblin.DefaultCoinCollectDuration + (troopManager.DartGoblin.CoinsCollectDurationChangePerTier * Player.DartGoblinTier);
		dartGoblin.NewStats ();
	}

	public void CalculateNewDartGoblinCost() {
		x = (float) Mathf.Pow(1.15f , Player.DartGoblinLevel);
		Player.DartGoblinElixCost = Mathf.FloorToInt((float) troopManager.DartGoblin.DefaultElixCost * x);
		kasernUI.UpgradeDartGoblinUI ();
	}

	public void CheckDartGoblinTierCards () {
		if (Player.DartGoblinTier == 0) {
			DartGoblinNextTierCards = Player.CardsToTier1;
		} else if (Player.DartGoblinTier == 1) {
			DartGoblinNextTierCards = Player.CardsToTier2;
		} else if (Player.DartGoblinTier == 2) {
			DartGoblinNextTierCards = Player.CardsToTier3;
		} else if (Player.DartGoblinTier == 3) {
			DartGoblinNextTierCards = Player.CardsToTier4;
		} else if (Player.DartGoblinTier == 4) {
			DartGoblinNextTierCards = Player.CardsToTier5;
		} else if (Player.DartGoblinTier == 5) {
			DartGoblinNextTierCards = Player.CardsToTier6;
		} else if (Player.DartGoblinTier == 6) {
			DartGoblinNextTierCards = Player.CardsToTier7;
		} else if (Player.DartGoblinTier == 7) {
			DartGoblinNextTierCards = Player.CardsToTier8;
		} else if (Player.DartGoblinTier == 8) {
			DartGoblinNextTierCards = Player.CardsToTier9;
		} else if (Player.DartGoblinTier == 9) {
			DartGoblinNextTierCards = Player.CardsToTier10;
		} else if (Player.DartGoblinTier == 10) {
			DartGoblinNextTierCards = Player.CardsToTier11;
		} else if (Player.DartGoblinTier == 11) {
			DartGoblinNextTierCards = Player.CardsToTier12;
		} else if (Player.DartGoblinTier == 12) {
			DartGoblinNextTierCards = Player.CardsToTier13;
		} else if (Player.DartGoblinTier == 13) {
			DartGoblinNextTierCards = 0;
		} else {
			DartGoblinNextTierCards = 0;
		}
	}

	public void UpgradeTierDartGoblin () {
		if (Player.DartGoblinCards >= DartGoblinNextTierCards && Player.DartGoblinTier <= 12) {
			Player.DartGoblinCards -= DartGoblinNextTierCards;
			Player.DartGoblinTier += 1;
			Player.Experience += troopManager.DartGoblin.ExperiencePerTier;
			Player.Trophys += troopManager.DartGoblin.TrophysPerTier;
			kasernUI.UpgradeTierDartGoblinUI ();
			CheckDartGoblinTierCards ();
			CalculateDartGoblinStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeBandit () {
		if (Player.Elix >= Player.BanditElixCost) {
			Player.Elix -= Player.BanditElixCost;
			Player.BanditLevel += 1;
			Player.Experience += troopManager.Bandit.ExperiencePerLevel;
			Player.Trophys += troopManager.Bandit.TrophysPerLevel;
			CalculateBanditStats ();
			CalculateNewBanditCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBanditStats () {
		troopManager.Bandit.CoinsPerTime = (float) troopManager.Bandit.DefaultCoinsPerTime + (troopManager.Bandit.CoinsPerTimeAddPerLevel * Player.BanditLevel) + (troopManager.Bandit.CoinsPerTimeAddPerTier * Player.BanditTier);
		troopManager.Bandit.CoinCollectDuration = (float) troopManager.Bandit.DefaultCoinCollectDuration + (troopManager.Bandit.CoinsCollectDurationChangePerTier * Player.BanditTier);
		bandit.NewStats ();
	}

	public void CalculateNewBanditCost() {
		x = (float) Mathf.Pow(1.15f , Player.BanditLevel);
		Player.BanditElixCost = Mathf.FloorToInt((float) troopManager.Bandit.DefaultElixCost * x);
		kasernUI.UpgradeBanditUI ();
	}

	public void CheckBanditTierCards () {
		if (Player.BanditTier == 0) {
			BanditNextTierCards = Player.CardsToTier1;
		} else if (Player.BanditTier == 1) {
			BanditNextTierCards = Player.CardsToTier2;
		} else if (Player.BanditTier == 2) {
			BanditNextTierCards = Player.CardsToTier3;
		} else if (Player.BanditTier == 3) {
			BanditNextTierCards = Player.CardsToTier4;
		} else if (Player.BanditTier == 4) {
			BanditNextTierCards = Player.CardsToTier5;
		} else if (Player.BanditTier == 5) {
			BanditNextTierCards = Player.CardsToTier6;
		} else if (Player.BanditTier == 6) {
			BanditNextTierCards = Player.CardsToTier7;
		} else if (Player.BanditTier == 7) {
			BanditNextTierCards = Player.CardsToTier8;
		} else if (Player.BanditTier == 8) {
			BanditNextTierCards = Player.CardsToTier9;
		} else if (Player.BanditTier == 9) {
			BanditNextTierCards = Player.CardsToTier10;
		} else if (Player.BanditTier == 10) {
			BanditNextTierCards = Player.CardsToTier11;
		} else if (Player.BanditTier == 11) {
			BanditNextTierCards = Player.CardsToTier12;
		} else if (Player.BanditTier == 12) {
			BanditNextTierCards = Player.CardsToTier13;
		} else if (Player.BanditTier == 13) {
			BanditNextTierCards = 0;
		} else {
			BanditNextTierCards = 0;
		}
	}

	public void UpgradeTierBandit () {
		if (Player.BanditCards >= BanditNextTierCards && Player.BanditTier <= 12) {
			Player.BanditCards -= BanditNextTierCards;
			Player.BanditTier += 1;
			Player.Experience += troopManager.Bandit.ExperiencePerTier;
			Player.Trophys += troopManager.Bandit.TrophysPerTier;
			kasernUI.UpgradeTierBanditUI ();
			CheckBanditTierCards ();
			CalculateBanditStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeFlyingMachine () {
		if (Player.Elix >= Player.FlyingMachineElixCost) {
			Player.Elix -= Player.FlyingMachineElixCost;
			Player.FlyingMachineLevel += 1;
			Player.Experience += troopManager.FlyingMachine.ExperiencePerLevel;
			Player.Trophys += troopManager.FlyingMachine.TrophysPerLevel;
			CalculateFlyingMachineStats ();
			CalculateNewFlyingMachineCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateFlyingMachineStats () {
		troopManager.FlyingMachine.CoinsPerTime = (float) troopManager.FlyingMachine.DefaultCoinsPerTime + (troopManager.FlyingMachine.CoinsPerTimeAddPerLevel * Player.FlyingMachineLevel) + (troopManager.FlyingMachine.CoinsPerTimeAddPerTier * Player.FlyingMachineTier);
		troopManager.FlyingMachine.CoinCollectDuration = (float) troopManager.FlyingMachine.DefaultCoinCollectDuration + (troopManager.FlyingMachine.CoinsCollectDurationChangePerTier * Player.FlyingMachineTier);
		flyingMachine.NewStats ();
	}

	public void CalculateNewFlyingMachineCost() {
		x = (float) Mathf.Pow(1.15f , Player.FlyingMachineLevel);
		Player.FlyingMachineElixCost = Mathf.FloorToInt((float) troopManager.FlyingMachine.DefaultElixCost * x);
		kasernUI.UpgradeFlyingMachineUI ();
	}

	public void CheckFlyingMachineTierCards () {
		if (Player.FlyingMachineTier == 0) {
			FlyingMachineNextTierCards = Player.CardsToTier1;
		} else if (Player.FlyingMachineTier == 1) {
			FlyingMachineNextTierCards = Player.CardsToTier2;
		} else if (Player.FlyingMachineTier == 2) {
			FlyingMachineNextTierCards = Player.CardsToTier3;
		} else if (Player.FlyingMachineTier == 3) {
			FlyingMachineNextTierCards = Player.CardsToTier4;
		} else if (Player.FlyingMachineTier == 4) {
			FlyingMachineNextTierCards = Player.CardsToTier5;
		} else if (Player.FlyingMachineTier == 5) {
			FlyingMachineNextTierCards = Player.CardsToTier6;
		} else if (Player.FlyingMachineTier == 6) {
			FlyingMachineNextTierCards = Player.CardsToTier7;
		} else if (Player.FlyingMachineTier == 7) {
			FlyingMachineNextTierCards = Player.CardsToTier8;
		} else if (Player.FlyingMachineTier == 8) {
			FlyingMachineNextTierCards = Player.CardsToTier9;
		} else if (Player.FlyingMachineTier == 9) {
			FlyingMachineNextTierCards = Player.CardsToTier10;
		} else if (Player.FlyingMachineTier == 10) {
			FlyingMachineNextTierCards = Player.CardsToTier11;
		} else if (Player.FlyingMachineTier == 11) {
			FlyingMachineNextTierCards = Player.CardsToTier12;
		} else if (Player.FlyingMachineTier == 12) {
			FlyingMachineNextTierCards = Player.CardsToTier13;
		} else if (Player.FlyingMachineTier == 13) {
			FlyingMachineNextTierCards = 0;
		} else {
			FlyingMachineNextTierCards = 0;
		}
	}

	public void UpgradeTierFlyingMachine () {
		if (Player.FlyingMachineCards >= FlyingMachineNextTierCards && Player.FlyingMachineTier <= 12) {
			Player.FlyingMachineCards -= FlyingMachineNextTierCards;
			Player.FlyingMachineTier += 1;
			Player.Experience += troopManager.FlyingMachine.ExperiencePerTier;
			Player.Trophys += troopManager.FlyingMachine.TrophysPerTier;
			kasernUI.UpgradeTierFlyingMachineUI ();
			CheckFlyingMachineTierCards ();
			CalculateFlyingMachineStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeHunter () {
		if (Player.Elix >= Player.HunterElixCost) {
			Player.Elix -= Player.HunterElixCost;
			Player.HunterLevel += 1;
			Player.Experience += troopManager.Hunter.ExperiencePerLevel;
			Player.Trophys += troopManager.Hunter.TrophysPerLevel;
			CalculateHunterStats ();
			CalculateNewHunterCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateHunterStats () {
		troopManager.Hunter.CoinsPerTime = (float) troopManager.Hunter.DefaultCoinsPerTime + (troopManager.Hunter.CoinsPerTimeAddPerLevel * Player.HunterLevel) + (troopManager.Hunter.CoinsPerTimeAddPerTier * Player.HunterTier);
		troopManager.Hunter.CoinCollectDuration = (float) troopManager.Hunter.DefaultCoinCollectDuration + (troopManager.Hunter.CoinsCollectDurationChangePerTier * Player.HunterTier);
		hunter.NewStats ();
	}

	public void CalculateNewHunterCost() {
		x = (float) Mathf.Pow(1.15f , Player.HunterLevel);
		Player.HunterElixCost = Mathf.FloorToInt((float) troopManager.Hunter.DefaultElixCost * x);
		kasernUI.UpgradeHunterUI ();
	}

	public void CheckHunterTierCards () {
		if (Player.HunterTier == 0) {
			HunterNextTierCards = Player.CardsToTier1;
		} else if (Player.HunterTier == 1) {
			HunterNextTierCards = Player.CardsToTier2;
		} else if (Player.HunterTier == 2) {
			HunterNextTierCards = Player.CardsToTier3;
		} else if (Player.HunterTier == 3) {
			HunterNextTierCards = Player.CardsToTier4;
		} else if (Player.HunterTier == 4) {
			HunterNextTierCards = Player.CardsToTier5;
		} else if (Player.HunterTier == 5) {
			HunterNextTierCards = Player.CardsToTier6;
		} else if (Player.HunterTier == 6) {
			HunterNextTierCards = Player.CardsToTier7;
		} else if (Player.HunterTier == 7) {
			HunterNextTierCards = Player.CardsToTier8;
		} else if (Player.HunterTier == 8) {
			HunterNextTierCards = Player.CardsToTier9;
		} else if (Player.HunterTier == 9) {
			HunterNextTierCards = Player.CardsToTier10;
		} else if (Player.HunterTier == 10) {
			HunterNextTierCards = Player.CardsToTier11;
		} else if (Player.HunterTier == 11) {
			HunterNextTierCards = Player.CardsToTier12;
		} else if (Player.HunterTier == 12) {
			HunterNextTierCards = Player.CardsToTier13;
		} else if (Player.HunterTier == 13) {
			HunterNextTierCards = 0;
		} else {
			HunterNextTierCards = 0;
		}
	}

	public void UpgradeTierHunter () {
		if (Player.HunterCards >= HunterNextTierCards && Player.HunterTier <= 12) {
			Player.HunterCards -= HunterNextTierCards;
			Player.HunterTier += 1;
			Player.Experience += troopManager.Hunter.ExperiencePerTier;
			Player.Trophys += troopManager.Hunter.TrophysPerTier;
			kasernUI.UpgradeTierHunterUI ();
			CheckHunterTierCards ();
			CalculateHunterStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeExecutioner () {
		if (Player.Elix >= Player.ExecutionerElixCost) {
			Player.Elix -= Player.ExecutionerElixCost;
			Player.ExecutionerLevel += 1;
			Player.Experience += troopManager.Executioner.ExperiencePerLevel;
			Player.Trophys += troopManager.Executioner.TrophysPerLevel;
			CalculateExecutionerStats ();
			CalculateNewExecutionerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateExecutionerStats () {
		troopManager.Executioner.CoinsPerTime = (float) troopManager.Executioner.DefaultCoinsPerTime + (troopManager.Executioner.CoinsPerTimeAddPerLevel * Player.ExecutionerLevel) + (troopManager.Executioner.CoinsPerTimeAddPerTier * Player.ExecutionerTier);
		troopManager.Executioner.CoinCollectDuration = (float) troopManager.Executioner.DefaultCoinCollectDuration + (troopManager.Executioner.CoinsCollectDurationChangePerTier * Player.ExecutionerTier);
		executioner.NewStats ();
	}

	public void CalculateNewExecutionerCost() {
		x = (float) Mathf.Pow(1.15f , Player.ExecutionerLevel);
		Player.ExecutionerElixCost = Mathf.FloorToInt((float) troopManager.Executioner.DefaultElixCost * x);
		kasernUI.UpgradeExecutionerUI ();
	}

	public void CheckExecutionerTierCards () {
		if (Player.ExecutionerTier == 0) {
			ExecutionerNextTierCards = Player.CardsToTier1;
		} else if (Player.ExecutionerTier == 1) {
			ExecutionerNextTierCards = Player.CardsToTier2;
		} else if (Player.ExecutionerTier == 2) {
			ExecutionerNextTierCards = Player.CardsToTier3;
		} else if (Player.ExecutionerTier == 3) {
			ExecutionerNextTierCards = Player.CardsToTier4;
		} else if (Player.ExecutionerTier == 4) {
			ExecutionerNextTierCards = Player.CardsToTier5;
		} else if (Player.ExecutionerTier == 5) {
			ExecutionerNextTierCards = Player.CardsToTier6;
		} else if (Player.ExecutionerTier == 6) {
			ExecutionerNextTierCards = Player.CardsToTier7;
		} else if (Player.ExecutionerTier == 7) {
			ExecutionerNextTierCards = Player.CardsToTier8;
		} else if (Player.ExecutionerTier == 8) {
			ExecutionerNextTierCards = Player.CardsToTier9;
		} else if (Player.ExecutionerTier == 9) {
			ExecutionerNextTierCards = Player.CardsToTier10;
		} else if (Player.ExecutionerTier == 10) {
			ExecutionerNextTierCards = Player.CardsToTier11;
		} else if (Player.ExecutionerTier == 11) {
			ExecutionerNextTierCards = Player.CardsToTier12;
		} else if (Player.ExecutionerTier == 12) {
			ExecutionerNextTierCards = Player.CardsToTier13;
		} else if (Player.ExecutionerTier == 13) {
			ExecutionerNextTierCards = 0;
		} else {
			ExecutionerNextTierCards = 0;
		}
	}

	public void UpgradeTierExecutioner () {
		if (Player.ExecutionerCards >= ExecutionerNextTierCards && Player.ExecutionerTier <= 12) {
			Player.ExecutionerCards -= ExecutionerNextTierCards;
			Player.ExecutionerTier += 1;
			Player.Experience += troopManager.Executioner.ExperiencePerTier;
			Player.Trophys += troopManager.Executioner.TrophysPerTier;
			kasernUI.UpgradeTierExecutionerUI ();
			CheckExecutionerTierCards ();
			CalculateExecutionerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 10

	public void UpgradeRoyalGhost () {
		if (Player.Elix >= Player.RoyalGhostElixCost) {
			Player.Elix -= Player.RoyalGhostElixCost;
			Player.RoyalGhostLevel += 1;
			Player.Experience += troopManager.RoyalGhost.ExperiencePerLevel;
			Player.Trophys += troopManager.RoyalGhost.TrophysPerLevel;
			CalculateRoyalGhostStats ();
			CalculateNewRoyalGhostCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateRoyalGhostStats () {
		troopManager.RoyalGhost.CoinsPerTime = (float) troopManager.RoyalGhost.DefaultCoinsPerTime + (troopManager.RoyalGhost.CoinsPerTimeAddPerLevel * Player.RoyalGhostLevel) + (troopManager.RoyalGhost.CoinsPerTimeAddPerTier * Player.RoyalGhostTier);
		troopManager.RoyalGhost.CoinCollectDuration = (float) troopManager.RoyalGhost.DefaultCoinCollectDuration + (troopManager.RoyalGhost.CoinsCollectDurationChangePerTier * Player.RoyalGhostTier);
		royalGhost.NewStats ();
	}

	public void CalculateNewRoyalGhostCost() {
		x = (float) Mathf.Pow(1.15f , Player.RoyalGhostLevel);
		Player.RoyalGhostElixCost = Mathf.FloorToInt((float) troopManager.RoyalGhost.DefaultElixCost * x);
		kasernUI.UpgradeRoyalGhostUI ();
	}

	public void CheckRoyalGhostTierCards () {
		if (Player.RoyalGhostTier == 0) {
			RoyalGhostNextTierCards = Player.CardsToTier1;
		} else if (Player.RoyalGhostTier == 1) {
			RoyalGhostNextTierCards = Player.CardsToTier2;
		} else if (Player.RoyalGhostTier == 2) {
			RoyalGhostNextTierCards = Player.CardsToTier3;
		} else if (Player.RoyalGhostTier == 3) {
			RoyalGhostNextTierCards = Player.CardsToTier4;
		} else if (Player.RoyalGhostTier == 4) {
			RoyalGhostNextTierCards = Player.CardsToTier5;
		} else if (Player.RoyalGhostTier == 5) {
			RoyalGhostNextTierCards = Player.CardsToTier6;
		} else if (Player.RoyalGhostTier == 6) {
			RoyalGhostNextTierCards = Player.CardsToTier7;
		} else if (Player.RoyalGhostTier == 7) {
			RoyalGhostNextTierCards = Player.CardsToTier8;
		} else if (Player.RoyalGhostTier == 8) {
			RoyalGhostNextTierCards = Player.CardsToTier9;
		} else if (Player.RoyalGhostTier == 9) {
			RoyalGhostNextTierCards = Player.CardsToTier10;
		} else if (Player.RoyalGhostTier == 10) {
			RoyalGhostNextTierCards = Player.CardsToTier11;
		} else if (Player.RoyalGhostTier == 11) {
			RoyalGhostNextTierCards = Player.CardsToTier12;
		} else if (Player.RoyalGhostTier == 12) {
			RoyalGhostNextTierCards = Player.CardsToTier13;
		} else if (Player.RoyalGhostTier == 13) {
			RoyalGhostNextTierCards = 0;
		} else {
			RoyalGhostNextTierCards = 0;
		}
	}

	public void UpgradeTierRoyalGhost () {
		if (Player.RoyalGhostCards >= RoyalGhostNextTierCards && Player.RoyalGhostTier <= 12) {
			Player.RoyalGhostCards -= RoyalGhostNextTierCards;
			Player.RoyalGhostTier += 1;
			Player.Experience += troopManager.RoyalGhost.ExperiencePerTier;
			Player.Trophys += troopManager.RoyalGhost.TrophysPerTier;
			kasernUI.UpgradeTierRoyalGhostUI ();
			CheckRoyalGhostTierCards ();
			CalculateRoyalGhostStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeCannonCart () {
		if (Player.Elix >= Player.CannonCartElixCost) {
			Player.Elix -= Player.CannonCartElixCost;
			Player.CannonCartLevel += 1;
			Player.Experience += troopManager.CannonCart.ExperiencePerLevel;
			Player.Trophys += troopManager.CannonCart.TrophysPerLevel;
			CalculateCannonCartStats ();
			CalculateNewCannonCartCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateCannonCartStats () {
		troopManager.CannonCart.CoinsPerTime = (float) troopManager.CannonCart.DefaultCoinsPerTime + (troopManager.CannonCart.CoinsPerTimeAddPerLevel * Player.CannonCartLevel) + (troopManager.CannonCart.CoinsPerTimeAddPerTier * Player.CannonCartTier);
		troopManager.CannonCart.CoinCollectDuration = (float) troopManager.CannonCart.DefaultCoinCollectDuration + (troopManager.CannonCart.CoinsCollectDurationChangePerTier * Player.CannonCartTier);
		cannonCart.NewStats ();
	}

	public void CalculateNewCannonCartCost() {
		x = (float) Mathf.Pow(1.15f , Player.CannonCartLevel);
		Player.CannonCartElixCost = Mathf.FloorToInt((float) troopManager.CannonCart.DefaultElixCost * x);
		kasernUI.UpgradeCannonCartUI ();
	}

	public void CheckCannonCartTierCards () {
		if (Player.CannonCartTier == 0) {
			CannonCartNextTierCards = Player.CardsToTier1;
		} else if (Player.CannonCartTier == 1) {
			CannonCartNextTierCards = Player.CardsToTier2;
		} else if (Player.CannonCartTier == 2) {
			CannonCartNextTierCards = Player.CardsToTier3;
		} else if (Player.CannonCartTier == 3) {
			CannonCartNextTierCards = Player.CardsToTier4;
		} else if (Player.CannonCartTier == 4) {
			CannonCartNextTierCards = Player.CardsToTier5;
		} else if (Player.CannonCartTier == 5) {
			CannonCartNextTierCards = Player.CardsToTier6;
		} else if (Player.CannonCartTier == 6) {
			CannonCartNextTierCards = Player.CardsToTier7;
		} else if (Player.CannonCartTier == 7) {
			CannonCartNextTierCards = Player.CardsToTier8;
		} else if (Player.CannonCartTier == 8) {
			CannonCartNextTierCards = Player.CardsToTier9;
		} else if (Player.CannonCartTier == 9) {
			CannonCartNextTierCards = Player.CardsToTier10;
		} else if (Player.CannonCartTier == 10) {
			CannonCartNextTierCards = Player.CardsToTier11;
		} else if (Player.CannonCartTier == 11) {
			CannonCartNextTierCards = Player.CardsToTier12;
		} else if (Player.CannonCartTier == 12) {
			CannonCartNextTierCards = Player.CardsToTier13;
		} else if (Player.CannonCartTier == 13) {
			CannonCartNextTierCards = 0;
		} else {
			CannonCartNextTierCards = 0;
		}
	}

	public void UpgradeTierCannonCart () {
		if (Player.CannonCartCards >= CannonCartNextTierCards && Player.CannonCartTier <= 12) {
			Player.CannonCartCards -= CannonCartNextTierCards;
			Player.CannonCartTier += 1;
			Player.Experience += troopManager.CannonCart.ExperiencePerTier;
			Player.Trophys += troopManager.CannonCart.TrophysPerTier;
			kasernUI.UpgradeTierCannonCartUI ();
			CheckCannonCartTierCards ();
			CalculateCannonCartStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMegaKnight () {
		if (Player.Elix >= Player.MegaKnightElixCost) {
			Player.Elix -= Player.MegaKnightElixCost;
			Player.MegaKnightLevel += 1;
			Player.Experience += troopManager.MegaKnight.ExperiencePerLevel;
			Player.Trophys += troopManager.MegaKnight.TrophysPerLevel;
			CalculateMegaKnightStats ();
			CalculateNewMegaKnightCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMegaKnightStats () {
		troopManager.MegaKnight.CoinsPerTime = (float) troopManager.MegaKnight.DefaultCoinsPerTime + (troopManager.MegaKnight.CoinsPerTimeAddPerLevel * Player.MegaKnightLevel) + (troopManager.MegaKnight.CoinsPerTimeAddPerTier * Player.MegaKnightTier);
		troopManager.MegaKnight.CoinCollectDuration = (float) troopManager.MegaKnight.DefaultCoinCollectDuration + (troopManager.MegaKnight.CoinsCollectDurationChangePerTier * Player.MegaKnightTier);
		megaKnight.NewStats ();
	}

	public void CalculateNewMegaKnightCost() {
		x = (float) Mathf.Pow(1.15f , Player.MegaKnightLevel);
		Player.MegaKnightElixCost = Mathf.FloorToInt((float) troopManager.MegaKnight.DefaultElixCost * x);
		kasernUI.UpgradeMegaKnightUI ();
	}

	public void CheckMegaKnightTierCards () {
		if (Player.MegaKnightTier == 0) {
			MegaKnightNextTierCards = Player.CardsToTier1;
		} else if (Player.MegaKnightTier == 1) {
			MegaKnightNextTierCards = Player.CardsToTier2;
		} else if (Player.MegaKnightTier == 2) {
			MegaKnightNextTierCards = Player.CardsToTier3;
		} else if (Player.MegaKnightTier == 3) {
			MegaKnightNextTierCards = Player.CardsToTier4;
		} else if (Player.MegaKnightTier == 4) {
			MegaKnightNextTierCards = Player.CardsToTier5;
		} else if (Player.MegaKnightTier == 5) {
			MegaKnightNextTierCards = Player.CardsToTier6;
		} else if (Player.MegaKnightTier == 6) {
			MegaKnightNextTierCards = Player.CardsToTier7;
		} else if (Player.MegaKnightTier == 7) {
			MegaKnightNextTierCards = Player.CardsToTier8;
		} else if (Player.MegaKnightTier == 8) {
			MegaKnightNextTierCards = Player.CardsToTier9;
		} else if (Player.MegaKnightTier == 9) {
			MegaKnightNextTierCards = Player.CardsToTier10;
		} else if (Player.MegaKnightTier == 10) {
			MegaKnightNextTierCards = Player.CardsToTier11;
		} else if (Player.MegaKnightTier == 11) {
			MegaKnightNextTierCards = Player.CardsToTier12;
		} else if (Player.MegaKnightTier == 12) {
			MegaKnightNextTierCards = Player.CardsToTier13;
		} else if (Player.MegaKnightTier == 13) {
			MegaKnightNextTierCards = 0;
		} else {
			MegaKnightNextTierCards = 0;
		}
	}

	public void UpgradeTierMegaKnight () {
		if (Player.MegaKnightCards >= MegaKnightNextTierCards && Player.MegaKnightTier <= 12) {
			Player.MegaKnightCards -= MegaKnightNextTierCards;
			Player.MegaKnightTier += 1;
			Player.Experience += troopManager.MegaKnight.ExperiencePerTier;
			Player.Trophys += troopManager.MegaKnight.TrophysPerTier;
			kasernUI.UpgradeTierMegaKnightUI ();
			CheckMegaKnightTierCards ();
			CalculateMegaKnightStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	// arena 11

	public void UpgradeZappies () {
		if (Player.Elix >= Player.ZappiesElixCost) {
			Player.Elix -= Player.ZappiesElixCost;
			Player.ZappiesLevel += 1;
			Player.Experience += troopManager.Zappies.ExperiencePerLevel;
			Player.Trophys += troopManager.Zappies.TrophysPerLevel;
			CalculateZappiesStats ();
			CalculateNewZappiesCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateZappiesStats () {
		troopManager.Zappies.CoinsPerTime = (float) troopManager.Zappies.DefaultCoinsPerTime + (troopManager.Zappies.CoinsPerTimeAddPerLevel * Player.ZappiesLevel) + (troopManager.Zappies.CoinsPerTimeAddPerTier * Player.ZappiesTier);
		troopManager.Zappies.CoinCollectDuration = (float) troopManager.Zappies.DefaultCoinCollectDuration + (troopManager.Zappies.CoinsCollectDurationChangePerTier * Player.ZappiesTier);
		zappies.NewStats ();
	}

	public void CalculateNewZappiesCost() {
		x = (float) Mathf.Pow(1.15f , Player.ZappiesLevel);
		Player.ZappiesElixCost = Mathf.FloorToInt((float) troopManager.Zappies.DefaultElixCost * x);
		kasernUI.UpgradeZappiesUI ();
	}

	public void CheckZappiesTierCards () {
		if (Player.ZappiesTier == 0) {
			ZappiesNextTierCards = Player.CardsToTier1;
		} else if (Player.ZappiesTier == 1) {
			ZappiesNextTierCards = Player.CardsToTier2;
		} else if (Player.ZappiesTier == 2) {
			ZappiesNextTierCards = Player.CardsToTier3;
		} else if (Player.ZappiesTier == 3) {
			ZappiesNextTierCards = Player.CardsToTier4;
		} else if (Player.ZappiesTier == 4) {
			ZappiesNextTierCards = Player.CardsToTier5;
		} else if (Player.ZappiesTier == 5) {
			ZappiesNextTierCards = Player.CardsToTier6;
		} else if (Player.ZappiesTier == 6) {
			ZappiesNextTierCards = Player.CardsToTier7;
		} else if (Player.ZappiesTier == 7) {
			ZappiesNextTierCards = Player.CardsToTier8;
		} else if (Player.ZappiesTier == 8) {
			ZappiesNextTierCards = Player.CardsToTier9;
		} else if (Player.ZappiesTier == 9) {
			ZappiesNextTierCards = Player.CardsToTier10;
		} else if (Player.ZappiesTier == 10) {
			ZappiesNextTierCards = Player.CardsToTier11;
		} else if (Player.ZappiesTier == 11) {
			ZappiesNextTierCards = Player.CardsToTier12;
		} else if (Player.ZappiesTier == 12) {
			ZappiesNextTierCards = Player.CardsToTier13;
		} else if (Player.ZappiesTier == 13) {
			ZappiesNextTierCards = 0;
		} else {
			ZappiesNextTierCards = 0;
		}
	}

	public void UpgradeTierZappies () {
		if (Player.ZappiesCards >= ZappiesNextTierCards && Player.ZappiesTier <= 12) {
			Player.ZappiesCards -= ZappiesNextTierCards;
			Player.ZappiesTier += 1;
			Player.Experience += troopManager.Zappies.ExperiencePerTier;
			Player.Trophys += troopManager.Zappies.TrophysPerTier;
			kasernUI.UpgradeTierZappiesUI ();
			CheckZappiesTierCards ();
			CalculateZappiesStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeMagicalArcher () {
		if (Player.Elix >= Player.MagicalArcherElixCost) {
			Player.Elix -= Player.MagicalArcherElixCost;
			Player.MagicalArcherLevel += 1;
			Player.Experience += troopManager.MagicalArcher.ExperiencePerLevel;
			Player.Trophys += troopManager.MagicalArcher.TrophysPerLevel;
			CalculateMagicalArcherStats ();
			CalculateNewMagicalArcherCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMagicalArcherStats () {
		troopManager.MagicalArcher.CoinsPerTime = (float) troopManager.MagicalArcher.DefaultCoinsPerTime + (troopManager.MagicalArcher.CoinsPerTimeAddPerLevel * Player.MagicalArcherLevel) + (troopManager.MagicalArcher.CoinsPerTimeAddPerTier * Player.MagicalArcherTier);
		troopManager.MagicalArcher.CoinCollectDuration = (float) troopManager.MagicalArcher.DefaultCoinCollectDuration + (troopManager.MagicalArcher.CoinsCollectDurationChangePerTier * Player.MagicalArcherTier);
		magicalArcher.NewStats ();
	}

	public void CalculateNewMagicalArcherCost() {
		x = (float) Mathf.Pow(1.15f , Player.MagicalArcherLevel);
		Player.MagicalArcherElixCost = Mathf.FloorToInt((float) troopManager.MagicalArcher.DefaultElixCost * x);
		kasernUI.UpgradeMagicalArcherUI ();
	}

	public void CheckMagicalArcherTierCards () {
		if (Player.MagicalArcherTier == 0) {
			MagicalArcherNextTierCards = Player.CardsToTier1;
		} else if (Player.MagicalArcherTier == 1) {
			MagicalArcherNextTierCards = Player.CardsToTier2;
		} else if (Player.MagicalArcherTier == 2) {
			MagicalArcherNextTierCards = Player.CardsToTier3;
		} else if (Player.MagicalArcherTier == 3) {
			MagicalArcherNextTierCards = Player.CardsToTier4;
		} else if (Player.MagicalArcherTier == 4) {
			MagicalArcherNextTierCards = Player.CardsToTier5;
		} else if (Player.MagicalArcherTier == 5) {
			MagicalArcherNextTierCards = Player.CardsToTier6;
		} else if (Player.MagicalArcherTier == 6) {
			MagicalArcherNextTierCards = Player.CardsToTier7;
		} else if (Player.MagicalArcherTier == 7) {
			MagicalArcherNextTierCards = Player.CardsToTier8;
		} else if (Player.MagicalArcherTier == 8) {
			MagicalArcherNextTierCards = Player.CardsToTier9;
		} else if (Player.MagicalArcherTier == 9) {
			MagicalArcherNextTierCards = Player.CardsToTier10;
		} else if (Player.MagicalArcherTier == 10) {
			MagicalArcherNextTierCards = Player.CardsToTier11;
		} else if (Player.MagicalArcherTier == 11) {
			MagicalArcherNextTierCards = Player.CardsToTier12;
		} else if (Player.MagicalArcherTier == 12) {
			MagicalArcherNextTierCards = Player.CardsToTier13;
		} else if (Player.MagicalArcherTier == 13) {
			MagicalArcherNextTierCards = 0;
		} else {
			MagicalArcherNextTierCards = 0;
		}
	}

	public void UpgradeTierMagicalArcher () {
		if (Player.MagicalArcherCards >= MagicalArcherNextTierCards && Player.MagicalArcherTier <= 12) {
			Player.MagicalArcherCards -= MagicalArcherNextTierCards;
			Player.MagicalArcherTier += 1;
			Player.Experience += troopManager.MagicalArcher.ExperiencePerTier;
			Player.Trophys += troopManager.MagicalArcher.TrophysPerTier;
			kasernUI.UpgradeTierMagicalArcherUI ();
			CheckMagicalArcherTierCards ();
			CalculateMagicalArcherStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

}
