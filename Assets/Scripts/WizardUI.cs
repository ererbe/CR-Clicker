using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WizardUI : MonoBehaviour {

	public SpellManager spellManager;

	public Text CostTextArrows;
	public Text CostTextFireball;
	public Text CostTextGoblinBarrel;
	public Text CostTextLightning;
	public Text CostTextRage;
	public Text CostTextRocket;
	public Text CostTextFreeze;
	public Text CostTextZap;
	public Text CostTextPoison;
	public Text CostTextMirror;
	public Text CostTextGraveyard;
	public Text CostTextTheLog;
	public Text CostTextTornado;
	public Text CostTextClone;
	public Text CostTextHeal;
	public Text CostTextBarbarianBarrel;

	void OnEnable () {
		UpdateAnything ();
	}

	public void UpdateAnything () {
		if (Player.Language == 1) {
			ArrowsName.text = spellManager.Arrows.SpellNameEnglisch;
			FireballName.text = spellManager.Fireball.SpellNameEnglisch;
			GoblinBarrelName.text = spellManager.GoblinBarrel.SpellNameEnglisch;
			LightningName.text = spellManager.Lightning.SpellNameEnglisch;
			RageName.text = spellManager.Rage.SpellNameEnglisch;
			RocketName.text = spellManager.Rocket.SpellNameEnglisch;
			FreezeName.text = spellManager.Freeze.SpellNameEnglisch;
			ZapName.text = spellManager.Zap.SpellNameEnglisch;
			PoisonName.text = spellManager.Poison.SpellNameEnglisch;
			MirrorName.text = spellManager.Mirror.SpellNameEnglisch;
			GraveyardName.text = spellManager.Graveyard.SpellNameEnglisch;
			TheLogName.text = spellManager.TheLog.SpellNameEnglisch;
			TornadoName.text = spellManager.Tornado.SpellNameEnglisch;
			CloneName.text = spellManager.Clone.SpellNameEnglisch;
			HealName.text = spellManager.Heal.SpellNameEnglisch;
			BarbarianBarrelName.text = spellManager.BarbarianBarrel.SpellNameEnglisch;

			CostTextArrows.text = "Cost:";
			CostTextFireball.text = "Cost:";
			CostTextGoblinBarrel.text = "Cost:";
			CostTextLightning.text = "Cost:";
			CostTextRage.text = "Cost:";
			CostTextRocket.text = "Cost:";
			CostTextFreeze.text = "Cost:";
			CostTextZap.text = "Cost:";
			CostTextPoison.text = "Cost:";
			CostTextMirror.text = "Cost:";
			CostTextGraveyard.text = "Cost:";
			CostTextTheLog.text = "Cost:";
			CostTextTornado.text = "Cost:";
			CostTextClone.text = "Cost:";
			CostTextHeal.text = "Cost:";
			CostTextBarbarianBarrel.text = "Cost:";

		} else if (Player.Language == 2) {
			ArrowsName.text = spellManager.Arrows.SpellNameGerman;
			FireballName.text = spellManager.Fireball.SpellNameGerman;
			GoblinBarrelName.text = spellManager.GoblinBarrel.SpellNameGerman;
			LightningName.text = spellManager.Lightning.SpellNameGerman;
			RageName.text = spellManager.Rage.SpellNameGerman;
			RocketName.text = spellManager.Rocket.SpellNameGerman;
			FreezeName.text = spellManager.Freeze.SpellNameGerman;
			ZapName.text = spellManager.Zap.SpellNameGerman;
			PoisonName.text = spellManager.Poison.SpellNameGerman;
			MirrorName.text = spellManager.Mirror.SpellNameGerman;
			GraveyardName.text = spellManager.Graveyard.SpellNameGerman;
			TheLogName.text = spellManager.TheLog.SpellNameGerman;
			TornadoName.text = spellManager.Tornado.SpellNameGerman;
			CloneName.text = spellManager.Clone.SpellNameGerman;
			HealName.text = spellManager.Heal.SpellNameGerman;
			BarbarianBarrelName.text = spellManager.BarbarianBarrel.SpellNameGerman;

			CostTextArrows.text = "Kosten:";
			CostTextFireball.text = "Kosten:";
			CostTextGoblinBarrel.text = "Kosten:";
			CostTextLightning.text = "Kosten:";
			CostTextRage.text = "Kosten:";
			CostTextRocket.text = "Kosten:";
			CostTextFreeze.text = "Kosten:";
			CostTextZap.text = "Kosten:";
			CostTextPoison.text = "Kosten:";
			CostTextMirror.text = "Kosten:";
			CostTextGraveyard.text = "Kosten:";
			CostTextTheLog.text = "Kosten:";
			CostTextTornado.text = "Kosten:";
			CostTextClone.text = "Kosten:";
			CostTextHeal.text = "Kosten:";
			CostTextBarbarianBarrel.text = "Kosten:";
		}
		CheckArrowsUI ();;
		CheckFireballUI ();;
		CheckGoblinBarrelUI ();;
		CheckLightningUI ();;
		CheckRageUI ();;
		CheckRocketUI ();;
		CheckFreezeUI ();;
		CheckZapUI ();;
		CheckPoisonUI ();;
		CheckMirrorUI ();;
		CheckGraveyardUI ();;
		CheckTheLogUI ();;
		CheckTornadoUI ();;
		CheckCloneUI ();;
		CheckHealUI ();;
		CheckBarbarianBarrelUI ();;
	}

	public Text ArrowsName;
	public Text ArrowsCost;
	public Text ArrowsLevel;
	public Text ArrowsTier;
	public Text ArrowsCardCurrent;
	public Text ArrowsCardNextTier;
	public Image ArrowsTierProgress;

	void CheckArrowsUI () {
		ArrowsCost.text = Player.ArrowsElixCost.ToString ();  
		ArrowsLevel.text = Player.ArrowsLevel.ToString ();
		ArrowsTier.text = Player.ArrowsTier.ToString ();
		ArrowsCardCurrent.text = Player.ArrowsCards.ToString ();
		ArrowsCardNextTier.text = WizardShop.ArrowsNextTierCards.ToString();
		ArrowsTierProgress.fillAmount = (float) Player.ArrowsCards / WizardShop.ArrowsNextTierCards;
	}

	public void UpgradeArrowsUI () {
		ArrowsCost.text = Player.ArrowsElixCost.ToString ();
		ArrowsLevel.text = Player.ArrowsLevel.ToString ();
	}

	public void UpgradeTierArrowsUI () {
		ArrowsTier.text = Player.ArrowsTier.ToString ();
		ArrowsCardCurrent.text = Player.ArrowsCards.ToString ();
		ArrowsCardNextTier.text = WizardShop.ArrowsNextTierCards.ToString();
		ArrowsTierProgress.fillAmount = (float) Player.ArrowsCards / WizardShop.ArrowsNextTierCards;
	}

	public Text FireballName;
	public Text FireballCost;
	public Text FireballLevel;
	public Text FireballTier;
	public Text FireballCardCurrent;
	public Text FireballCardNextTier;
	public Image FireballTierProgress;

	void CheckFireballUI () {
		FireballCost.text = Player.FireballElixCost.ToString ();  
		FireballLevel.text = Player.FireballLevel.ToString ();
		FireballTier.text = Player.FireballTier.ToString ();
		FireballCardCurrent.text = Player.FireballCards.ToString ();
		FireballCardNextTier.text = WizardShop.FireballNextTierCards.ToString();
		FireballTierProgress.fillAmount = (float) Player.FireballCards / WizardShop.FireballNextTierCards;
	}

	public void UpgradeFireballUI () {
		FireballCost.text = Player.FireballElixCost.ToString ();
		FireballLevel.text = Player.FireballLevel.ToString ();
	}

	public void UpgradeTierFireballUI () {
		FireballTier.text = Player.FireballTier.ToString ();
		FireballCardCurrent.text = Player.FireballCards.ToString ();
		FireballCardNextTier.text = WizardShop.FireballNextTierCards.ToString();
		FireballTierProgress.fillAmount = (float) Player.FireballCards / WizardShop.FireballNextTierCards;
	}

	public Text GoblinBarrelName;
	public Text GoblinBarrelCost;
	public Text GoblinBarrelLevel;
	public Text GoblinBarrelTier;
	public Text GoblinBarrelCardCurrent;
	public Text GoblinBarrelCardNextTier;
	public Image GoblinBarrelTierProgress;

	void CheckGoblinBarrelUI () {
		GoblinBarrelCost.text = Player.GoblinBarrelElixCost.ToString ();  
		GoblinBarrelLevel.text = Player.GoblinBarrelLevel.ToString ();
		GoblinBarrelTier.text = Player.GoblinBarrelTier.ToString ();
		GoblinBarrelCardCurrent.text = Player.GoblinBarrelCards.ToString ();
		GoblinBarrelCardNextTier.text = WizardShop.GoblinBarrelNextTierCards.ToString();
		GoblinBarrelTierProgress.fillAmount = (float) Player.GoblinBarrelCards / WizardShop.GoblinBarrelNextTierCards;
	}

	public void UpgradeGoblinBarrelUI () {
		GoblinBarrelCost.text = Player.GoblinBarrelElixCost.ToString ();
		GoblinBarrelLevel.text = Player.GoblinBarrelLevel.ToString ();
	}

	public void UpgradeTierGoblinBarrelUI () {
		GoblinBarrelTier.text = Player.GoblinBarrelTier.ToString ();
		GoblinBarrelCardCurrent.text = Player.GoblinBarrelCards.ToString ();
		GoblinBarrelCardNextTier.text = WizardShop.GoblinBarrelNextTierCards.ToString();
		GoblinBarrelTierProgress.fillAmount = (float) Player.GoblinBarrelCards / WizardShop.GoblinBarrelNextTierCards;
	}

	public Text LightningName;
	public Text LightningCost;
	public Text LightningLevel;
	public Text LightningTier;
	public Text LightningCardCurrent;
	public Text LightningCardNextTier;
	public Image LightningTierProgress;

	void CheckLightningUI () {
		LightningCost.text = Player.LightningElixCost.ToString ();  
		LightningLevel.text = Player.LightningLevel.ToString ();
		LightningTier.text = Player.LightningTier.ToString ();
		LightningCardCurrent.text = Player.LightningCards.ToString ();
		LightningCardNextTier.text = WizardShop.LightningNextTierCards.ToString();
		LightningTierProgress.fillAmount = (float) Player.LightningCards / WizardShop.LightningNextTierCards;
	}

	public void UpgradeLightningUI () {
		LightningCost.text = Player.LightningElixCost.ToString ();
		LightningLevel.text = Player.LightningLevel.ToString ();
	}

	public void UpgradeTierLightningUI () {
		LightningTier.text = Player.LightningTier.ToString ();
		LightningCardCurrent.text = Player.LightningCards.ToString ();
		LightningCardNextTier.text = WizardShop.LightningNextTierCards.ToString();
		LightningTierProgress.fillAmount = (float) Player.LightningCards / WizardShop.LightningNextTierCards;
	}

	public Text RageName;
	public Text RageCost;
	public Text RageLevel;
	public Text RageTier;
	public Text RageCardCurrent;
	public Text RageCardNextTier;
	public Image RageTierProgress;

	void CheckRageUI () {
		RageCost.text = Player.RageElixCost.ToString ();  
		RageLevel.text = Player.RageLevel.ToString ();
		RageTier.text = Player.RageTier.ToString ();
		RageCardCurrent.text = Player.RageCards.ToString ();
		RageCardNextTier.text = WizardShop.RageNextTierCards.ToString();
		RageTierProgress.fillAmount = (float) Player.RageCards / WizardShop.RageNextTierCards;
	}

	public void UpgradeRageUI () {
		RageCost.text = Player.RageElixCost.ToString ();
		RageLevel.text = Player.RageLevel.ToString ();
	}

	public void UpgradeTierRageUI () {
		RageTier.text = Player.RageTier.ToString ();
		RageCardCurrent.text = Player.RageCards.ToString ();
		RageCardNextTier.text = WizardShop.RageNextTierCards.ToString();
		RageTierProgress.fillAmount = (float) Player.RageCards / WizardShop.RageNextTierCards;
	}

	public Text RocketName;
	public Text RocketCost;
	public Text RocketLevel;
	public Text RocketTier;
	public Text RocketCardCurrent;
	public Text RocketCardNextTier;
	public Image RocketTierProgress;

	void CheckRocketUI () {
		RocketCost.text = Player.RocketElixCost.ToString ();  
		RocketLevel.text = Player.RocketLevel.ToString ();
		RocketTier.text = Player.RocketTier.ToString ();
		RocketCardCurrent.text = Player.RocketCards.ToString ();
		RocketCardNextTier.text = WizardShop.RocketNextTierCards.ToString();
		RocketTierProgress.fillAmount = (float) Player.RocketCards / WizardShop.RocketNextTierCards;
	}

	public void UpgradeRocketUI () {
		RocketCost.text = Player.RocketElixCost.ToString ();
		RocketLevel.text = Player.RocketLevel.ToString ();
	}

	public void UpgradeTierRocketUI () {
		RocketTier.text = Player.RocketTier.ToString ();
		RocketCardCurrent.text = Player.RocketCards.ToString ();
		RocketCardNextTier.text = WizardShop.RocketNextTierCards.ToString();
		RocketTierProgress.fillAmount = (float) Player.RocketCards / WizardShop.RocketNextTierCards;
	}

	public Text FreezeName;
	public Text FreezeCost;
	public Text FreezeLevel;
	public Text FreezeTier;
	public Text FreezeCardCurrent;
	public Text FreezeCardNextTier;
	public Image FreezeTierProgress;

	void CheckFreezeUI () {
		FreezeCost.text = Player.FreezeElixCost.ToString ();  
		FreezeLevel.text = Player.FreezeLevel.ToString ();
		FreezeTier.text = Player.FreezeTier.ToString ();
		FreezeCardCurrent.text = Player.FreezeCards.ToString ();
		FreezeCardNextTier.text = WizardShop.FreezeNextTierCards.ToString();
		FreezeTierProgress.fillAmount = (float) Player.FreezeCards / WizardShop.FreezeNextTierCards;
	}

	public void UpgradeFreezeUI () {
		FreezeCost.text = Player.FreezeElixCost.ToString ();
		FreezeLevel.text = Player.FreezeLevel.ToString ();
	}

	public void UpgradeTierFreezeUI () {
		FreezeTier.text = Player.FreezeTier.ToString ();
		FreezeCardCurrent.text = Player.FreezeCards.ToString ();
		FreezeCardNextTier.text = WizardShop.FreezeNextTierCards.ToString();
		FreezeTierProgress.fillAmount = (float) Player.FreezeCards / WizardShop.FreezeNextTierCards;
	}

	public Text ZapName;
	public Text ZapCost;
	public Text ZapLevel;
	public Text ZapTier;
	public Text ZapCardCurrent;
	public Text ZapCardNextTier;
	public Image ZapTierProgress;

	void CheckZapUI () {
		ZapCost.text = Player.ZapElixCost.ToString ();  
		ZapLevel.text = Player.ZapLevel.ToString ();
		ZapTier.text = Player.ZapTier.ToString ();
		ZapCardCurrent.text = Player.ZapCards.ToString ();
		ZapCardNextTier.text = WizardShop.ZapNextTierCards.ToString();
		ZapTierProgress.fillAmount = (float) Player.ZapCards / WizardShop.ZapNextTierCards;
	}

	public void UpgradeZapUI () {
		ZapCost.text = Player.ZapElixCost.ToString ();
		ZapLevel.text = Player.ZapLevel.ToString ();
	}

	public void UpgradeTierZapUI () {
		ZapTier.text = Player.ZapTier.ToString ();
		ZapCardCurrent.text = Player.ZapCards.ToString ();
		ZapCardNextTier.text = WizardShop.ZapNextTierCards.ToString();
		ZapTierProgress.fillAmount = (float) Player.ZapCards / WizardShop.ZapNextTierCards;
	}

	public Text PoisonName;
	public Text PoisonCost;
	public Text PoisonLevel;
	public Text PoisonTier;
	public Text PoisonCardCurrent;
	public Text PoisonCardNextTier;
	public Image PoisonTierProgress;

	void CheckPoisonUI () {
		PoisonCost.text = Player.PoisonElixCost.ToString ();  
		PoisonLevel.text = Player.PoisonLevel.ToString ();
		PoisonTier.text = Player.PoisonTier.ToString ();
		PoisonCardCurrent.text = Player.PoisonCards.ToString ();
		PoisonCardNextTier.text = WizardShop.PoisonNextTierCards.ToString();
		PoisonTierProgress.fillAmount = (float) Player.PoisonCards / WizardShop.PoisonNextTierCards;
	}

	public void UpgradePoisonUI () {
		PoisonCost.text = Player.PoisonElixCost.ToString ();
		PoisonLevel.text = Player.PoisonLevel.ToString ();
	}

	public void UpgradeTierPoisonUI () {
		PoisonTier.text = Player.PoisonTier.ToString ();
		PoisonCardCurrent.text = Player.PoisonCards.ToString ();
		PoisonCardNextTier.text = WizardShop.PoisonNextTierCards.ToString();
		PoisonTierProgress.fillAmount = (float) Player.PoisonCards / WizardShop.PoisonNextTierCards;
	}

	public Text MirrorName;
	public Text MirrorCost;
	public Text MirrorLevel;
	public Text MirrorTier;
	public Text MirrorCardCurrent;
	public Text MirrorCardNextTier;
	public Image MirrorTierProgress;

	void CheckMirrorUI () {
		MirrorCost.text = Player.MirrorElixCost.ToString ();  
		MirrorLevel.text = Player.MirrorLevel.ToString ();
		MirrorTier.text = Player.MirrorTier.ToString ();
		MirrorCardCurrent.text = Player.MirrorCards.ToString ();
		MirrorCardNextTier.text = WizardShop.MirrorNextTierCards.ToString();
		MirrorTierProgress.fillAmount = (float) Player.MirrorCards / WizardShop.MirrorNextTierCards;
	}

	public void UpgradeMirrorUI () {
		MirrorCost.text = Player.MirrorElixCost.ToString ();
		MirrorLevel.text = Player.MirrorLevel.ToString ();
	}

	public void UpgradeTierMirrorUI () {
		MirrorTier.text = Player.MirrorTier.ToString ();
		MirrorCardCurrent.text = Player.MirrorCards.ToString ();
		MirrorCardNextTier.text = WizardShop.MirrorNextTierCards.ToString();
		MirrorTierProgress.fillAmount = (float) Player.MirrorCards / WizardShop.MirrorNextTierCards;
	}

	public Text GraveyardName;
	public Text GraveyardCost;
	public Text GraveyardLevel;
	public Text GraveyardTier;
	public Text GraveyardCardCurrent;
	public Text GraveyardCardNextTier;
	public Image GraveyardTierProgress;

	void CheckGraveyardUI () {
		GraveyardCost.text = Player.GraveyardElixCost.ToString ();  
		GraveyardLevel.text = Player.GraveyardLevel.ToString ();
		GraveyardTier.text = Player.GraveyardTier.ToString ();
		GraveyardCardCurrent.text = Player.GraveyardCards.ToString ();
		GraveyardCardNextTier.text = WizardShop.GraveyardNextTierCards.ToString();
		GraveyardTierProgress.fillAmount = (float) Player.GraveyardCards / WizardShop.GraveyardNextTierCards;
	}

	public void UpgradeGraveyardUI () {
		GraveyardCost.text = Player.GraveyardElixCost.ToString ();
		GraveyardLevel.text = Player.GraveyardLevel.ToString ();
	}

	public void UpgradeTierGraveyardUI () {
		GraveyardTier.text = Player.GraveyardTier.ToString ();
		GraveyardCardCurrent.text = Player.GraveyardCards.ToString ();
		GraveyardCardNextTier.text = WizardShop.GraveyardNextTierCards.ToString();
		GraveyardTierProgress.fillAmount = (float) Player.GraveyardCards / WizardShop.GraveyardNextTierCards;
	}

	public Text TheLogName;
	public Text TheLogCost;
	public Text TheLogLevel;
	public Text TheLogTier;
	public Text TheLogCardCurrent;
	public Text TheLogCardNextTier;
	public Image TheLogTierProgress;

	void CheckTheLogUI () {
		TheLogCost.text = Player.TheLogElixCost.ToString ();  
		TheLogLevel.text = Player.TheLogLevel.ToString ();
		TheLogTier.text = Player.TheLogTier.ToString ();
		TheLogCardCurrent.text = Player.TheLogCards.ToString ();
		TheLogCardNextTier.text = WizardShop.TheLogNextTierCards.ToString();
		TheLogTierProgress.fillAmount = (float) Player.TheLogCards / WizardShop.TheLogNextTierCards;
	}

	public void UpgradeTheLogUI () {
		TheLogCost.text = Player.TheLogElixCost.ToString ();
		TheLogLevel.text = Player.TheLogLevel.ToString ();
	}

	public void UpgradeTierTheLogUI () {
		TheLogTier.text = Player.TheLogTier.ToString ();
		TheLogCardCurrent.text = Player.TheLogCards.ToString ();
		TheLogCardNextTier.text = WizardShop.TheLogNextTierCards.ToString();
		TheLogTierProgress.fillAmount = (float) Player.TheLogCards / WizardShop.TheLogNextTierCards;
	}

	public Text TornadoName;
	public Text TornadoCost;
	public Text TornadoLevel;
	public Text TornadoTier;
	public Text TornadoCardCurrent;
	public Text TornadoCardNextTier;
	public Image TornadoTierProgress;

	void CheckTornadoUI () {
		TornadoCost.text = Player.TornadoElixCost.ToString ();  
		TornadoLevel.text = Player.TornadoLevel.ToString ();
		TornadoTier.text = Player.TornadoTier.ToString ();
		TornadoCardCurrent.text = Player.TornadoCards.ToString ();
		TornadoCardNextTier.text = WizardShop.TornadoNextTierCards.ToString();
		TornadoTierProgress.fillAmount = (float) Player.TornadoCards / WizardShop.TornadoNextTierCards;
	}

	public void UpgradeTornadoUI () {
		TornadoCost.text = Player.TornadoElixCost.ToString ();
		TornadoLevel.text = Player.TornadoLevel.ToString ();
	}

	public void UpgradeTierTornadoUI () {
		TornadoTier.text = Player.TornadoTier.ToString ();
		TornadoCardCurrent.text = Player.TornadoCards.ToString ();
		TornadoCardNextTier.text = WizardShop.TornadoNextTierCards.ToString();
		TornadoTierProgress.fillAmount = (float) Player.TornadoCards / WizardShop.TornadoNextTierCards;
	}

	public Text CloneName;
	public Text CloneCost;
	public Text CloneLevel;
	public Text CloneTier;
	public Text CloneCardCurrent;
	public Text CloneCardNextTier;
	public Image CloneTierProgress;

	void CheckCloneUI () {
		CloneCost.text = Player.CloneElixCost.ToString ();  
		CloneLevel.text = Player.CloneLevel.ToString ();
		CloneTier.text = Player.CloneTier.ToString ();
		CloneCardCurrent.text = Player.CloneCards.ToString ();
		CloneCardNextTier.text = WizardShop.CloneNextTierCards.ToString();
		CloneTierProgress.fillAmount = (float) Player.CloneCards / WizardShop.CloneNextTierCards;
	}

	public void UpgradeCloneUI () {
		CloneCost.text = Player.CloneElixCost.ToString ();
		CloneLevel.text = Player.CloneLevel.ToString ();
	}

	public void UpgradeTierCloneUI () {
		CloneTier.text = Player.CloneTier.ToString ();
		CloneCardCurrent.text = Player.CloneCards.ToString ();
		CloneCardNextTier.text = WizardShop.CloneNextTierCards.ToString();
		CloneTierProgress.fillAmount = (float) Player.CloneCards / WizardShop.CloneNextTierCards;
	}

	public Text HealName;
	public Text HealCost;
	public Text HealLevel;
	public Text HealTier;
	public Text HealCardCurrent;
	public Text HealCardNextTier;
	public Image HealTierProgress;

	void CheckHealUI () {
		HealCost.text = Player.HealElixCost.ToString ();  
		HealLevel.text = Player.HealLevel.ToString ();
		HealTier.text = Player.HealTier.ToString ();
		HealCardCurrent.text = Player.HealCards.ToString ();
		HealCardNextTier.text = WizardShop.HealNextTierCards.ToString();
		HealTierProgress.fillAmount = (float) Player.HealCards / WizardShop.HealNextTierCards;
	}

	public void UpgradeHealUI () {
		HealCost.text = Player.HealElixCost.ToString ();
		HealLevel.text = Player.HealLevel.ToString ();
	}

	public void UpgradeTierHealUI () {
		HealTier.text = Player.HealTier.ToString ();
		HealCardCurrent.text = Player.HealCards.ToString ();
		HealCardNextTier.text = WizardShop.HealNextTierCards.ToString();
		HealTierProgress.fillAmount = (float) Player.HealCards / WizardShop.HealNextTierCards;
	}

	public Text BarbarianBarrelName;
	public Text BarbarianBarrelCost;
	public Text BarbarianBarrelLevel;
	public Text BarbarianBarrelTier;
	public Text BarbarianBarrelCardCurrent;
	public Text BarbarianBarrelCardNextTier;
	public Image BarbarianBarrelTierProgress;

	void CheckBarbarianBarrelUI () {
		BarbarianBarrelCost.text = Player.BarbarianBarrelElixCost.ToString ();  
		BarbarianBarrelLevel.text = Player.BarbarianBarrelLevel.ToString ();
		BarbarianBarrelTier.text = Player.BarbarianBarrelTier.ToString ();
		BarbarianBarrelCardCurrent.text = Player.BarbarianBarrelCards.ToString ();
		BarbarianBarrelCardNextTier.text = WizardShop.BarbarianBarrelNextTierCards.ToString();
		BarbarianBarrelTierProgress.fillAmount = (float) Player.BarbarianBarrelCards / WizardShop.BarbarianBarrelNextTierCards;
	}

	public void UpgradeBarbarianBarrelUI () {
		BarbarianBarrelCost.text = Player.BarbarianBarrelElixCost.ToString ();
		BarbarianBarrelLevel.text = Player.BarbarianBarrelLevel.ToString ();
	}

	public void UpgradeTierBarbarianBarrelUI () {
		BarbarianBarrelTier.text = Player.BarbarianBarrelTier.ToString ();
		BarbarianBarrelCardCurrent.text = Player.BarbarianBarrelCards.ToString ();
		BarbarianBarrelCardNextTier.text = WizardShop.BarbarianBarrelNextTierCards.ToString();
		BarbarianBarrelTierProgress.fillAmount = (float) Player.BarbarianBarrelCards / WizardShop.BarbarianBarrelNextTierCards;
	}

}
