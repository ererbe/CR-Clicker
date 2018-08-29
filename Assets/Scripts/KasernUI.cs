using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KasernUI : MonoBehaviour {

	public TroopManager troopManager;

	public Text CostTextSkeleton;
	public Text CostTextArchers;
	public Text CostTextKnight;
	public Text CostTextBomber;
	public Text CostTextSkeletonArmy;
	public Text CostTextMusketeer;
	public Text CostTextMiniPekka;
	public Text CostTextBabyDragon;
	public Text CostTextGiant;  
	public Text CostTextPrince;
	public Text CostTextWitch;
	public Text CostTextGoblins;
	public Text CostTextSpearGoblins;
	public Text CostTextValkyrie;
	public Text CostTextMinions;
	public Text CostTextBallon;
	public Text CostTextGiantSkeleton;
	public Text CostTextBabarians;
	public Text CostTextHogRaider;
	public Text CostTextInfernoDragon;
	public Text CostTextMinionHorde;
	public Text CostTextPekka;
	public Text CostTextLavaHound;
	public Text CostTextFireSpirits;
	public Text CostTextIceWizard;
	public Text CostTextWizard;
	public Text CostTextSkeletonBarrel;
	public Text CostTextMiner;
	public Text CostTextBattleRam;
	public Text CostTextSparky;
	public Text CostTextGolem;
	public Text CostTextMegaMinion;
	public Text CostTextGuards;
	public Text CostTextPrincess;
	public Text CostTextDarkPrince;
	public Text CostTextElectroWizard;
	public Text CostTextRoyalGiant;
	public Text CostTextEliteBarbarians;
	public Text CostTextThreeMusketeers;
	public Text CostTextIceSpirit;
	public Text CostTextBats;
	public Text CostTextIceGolem;
	public Text CostTextNightWitch;
	public Text CostTextLumberjack;
	public Text CostTextBowler;
	public Text CostTextGoblinGang;
	public Text CostTextDartGoblin;
	public Text CostTextBandit;
	public Text CostTextFlyingMachine;
	public Text CostTextHunter;
	public Text CostTextExecutioner;
	public Text CostTextRoyalGhost;
	public Text CostTextCannonCart;
	public Text CostTextMegaKnight;
	public Text CostTextZappies;
	public Text CostTextMagicalArcher;

	void OnEnable () {
		UpdateAnything ();
	}

	public void UpdateAnything () {
		if (Player.Language == 1) {
			SkeletonName.text = troopManager.Skeleton.TroopNameEnglisch;
			ArchersName.text = troopManager.Archers.TroopNameEnglisch;
			KnightName.text = troopManager.Knight.TroopNameEnglisch;
			BomberName.text = troopManager.Bomber.TroopNameEnglisch;
			SkeletonArmyName.text = troopManager.SkeletonArmy.TroopNameEnglisch;
			MusketeerName.text = troopManager.Musketeer.TroopNameEnglisch;
			MiniPekkaName.text = troopManager.MiniPekka.TroopNameEnglisch;
			BabyDragonName.text = troopManager.BabyDragon.TroopNameEnglisch;
			GiantName.text = troopManager.Giant.TroopNameEnglisch;
			PrinceName.text = troopManager.Prince.TroopNameEnglisch;
			WitchName.text = troopManager.Witch.TroopNameEnglisch;
			GoblinsName.text = troopManager.Goblins.TroopNameEnglisch;
			SpearGoblinsName.text = troopManager.SpearGoblins.TroopNameEnglisch;
			ValkyrieName.text = troopManager.Valkyrie.TroopNameEnglisch;
			MinionsName.text = troopManager.Minions.TroopNameEnglisch;
			BallonName.text = troopManager.Ballon.TroopNameEnglisch;
			GiantSkeletonName.text = troopManager.GiantSkeleton.TroopNameEnglisch;
			BabariansName.text = troopManager.Babarians.TroopNameEnglisch;
			HogRaiderName.text = troopManager.HogRaider.TroopNameEnglisch;
			InfernoDragonName.text = troopManager.InfernoDragon.TroopNameEnglisch;
			MinionHordeName.text = troopManager.MinionHorde.TroopNameEnglisch;
			PekkaName.text = troopManager.Pekka.TroopNameEnglisch;
			LavaHoundName.text = troopManager.LavaHound.TroopNameEnglisch;
			FireSpiritsName.text = troopManager.FireSpirits.TroopNameEnglisch;
			IceWizardName.text = troopManager.IceWizard.TroopNameEnglisch;
			WizardName.text = troopManager.Wizard.TroopNameEnglisch;
			SkeletonBarrelName.text = troopManager.SkeletonBarrel.TroopNameEnglisch;
			MinerName.text = troopManager.Miner.TroopNameEnglisch;
			BattleRamName.text = troopManager.BattleRam.TroopNameEnglisch;
			SparkyName.text = troopManager.Sparky.TroopNameEnglisch;
			GolemName.text = troopManager.Golem.TroopNameEnglisch;
			MegaMinionName.text = troopManager.MegaMinion.TroopNameEnglisch;
			GuardsName.text = troopManager.Guards.TroopNameEnglisch;
			PrincessName.text = troopManager.Princess.TroopNameEnglisch;
			DarkPrinceName.text = troopManager.DarkPrince.TroopNameEnglisch;
			ElectroWizardName.text = troopManager.ElectroWizard.TroopNameEnglisch;
			RoyalGiantName.text = troopManager.RoyalGiant.TroopNameEnglisch;
			EliteBarbariansName.text = troopManager.EliteBarbarians.TroopNameEnglisch;
			ThreeMusketeersName.text = troopManager.ThreeMusketeers.TroopNameEnglisch;
			IceSpiritName.text = troopManager.IceSpirit.TroopNameEnglisch;
			BatsName.text = troopManager.Bats.TroopNameEnglisch;
			IceGolemName.text = troopManager.IceGolem.TroopNameEnglisch;
			NightWitchName.text = troopManager.NightWitch.TroopNameEnglisch;
			LumberjackName.text = troopManager.Lumberjack.TroopNameEnglisch;
			BowlerName.text = troopManager.Bowler.TroopNameEnglisch;
			GoblinGangName.text = troopManager.GoblinGang.TroopNameEnglisch;
			DartGoblinName.text = troopManager.DartGoblin.TroopNameEnglisch;
			BanditName.text = troopManager.Bandit.TroopNameEnglisch;
			FlyingMachineName.text = troopManager.FlyingMachine.TroopNameEnglisch;
			HunterName.text = troopManager.Hunter.TroopNameEnglisch;
			ExecutionerName.text = troopManager.Executioner.TroopNameEnglisch;
			RoyalGhostName.text = troopManager.RoyalGhost.TroopNameEnglisch;
			CannonCartName.text = troopManager.CannonCart.TroopNameEnglisch;
			MegaKnightName.text = troopManager.MegaKnight.TroopNameEnglisch;
			ZappiesName.text = troopManager.Zappies.TroopNameEnglisch;
			MagicalArcherName.text = troopManager.MagicalArcher.TroopNameEnglisch;

			CostTextSkeleton.text = "Cost:";
			CostTextArchers.text = "Cost:";
			CostTextKnight.text = "Cost:";
			CostTextBomber.text = "Cost:";
			CostTextSkeletonArmy.text = "Cost:";
			CostTextMusketeer.text = "Cost:";
			CostTextMiniPekka.text = "Cost:";
			CostTextBabyDragon.text = "Cost:";
			CostTextGiant.text = "Cost:";
			CostTextPrince.text = "Cost:";
			CostTextWitch.text = "Cost:";
			CostTextGoblins.text = "Cost:";
			CostTextSpearGoblins.text = "Cost:";
			CostTextValkyrie.text = "Cost:";
			CostTextMinions.text = "Cost:";
			CostTextBallon.text = "Cost:";
			CostTextGiantSkeleton.text = "Cost:";
			CostTextBabarians.text = "Cost:";
			CostTextHogRaider.text = "Cost:";
			CostTextInfernoDragon.text = "Cost:";
			CostTextMinionHorde.text = "Cost:";
			CostTextPekka.text = "Cost:";
			CostTextLavaHound.text = "Cost:";
			CostTextFireSpirits.text = "Cost:";
			CostTextIceWizard.text = "Cost:";
			CostTextWizard.text = "Cost:";
			CostTextSkeletonBarrel.text = "Cost:";
			CostTextMiner.text = "Cost:";
			CostTextBattleRam.text = "Cost:";
			CostTextSparky.text = "Cost:";
			CostTextGolem.text = "Cost:";
			CostTextMegaMinion.text = "Cost:";
			CostTextGuards.text = "Cost:";
			CostTextPrincess.text = "Cost:";
			CostTextDarkPrince.text = "Cost:";
			CostTextElectroWizard.text = "Cost:";
			CostTextRoyalGiant.text = "Cost:";
			CostTextEliteBarbarians.text = "Cost:";
			CostTextThreeMusketeers.text = "Cost:";
			CostTextIceSpirit.text = "Cost:";
			CostTextBats.text = "Cost:";
			CostTextIceGolem.text = "Cost:";
			CostTextNightWitch.text = "Cost:";
			CostTextLumberjack.text = "Cost:";
			CostTextBowler.text = "Cost:";
			CostTextGoblinGang.text = "Cost:";
			CostTextDartGoblin.text = "Cost:";
			CostTextBandit.text = "Cost:";
			CostTextFlyingMachine.text = "Cost:";
			CostTextHunter.text = "Cost:";
			CostTextExecutioner.text = "Cost:";
			CostTextRoyalGhost.text = "Cost:";
			CostTextCannonCart.text = "Cost:";
			CostTextMegaKnight.text = "Cost:";
			CostTextZappies.text = "Cost:";
			CostTextMagicalArcher.text = "Cost:";

		} else if (Player.Language == 2) {
			SkeletonName.text = troopManager.Skeleton.TroopNameGerman;
			ArchersName.text = troopManager.Archers.TroopNameGerman;
			KnightName.text = troopManager.Knight.TroopNameGerman;
			BomberName.text = troopManager.Bomber.TroopNameGerman;
			SkeletonArmyName.text = troopManager.SkeletonArmy.TroopNameGerman;
			MusketeerName.text = troopManager.Musketeer.TroopNameGerman;
			MiniPekkaName.text = troopManager.MiniPekka.TroopNameGerman;
			BabyDragonName.text = troopManager.BabyDragon.TroopNameGerman;
			GiantName.text = troopManager.Giant.TroopNameGerman;
			PrinceName.text = troopManager.Prince.TroopNameGerman;
			WitchName.text = troopManager.Witch.TroopNameGerman;
			GoblinsName.text = troopManager.Goblins.TroopNameGerman;
			SpearGoblinsName.text = troopManager.SpearGoblins.TroopNameGerman;
			ValkyrieName.text = troopManager.Valkyrie.TroopNameGerman;
			MinionsName.text = troopManager.Minions.TroopNameGerman;
			BallonName.text = troopManager.Ballon.TroopNameGerman;
			GiantSkeletonName.text = troopManager.GiantSkeleton.TroopNameGerman;
			BabariansName.text = troopManager.Babarians.TroopNameGerman;
			MinionHordeName.text = troopManager.MinionHorde.TroopNameGerman;
			PekkaName.text = troopManager.Pekka.TroopNameGerman;
			LavaHoundName.text = troopManager.LavaHound.TroopNameGerman;
			FireSpiritsName.text = troopManager.FireSpirits.TroopNameGerman;
			IceWizardName.text = troopManager.IceWizard.TroopNameGerman;
			WizardName.text = troopManager.Wizard.TroopNameGerman;
			SkeletonBarrelName.text = troopManager.SkeletonBarrel.TroopNameGerman;
			MinerName.text = troopManager.Miner.TroopNameGerman;
			BattleRamName.text = troopManager.BattleRam.TroopNameGerman;
			SparkyName.text = troopManager.Sparky.TroopNameGerman;
			GolemName.text = troopManager.Golem.TroopNameGerman;
			MegaMinionName.text = troopManager.MegaMinion.TroopNameGerman;
			GuardsName.text = troopManager.Guards.TroopNameGerman;
			PrincessName.text = troopManager.Princess.TroopNameGerman;
			DarkPrinceName.text = troopManager.DarkPrince.TroopNameGerman;
			ElectroWizardName.text = troopManager.ElectroWizard.TroopNameGerman;
			RoyalGiantName.text = troopManager.RoyalGiant.TroopNameGerman;
			EliteBarbariansName.text = troopManager.EliteBarbarians.TroopNameGerman;
			ThreeMusketeersName.text = troopManager.ThreeMusketeers.TroopNameGerman;
			IceSpiritName.text = troopManager.IceSpirit.TroopNameGerman;
			BatsName.text = troopManager.Bats.TroopNameGerman;
			IceGolemName.text = troopManager.IceGolem.TroopNameGerman;
			NightWitchName.text = troopManager.NightWitch.TroopNameGerman;
			LumberjackName.text = troopManager.Lumberjack.TroopNameGerman;
			BowlerName.text = troopManager.Bowler.TroopNameGerman;
			GoblinGangName.text = troopManager.GoblinGang.TroopNameGerman;
			DartGoblinName.text = troopManager.DartGoblin.TroopNameGerman;
			BanditName.text = troopManager.Bandit.TroopNameGerman;
			FlyingMachineName.text = troopManager.FlyingMachine.TroopNameGerman;
			HunterName.text = troopManager.Hunter.TroopNameGerman;
			ExecutionerName.text = troopManager.Executioner.TroopNameGerman;
			RoyalGhostName.text = troopManager.RoyalGhost.TroopNameGerman;
			CannonCartName.text = troopManager.CannonCart.TroopNameGerman;
			MegaKnightName.text = troopManager.MegaKnight.TroopNameGerman;
			ZappiesName.text = troopManager.Zappies.TroopNameGerman;
			MagicalArcherName.text = troopManager.MagicalArcher.TroopNameGerman;

			CostTextSkeleton.text = "Kosten:";
			CostTextArchers.text = "Kosten:";
			CostTextKnight.text = "Kosten:";
			CostTextBomber.text = "Kosten:";
			CostTextSkeletonArmy.text = "Kosten:";
			CostTextMusketeer.text = "Kosten:";
			CostTextMiniPekka.text = "Kosten:";
			CostTextBabyDragon.text = "Kosten:";
			CostTextGiant.text = "Kosten:";
			CostTextPrince.text = "Kosten:";
			CostTextWitch.text = "Kosten:";
			CostTextGoblins.text = "Kosten:";
			CostTextSpearGoblins.text = "Kosten:";
			CostTextValkyrie.text = "Kosten:";
			CostTextMinions.text = "Kosten:";
			CostTextBallon.text = "Kosten:";
			CostTextGiantSkeleton.text = "Kosten:";
			CostTextBabarians.text = "Kosten:";
			CostTextHogRaider.text = "Kosten:";
			CostTextInfernoDragon.text = "Kosten:";
			CostTextMinionHorde.text = "Kosten:";
			CostTextPekka.text = "Kosten:";
			CostTextLavaHound.text = "Kosten:";
			CostTextFireSpirits.text = "Kosten:";
			CostTextIceWizard.text = "Kosten:";
			CostTextWizard.text = "Kosten:";
			CostTextSkeletonBarrel.text = "Kosten:";
			CostTextMiner.text = "Kosten:";
			CostTextBattleRam.text = "Kosten:";
			CostTextSparky.text = "Kosten:";
			CostTextGolem.text = "Kosten:";
			CostTextMegaMinion.text = "Kosten:";
			CostTextGuards.text = "Kosten:";
			CostTextPrincess.text = "Kosten:";
			CostTextDarkPrince.text = "Kosten:";
			CostTextElectroWizard.text = "Kosten:";
			CostTextRoyalGiant.text = "Kosten:";
			CostTextEliteBarbarians.text = "Kosten:";
			CostTextThreeMusketeers.text = "Kosten:";
			CostTextIceSpirit.text = "Kosten:";
			CostTextBats.text = "Kosten:";
			CostTextIceGolem.text = "Kosten:";
			CostTextNightWitch.text = "Kosten:";
			CostTextLumberjack.text = "Kosten:";
			CostTextBowler.text = "Kosten:";
			CostTextGoblinGang.text = "Kosten:";
			CostTextDartGoblin.text = "Kosten:";
			CostTextBandit.text = "Kosten:";
			CostTextFlyingMachine.text = "Kosten:";
			CostTextHunter.text = "Kosten:";
			CostTextExecutioner.text = "Kosten:";
			CostTextRoyalGhost.text = "Kosten:";
			CostTextCannonCart.text = "Kosten:";
			CostTextMegaKnight.text = "Kosten:";
			CostTextZappies.text = "Kosten:";
			CostTextMagicalArcher.text = "Kosten:";
		}
		CheckSkeletonUI ();
		CheckArchersUI ();
		CheckKnightUI ();
		CheckBomberUI ();
		CheckSkeletonArmyUI ();
		CheckMusketeerUI ();
		CheckMiniPekkaUI ();
		CheckBabyDragonUI ();
		CheckGiantUI ();
		CheckPrinceUI ();
		CheckWitchUI ();
		CheckGoblinsUI ();
		CheckSpearGoblinsUI ();
		CheckValkyrieUI ();
		CheckMinionsUI ();
		CheckBallonUI ();
		CheckGiantSkeletonUI ();
		CheckBabariansUI ();
		CheckHogRaiderUI ();
		CheckInfernoDragonUI ();
		CheckMinionHordeUI ();
		CheckPekkaUI ();
		CheckLavaHoundUI ();
		CheckFireSpiritsUI ();
		CheckIceWizardUI ();
		CheckWizardUI ();
		CheckSkeletonBarrelUI ();
		CheckMinerUI ();
		CheckBattleRamUI ();
		CheckSparkyUI ();
		CheckGolemUI ();
		CheckMegaMinionUI ();
		CheckGuardsUI ();
		CheckPrincessUI ();
		CheckDarkPrinceUI ();
		CheckElectroWizardUI ();
		CheckRoyalGiantUI ();
		CheckEliteBarbariansUI ();
		CheckThreeMusketeersUI ();
		CheckIceSpiritUI ();
		CheckBatsUI ();
		CheckIceGolemUI ();
		CheckNightWitchUI ();
		CheckLumberjackUI ();
		CheckBowlerUI ();
		CheckGoblinGangUI ();
		CheckDartGoblinUI ();
		CheckBanditUI ();
		CheckFlyingMachineUI ();
		CheckHunterUI ();
		CheckExecutionerUI ();
		CheckRoyalGhostUI ();
		CheckCannonCartUI ();
		CheckMegaKnightUI ();
		CheckZappiesUI ();
		CheckMagicalArcherUI ();
	}

	public Text SkeletonName;
	public Text SkeletonCost;
	public Text SkeletonLevel;
	public Text SkeletonTier;
	public Text SkeletonCardCurrent;
	public Text SkeletonCardNextTier;
	public Image SkeletonTierProgress;

	void CheckSkeletonUI () {
		SkeletonCost.text = Player.SkeletonElixCost.ToString ();  
		SkeletonLevel.text = Player.SkeletonLevel.ToString ();
		SkeletonTier.text = Player.SkeletonTier.ToString ();
		SkeletonCardCurrent.text = Player.SkeletonCards.ToString ();
		SkeletonCardNextTier.text = Kasern.SkeletonNextTierCards.ToString();
		SkeletonTierProgress.fillAmount = (float) Player.SkeletonCards / Kasern.SkeletonNextTierCards;
	}

	public void UpgradeSkeletonUI () {
		SkeletonCost.text = Player.SkeletonElixCost.ToString ();
		SkeletonLevel.text = Player.SkeletonLevel.ToString ();
	}

	public void UpgradeTierSkeletonUI () {
		SkeletonTier.text = Player.SkeletonTier.ToString ();
		SkeletonCardCurrent.text = Player.SkeletonCards.ToString ();
		SkeletonCardNextTier.text = Kasern.SkeletonNextTierCards.ToString();
		SkeletonTierProgress.fillAmount = (float) Player.SkeletonCards / Kasern.SkeletonNextTierCards;
	}

	public Text ArchersName;
	public Text ArchersCost;
	public Text ArchersLevel;
	public Text ArchersTier;
	public Text ArchersCardCurrent;
	public Text ArchersCardNextTier;
	public Image ArchersTierProgress;

	void CheckArchersUI () {
		ArchersCost.text = Player.ArchersElixCost.ToString ();  
		ArchersLevel.text = Player.ArchersLevel.ToString ();
		ArchersTier.text = Player.ArchersTier.ToString ();
		ArchersCardCurrent.text = Player.ArchersCards.ToString ();
		ArchersCardNextTier.text = Kasern.ArchersNextTierCards.ToString();
		ArchersTierProgress.fillAmount = (float) Player.ArchersCards / Kasern.ArchersNextTierCards;
	}

	public void UpgradeArchersUI () {
		ArchersCost.text = Player.ArchersElixCost.ToString ();
		ArchersLevel.text = Player.ArchersLevel.ToString ();
	}

	public void UpgradeTierArchersUI () {
		ArchersTier.text = Player.ArchersTier.ToString ();
		ArchersCardCurrent.text = Player.ArchersCards.ToString ();
		ArchersCardNextTier.text = Kasern.ArchersNextTierCards.ToString();
		ArchersTierProgress.fillAmount = (float) Player.ArchersCards / Kasern.ArchersNextTierCards;
	}

	public Text KnightName;
	public Text KnightCost;
	public Text KnightLevel;
	public Text KnightTier;
	public Text KnightCardCurrent;
	public Text KnightCardNextTier;
	public Image KnightTierProgress;

	void CheckKnightUI () {
		KnightCost.text = Player.KnightElixCost.ToString ();  
		KnightLevel.text = Player.KnightLevel.ToString ();
		KnightTier.text = Player.KnightTier.ToString ();
		KnightCardCurrent.text = Player.KnightCards.ToString ();
		KnightCardNextTier.text = Kasern.KnightNextTierCards.ToString();
		KnightTierProgress.fillAmount = (float) Player.KnightCards / Kasern.KnightNextTierCards;
	}

	public void UpgradeKnightUI () {
		KnightCost.text = Player.KnightElixCost.ToString ();
		KnightLevel.text = Player.KnightLevel.ToString ();
	}

	public void UpgradeTierKnightUI () {
		KnightTier.text = Player.KnightTier.ToString ();
		KnightCardCurrent.text = Player.KnightCards.ToString ();
		KnightCardNextTier.text = Kasern.KnightNextTierCards.ToString();
		KnightTierProgress.fillAmount = (float) Player.KnightCards / Kasern.KnightNextTierCards;
	}

	public Text BomberName;
	public Text BomberCost;
	public Text BomberLevel;
	public Text BomberTier;
	public Text BomberCardCurrent;
	public Text BomberCardNextTier;
	public Image BomberTierProgress;

	void CheckBomberUI () {
		BomberCost.text = Player.BomberElixCost.ToString ();  
		BomberLevel.text = Player.BomberLevel.ToString ();
		BomberTier.text = Player.BomberTier.ToString ();
		BomberCardCurrent.text = Player.BomberCards.ToString ();
		BomberCardNextTier.text = Kasern.BomberNextTierCards.ToString();
		BomberTierProgress.fillAmount = (float) Player.BomberCards / Kasern.BomberNextTierCards;
	}

	public void UpgradeBomberUI () {
		BomberCost.text = Player.BomberElixCost.ToString ();
		BomberLevel.text = Player.BomberLevel.ToString ();
	}

	public void UpgradeTierBomberUI () {
		BomberTier.text = Player.BomberTier.ToString ();
		BomberCardCurrent.text = Player.BomberCards.ToString ();
		BomberCardNextTier.text = Kasern.BomberNextTierCards.ToString();
		BomberTierProgress.fillAmount = (float) Player.BomberCards / Kasern.BomberNextTierCards;
	}

	public Text SkeletonArmyName;
	public Text SkeletonArmyCost;
	public Text SkeletonArmyLevel;
	public Text SkeletonArmyTier;
	public Text SkeletonArmyCardCurrent;
	public Text SkeletonArmyCardNextTier;
	public Image SkeletonArmyTierProgress;

	void CheckSkeletonArmyUI () {
		SkeletonArmyCost.text = Player.SkeletonArmyElixCost.ToString ();  
		SkeletonArmyLevel.text = Player.SkeletonArmyLevel.ToString ();
		SkeletonArmyTier.text = Player.SkeletonArmyTier.ToString ();
		SkeletonArmyCardCurrent.text = Player.SkeletonArmyCards.ToString ();
		SkeletonArmyCardNextTier.text = Kasern.SkeletonArmyNextTierCards.ToString();
		SkeletonArmyTierProgress.fillAmount = (float) Player.SkeletonArmyCards / Kasern.SkeletonArmyNextTierCards;
	}

	public void UpgradeSkeletonArmyUI () {
		SkeletonArmyCost.text = Player.SkeletonArmyElixCost.ToString ();
		SkeletonArmyLevel.text = Player.SkeletonArmyLevel.ToString ();
	}

	public void UpgradeTierSkeletonArmyUI () {
		SkeletonArmyTier.text = Player.SkeletonArmyTier.ToString ();
		SkeletonArmyCardCurrent.text = Player.SkeletonArmyCards.ToString ();
		SkeletonArmyCardNextTier.text = Kasern.SkeletonArmyNextTierCards.ToString();
		SkeletonArmyTierProgress.fillAmount = (float) Player.SkeletonArmyCards / Kasern.SkeletonArmyNextTierCards;
	}

	public Text MusketeerName;
	public Text MusketeerCost;
	public Text MusketeerLevel;
	public Text MusketeerTier;
	public Text MusketeerCardCurrent;
	public Text MusketeerCardNextTier;
	public Image MusketeerTierProgress;

	void CheckMusketeerUI () {
		MusketeerCost.text = Player.MusketeerElixCost.ToString ();  
		MusketeerLevel.text = Player.MusketeerLevel.ToString ();
		MusketeerTier.text = Player.MusketeerTier.ToString ();
		MusketeerCardCurrent.text = Player.MusketeerCards.ToString ();
		MusketeerCardNextTier.text = Kasern.MusketeerNextTierCards.ToString();
		MusketeerTierProgress.fillAmount = (float) Player.MusketeerCards / Kasern.MusketeerNextTierCards;
	}

	public void UpgradeMusketeerUI () {
		MusketeerCost.text = Player.MusketeerElixCost.ToString ();
		MusketeerLevel.text = Player.MusketeerLevel.ToString ();
	}

	public void UpgradeTierMusketeerUI () {
		MusketeerTier.text = Player.MusketeerTier.ToString ();
		MusketeerCardCurrent.text = Player.MusketeerCards.ToString ();
		MusketeerCardNextTier.text = Kasern.MusketeerNextTierCards.ToString();
		MusketeerTierProgress.fillAmount = (float) Player.MusketeerCards / Kasern.MusketeerNextTierCards;
	}

	public Text MiniPekkaName;
	public Text MiniPekkaCost;
	public Text MiniPekkaLevel;
	public Text MiniPekkaTier;
	public Text MiniPekkaCardCurrent;
	public Text MiniPekkaCardNextTier;
	public Image MiniPekkaTierProgress;

	void CheckMiniPekkaUI () {
		MiniPekkaCost.text = Player.MiniPekkaElixCost.ToString ();  
		MiniPekkaLevel.text = Player.MiniPekkaLevel.ToString ();
		MiniPekkaTier.text = Player.MiniPekkaTier.ToString ();
		MiniPekkaCardCurrent.text = Player.MiniPekkaCards.ToString ();
		MiniPekkaCardNextTier.text = Kasern.MiniPekkaNextTierCards.ToString();
		MiniPekkaTierProgress.fillAmount = (float) Player.MiniPekkaCards / Kasern.MiniPekkaNextTierCards;
	}

	public void UpgradeMiniPekkaUI () {
		MiniPekkaCost.text = Player.MiniPekkaElixCost.ToString ();
		MiniPekkaLevel.text = Player.MiniPekkaLevel.ToString ();
	}

	public void UpgradeTierMiniPekkaUI () {
		MiniPekkaTier.text = Player.MiniPekkaTier.ToString ();
		MiniPekkaCardCurrent.text = Player.MiniPekkaCards.ToString ();
		MiniPekkaCardNextTier.text = Kasern.MiniPekkaNextTierCards.ToString();
		MiniPekkaTierProgress.fillAmount = (float) Player.MiniPekkaCards / Kasern.MiniPekkaNextTierCards;
	}

	public Text BabyDragonName;
	public Text BabyDragonCost;
	public Text BabyDragonLevel;
	public Text BabyDragonTier;
	public Text BabyDragonCardCurrent;
	public Text BabyDragonCardNextTier;
	public Image BabyDragonTierProgress;

	void CheckBabyDragonUI () {
		BabyDragonCost.text = Player.BabyDragonElixCost.ToString ();  
		BabyDragonLevel.text = Player.BabyDragonLevel.ToString ();
		BabyDragonTier.text = Player.BabyDragonTier.ToString ();
		BabyDragonCardCurrent.text = Player.BabyDragonCards.ToString ();
		BabyDragonCardNextTier.text = Kasern.BabyDragonNextTierCards.ToString();
		BabyDragonTierProgress.fillAmount = (float) Player.BabyDragonCards / Kasern.BabyDragonNextTierCards;
	}

	public void UpgradeBabyDragonUI () {
		BabyDragonCost.text = Player.BabyDragonElixCost.ToString ();
		BabyDragonLevel.text = Player.BabyDragonLevel.ToString ();
	}

	public void UpgradeTierBabyDragonUI () {
		BabyDragonTier.text = Player.BabyDragonTier.ToString ();
		BabyDragonCardCurrent.text = Player.BabyDragonCards.ToString ();
		BabyDragonCardNextTier.text = Kasern.BabyDragonNextTierCards.ToString();
		BabyDragonTierProgress.fillAmount = (float) Player.BabyDragonCards / Kasern.BabyDragonNextTierCards;
	}

	public Text GiantName;
	public Text GiantCost;
	public Text GiantLevel;
	public Text GiantTier;
	public Text GiantCardCurrent;
	public Text GiantCardNextTier;
	public Image GiantTierProgress;

	void CheckGiantUI () {
		GiantCost.text = Player.GiantElixCost.ToString ();  
		GiantLevel.text = Player.GiantLevel.ToString ();
		GiantTier.text = Player.GiantTier.ToString ();
		GiantCardCurrent.text = Player.GiantCards.ToString ();
		GiantCardNextTier.text = Kasern.GiantNextTierCards.ToString();
		GiantTierProgress.fillAmount = (float) Player.GiantCards / Kasern.GiantNextTierCards;
	}

	public void UpgradeGiantUI () {
		GiantCost.text = Player.GiantElixCost.ToString ();
		GiantLevel.text = Player.GiantLevel.ToString ();
	}

	public void UpgradeTierGiantUI () {
		GiantTier.text = Player.GiantTier.ToString ();
		GiantCardCurrent.text = Player.GiantCards.ToString ();
		GiantCardNextTier.text = Kasern.GiantNextTierCards.ToString();
		GiantTierProgress.fillAmount = (float) Player.GiantCards / Kasern.GiantNextTierCards;
	}

	public Text PrinceName;
	public Text PrinceCost;
	public Text PrinceLevel;
	public Text PrinceTier;
	public Text PrinceCardCurrent;
	public Text PrinceCardNextTier;
	public Image PrinceTierProgress;

	void CheckPrinceUI () {
		PrinceCost.text = Player.PrinceElixCost.ToString ();  
		PrinceLevel.text = Player.PrinceLevel.ToString ();
		PrinceTier.text = Player.PrinceTier.ToString ();
		PrinceCardCurrent.text = Player.PrinceCards.ToString ();
		PrinceCardNextTier.text = Kasern.PrinceNextTierCards.ToString();
		PrinceTierProgress.fillAmount = (float) Player.PrinceCards / Kasern.PrinceNextTierCards;
	}

	public void UpgradePrinceUI () {
		PrinceCost.text = Player.PrinceElixCost.ToString ();
		PrinceLevel.text = Player.PrinceLevel.ToString ();
	}

	public void UpgradeTierPrinceUI () {
		PrinceTier.text = Player.PrinceTier.ToString ();
		PrinceCardCurrent.text = Player.PrinceCards.ToString ();
		PrinceCardNextTier.text = Kasern.PrinceNextTierCards.ToString();
		PrinceTierProgress.fillAmount = (float) Player.PrinceCards / Kasern.PrinceNextTierCards;
	}

	public Text WitchName;
	public Text WitchCost;
	public Text WitchLevel;
	public Text WitchTier;
	public Text WitchCardCurrent;
	public Text WitchCardNextTier;
	public Image WitchTierProgress;

	void CheckWitchUI () {
		WitchCost.text = Player.WitchElixCost.ToString ();  
		WitchLevel.text = Player.WitchLevel.ToString ();
		WitchTier.text = Player.WitchTier.ToString ();
		WitchCardCurrent.text = Player.WitchCards.ToString ();
		WitchCardNextTier.text = Kasern.WitchNextTierCards.ToString();
		WitchTierProgress.fillAmount = (float) Player.WitchCards / Kasern.WitchNextTierCards;
	}

	public void UpgradeWitchUI () {
		WitchCost.text = Player.WitchElixCost.ToString ();
		WitchLevel.text = Player.WitchLevel.ToString ();
	}

	public void UpgradeTierWitchUI () {
		WitchTier.text = Player.WitchTier.ToString ();
		WitchCardCurrent.text = Player.WitchCards.ToString ();
		WitchCardNextTier.text = Kasern.WitchNextTierCards.ToString();
		WitchTierProgress.fillAmount = (float) Player.WitchCards / Kasern.WitchNextTierCards;
	}
		
	public Text GoblinsName;
	public Text GoblinsCost;
	public Text GoblinsLevel;
	public Text GoblinsTier;
	public Text GoblinsCardCurrent;
	public Text GoblinsCardNextTier;
	public Image GoblinsTierProgress;

	void CheckGoblinsUI () {
		GoblinsCost.text = Player.GoblinsElixCost.ToString ();  
		GoblinsLevel.text = Player.GoblinsLevel.ToString ();
		GoblinsTier.text = Player.GoblinsTier.ToString ();
		GoblinsCardCurrent.text = Player.GoblinsCards.ToString ();
		GoblinsCardNextTier.text = Kasern.GoblinsNextTierCards.ToString();
		GoblinsTierProgress.fillAmount = (float) Player.GoblinsCards / Kasern.GoblinsNextTierCards;
	}

	public void UpgradeGoblinsUI () {
		GoblinsCost.text = Player.GoblinsElixCost.ToString ();
		GoblinsLevel.text = Player.GoblinsLevel.ToString ();
	}

	public void UpgradeTierGoblinsUI () {
		GoblinsTier.text = Player.GoblinsTier.ToString ();
		GoblinsCardCurrent.text = Player.GoblinsCards.ToString ();
		GoblinsCardNextTier.text = Kasern.GoblinsNextTierCards.ToString();
		GoblinsTierProgress.fillAmount = (float) Player.GoblinsCards / Kasern.GoblinsNextTierCards;
	}

	public Text SpearGoblinsName;
	public Text SpearGoblinsCost;
	public Text SpearGoblinsLevel;
	public Text SpearGoblinsTier;
	public Text SpearGoblinsCardCurrent;
	public Text SpearGoblinsCardNextTier;
	public Image SpearGoblinsTierProgress;

	void CheckSpearGoblinsUI () {
		SpearGoblinsCost.text = Player.SpearGoblinsElixCost.ToString ();  
		SpearGoblinsLevel.text = Player.SpearGoblinsLevel.ToString ();
		SpearGoblinsTier.text = Player.SpearGoblinsTier.ToString ();
		SpearGoblinsCardCurrent.text = Player.SpearGoblinsCards.ToString ();
		SpearGoblinsCardNextTier.text = Kasern.SpearGoblinsNextTierCards.ToString();
		SpearGoblinsTierProgress.fillAmount = (float) Player.SpearGoblinsCards / Kasern.SpearGoblinsNextTierCards;
	}

	public void UpgradeSpearGoblinsUI () {
		SpearGoblinsCost.text = Player.SpearGoblinsElixCost.ToString ();
		SpearGoblinsLevel.text = Player.SpearGoblinsLevel.ToString ();
	}

	public void UpgradeTierSpearGoblinsUI () {
		SpearGoblinsTier.text = Player.SpearGoblinsTier.ToString ();
		SpearGoblinsCardCurrent.text = Player.SpearGoblinsCards.ToString ();
		SpearGoblinsCardNextTier.text = Kasern.SpearGoblinsNextTierCards.ToString();
		SpearGoblinsTierProgress.fillAmount = (float) Player.SpearGoblinsCards / Kasern.SpearGoblinsNextTierCards;
	}

	public Text ValkyrieName;
	public Text ValkyrieCost;
	public Text ValkyrieLevel;
	public Text ValkyrieTier;
	public Text ValkyrieCardCurrent;
	public Text ValkyrieCardNextTier;
	public Image ValkyrieTierProgress;

	void CheckValkyrieUI () {
		ValkyrieCost.text = Player.ValkyrieElixCost.ToString ();  
		ValkyrieLevel.text = Player.ValkyrieLevel.ToString ();
		ValkyrieTier.text = Player.ValkyrieTier.ToString ();
		ValkyrieCardCurrent.text = Player.ValkyrieCards.ToString ();
		ValkyrieCardNextTier.text = Kasern.ValkyrieNextTierCards.ToString();
		ValkyrieTierProgress.fillAmount = (float) Player.ValkyrieCards / Kasern.ValkyrieNextTierCards;
	}

	public void UpgradeValkyrieUI () {
		ValkyrieCost.text = Player.ValkyrieElixCost.ToString ();
		ValkyrieLevel.text = Player.ValkyrieLevel.ToString ();
	}

	public void UpgradeTierValkyrieUI () {
		ValkyrieTier.text = Player.ValkyrieTier.ToString ();
		ValkyrieCardCurrent.text = Player.ValkyrieCards.ToString ();
		ValkyrieCardNextTier.text = Kasern.ValkyrieNextTierCards.ToString();
		ValkyrieTierProgress.fillAmount = (float) Player.ValkyrieCards / Kasern.ValkyrieNextTierCards;
	}

	public Text MinionsName;
	public Text MinionsCost;
	public Text MinionsLevel;
	public Text MinionsTier;
	public Text MinionsCardCurrent;
	public Text MinionsCardNextTier;
	public Image MinionsTierProgress;

	void CheckMinionsUI () {
		MinionsCost.text = Player.MinionsElixCost.ToString ();  
		MinionsLevel.text = Player.MinionsLevel.ToString ();
		MinionsTier.text = Player.MinionsTier.ToString ();
		MinionsCardCurrent.text = Player.MinionsCards.ToString ();
		MinionsCardNextTier.text = Kasern.MinionsNextTierCards.ToString();
		MinionsTierProgress.fillAmount = (float) Player.MinionsCards / Kasern.MinionsNextTierCards;
	}

	public void UpgradeMinionsUI () {
		MinionsCost.text = Player.MinionsElixCost.ToString ();
		MinionsLevel.text = Player.MinionsLevel.ToString ();
	}

	public void UpgradeTierMinionsUI () {
		MinionsTier.text = Player.MinionsTier.ToString ();
		MinionsCardCurrent.text = Player.MinionsCards.ToString ();
		MinionsCardNextTier.text = Kasern.MinionsNextTierCards.ToString();
		MinionsTierProgress.fillAmount = (float) Player.MinionsCards / Kasern.MinionsNextTierCards;
	}

	public Text BallonName;
	public Text BallonCost;
	public Text BallonLevel;
	public Text BallonTier;
	public Text BallonCardCurrent;
	public Text BallonCardNextTier;
	public Image BallonTierProgress;

	void CheckBallonUI () {
		BallonCost.text = Player.BallonElixCost.ToString ();  
		BallonLevel.text = Player.BallonLevel.ToString ();
		BallonTier.text = Player.BallonTier.ToString ();
		BallonCardCurrent.text = Player.BallonCards.ToString ();
		BallonCardNextTier.text = Kasern.BallonNextTierCards.ToString();
		BallonTierProgress.fillAmount = (float) Player.BallonCards / Kasern.BallonNextTierCards;
	}

	public void UpgradeBallonUI () {
		BallonCost.text = Player.BallonElixCost.ToString ();
		BallonLevel.text = Player.BallonLevel.ToString ();
	}

	public void UpgradeTierBallonUI () {
		BallonTier.text = Player.BallonTier.ToString ();
		BallonCardCurrent.text = Player.BallonCards.ToString ();
		BallonCardNextTier.text = Kasern.BallonNextTierCards.ToString();
		BallonTierProgress.fillAmount = (float) Player.BallonCards / Kasern.BallonNextTierCards;
	}

	public Text GiantSkeletonName;
	public Text GiantSkeletonCost;
	public Text GiantSkeletonLevel;
	public Text GiantSkeletonTier;
	public Text GiantSkeletonCardCurrent;
	public Text GiantSkeletonCardNextTier;
	public Image GiantSkeletonTierProgress;

	void CheckGiantSkeletonUI () {
		GiantSkeletonCost.text = Player.GiantSkeletonElixCost.ToString ();  
		GiantSkeletonLevel.text = Player.GiantSkeletonLevel.ToString ();
		GiantSkeletonTier.text = Player.GiantSkeletonTier.ToString ();
		GiantSkeletonCardCurrent.text = Player.GiantSkeletonCards.ToString ();
		GiantSkeletonCardNextTier.text = Kasern.GiantSkeletonNextTierCards.ToString();
		GiantSkeletonTierProgress.fillAmount = (float) Player.GiantSkeletonCards / Kasern.GiantSkeletonNextTierCards;
	}

	public void UpgradeGiantSkeletonUI () {
		GiantSkeletonCost.text = Player.GiantSkeletonElixCost.ToString ();
		GiantSkeletonLevel.text = Player.GiantSkeletonLevel.ToString ();
	}

	public void UpgradeTierGiantSkeletonUI () {
		GiantSkeletonTier.text = Player.GiantSkeletonTier.ToString ();
		GiantSkeletonCardCurrent.text = Player.GiantSkeletonCards.ToString ();
		GiantSkeletonCardNextTier.text = Kasern.GiantSkeletonNextTierCards.ToString();
		GiantSkeletonTierProgress.fillAmount = (float) Player.GiantSkeletonCards / Kasern.GiantSkeletonNextTierCards;
	}

	public Text BabariansName;
	public Text BabariansCost;
	public Text BabariansLevel;
	public Text BabariansTier;
	public Text BabariansCardCurrent;
	public Text BabariansCardNextTier;
	public Image BabariansTierProgress;

	void CheckBabariansUI () {
		BabariansCost.text = Player.BabariansElixCost.ToString ();  
		BabariansLevel.text = Player.BabariansLevel.ToString ();
		BabariansTier.text = Player.BabariansTier.ToString ();
		BabariansCardCurrent.text = Player.BabariansCards.ToString ();
		BabariansCardNextTier.text = Kasern.BabariansNextTierCards.ToString();
		BabariansTierProgress.fillAmount = (float) Player.BabariansCards / Kasern.BabariansNextTierCards;
	}

	public void UpgradeBabariansUI () {
		BabariansCost.text = Player.BabariansElixCost.ToString ();
		BabariansLevel.text = Player.BabariansLevel.ToString ();
	}

	public void UpgradeTierBabariansUI () {
		BabariansTier.text = Player.BabariansTier.ToString ();
		BabariansCardCurrent.text = Player.BabariansCards.ToString ();
		BabariansCardNextTier.text = Kasern.BabariansNextTierCards.ToString();
		BabariansTierProgress.fillAmount = (float) Player.BabariansCards / Kasern.BabariansNextTierCards;
	}

	public Text HogRaiderName;
	public Text HogRaiderCost;
	public Text HogRaiderLevel;
	public Text HogRaiderTier;
	public Text HogRaiderCardCurrent;
	public Text HogRaiderCardNextTier;
	public Image HogRaiderTierProgress;

	void CheckHogRaiderUI () {
		HogRaiderCost.text = Player.HogRaiderElixCost.ToString ();  
		HogRaiderLevel.text = Player.HogRaiderLevel.ToString ();
		HogRaiderTier.text = Player.HogRaiderTier.ToString ();
		HogRaiderCardCurrent.text = Player.HogRaiderCards.ToString ();
		HogRaiderCardNextTier.text = Kasern.HogRaiderNextTierCards.ToString();
		HogRaiderTierProgress.fillAmount = (float) Player.HogRaiderCards / Kasern.HogRaiderNextTierCards;
	}

	public void UpgradeHogRaiderUI () {
		HogRaiderCost.text = Player.HogRaiderElixCost.ToString ();
		HogRaiderLevel.text = Player.HogRaiderLevel.ToString ();
	}

	public void UpgradeTierHogRaiderUI () {
		HogRaiderTier.text = Player.HogRaiderTier.ToString ();
		HogRaiderCardCurrent.text = Player.HogRaiderCards.ToString ();
		HogRaiderCardNextTier.text = Kasern.HogRaiderNextTierCards.ToString();
		HogRaiderTierProgress.fillAmount = (float) Player.HogRaiderCards / Kasern.HogRaiderNextTierCards;
	}

	public Text InfernoDragonName;
	public Text InfernoDragonCost;
	public Text InfernoDragonLevel;
	public Text InfernoDragonTier;
	public Text InfernoDragonCardCurrent;
	public Text InfernoDragonCardNextTier;
	public Image InfernoDragonTierProgress;

	void CheckInfernoDragonUI () {
		InfernoDragonCost.text = Player.InfernoDragonElixCost.ToString ();  
		InfernoDragonLevel.text = Player.InfernoDragonLevel.ToString ();
		InfernoDragonTier.text = Player.InfernoDragonTier.ToString ();
		InfernoDragonCardCurrent.text = Player.InfernoDragonCards.ToString ();
		InfernoDragonCardNextTier.text = Kasern.InfernoDragonNextTierCards.ToString();
		InfernoDragonTierProgress.fillAmount = (float) Player.InfernoDragonCards / Kasern.InfernoDragonNextTierCards;
	}

	public void UpgradeInfernoDragonUI () {
		InfernoDragonCost.text = Player.InfernoDragonElixCost.ToString ();
		InfernoDragonLevel.text = Player.InfernoDragonLevel.ToString ();
	}

	public void UpgradeTierInfernoDragonUI () {
		InfernoDragonTier.text = Player.InfernoDragonTier.ToString ();
		InfernoDragonCardCurrent.text = Player.InfernoDragonCards.ToString ();
		InfernoDragonCardNextTier.text = Kasern.InfernoDragonNextTierCards.ToString();
		InfernoDragonTierProgress.fillAmount = (float) Player.InfernoDragonCards / Kasern.InfernoDragonNextTierCards;
	}

	public Text MinionHordeName;
	public Text MinionHordeCost;
	public Text MinionHordeLevel;
	public Text MinionHordeTier;
	public Text MinionHordeCardCurrent;
	public Text MinionHordeCardNextTier;
	public Image MinionHordeTierProgress;

	void CheckMinionHordeUI () {
		MinionHordeCost.text = Player.MinionHordeElixCost.ToString ();  
		MinionHordeLevel.text = Player.MinionHordeLevel.ToString ();
		MinionHordeTier.text = Player.MinionHordeTier.ToString ();
		MinionHordeCardCurrent.text = Player.MinionHordeCards.ToString ();
		MinionHordeCardNextTier.text = Kasern.MinionHordeNextTierCards.ToString();
		MinionHordeTierProgress.fillAmount = (float) Player.MinionHordeCards / Kasern.MinionHordeNextTierCards;
	}

	public void UpgradeMinionHordeUI () {
		MinionHordeCost.text = Player.MinionHordeElixCost.ToString ();
		MinionHordeLevel.text = Player.MinionHordeLevel.ToString ();
	}

	public void UpgradeTierMinionHordeUI () {
		MinionHordeTier.text = Player.MinionHordeTier.ToString ();
		MinionHordeCardCurrent.text = Player.MinionHordeCards.ToString ();
		MinionHordeCardNextTier.text = Kasern.MinionHordeNextTierCards.ToString();
		MinionHordeTierProgress.fillAmount = (float) Player.MinionHordeCards / Kasern.MinionHordeNextTierCards;
	}


	public Text PekkaName;
	public Text PekkaCost;
	public Text PekkaLevel;
	public Text PekkaTier;
	public Text PekkaCardCurrent;
	public Text PekkaCardNextTier;
	public Image PekkaTierProgress;

	void CheckPekkaUI () {
		PekkaCost.text = Player.PekkaElixCost.ToString ();  
		PekkaLevel.text = Player.PekkaLevel.ToString ();
		PekkaTier.text = Player.PekkaTier.ToString ();
		PekkaCardCurrent.text = Player.PekkaCards.ToString ();
		PekkaCardNextTier.text = Kasern.PekkaNextTierCards.ToString();
		PekkaTierProgress.fillAmount = (float) Player.PekkaCards / Kasern.PekkaNextTierCards;
	}

	public void UpgradePekkaUI () {
		PekkaCost.text = Player.PekkaElixCost.ToString ();
		PekkaLevel.text = Player.PekkaLevel.ToString ();
	}

	public void UpgradeTierPekkaUI () {
		PekkaTier.text = Player.PekkaTier.ToString ();
		PekkaCardCurrent.text = Player.PekkaCards.ToString ();
		PekkaCardNextTier.text = Kasern.PekkaNextTierCards.ToString();
		PekkaTierProgress.fillAmount = (float) Player.PekkaCards / Kasern.PekkaNextTierCards;
	}

	public Text LavaHoundName;
	public Text LavaHoundCost;
	public Text LavaHoundLevel;
	public Text LavaHoundTier;
	public Text LavaHoundCardCurrent;
	public Text LavaHoundCardNextTier;
	public Image LavaHoundTierProgress;

	void CheckLavaHoundUI () {
		LavaHoundCost.text = Player.LavaHoundElixCost.ToString ();  
		LavaHoundLevel.text = Player.LavaHoundLevel.ToString ();
		LavaHoundTier.text = Player.LavaHoundTier.ToString ();
		LavaHoundCardCurrent.text = Player.LavaHoundCards.ToString ();
		LavaHoundCardNextTier.text = Kasern.LavaHoundNextTierCards.ToString();
		LavaHoundTierProgress.fillAmount = (float) Player.LavaHoundCards / Kasern.LavaHoundNextTierCards;
	}

	public void UpgradeLavaHoundUI () {
		LavaHoundCost.text = Player.LavaHoundElixCost.ToString ();
		LavaHoundLevel.text = Player.LavaHoundLevel.ToString ();
	}

	public void UpgradeTierLavaHoundUI () {
		LavaHoundTier.text = Player.LavaHoundTier.ToString ();
		LavaHoundCardCurrent.text = Player.LavaHoundCards.ToString ();
		LavaHoundCardNextTier.text = Kasern.LavaHoundNextTierCards.ToString();
		LavaHoundTierProgress.fillAmount = (float) Player.LavaHoundCards / Kasern.LavaHoundNextTierCards;
	}

	public Text FireSpiritsName;
	public Text FireSpiritsCost;
	public Text FireSpiritsLevel;
	public Text FireSpiritsTier;
	public Text FireSpiritsCardCurrent;
	public Text FireSpiritsCardNextTier;
	public Image FireSpiritsTierProgress;

	void CheckFireSpiritsUI () {
		FireSpiritsCost.text = Player.FireSpiritsElixCost.ToString ();  
		FireSpiritsLevel.text = Player.FireSpiritsLevel.ToString ();
		FireSpiritsTier.text = Player.FireSpiritsTier.ToString ();
		FireSpiritsCardCurrent.text = Player.FireSpiritsCards.ToString ();
		FireSpiritsCardNextTier.text = Kasern.FireSpiritsNextTierCards.ToString();
		FireSpiritsTierProgress.fillAmount = (float) Player.FireSpiritsCards / Kasern.FireSpiritsNextTierCards;
	}

	public void UpgradeFireSpiritsUI () {
		FireSpiritsCost.text = Player.FireSpiritsElixCost.ToString ();
		FireSpiritsLevel.text = Player.FireSpiritsLevel.ToString ();
	}

	public void UpgradeTierFireSpiritsUI () {
		FireSpiritsTier.text = Player.FireSpiritsTier.ToString ();
		FireSpiritsCardCurrent.text = Player.FireSpiritsCards.ToString ();
		FireSpiritsCardNextTier.text = Kasern.FireSpiritsNextTierCards.ToString();
		FireSpiritsTierProgress.fillAmount = (float) Player.FireSpiritsCards / Kasern.FireSpiritsNextTierCards;
	}

	public Text IceWizardName;
	public Text IceWizardCost;
	public Text IceWizardLevel;
	public Text IceWizardTier;
	public Text IceWizardCardCurrent;
	public Text IceWizardCardNextTier;
	public Image IceWizardTierProgress;

	void CheckIceWizardUI () {
		IceWizardCost.text = Player.IceWizardElixCost.ToString ();  
		IceWizardLevel.text = Player.IceWizardLevel.ToString ();
		IceWizardTier.text = Player.IceWizardTier.ToString ();
		IceWizardCardCurrent.text = Player.IceWizardCards.ToString ();
		IceWizardCardNextTier.text = Kasern.IceWizardNextTierCards.ToString();
		IceWizardTierProgress.fillAmount = (float) Player.IceWizardCards / Kasern.IceWizardNextTierCards;
	}

	public void UpgradeIceWizardUI () {
		IceWizardCost.text = Player.IceWizardElixCost.ToString ();
		IceWizardLevel.text = Player.IceWizardLevel.ToString ();
	}

	public void UpgradeTierIceWizardUI () {
		IceWizardTier.text = Player.IceWizardTier.ToString ();
		IceWizardCardCurrent.text = Player.IceWizardCards.ToString ();
		IceWizardCardNextTier.text = Kasern.IceWizardNextTierCards.ToString();
		IceWizardTierProgress.fillAmount = (float) Player.IceWizardCards / Kasern.IceWizardNextTierCards;
	}

	public Text WizardName;
	public Text WizardCost;
	public Text WizardLevel;
	public Text WizardTier;
	public Text WizardCardCurrent;
	public Text WizardCardNextTier;
	public Image WizardTierProgress;

	void CheckWizardUI () {
		WizardCost.text = Player.WizardElixCost.ToString ();  
		WizardLevel.text = Player.WizardLevel.ToString ();
		WizardTier.text = Player.WizardTier.ToString ();
		WizardCardCurrent.text = Player.WizardCards.ToString ();
		WizardCardNextTier.text = Kasern.WizardNextTierCards.ToString();
		WizardTierProgress.fillAmount = (float) Player.WizardCards / Kasern.WizardNextTierCards;
	}

	public void UpgradeWizardUI () {
		WizardCost.text = Player.WizardElixCost.ToString ();
		WizardLevel.text = Player.WizardLevel.ToString ();
	}

	public void UpgradeTierWizardUI () {
		WizardTier.text = Player.WizardTier.ToString ();
		WizardCardCurrent.text = Player.WizardCards.ToString ();
		WizardCardNextTier.text = Kasern.WizardNextTierCards.ToString();
		WizardTierProgress.fillAmount = (float) Player.WizardCards / Kasern.WizardNextTierCards;
	}

	public Text SkeletonBarrelName;
	public Text SkeletonBarrelCost;
	public Text SkeletonBarrelLevel;
	public Text SkeletonBarrelTier;
	public Text SkeletonBarrelCardCurrent;
	public Text SkeletonBarrelCardNextTier;
	public Image SkeletonBarrelTierProgress;

	void CheckSkeletonBarrelUI () {
		SkeletonBarrelCost.text = Player.SkeletonBarrelElixCost.ToString ();  
		SkeletonBarrelLevel.text = Player.SkeletonBarrelLevel.ToString ();
		SkeletonBarrelTier.text = Player.SkeletonBarrelTier.ToString ();
		SkeletonBarrelCardCurrent.text = Player.SkeletonBarrelCards.ToString ();
		SkeletonBarrelCardNextTier.text = Kasern.SkeletonBarrelNextTierCards.ToString();
		SkeletonBarrelTierProgress.fillAmount = (float) Player.SkeletonBarrelCards / Kasern.SkeletonBarrelNextTierCards;
	}

	public void UpgradeSkeletonBarrelUI () {
		SkeletonBarrelCost.text = Player.SkeletonBarrelElixCost.ToString ();
		SkeletonBarrelLevel.text = Player.SkeletonBarrelLevel.ToString ();
	}

	public void UpgradeTierSkeletonBarrelUI () {
		SkeletonBarrelTier.text = Player.SkeletonBarrelTier.ToString ();
		SkeletonBarrelCardCurrent.text = Player.SkeletonBarrelCards.ToString ();
		SkeletonBarrelCardNextTier.text = Kasern.SkeletonBarrelNextTierCards.ToString();
		SkeletonBarrelTierProgress.fillAmount = (float) Player.SkeletonBarrelCards / Kasern.SkeletonBarrelNextTierCards;
	}

	public Text MinerName;
	public Text MinerCost;
	public Text MinerLevel;
	public Text MinerTier;
	public Text MinerCardCurrent;
	public Text MinerCardNextTier;
	public Image MinerTierProgress;

	void CheckMinerUI () {
		MinerCost.text = Player.MinerElixCost.ToString ();  
		MinerLevel.text = Player.MinerLevel.ToString ();
		MinerTier.text = Player.MinerTier.ToString ();
		MinerCardCurrent.text = Player.MinerCards.ToString ();
		MinerCardNextTier.text = Kasern.MinerNextTierCards.ToString();
		MinerTierProgress.fillAmount = (float) Player.MinerCards / Kasern.MinerNextTierCards;
	}

	public void UpgradeMinerUI () {
		MinerCost.text = Player.MinerElixCost.ToString ();
		MinerLevel.text = Player.MinerLevel.ToString ();
	}

	public void UpgradeTierMinerUI () {
		MinerTier.text = Player.MinerTier.ToString ();
		MinerCardCurrent.text = Player.MinerCards.ToString ();
		MinerCardNextTier.text = Kasern.MinerNextTierCards.ToString();
		MinerTierProgress.fillAmount = (float) Player.MinerCards / Kasern.MinerNextTierCards;
	}

	public Text BattleRamName;
	public Text BattleRamCost;
	public Text BattleRamLevel;
	public Text BattleRamTier;
	public Text BattleRamCardCurrent;
	public Text BattleRamCardNextTier;
	public Image BattleRamTierProgress;

	void CheckBattleRamUI () {
		BattleRamCost.text = Player.BattleRamElixCost.ToString ();  
		BattleRamLevel.text = Player.BattleRamLevel.ToString ();
		BattleRamTier.text = Player.BattleRamTier.ToString ();
		BattleRamCardCurrent.text = Player.BattleRamCards.ToString ();
		BattleRamCardNextTier.text = Kasern.BattleRamNextTierCards.ToString();
		BattleRamTierProgress.fillAmount = (float) Player.BattleRamCards / Kasern.BattleRamNextTierCards;
	}

	public void UpgradeBattleRamUI () {
		BattleRamCost.text = Player.BattleRamElixCost.ToString ();
		BattleRamLevel.text = Player.BattleRamLevel.ToString ();
	}

	public void UpgradeTierBattleRamUI () {
		BattleRamTier.text = Player.BattleRamTier.ToString ();
		BattleRamCardCurrent.text = Player.BattleRamCards.ToString ();
		BattleRamCardNextTier.text = Kasern.BattleRamNextTierCards.ToString();
		BattleRamTierProgress.fillAmount = (float) Player.BattleRamCards / Kasern.BattleRamNextTierCards;
	}

	public Text SparkyName;
	public Text SparkyCost;
	public Text SparkyLevel;
	public Text SparkyTier;
	public Text SparkyCardCurrent;
	public Text SparkyCardNextTier;
	public Image SparkyTierProgress;

	void CheckSparkyUI () {
		SparkyCost.text = Player.SparkyElixCost.ToString ();  
		SparkyLevel.text = Player.SparkyLevel.ToString ();
		SparkyTier.text = Player.SparkyTier.ToString ();
		SparkyCardCurrent.text = Player.SparkyCards.ToString ();
		SparkyCardNextTier.text = Kasern.SparkyNextTierCards.ToString();
		SparkyTierProgress.fillAmount = (float) Player.SparkyCards / Kasern.SparkyNextTierCards;
	}

	public void UpgradeSparkyUI () {
		SparkyCost.text = Player.SparkyElixCost.ToString ();
		SparkyLevel.text = Player.SparkyLevel.ToString ();
	}

	public void UpgradeTierSparkyUI () {
		SparkyTier.text = Player.SparkyTier.ToString ();
		SparkyCardCurrent.text = Player.SparkyCards.ToString ();
		SparkyCardNextTier.text = Kasern.SparkyNextTierCards.ToString();
		SparkyTierProgress.fillAmount = (float) Player.SparkyCards / Kasern.SparkyNextTierCards;
	}

	public Text GolemName;
	public Text GolemCost;
	public Text GolemLevel;
	public Text GolemTier;
	public Text GolemCardCurrent;
	public Text GolemCardNextTier;
	public Image GolemTierProgress;

	void CheckGolemUI () {
		GolemCost.text = Player.GolemElixCost.ToString ();  
		GolemLevel.text = Player.GolemLevel.ToString ();
		GolemTier.text = Player.GolemTier.ToString ();
		GolemCardCurrent.text = Player.GolemCards.ToString ();
		GolemCardNextTier.text = Kasern.GolemNextTierCards.ToString();
		GolemTierProgress.fillAmount = (float) Player.GolemCards / Kasern.GolemNextTierCards;
	}

	public void UpgradeGolemUI () {
		GolemCost.text = Player.GolemElixCost.ToString ();
		GolemLevel.text = Player.GolemLevel.ToString ();
	}

	public void UpgradeTierGolemUI () {
		GolemTier.text = Player.GolemTier.ToString ();
		GolemCardCurrent.text = Player.GolemCards.ToString ();
		GolemCardNextTier.text = Kasern.GolemNextTierCards.ToString();
		GolemTierProgress.fillAmount = (float) Player.GolemCards / Kasern.GolemNextTierCards;
	}

	public Text MegaMinionName;
	public Text MegaMinionCost;
	public Text MegaMinionLevel;
	public Text MegaMinionTier;
	public Text MegaMinionCardCurrent;
	public Text MegaMinionCardNextTier;
	public Image MegaMinionTierProgress;

	void CheckMegaMinionUI () {
		MegaMinionCost.text = Player.MegaMinionElixCost.ToString ();  
		MegaMinionLevel.text = Player.MegaMinionLevel.ToString ();
		MegaMinionTier.text = Player.MegaMinionTier.ToString ();
		MegaMinionCardCurrent.text = Player.MegaMinionCards.ToString ();
		MegaMinionCardNextTier.text = Kasern.MegaMinionNextTierCards.ToString();
		MegaMinionTierProgress.fillAmount = (float) Player.MegaMinionCards / Kasern.MegaMinionNextTierCards;
	}

	public void UpgradeMegaMinionUI () {
		MegaMinionCost.text = Player.MegaMinionElixCost.ToString ();
		MegaMinionLevel.text = Player.MegaMinionLevel.ToString ();
	}

	public void UpgradeTierMegaMinionUI () {
		MegaMinionTier.text = Player.MegaMinionTier.ToString ();
		MegaMinionCardCurrent.text = Player.MegaMinionCards.ToString ();
		MegaMinionCardNextTier.text = Kasern.MegaMinionNextTierCards.ToString();
		MegaMinionTierProgress.fillAmount = (float) Player.MegaMinionCards / Kasern.MegaMinionNextTierCards;
	}

	public Text GuardsName;
	public Text GuardsCost;
	public Text GuardsLevel;
	public Text GuardsTier;
	public Text GuardsCardCurrent;
	public Text GuardsCardNextTier;
	public Image GuardsTierProgress;

	void CheckGuardsUI () {
		GuardsCost.text = Player.GuardsElixCost.ToString ();  
		GuardsLevel.text = Player.GuardsLevel.ToString ();
		GuardsTier.text = Player.GuardsTier.ToString ();
		GuardsCardCurrent.text = Player.GuardsCards.ToString ();
		GuardsCardNextTier.text = Kasern.GuardsNextTierCards.ToString();
		GuardsTierProgress.fillAmount = (float) Player.GuardsCards / Kasern.GuardsNextTierCards;
	}

	public void UpgradeGuardsUI () {
		GuardsCost.text = Player.GuardsElixCost.ToString ();
		GuardsLevel.text = Player.GuardsLevel.ToString ();
	}

	public void UpgradeTierGuardsUI () {
		GuardsTier.text = Player.GuardsTier.ToString ();
		GuardsCardCurrent.text = Player.GuardsCards.ToString ();
		GuardsCardNextTier.text = Kasern.GuardsNextTierCards.ToString();
		GuardsTierProgress.fillAmount = (float) Player.GuardsCards / Kasern.GuardsNextTierCards;
	}

	public Text PrincessName;
	public Text PrincessCost;
	public Text PrincessLevel;
	public Text PrincessTier;
	public Text PrincessCardCurrent;
	public Text PrincessCardNextTier;
	public Image PrincessTierProgress;

	void CheckPrincessUI () {
		PrincessCost.text = Player.PrincessElixCost.ToString ();  
		PrincessLevel.text = Player.PrincessLevel.ToString ();
		PrincessTier.text = Player.PrincessTier.ToString ();
		PrincessCardCurrent.text = Player.PrincessCards.ToString ();
		PrincessCardNextTier.text = Kasern.PrincessNextTierCards.ToString();
		PrincessTierProgress.fillAmount = (float) Player.PrincessCards / Kasern.PrincessNextTierCards;
	}

	public void UpgradePrincessUI () {
		PrincessCost.text = Player.PrincessElixCost.ToString ();
		PrincessLevel.text = Player.PrincessLevel.ToString ();
	}

	public void UpgradeTierPrincessUI () {
		PrincessTier.text = Player.PrincessTier.ToString ();
		PrincessCardCurrent.text = Player.PrincessCards.ToString ();
		PrincessCardNextTier.text = Kasern.PrincessNextTierCards.ToString();
		PrincessTierProgress.fillAmount = (float) Player.PrincessCards / Kasern.PrincessNextTierCards;
	}

	public Text DarkPrinceName;
	public Text DarkPrinceCost;
	public Text DarkPrinceLevel;
	public Text DarkPrinceTier;
	public Text DarkPrinceCardCurrent;
	public Text DarkPrinceCardNextTier;
	public Image DarkPrinceTierProgress;

	void CheckDarkPrinceUI () {
		DarkPrinceCost.text = Player.DarkPrinceElixCost.ToString ();  
		DarkPrinceLevel.text = Player.DarkPrinceLevel.ToString ();
		DarkPrinceTier.text = Player.DarkPrinceTier.ToString ();
		DarkPrinceCardCurrent.text = Player.DarkPrinceCards.ToString ();
		DarkPrinceCardNextTier.text = Kasern.DarkPrinceNextTierCards.ToString();
		DarkPrinceTierProgress.fillAmount = (float) Player.DarkPrinceCards / Kasern.DarkPrinceNextTierCards;
	}

	public void UpgradeDarkPrinceUI () {
		DarkPrinceCost.text = Player.DarkPrinceElixCost.ToString ();
		DarkPrinceLevel.text = Player.DarkPrinceLevel.ToString ();
	}

	public void UpgradeTierDarkPrinceUI () {
		DarkPrinceTier.text = Player.DarkPrinceTier.ToString ();
		DarkPrinceCardCurrent.text = Player.DarkPrinceCards.ToString ();
		DarkPrinceCardNextTier.text = Kasern.DarkPrinceNextTierCards.ToString();
		DarkPrinceTierProgress.fillAmount = (float) Player.DarkPrinceCards / Kasern.DarkPrinceNextTierCards;
	}

	public Text ElectroWizardName;
	public Text ElectroWizardCost;
	public Text ElectroWizardLevel;
	public Text ElectroWizardTier;
	public Text ElectroWizardCardCurrent;
	public Text ElectroWizardCardNextTier;
	public Image ElectroWizardTierProgress;

	void CheckElectroWizardUI () {
		ElectroWizardCost.text = Player.ElectroWizardElixCost.ToString ();  
		ElectroWizardLevel.text = Player.ElectroWizardLevel.ToString ();
		ElectroWizardTier.text = Player.ElectroWizardTier.ToString ();
		ElectroWizardCardCurrent.text = Player.ElectroWizardCards.ToString ();
		ElectroWizardCardNextTier.text = Kasern.ElectroWizardNextTierCards.ToString();
		ElectroWizardTierProgress.fillAmount = (float) Player.ElectroWizardCards / Kasern.ElectroWizardNextTierCards;
	}

	public void UpgradeElectroWizardUI () {
		ElectroWizardCost.text = Player.ElectroWizardElixCost.ToString ();
		ElectroWizardLevel.text = Player.ElectroWizardLevel.ToString ();
	}

	public void UpgradeTierElectroWizardUI () {
		ElectroWizardTier.text = Player.ElectroWizardTier.ToString ();
		ElectroWizardCardCurrent.text = Player.ElectroWizardCards.ToString ();
		ElectroWizardCardNextTier.text = Kasern.ElectroWizardNextTierCards.ToString();
		ElectroWizardTierProgress.fillAmount = (float) Player.ElectroWizardCards / Kasern.ElectroWizardNextTierCards;
	}

	public Text RoyalGiantName;
	public Text RoyalGiantCost;
	public Text RoyalGiantLevel;
	public Text RoyalGiantTier;
	public Text RoyalGiantCardCurrent;
	public Text RoyalGiantCardNextTier;
	public Image RoyalGiantTierProgress;

	void CheckRoyalGiantUI () {
		RoyalGiantCost.text = Player.RoyalGiantElixCost.ToString ();  
		RoyalGiantLevel.text = Player.RoyalGiantLevel.ToString ();
		RoyalGiantTier.text = Player.RoyalGiantTier.ToString ();
		RoyalGiantCardCurrent.text = Player.RoyalGiantCards.ToString ();
		RoyalGiantCardNextTier.text = Kasern.RoyalGiantNextTierCards.ToString();
		RoyalGiantTierProgress.fillAmount = (float) Player.RoyalGiantCards / Kasern.RoyalGiantNextTierCards;
	}

	public void UpgradeRoyalGiantUI () {
		RoyalGiantCost.text = Player.RoyalGiantElixCost.ToString ();
		RoyalGiantLevel.text = Player.RoyalGiantLevel.ToString ();
	}

	public void UpgradeTierRoyalGiantUI () {
		RoyalGiantTier.text = Player.RoyalGiantTier.ToString ();
		RoyalGiantCardCurrent.text = Player.RoyalGiantCards.ToString ();
		RoyalGiantCardNextTier.text = Kasern.RoyalGiantNextTierCards.ToString();
		RoyalGiantTierProgress.fillAmount = (float) Player.RoyalGiantCards / Kasern.RoyalGiantNextTierCards;
	}

	public Text EliteBarbariansName;
	public Text EliteBarbariansCost;
	public Text EliteBarbariansLevel;
	public Text EliteBarbariansTier;
	public Text EliteBarbariansCardCurrent;
	public Text EliteBarbariansCardNextTier;
	public Image EliteBarbariansTierProgress;

	void CheckEliteBarbariansUI () {
		EliteBarbariansCost.text = Player.EliteBarbariansElixCost.ToString ();  
		EliteBarbariansLevel.text = Player.EliteBarbariansLevel.ToString ();
		EliteBarbariansTier.text = Player.EliteBarbariansTier.ToString ();
		EliteBarbariansCardCurrent.text = Player.EliteBarbariansCards.ToString ();
		EliteBarbariansCardNextTier.text = Kasern.EliteBarbariansNextTierCards.ToString();
		EliteBarbariansTierProgress.fillAmount = (float) Player.EliteBarbariansCards / Kasern.EliteBarbariansNextTierCards;
	}

	public void UpgradeEliteBarbariansUI () {
		EliteBarbariansCost.text = Player.EliteBarbariansElixCost.ToString ();
		EliteBarbariansLevel.text = Player.EliteBarbariansLevel.ToString ();
	}

	public void UpgradeTierEliteBarbariansUI () {
		EliteBarbariansTier.text = Player.EliteBarbariansTier.ToString ();
		EliteBarbariansCardCurrent.text = Player.EliteBarbariansCards.ToString ();
		EliteBarbariansCardNextTier.text = Kasern.EliteBarbariansNextTierCards.ToString();
		EliteBarbariansTierProgress.fillAmount = (float) Player.EliteBarbariansCards / Kasern.EliteBarbariansNextTierCards;
	}

	public Text ThreeMusketeersName;
	public Text ThreeMusketeersCost;
	public Text ThreeMusketeersLevel;
	public Text ThreeMusketeersTier;
	public Text ThreeMusketeersCardCurrent;
	public Text ThreeMusketeersCardNextTier;
	public Image ThreeMusketeersTierProgress;

	void CheckThreeMusketeersUI () {
		ThreeMusketeersCost.text = Player.ThreeMusketeersElixCost.ToString ();  
		ThreeMusketeersLevel.text = Player.ThreeMusketeersLevel.ToString ();
		ThreeMusketeersTier.text = Player.ThreeMusketeersTier.ToString ();
		ThreeMusketeersCardCurrent.text = Player.ThreeMusketeersCards.ToString ();
		ThreeMusketeersCardNextTier.text = Kasern.ThreeMusketeersNextTierCards.ToString();
		ThreeMusketeersTierProgress.fillAmount = (float) Player.ThreeMusketeersCards / Kasern.ThreeMusketeersNextTierCards;
	}

	public void UpgradeThreeMusketeersUI () {
		ThreeMusketeersCost.text = Player.ThreeMusketeersElixCost.ToString ();
		ThreeMusketeersLevel.text = Player.ThreeMusketeersLevel.ToString ();
	}

	public void UpgradeTierThreeMusketeersUI () {
		ThreeMusketeersTier.text = Player.ThreeMusketeersTier.ToString ();
		ThreeMusketeersCardCurrent.text = Player.ThreeMusketeersCards.ToString ();
		ThreeMusketeersCardNextTier.text = Kasern.ThreeMusketeersNextTierCards.ToString();
		ThreeMusketeersTierProgress.fillAmount = (float) Player.ThreeMusketeersCards / Kasern.ThreeMusketeersNextTierCards;
	}

	public Text IceSpiritName;
	public Text IceSpiritCost;
	public Text IceSpiritLevel;
	public Text IceSpiritTier;
	public Text IceSpiritCardCurrent;
	public Text IceSpiritCardNextTier;
	public Image IceSpiritTierProgress;

	void CheckIceSpiritUI () {
		IceSpiritCost.text = Player.IceSpiritElixCost.ToString ();  
		IceSpiritLevel.text = Player.IceSpiritLevel.ToString ();
		IceSpiritTier.text = Player.IceSpiritTier.ToString ();
		IceSpiritCardCurrent.text = Player.IceSpiritCards.ToString ();
		IceSpiritCardNextTier.text = Kasern.IceSpiritNextTierCards.ToString();
		IceSpiritTierProgress.fillAmount = (float) Player.IceSpiritCards / Kasern.IceSpiritNextTierCards;
	}

	public void UpgradeIceSpiritUI () {
		IceSpiritCost.text = Player.IceSpiritElixCost.ToString ();
		IceSpiritLevel.text = Player.IceSpiritLevel.ToString ();
	}

	public void UpgradeTierIceSpiritUI () {
		IceSpiritTier.text = Player.IceSpiritTier.ToString ();
		IceSpiritCardCurrent.text = Player.IceSpiritCards.ToString ();
		IceSpiritCardNextTier.text = Kasern.IceSpiritNextTierCards.ToString();
		IceSpiritTierProgress.fillAmount = (float) Player.IceSpiritCards / Kasern.IceSpiritNextTierCards;
	}

	public Text BatsName;
	public Text BatsCost;
	public Text BatsLevel;
	public Text BatsTier;
	public Text BatsCardCurrent;
	public Text BatsCardNextTier;
	public Image BatsTierProgress;

	void CheckBatsUI () {
		BatsCost.text = Player.BatsElixCost.ToString ();  
		BatsLevel.text = Player.BatsLevel.ToString ();
		BatsTier.text = Player.BatsTier.ToString ();
		BatsCardCurrent.text = Player.BatsCards.ToString ();
		BatsCardNextTier.text = Kasern.BatsNextTierCards.ToString();
		BatsTierProgress.fillAmount = (float) Player.BatsCards / Kasern.BatsNextTierCards;
	}

	public void UpgradeBatsUI () {
		BatsCost.text = Player.BatsElixCost.ToString ();
		BatsLevel.text = Player.BatsLevel.ToString ();
	}

	public void UpgradeTierBatsUI () {
		BatsTier.text = Player.BatsTier.ToString ();
		BatsCardCurrent.text = Player.BatsCards.ToString ();
		BatsCardNextTier.text = Kasern.BatsNextTierCards.ToString();
		BatsTierProgress.fillAmount = (float) Player.BatsCards / Kasern.BatsNextTierCards;
	}

	public Text IceGolemName;
	public Text IceGolemCost;
	public Text IceGolemLevel;
	public Text IceGolemTier;
	public Text IceGolemCardCurrent;
	public Text IceGolemCardNextTier;
	public Image IceGolemTierProgress;

	void CheckIceGolemUI () {
		IceGolemCost.text = Player.IceGolemElixCost.ToString ();  
		IceGolemLevel.text = Player.IceGolemLevel.ToString ();
		IceGolemTier.text = Player.IceGolemTier.ToString ();
		IceGolemCardCurrent.text = Player.IceGolemCards.ToString ();
		IceGolemCardNextTier.text = Kasern.IceGolemNextTierCards.ToString();
		IceGolemTierProgress.fillAmount = (float) Player.IceGolemCards / Kasern.IceGolemNextTierCards;
	}

	public void UpgradeIceGolemUI () {
		IceGolemCost.text = Player.IceGolemElixCost.ToString ();
		IceGolemLevel.text = Player.IceGolemLevel.ToString ();
	}

	public void UpgradeTierIceGolemUI () {
		IceGolemTier.text = Player.IceGolemTier.ToString ();
		IceGolemCardCurrent.text = Player.IceGolemCards.ToString ();
		IceGolemCardNextTier.text = Kasern.IceGolemNextTierCards.ToString();
		IceGolemTierProgress.fillAmount = (float) Player.IceGolemCards / Kasern.IceGolemNextTierCards;
	}

	public Text NightWitchName;
	public Text NightWitchCost;
	public Text NightWitchLevel;
	public Text NightWitchTier;
	public Text NightWitchCardCurrent;
	public Text NightWitchCardNextTier;
	public Image NightWitchTierProgress;

	void CheckNightWitchUI () {
		NightWitchCost.text = Player.NightWitchElixCost.ToString ();  
		NightWitchLevel.text = Player.NightWitchLevel.ToString ();
		NightWitchTier.text = Player.NightWitchTier.ToString ();
		NightWitchCardCurrent.text = Player.NightWitchCards.ToString ();
		NightWitchCardNextTier.text = Kasern.NightWitchNextTierCards.ToString();
		NightWitchTierProgress.fillAmount = (float) Player.NightWitchCards / Kasern.NightWitchNextTierCards;
	}

	public void UpgradeNightWitchUI () {
		NightWitchCost.text = Player.NightWitchElixCost.ToString ();
		NightWitchLevel.text = Player.NightWitchLevel.ToString ();
	}

	public void UpgradeTierNightWitchUI () {
		NightWitchTier.text = Player.NightWitchTier.ToString ();
		NightWitchCardCurrent.text = Player.NightWitchCards.ToString ();
		NightWitchCardNextTier.text = Kasern.NightWitchNextTierCards.ToString();
		NightWitchTierProgress.fillAmount = (float) Player.NightWitchCards / Kasern.NightWitchNextTierCards;
	}

	public Text LumberjackName;
	public Text LumberjackCost;
	public Text LumberjackLevel;
	public Text LumberjackTier;
	public Text LumberjackCardCurrent;
	public Text LumberjackCardNextTier;
	public Image LumberjackTierProgress;

	void CheckLumberjackUI () {
		LumberjackCost.text = Player.LumberjackElixCost.ToString ();  
		LumberjackLevel.text = Player.LumberjackLevel.ToString ();
		LumberjackTier.text = Player.LumberjackTier.ToString ();
		LumberjackCardCurrent.text = Player.LumberjackCards.ToString ();
		LumberjackCardNextTier.text = Kasern.LumberjackNextTierCards.ToString();
		LumberjackTierProgress.fillAmount = (float) Player.LumberjackCards / Kasern.LumberjackNextTierCards;
	}

	public void UpgradeLumberjackUI () {
		LumberjackCost.text = Player.LumberjackElixCost.ToString ();
		LumberjackLevel.text = Player.LumberjackLevel.ToString ();
	}

	public void UpgradeTierLumberjackUI () {
		LumberjackTier.text = Player.LumberjackTier.ToString ();
		LumberjackCardCurrent.text = Player.LumberjackCards.ToString ();
		LumberjackCardNextTier.text = Kasern.LumberjackNextTierCards.ToString();
		LumberjackTierProgress.fillAmount = (float) Player.LumberjackCards / Kasern.LumberjackNextTierCards;
	}

	public Text BowlerName;
	public Text BowlerCost;
	public Text BowlerLevel;
	public Text BowlerTier;
	public Text BowlerCardCurrent;
	public Text BowlerCardNextTier;
	public Image BowlerTierProgress;

	void CheckBowlerUI () {
		BowlerCost.text = Player.BowlerElixCost.ToString ();  
		BowlerLevel.text = Player.BowlerLevel.ToString ();
		BowlerTier.text = Player.BowlerTier.ToString ();
		BowlerCardCurrent.text = Player.BowlerCards.ToString ();
		BowlerCardNextTier.text = Kasern.BowlerNextTierCards.ToString();
		BowlerTierProgress.fillAmount = (float) Player.BowlerCards / Kasern.BowlerNextTierCards;
	}

	public void UpgradeBowlerUI () {
		BowlerCost.text = Player.BowlerElixCost.ToString ();
		BowlerLevel.text = Player.BowlerLevel.ToString ();
	}

	public void UpgradeTierBowlerUI () {
		BowlerTier.text = Player.BowlerTier.ToString ();
		BowlerCardCurrent.text = Player.BowlerCards.ToString ();
		BowlerCardNextTier.text = Kasern.BowlerNextTierCards.ToString();
		BowlerTierProgress.fillAmount = (float) Player.BowlerCards / Kasern.BowlerNextTierCards;
	}

	public Text GoblinGangName;
	public Text GoblinGangCost;
	public Text GoblinGangLevel;
	public Text GoblinGangTier;
	public Text GoblinGangCardCurrent;
	public Text GoblinGangCardNextTier;
	public Image GoblinGangTierProgress;

	void CheckGoblinGangUI () {
		GoblinGangCost.text = Player.GoblinGangElixCost.ToString ();  
		GoblinGangLevel.text = Player.GoblinGangLevel.ToString ();
		GoblinGangTier.text = Player.GoblinGangTier.ToString ();
		GoblinGangCardCurrent.text = Player.GoblinGangCards.ToString ();
		GoblinGangCardNextTier.text = Kasern.GoblinGangNextTierCards.ToString();
		GoblinGangTierProgress.fillAmount = (float) Player.GoblinGangCards / Kasern.GoblinGangNextTierCards;
	}

	public void UpgradeGoblinGangUI () {
		GoblinGangCost.text = Player.GoblinGangElixCost.ToString ();
		GoblinGangLevel.text = Player.GoblinGangLevel.ToString ();
	}

	public void UpgradeTierGoblinGangUI () {
		GoblinGangTier.text = Player.GoblinGangTier.ToString ();
		GoblinGangCardCurrent.text = Player.GoblinGangCards.ToString ();
		GoblinGangCardNextTier.text = Kasern.GoblinGangNextTierCards.ToString();
		GoblinGangTierProgress.fillAmount = (float) Player.GoblinGangCards / Kasern.GoblinGangNextTierCards;
	}

	public Text DartGoblinName;
	public Text DartGoblinCost;
	public Text DartGoblinLevel;
	public Text DartGoblinTier;
	public Text DartGoblinCardCurrent;
	public Text DartGoblinCardNextTier;
	public Image DartGoblinTierProgress;

	void CheckDartGoblinUI () {
		DartGoblinCost.text = Player.DartGoblinElixCost.ToString ();  
		DartGoblinLevel.text = Player.DartGoblinLevel.ToString ();
		DartGoblinTier.text = Player.DartGoblinTier.ToString ();
		DartGoblinCardCurrent.text = Player.DartGoblinCards.ToString ();
		DartGoblinCardNextTier.text = Kasern.DartGoblinNextTierCards.ToString();
		DartGoblinTierProgress.fillAmount = (float) Player.DartGoblinCards / Kasern.DartGoblinNextTierCards;
	}

	public void UpgradeDartGoblinUI () {
		DartGoblinCost.text = Player.DartGoblinElixCost.ToString ();
		DartGoblinLevel.text = Player.DartGoblinLevel.ToString ();
	}

	public void UpgradeTierDartGoblinUI () {
		DartGoblinTier.text = Player.DartGoblinTier.ToString ();
		DartGoblinCardCurrent.text = Player.DartGoblinCards.ToString ();
		DartGoblinCardNextTier.text = Kasern.DartGoblinNextTierCards.ToString();
		DartGoblinTierProgress.fillAmount = (float) Player.DartGoblinCards / Kasern.DartGoblinNextTierCards;
	}

	public Text BanditName;
	public Text BanditCost;
	public Text BanditLevel;
	public Text BanditTier;
	public Text BanditCardCurrent;
	public Text BanditCardNextTier;
	public Image BanditTierProgress;

	void CheckBanditUI () {
		BanditCost.text = Player.BanditElixCost.ToString ();  
		BanditLevel.text = Player.BanditLevel.ToString ();
		BanditTier.text = Player.BanditTier.ToString ();
		BanditCardCurrent.text = Player.BanditCards.ToString ();
		BanditCardNextTier.text = Kasern.BanditNextTierCards.ToString();
		BanditTierProgress.fillAmount = (float) Player.BanditCards / Kasern.BanditNextTierCards;
	}

	public void UpgradeBanditUI () {
		BanditCost.text = Player.BanditElixCost.ToString ();
		BanditLevel.text = Player.BanditLevel.ToString ();
	}

	public void UpgradeTierBanditUI () {
		BanditTier.text = Player.BanditTier.ToString ();
		BanditCardCurrent.text = Player.BanditCards.ToString ();
		BanditCardNextTier.text = Kasern.BanditNextTierCards.ToString();
		BanditTierProgress.fillAmount = (float) Player.BanditCards / Kasern.BanditNextTierCards;
	}

	public Text FlyingMachineName;
	public Text FlyingMachineCost;
	public Text FlyingMachineLevel;
	public Text FlyingMachineTier;
	public Text FlyingMachineCardCurrent;
	public Text FlyingMachineCardNextTier;
	public Image FlyingMachineTierProgress;

	void CheckFlyingMachineUI () {
		FlyingMachineCost.text = Player.FlyingMachineElixCost.ToString ();  
		FlyingMachineLevel.text = Player.FlyingMachineLevel.ToString ();
		FlyingMachineTier.text = Player.FlyingMachineTier.ToString ();
		FlyingMachineCardCurrent.text = Player.FlyingMachineCards.ToString ();
		FlyingMachineCardNextTier.text = Kasern.FlyingMachineNextTierCards.ToString();
		FlyingMachineTierProgress.fillAmount = (float) Player.FlyingMachineCards / Kasern.FlyingMachineNextTierCards;
	}

	public void UpgradeFlyingMachineUI () {
		FlyingMachineCost.text = Player.FlyingMachineElixCost.ToString ();
		FlyingMachineLevel.text = Player.FlyingMachineLevel.ToString ();
	}

	public void UpgradeTierFlyingMachineUI () {
		FlyingMachineTier.text = Player.FlyingMachineTier.ToString ();
		FlyingMachineCardCurrent.text = Player.FlyingMachineCards.ToString ();
		FlyingMachineCardNextTier.text = Kasern.FlyingMachineNextTierCards.ToString();
		FlyingMachineTierProgress.fillAmount = (float) Player.FlyingMachineCards / Kasern.FlyingMachineNextTierCards;
	}

	public Text HunterName;
	public Text HunterCost;
	public Text HunterLevel;
	public Text HunterTier;
	public Text HunterCardCurrent;
	public Text HunterCardNextTier;
	public Image HunterTierProgress;

	void CheckHunterUI () {
		HunterCost.text = Player.HunterElixCost.ToString ();  
		HunterLevel.text = Player.HunterLevel.ToString ();
		HunterTier.text = Player.HunterTier.ToString ();
		HunterCardCurrent.text = Player.HunterCards.ToString ();
		HunterCardNextTier.text = Kasern.HunterNextTierCards.ToString();
		HunterTierProgress.fillAmount = (float) Player.HunterCards / Kasern.HunterNextTierCards;
	}

	public void UpgradeHunterUI () {
		HunterCost.text = Player.HunterElixCost.ToString ();
		HunterLevel.text = Player.HunterLevel.ToString ();
	}

	public void UpgradeTierHunterUI () {
		HunterTier.text = Player.HunterTier.ToString ();
		HunterCardCurrent.text = Player.HunterCards.ToString ();
		HunterCardNextTier.text = Kasern.HunterNextTierCards.ToString();
		HunterTierProgress.fillAmount = (float) Player.HunterCards / Kasern.HunterNextTierCards;
	}

	public Text ExecutionerName;
	public Text ExecutionerCost;
	public Text ExecutionerLevel;
	public Text ExecutionerTier;
	public Text ExecutionerCardCurrent;
	public Text ExecutionerCardNextTier;
	public Image ExecutionerTierProgress;

	void CheckExecutionerUI () {
		ExecutionerCost.text = Player.ExecutionerElixCost.ToString ();  
		ExecutionerLevel.text = Player.ExecutionerLevel.ToString ();
		ExecutionerTier.text = Player.ExecutionerTier.ToString ();
		ExecutionerCardCurrent.text = Player.ExecutionerCards.ToString ();
		ExecutionerCardNextTier.text = Kasern.ExecutionerNextTierCards.ToString();
		ExecutionerTierProgress.fillAmount = (float) Player.ExecutionerCards / Kasern.ExecutionerNextTierCards;
	}

	public void UpgradeExecutionerUI () {
		ExecutionerCost.text = Player.ExecutionerElixCost.ToString ();
		ExecutionerLevel.text = Player.ExecutionerLevel.ToString ();
	}

	public void UpgradeTierExecutionerUI () {
		ExecutionerTier.text = Player.ExecutionerTier.ToString ();
		ExecutionerCardCurrent.text = Player.ExecutionerCards.ToString ();
		ExecutionerCardNextTier.text = Kasern.ExecutionerNextTierCards.ToString();
		ExecutionerTierProgress.fillAmount = (float) Player.ExecutionerCards / Kasern.ExecutionerNextTierCards;
	}

	public Text RoyalGhostName;
	public Text RoyalGhostCost;
	public Text RoyalGhostLevel;
	public Text RoyalGhostTier;
	public Text RoyalGhostCardCurrent;
	public Text RoyalGhostCardNextTier;
	public Image RoyalGhostTierProgress;

	void CheckRoyalGhostUI () {
		RoyalGhostCost.text = Player.RoyalGhostElixCost.ToString ();  
		RoyalGhostLevel.text = Player.RoyalGhostLevel.ToString ();
		RoyalGhostTier.text = Player.RoyalGhostTier.ToString ();
		RoyalGhostCardCurrent.text = Player.RoyalGhostCards.ToString ();
		RoyalGhostCardNextTier.text = Kasern.RoyalGhostNextTierCards.ToString();
		RoyalGhostTierProgress.fillAmount = (float) Player.RoyalGhostCards / Kasern.RoyalGhostNextTierCards;
	}

	public void UpgradeRoyalGhostUI () {
		RoyalGhostCost.text = Player.RoyalGhostElixCost.ToString ();
		RoyalGhostLevel.text = Player.RoyalGhostLevel.ToString ();
	}

	public void UpgradeTierRoyalGhostUI () {
		RoyalGhostTier.text = Player.RoyalGhostTier.ToString ();
		RoyalGhostCardCurrent.text = Player.RoyalGhostCards.ToString ();
		RoyalGhostCardNextTier.text = Kasern.RoyalGhostNextTierCards.ToString();
		RoyalGhostTierProgress.fillAmount = (float) Player.RoyalGhostCards / Kasern.RoyalGhostNextTierCards;
	}

	public Text CannonCartName;
	public Text CannonCartCost;
	public Text CannonCartLevel;
	public Text CannonCartTier;
	public Text CannonCartCardCurrent;
	public Text CannonCartCardNextTier;
	public Image CannonCartTierProgress;

	void CheckCannonCartUI () {
		CannonCartCost.text = Player.CannonCartElixCost.ToString ();  
		CannonCartLevel.text = Player.CannonCartLevel.ToString ();
		CannonCartTier.text = Player.CannonCartTier.ToString ();
		CannonCartCardCurrent.text = Player.CannonCartCards.ToString ();
		CannonCartCardNextTier.text = Kasern.CannonCartNextTierCards.ToString();
		CannonCartTierProgress.fillAmount = (float) Player.CannonCartCards / Kasern.CannonCartNextTierCards;
	}

	public void UpgradeCannonCartUI () {
		CannonCartCost.text = Player.CannonCartElixCost.ToString ();
		CannonCartLevel.text = Player.CannonCartLevel.ToString ();
	}

	public void UpgradeTierCannonCartUI () {
		CannonCartTier.text = Player.CannonCartTier.ToString ();
		CannonCartCardCurrent.text = Player.CannonCartCards.ToString ();
		CannonCartCardNextTier.text = Kasern.CannonCartNextTierCards.ToString();
		CannonCartTierProgress.fillAmount = (float) Player.CannonCartCards / Kasern.CannonCartNextTierCards;
	}

	public Text MegaKnightName;
	public Text MegaKnightCost;
	public Text MegaKnightLevel;
	public Text MegaKnightTier;
	public Text MegaKnightCardCurrent;
	public Text MegaKnightCardNextTier;
	public Image MegaKnightTierProgress;

	void CheckMegaKnightUI () {
		MegaKnightCost.text = Player.MegaKnightElixCost.ToString ();  
		MegaKnightLevel.text = Player.MegaKnightLevel.ToString ();
		MegaKnightTier.text = Player.MegaKnightTier.ToString ();
		MegaKnightCardCurrent.text = Player.MegaKnightCards.ToString ();
		MegaKnightCardNextTier.text = Kasern.MegaKnightNextTierCards.ToString();
		MegaKnightTierProgress.fillAmount = (float) Player.MegaKnightCards / Kasern.MegaKnightNextTierCards;
	}

	public void UpgradeMegaKnightUI () {
		MegaKnightCost.text = Player.MegaKnightElixCost.ToString ();
		MegaKnightLevel.text = Player.MegaKnightLevel.ToString ();
	}

	public void UpgradeTierMegaKnightUI () {
		MegaKnightTier.text = Player.MegaKnightTier.ToString ();
		MegaKnightCardCurrent.text = Player.MegaKnightCards.ToString ();
		MegaKnightCardNextTier.text = Kasern.MegaKnightNextTierCards.ToString();
		MegaKnightTierProgress.fillAmount = (float) Player.MegaKnightCards / Kasern.MegaKnightNextTierCards;
	}

	public Text ZappiesName;
	public Text ZappiesCost;
	public Text ZappiesLevel;
	public Text ZappiesTier;
	public Text ZappiesCardCurrent;
	public Text ZappiesCardNextTier;
	public Image ZappiesTierProgress;

	void CheckZappiesUI () {
		ZappiesCost.text = Player.ZappiesElixCost.ToString ();  
		ZappiesLevel.text = Player.ZappiesLevel.ToString ();
		ZappiesTier.text = Player.ZappiesTier.ToString ();
		ZappiesCardCurrent.text = Player.ZappiesCards.ToString ();
		ZappiesCardNextTier.text = Kasern.ZappiesNextTierCards.ToString();
		ZappiesTierProgress.fillAmount = (float) Player.ZappiesCards / Kasern.ZappiesNextTierCards;
	}

	public void UpgradeZappiesUI () {
		ZappiesCost.text = Player.ZappiesElixCost.ToString ();
		ZappiesLevel.text = Player.ZappiesLevel.ToString ();
	}

	public void UpgradeTierZappiesUI () {
		ZappiesTier.text = Player.ZappiesTier.ToString ();
		ZappiesCardCurrent.text = Player.ZappiesCards.ToString ();
		ZappiesCardNextTier.text = Kasern.ZappiesNextTierCards.ToString();
		ZappiesTierProgress.fillAmount = (float) Player.ZappiesCards / Kasern.ZappiesNextTierCards;
	}

	public Text MagicalArcherName;
	public Text MagicalArcherCost;
	public Text MagicalArcherLevel;
	public Text MagicalArcherTier;
	public Text MagicalArcherCardCurrent;
	public Text MagicalArcherCardNextTier;
	public Image MagicalArcherTierProgress;

	void CheckMagicalArcherUI () {
		MagicalArcherCost.text = Player.MagicalArcherElixCost.ToString ();  
		MagicalArcherLevel.text = Player.MagicalArcherLevel.ToString ();
		MagicalArcherTier.text = Player.MagicalArcherTier.ToString ();
		MagicalArcherCardCurrent.text = Player.MagicalArcherCards.ToString ();
		MagicalArcherCardNextTier.text = Kasern.MagicalArcherNextTierCards.ToString();
		MagicalArcherTierProgress.fillAmount = (float) Player.MagicalArcherCards / Kasern.MagicalArcherNextTierCards;
	}

	public void UpgradeMagicalArcherUI () {
		MagicalArcherCost.text = Player.MagicalArcherElixCost.ToString ();
		MagicalArcherLevel.text = Player.MagicalArcherLevel.ToString ();
	}

	public void UpgradeTierMagicalArcherUI () {
		MagicalArcherTier.text = Player.MagicalArcherTier.ToString ();
		MagicalArcherCardCurrent.text = Player.MagicalArcherCards.ToString ();
		MagicalArcherCardNextTier.text = Kasern.MagicalArcherNextTierCards.ToString();
		MagicalArcherTierProgress.fillAmount = (float) Player.MagicalArcherCards / Kasern.MagicalArcherNextTierCards;
	}
}
