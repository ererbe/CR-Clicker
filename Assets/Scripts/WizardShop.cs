using System.Collections;
using UnityEngine;

public class WizardShop : MonoBehaviour {

	public WizardUI wizardUI;
	public SpellManager spellManager;
	public ArenaTextUI arenaTextUI;
	public ExperienceUI experienceUI;
	public SpellEffects spellEffects;

	public static int ArrowsNextTierCards;
	public static int FireballNextTierCards;
	public static int GoblinBarrelNextTierCards;
	public static int LightningNextTierCards;
	public static int RageNextTierCards;
	public static int RocketNextTierCards;
	public static int FreezeNextTierCards;
	public static int ZapNextTierCards;
	public static int PoisonNextTierCards;
	public static int MirrorNextTierCards;
	public static int GraveyardNextTierCards;
	public static int TheLogNextTierCards;
	public static int TornadoNextTierCards;
	public static int CloneNextTierCards;
	public static int HealNextTierCards;
	public static int BarbarianBarrelNextTierCards;

	private float x;

	void Awake () {
		UpdateSpellStatistics ();
	}

	public void UpdateSpellStatistics () {
		CalculateArrowsStats ();
		CalculateFireballStats ();
		CalculateGoblinBarrelStats ();
		CalculateLightningStats ();
		CalculateRageStats ();
		CalculateRocketStats ();
		CalculateFreezeStats ();
		CalculateZapStats ();
		CalculatePoisonStats ();
		CalculateMirrorStats ();
		CalculateGraveyardStats ();
		CalculateTheLogStats ();
		CalculateTornadoStats ();
		CalculateCloneStats ();
		CalculateHealStats ();
		CalculateBarbarianBarrelStats ();

		CheckArrowsTierCards ();
		CheckFireballTierCards ();
		CheckGoblinBarrelTierCards ();
		CheckLightningTierCards ();
		CheckRageTierCards ();
		CheckRocketTierCards ();
		CheckFreezeTierCards ();
		CheckZapTierCards ();
		CheckPoisonTierCards ();
		CheckMirrorTierCards ();
		CheckGraveyardTierCards ();
		CheckTheLogTierCards ();
		CheckTornadoTierCards ();
		CheckCloneTierCards ();
		CheckHealTierCards ();
		CheckBarbarianBarrelTierCards ();

		CalculateNewArrowsCost ();
		CalculateNewFireballCost ();
		CalculateNewGoblinBarrelCost ();
		CalculateNewLightningCost ();
		CalculateNewRageCost ();
		CalculateNewRocketCost ();
		CalculateNewFreezeCost ();
		CalculateNewZapCost ();
		CalculateNewPoisonCost ();
		CalculateNewMirrorCost ();
		CalculateNewGraveyardCost ();
		CalculateNewTheLogCost ();
		CalculateNewTornadoCost ();
		CalculateNewCloneCost ();
		CalculateNewHealCost ();
		CalculateNewBarbarianBarrelCost ();
	}

	public void UpgradeArrows () {
		if (Player.Elix >= Player.ArrowsElixCost) {
			Player.Elix -= Player.ArrowsElixCost;
			Player.ArrowsLevel += 1;
			Player.Experience += spellManager.Arrows.ExperiencePerLevel;
			Player.Trophys += spellManager.Arrows.TrophysPerLevel;
			CalculateArrowsStats ();
			CalculateNewArrowsCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierArrows () {
		if (Player.ArrowsCards >= ArrowsNextTierCards && Player.ArrowsTier <= 12) {
			Player.ArrowsCards -= ArrowsNextTierCards;
			Player.ArrowsTier += 1;
			Player.Experience += spellManager.Arrows.ExperiencePerTier;
			Player.Trophys += spellManager.Arrows.TrophysPerTier;
			wizardUI.UpgradeTierArrowsUI ();
			CheckArrowsTierCards ();
			CalculateArrowsStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateArrowsStats () {
		if (Player.ArrowsTier >= 1) {
			spellManager.Arrows.Power = (float)spellManager.Arrows.DefaultPower + ((spellManager.Arrows.DefaultPower/5) * Player.ArrowsLevel) + (spellManager.Arrows.DefaultPower * Player.ArrowsTier);
			spellManager.Arrows.Cooldown = (float) spellManager.Arrows.DefaultCooldown - ((spellManager.Arrows.DefaultCooldown/20) * Player.ArrowsTier);
		} else {
			spellManager.Arrows.Power = 0f;
			spellManager.Arrows.Cooldown = 0f;
		}
	}

	public void CalculateNewArrowsCost() {
		x = (float) Mathf.Pow(1.15f , Player.ArrowsLevel);
		Player.ArrowsElixCost = Mathf.FloorToInt((float) spellManager.Arrows.DefaultElixCost * x);
		wizardUI.UpgradeArrowsUI ();
	}

	public void CheckArrowsTierCards () {
		if (Player.ArrowsTier == 0) {
			ArrowsNextTierCards = Player.CardsToTier1;
		} else if (Player.ArrowsTier == 1) {
			ArrowsNextTierCards = Player.CardsToTier2;
		} else if (Player.ArrowsTier == 2) {
			ArrowsNextTierCards = Player.CardsToTier3;
		} else if (Player.ArrowsTier == 3) {
			ArrowsNextTierCards = Player.CardsToTier4;
		} else if (Player.ArrowsTier == 4) {
			ArrowsNextTierCards = Player.CardsToTier5;
		} else if (Player.ArrowsTier == 5) {
			ArrowsNextTierCards = Player.CardsToTier6;
		} else if (Player.ArrowsTier == 6) {
			ArrowsNextTierCards = Player.CardsToTier7;
		} else if (Player.ArrowsTier == 7) {
			ArrowsNextTierCards = Player.CardsToTier8;
		} else if (Player.ArrowsTier == 8) {
			ArrowsNextTierCards = Player.CardsToTier9;
		} else if (Player.ArrowsTier == 9) {
			ArrowsNextTierCards = Player.CardsToTier10;
		} else if (Player.ArrowsTier == 10) {
			ArrowsNextTierCards = Player.CardsToTier11;
		} else if (Player.ArrowsTier == 11) {
			ArrowsNextTierCards = Player.CardsToTier12;
		} else if (Player.ArrowsTier == 12) {
			ArrowsNextTierCards = Player.CardsToTier13;
		} else if (Player.ArrowsTier == 13) {
			ArrowsNextTierCards = 0;
		} else {
			ArrowsNextTierCards = 0;
		}
	}


	public void UpgradeFireball () {
		if (Player.Elix >= Player.FireballElixCost) {
			Player.Elix -= Player.FireballElixCost;
			Player.FireballLevel += 1;
			Player.Experience += spellManager.Fireball.ExperiencePerLevel;
			Player.Trophys += spellManager.Fireball.TrophysPerLevel;
			CalculateFireballStats ();
			CalculateNewFireballCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierFireball () {
		if (Player.FireballCards >= FireballNextTierCards && Player.FireballTier <= 12) {
			Player.FireballCards -= FireballNextTierCards;
			Player.FireballTier += 1;
			Player.Experience += spellManager.Fireball.ExperiencePerTier;
			Player.Trophys += spellManager.Fireball.TrophysPerTier;
			wizardUI.UpgradeTierFireballUI ();
			CheckFireballTierCards ();
			CalculateFireballStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateFireballStats () {
		if (Player.FireballTier >= 1) {
			spellManager.Fireball.Power = (float)spellManager.Fireball.DefaultPower + ((spellManager.Fireball.DefaultPower/5) * Player.FireballLevel) + (spellManager.Fireball.DefaultPower * Player.FireballTier);
			spellManager.Fireball.Cooldown = (float) spellManager.Fireball.DefaultCooldown - ((spellManager.Fireball.DefaultCooldown/20) * Player.FireballTier);
		} else {
			spellManager.Fireball.Power = 0f;
			spellManager.Fireball.Cooldown = 0f;
		}
	}

	public void CalculateNewFireballCost() {
		x = (float) Mathf.Pow(1.15f , Player.FireballLevel);
		Player.FireballElixCost = Mathf.FloorToInt((float) spellManager.Fireball.DefaultElixCost * x);
		wizardUI.UpgradeFireballUI ();
	}

	public void CheckFireballTierCards () {
		if (Player.FireballTier == 0) {
			FireballNextTierCards = Player.CardsToTier1;
		} else if (Player.FireballTier == 1) {
			FireballNextTierCards = Player.CardsToTier2;
		} else if (Player.FireballTier == 2) {
			FireballNextTierCards = Player.CardsToTier3;
		} else if (Player.FireballTier == 3) {
			FireballNextTierCards = Player.CardsToTier4;
		} else if (Player.FireballTier == 4) {
			FireballNextTierCards = Player.CardsToTier5;
		} else if (Player.FireballTier == 5) {
			FireballNextTierCards = Player.CardsToTier6;
		} else if (Player.FireballTier == 6) {
			FireballNextTierCards = Player.CardsToTier7;
		} else if (Player.FireballTier == 7) {
			FireballNextTierCards = Player.CardsToTier8;
		} else if (Player.FireballTier == 8) {
			FireballNextTierCards = Player.CardsToTier9;
		} else if (Player.FireballTier == 9) {
			FireballNextTierCards = Player.CardsToTier10;
		} else if (Player.FireballTier == 10) {
			FireballNextTierCards = Player.CardsToTier11;
		} else if (Player.FireballTier == 11) {
			FireballNextTierCards = Player.CardsToTier12;
		} else if (Player.FireballTier == 12) {
			FireballNextTierCards = Player.CardsToTier13;
		} else if (Player.FireballTier == 13) {
			FireballNextTierCards = 0;
		} else {
			FireballNextTierCards = 0;
		}
	}

	public void UpgradeGoblinBarrel () {
		if (Player.Elix >= Player.GoblinBarrelElixCost) {
			Player.Elix -= Player.GoblinBarrelElixCost;
			Player.GoblinBarrelLevel += 1;
			Player.Experience += spellManager.GoblinBarrel.ExperiencePerLevel;
			Player.Trophys += spellManager.GoblinBarrel.TrophysPerLevel;
			CalculateGoblinBarrelStats ();
			CalculateNewGoblinBarrelCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierGoblinBarrel () {
		if (Player.GoblinBarrelCards >= GoblinBarrelNextTierCards && Player.GoblinBarrelTier <= 12) {
			Player.GoblinBarrelCards -= GoblinBarrelNextTierCards;
			Player.GoblinBarrelTier += 1;
			Player.Experience += spellManager.GoblinBarrel.ExperiencePerTier;
			Player.Trophys += spellManager.GoblinBarrel.TrophysPerTier;
			wizardUI.UpgradeTierGoblinBarrelUI ();
			CheckGoblinBarrelTierCards ();
			CalculateGoblinBarrelStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateGoblinBarrelStats () {
		if (Player.GoblinBarrelTier >= 1) {
			spellManager.GoblinBarrel.Power = (float)spellManager.GoblinBarrel.DefaultPower + ((spellManager.GoblinBarrel.DefaultPower/5) * Player.GoblinBarrelLevel) + (spellManager.GoblinBarrel.DefaultPower * Player.GoblinBarrelTier);
			spellManager.GoblinBarrel.Cooldown = (float) spellManager.GoblinBarrel.DefaultCooldown - ((spellManager.GoblinBarrel.DefaultCooldown/20) * Player.GoblinBarrelTier);
		} else {
			spellManager.GoblinBarrel.Power = 0f;
			spellManager.GoblinBarrel.Cooldown = 0f;
		}
	}

	public void CalculateNewGoblinBarrelCost() {
		x = (float) Mathf.Pow(1.15f , Player.GoblinBarrelLevel);
		Player.GoblinBarrelElixCost = Mathf.FloorToInt((float) spellManager.GoblinBarrel.DefaultElixCost * x);
		wizardUI.UpgradeGoblinBarrelUI ();
	}

	public void CheckGoblinBarrelTierCards () {
		if (Player.GoblinBarrelTier == 0) {
			GoblinBarrelNextTierCards = Player.CardsToTier1;
		} else if (Player.GoblinBarrelTier == 1) {
			GoblinBarrelNextTierCards = Player.CardsToTier2;
		} else if (Player.GoblinBarrelTier == 2) {
			GoblinBarrelNextTierCards = Player.CardsToTier3;
		} else if (Player.GoblinBarrelTier == 3) {
			GoblinBarrelNextTierCards = Player.CardsToTier4;
		} else if (Player.GoblinBarrelTier == 4) {
			GoblinBarrelNextTierCards = Player.CardsToTier5;
		} else if (Player.GoblinBarrelTier == 5) {
			GoblinBarrelNextTierCards = Player.CardsToTier6;
		} else if (Player.GoblinBarrelTier == 6) {
			GoblinBarrelNextTierCards = Player.CardsToTier7;
		} else if (Player.GoblinBarrelTier == 7) {
			GoblinBarrelNextTierCards = Player.CardsToTier8;
		} else if (Player.GoblinBarrelTier == 8) {
			GoblinBarrelNextTierCards = Player.CardsToTier9;
		} else if (Player.GoblinBarrelTier == 9) {
			GoblinBarrelNextTierCards = Player.CardsToTier10;
		} else if (Player.GoblinBarrelTier == 10) {
			GoblinBarrelNextTierCards = Player.CardsToTier11;
		} else if (Player.GoblinBarrelTier == 11) {
			GoblinBarrelNextTierCards = Player.CardsToTier12;
		} else if (Player.GoblinBarrelTier == 12) {
			GoblinBarrelNextTierCards = Player.CardsToTier13;
		} else if (Player.GoblinBarrelTier == 13) {
			GoblinBarrelNextTierCards = 0;
		} else {
			GoblinBarrelNextTierCards = 0;
		}
	}

	public void UpgradeLightning () {
		if (Player.Elix >= Player.LightningElixCost) {
			Player.Elix -= Player.LightningElixCost;
			Player.LightningLevel += 1;
			Player.Experience += spellManager.Lightning.ExperiencePerLevel;
			Player.Trophys += spellManager.Lightning.TrophysPerLevel;
			CalculateLightningStats ();
			CalculateNewLightningCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierLightning () {
		if (Player.LightningCards >= LightningNextTierCards && Player.LightningTier <= 12) {
			Player.LightningCards -= LightningNextTierCards;
			Player.LightningTier += 1;
			Player.Experience += spellManager.Lightning.ExperiencePerTier;
			Player.Trophys += spellManager.Lightning.TrophysPerTier;
			wizardUI.UpgradeTierLightningUI ();
			CheckLightningTierCards ();
			CalculateLightningStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateLightningStats () {
		if (Player.LightningTier >= 1) {
			spellManager.Lightning.Power = (float)spellManager.Lightning.DefaultPower + ((spellManager.Lightning.DefaultPower/5) * Player.LightningLevel) + (spellManager.Lightning.DefaultPower * Player.LightningTier);
			spellManager.Lightning.Cooldown = (float) spellManager.Lightning.DefaultCooldown - ((spellManager.Lightning.DefaultCooldown/20) * Player.LightningTier);
		} else {
			spellManager.Lightning.Power = 0f;
			spellManager.Lightning.Cooldown = 0f;
		}
	}

	public void CalculateNewLightningCost() {
		x = (float) Mathf.Pow(1.15f , Player.LightningLevel);
		Player.LightningElixCost = Mathf.FloorToInt((float) spellManager.Lightning.DefaultElixCost * x);
		wizardUI.UpgradeLightningUI ();
	}

	public void CheckLightningTierCards () {
		if (Player.LightningTier == 0) {
			LightningNextTierCards = Player.CardsToTier1;
		} else if (Player.LightningTier == 1) {
			LightningNextTierCards = Player.CardsToTier2;
		} else if (Player.LightningTier == 2) {
			LightningNextTierCards = Player.CardsToTier3;
		} else if (Player.LightningTier == 3) {
			LightningNextTierCards = Player.CardsToTier4;
		} else if (Player.LightningTier == 4) {
			LightningNextTierCards = Player.CardsToTier5;
		} else if (Player.LightningTier == 5) {
			LightningNextTierCards = Player.CardsToTier6;
		} else if (Player.LightningTier == 6) {
			LightningNextTierCards = Player.CardsToTier7;
		} else if (Player.LightningTier == 7) {
			LightningNextTierCards = Player.CardsToTier8;
		} else if (Player.LightningTier == 8) {
			LightningNextTierCards = Player.CardsToTier9;
		} else if (Player.LightningTier == 9) {
			LightningNextTierCards = Player.CardsToTier10;
		} else if (Player.LightningTier == 10) {
			LightningNextTierCards = Player.CardsToTier11;
		} else if (Player.LightningTier == 11) {
			LightningNextTierCards = Player.CardsToTier12;
		} else if (Player.LightningTier == 12) {
			LightningNextTierCards = Player.CardsToTier13;
		} else if (Player.LightningTier == 13) {
			LightningNextTierCards = 0;
		} else {
			LightningNextTierCards = 0;
		}
	}

	public void UpgradeRage () {
		if (Player.Elix >= Player.RageElixCost) {
			Player.Elix -= Player.RageElixCost;
			Player.RageLevel += 1;
			Player.Experience += spellManager.Rage.ExperiencePerLevel;
			Player.Trophys += spellManager.Rage.TrophysPerLevel;
			CalculateRageStats ();
			CalculateNewRageCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierRage () {
		if (Player.RageCards >= RageNextTierCards && Player.RageTier <= 12) {
			Player.RageCards -= RageNextTierCards;
			Player.RageTier += 1;
			Player.Experience += spellManager.Rage.ExperiencePerTier;
			Player.Trophys += spellManager.Rage.TrophysPerTier;
			wizardUI.UpgradeTierRageUI ();
			CheckRageTierCards ();
			CalculateRageStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateRageStats () {
		if (Player.RageTier >= 1) {
			spellManager.Rage.Power = (float)spellManager.Rage.DefaultPower + ((spellManager.Rage.DefaultPower/5) * Player.RageLevel) + (spellManager.Rage.DefaultPower * Player.RageTier);
			spellManager.Rage.Cooldown = (float) spellManager.Rage.DefaultCooldown - ((spellManager.Rage.DefaultCooldown/20) * Player.RageTier);
		} else {
			spellManager.Rage.Power = 0f;
			spellManager.Rage.Cooldown = 0f;
		}
	}

	public void CalculateNewRageCost() {
		x = (float) Mathf.Pow(1.15f , Player.RageLevel);
		Player.RageElixCost = Mathf.FloorToInt((float) spellManager.Rage.DefaultElixCost * x);
		wizardUI.UpgradeRageUI ();
	}

	public void CheckRageTierCards () {
		if (Player.RageTier == 0) {
			RageNextTierCards = Player.CardsToTier1;
		} else if (Player.RageTier == 1) {
			RageNextTierCards = Player.CardsToTier2;
		} else if (Player.RageTier == 2) {
			RageNextTierCards = Player.CardsToTier3;
		} else if (Player.RageTier == 3) {
			RageNextTierCards = Player.CardsToTier4;
		} else if (Player.RageTier == 4) {
			RageNextTierCards = Player.CardsToTier5;
		} else if (Player.RageTier == 5) {
			RageNextTierCards = Player.CardsToTier6;
		} else if (Player.RageTier == 6) {
			RageNextTierCards = Player.CardsToTier7;
		} else if (Player.RageTier == 7) {
			RageNextTierCards = Player.CardsToTier8;
		} else if (Player.RageTier == 8) {
			RageNextTierCards = Player.CardsToTier9;
		} else if (Player.RageTier == 9) {
			RageNextTierCards = Player.CardsToTier10;
		} else if (Player.RageTier == 10) {
			RageNextTierCards = Player.CardsToTier11;
		} else if (Player.RageTier == 11) {
			RageNextTierCards = Player.CardsToTier12;
		} else if (Player.RageTier == 12) {
			RageNextTierCards = Player.CardsToTier13;
		} else if (Player.RageTier == 13) {
			RageNextTierCards = 0;
		} else {
			RageNextTierCards = 0;
		}
	}

	public void UpgradeRocket () {
		if (Player.Elix >= Player.RocketElixCost) {
			Player.Elix -= Player.RocketElixCost;
			Player.RocketLevel += 1;
			Player.Experience += spellManager.Rocket.ExperiencePerLevel;
			Player.Trophys += spellManager.Rocket.TrophysPerLevel;
			CalculateRocketStats ();
			CalculateNewRocketCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierRocket () {
		if (Player.RocketCards >= RocketNextTierCards && Player.RocketTier <= 12) {
			Player.RocketCards -= RocketNextTierCards;
			Player.RocketTier += 1;
			Player.Experience += spellManager.Rocket.ExperiencePerTier;
			Player.Trophys += spellManager.Rocket.TrophysPerTier;
			wizardUI.UpgradeTierRocketUI ();
			CheckRocketTierCards ();
			CalculateRocketStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateRocketStats () {
		if (Player.RocketTier >= 1) {
			spellManager.Rocket.Power = (float)spellManager.Rocket.DefaultPower + ((spellManager.Rocket.DefaultPower/5) * Player.RocketLevel) + (spellManager.Rocket.DefaultPower * Player.RocketTier);
			spellManager.Rocket.Cooldown = (float) spellManager.Rocket.DefaultCooldown - ((spellManager.Rocket.DefaultCooldown/20) * Player.RocketTier);
		} else {
			spellManager.Rocket.Power = 0f;
			spellManager.Rocket.Cooldown = 0f;
		}
	}

	public void CalculateNewRocketCost() {
		x = (float) Mathf.Pow(1.15f , Player.RocketLevel);
		Player.RocketElixCost = Mathf.FloorToInt((float) spellManager.Rocket.DefaultElixCost * x);
		wizardUI.UpgradeRocketUI ();
	}

	public void CheckRocketTierCards () {
		if (Player.RocketTier == 0) {
			RocketNextTierCards = Player.CardsToTier1;
		} else if (Player.RocketTier == 1) {
			RocketNextTierCards = Player.CardsToTier2;
		} else if (Player.RocketTier == 2) {
			RocketNextTierCards = Player.CardsToTier3;
		} else if (Player.RocketTier == 3) {
			RocketNextTierCards = Player.CardsToTier4;
		} else if (Player.RocketTier == 4) {
			RocketNextTierCards = Player.CardsToTier5;
		} else if (Player.RocketTier == 5) {
			RocketNextTierCards = Player.CardsToTier6;
		} else if (Player.RocketTier == 6) {
			RocketNextTierCards = Player.CardsToTier7;
		} else if (Player.RocketTier == 7) {
			RocketNextTierCards = Player.CardsToTier8;
		} else if (Player.RocketTier == 8) {
			RocketNextTierCards = Player.CardsToTier9;
		} else if (Player.RocketTier == 9) {
			RocketNextTierCards = Player.CardsToTier10;
		} else if (Player.RocketTier == 10) {
			RocketNextTierCards = Player.CardsToTier11;
		} else if (Player.RocketTier == 11) {
			RocketNextTierCards = Player.CardsToTier12;
		} else if (Player.RocketTier == 12) {
			RocketNextTierCards = Player.CardsToTier13;
		} else if (Player.RocketTier == 13) {
			RocketNextTierCards = 0;
		} else {
			RocketNextTierCards = 0;
		}
	}

	public void UpgradeFreeze () {
		if (Player.Elix >= Player.FreezeElixCost) {
			Player.Elix -= Player.FreezeElixCost;
			Player.FreezeLevel += 1;
			Player.Experience += spellManager.Freeze.ExperiencePerLevel;
			Player.Trophys += spellManager.Freeze.TrophysPerLevel;
			CalculateFreezeStats ();
			CalculateNewFreezeCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierFreeze () {
		if (Player.FreezeCards >= FreezeNextTierCards && Player.FreezeTier <= 12) {
			Player.FreezeCards -= FreezeNextTierCards;
			Player.FreezeTier += 1;
			Player.Experience += spellManager.Freeze.ExperiencePerTier;
			Player.Trophys += spellManager.Freeze.TrophysPerTier;
			wizardUI.UpgradeTierFreezeUI ();
			CheckFreezeTierCards ();
			CalculateFreezeStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateFreezeStats () {
		if (Player.FreezeTier >= 1) {
			spellManager.Freeze.Power = (float)spellManager.Freeze.DefaultPower + ((spellManager.Freeze.DefaultPower/5) * Player.FreezeLevel) + (spellManager.Freeze.DefaultPower * Player.FreezeTier);
			spellManager.Freeze.Cooldown = (float) spellManager.Freeze.DefaultCooldown - ((spellManager.Freeze.DefaultCooldown/20) * Player.FreezeTier);
		} else {
			spellManager.Freeze.Power = 0f;
			spellManager.Freeze.Cooldown = 0f;
		}
	}

	public void CalculateNewFreezeCost() {
		x = (float) Mathf.Pow(1.15f , Player.FreezeLevel);
		Player.FreezeElixCost = Mathf.FloorToInt((float) spellManager.Freeze.DefaultElixCost * x);
		wizardUI.UpgradeFreezeUI ();
	}

	public void CheckFreezeTierCards () {
		if (Player.FreezeTier == 0) {
			FreezeNextTierCards = Player.CardsToTier1;
		} else if (Player.FreezeTier == 1) {
			FreezeNextTierCards = Player.CardsToTier2;
		} else if (Player.FreezeTier == 2) {
			FreezeNextTierCards = Player.CardsToTier3;
		} else if (Player.FreezeTier == 3) {
			FreezeNextTierCards = Player.CardsToTier4;
		} else if (Player.FreezeTier == 4) {
			FreezeNextTierCards = Player.CardsToTier5;
		} else if (Player.FreezeTier == 5) {
			FreezeNextTierCards = Player.CardsToTier6;
		} else if (Player.FreezeTier == 6) {
			FreezeNextTierCards = Player.CardsToTier7;
		} else if (Player.FreezeTier == 7) {
			FreezeNextTierCards = Player.CardsToTier8;
		} else if (Player.FreezeTier == 8) {
			FreezeNextTierCards = Player.CardsToTier9;
		} else if (Player.FreezeTier == 9) {
			FreezeNextTierCards = Player.CardsToTier10;
		} else if (Player.FreezeTier == 10) {
			FreezeNextTierCards = Player.CardsToTier11;
		} else if (Player.FreezeTier == 11) {
			FreezeNextTierCards = Player.CardsToTier12;
		} else if (Player.FreezeTier == 12) {
			FreezeNextTierCards = Player.CardsToTier13;
		} else if (Player.FreezeTier == 13) {
			FreezeNextTierCards = 0;
		} else {
			FreezeNextTierCards = 0;
		}
	}

	public void UpgradeZap () {
		if (Player.Elix >= Player.ZapElixCost) {
			Player.Elix -= Player.ZapElixCost;
			Player.ZapLevel += 1;
			Player.Experience += spellManager.Zap.ExperiencePerLevel;
			Player.Trophys += spellManager.Zap.TrophysPerLevel;
			CalculateZapStats ();
			CalculateNewZapCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierZap () {
		if (Player.ZapCards >= ZapNextTierCards && Player.ZapTier <= 12) {
			Player.ZapCards -= ZapNextTierCards;
			Player.ZapTier += 1;
			Player.Experience += spellManager.Zap.ExperiencePerTier;
			Player.Trophys += spellManager.Zap.TrophysPerTier;
			wizardUI.UpgradeTierZapUI ();
			CheckZapTierCards ();
			CalculateZapStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateZapStats () {
		if (Player.ZapTier >= 1) {
			spellManager.Zap.Power = (float)spellManager.Zap.DefaultPower + ((spellManager.Zap.DefaultPower/5) * Player.ZapLevel) + (spellManager.Zap.DefaultPower * Player.ZapTier);
			spellManager.Zap.Cooldown = (float) spellManager.Zap.DefaultCooldown - ((spellManager.Zap.DefaultCooldown/20) * Player.ZapTier);
		} else {
			spellManager.Zap.Power = 0f;
			spellManager.Zap.Cooldown = 0f;
		}
	}

	public void CalculateNewZapCost() {
		x = (float) Mathf.Pow(1.15f , Player.ZapLevel);
		Player.ZapElixCost = Mathf.FloorToInt((float) spellManager.Zap.DefaultElixCost * x);
		wizardUI.UpgradeZapUI ();
	}

	public void CheckZapTierCards () {
		if (Player.ZapTier == 0) {
			ZapNextTierCards = Player.CardsToTier1;
		} else if (Player.ZapTier == 1) {
			ZapNextTierCards = Player.CardsToTier2;
		} else if (Player.ZapTier == 2) {
			ZapNextTierCards = Player.CardsToTier3;
		} else if (Player.ZapTier == 3) {
			ZapNextTierCards = Player.CardsToTier4;
		} else if (Player.ZapTier == 4) {
			ZapNextTierCards = Player.CardsToTier5;
		} else if (Player.ZapTier == 5) {
			ZapNextTierCards = Player.CardsToTier6;
		} else if (Player.ZapTier == 6) {
			ZapNextTierCards = Player.CardsToTier7;
		} else if (Player.ZapTier == 7) {
			ZapNextTierCards = Player.CardsToTier8;
		} else if (Player.ZapTier == 8) {
			ZapNextTierCards = Player.CardsToTier9;
		} else if (Player.ZapTier == 9) {
			ZapNextTierCards = Player.CardsToTier10;
		} else if (Player.ZapTier == 10) {
			ZapNextTierCards = Player.CardsToTier11;
		} else if (Player.ZapTier == 11) {
			ZapNextTierCards = Player.CardsToTier12;
		} else if (Player.ZapTier == 12) {
			ZapNextTierCards = Player.CardsToTier13;
		} else if (Player.ZapTier == 13) {
			ZapNextTierCards = 0;
		} else {
			ZapNextTierCards = 0;
		}
	}

	public void UpgradePoison () {
		if (Player.Elix >= Player.PoisonElixCost) {
			Player.Elix -= Player.PoisonElixCost;
			Player.PoisonLevel += 1;
			Player.Experience += spellManager.Poison.ExperiencePerLevel;
			Player.Trophys += spellManager.Poison.TrophysPerLevel;
			CalculatePoisonStats ();
			CalculateNewPoisonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierPoison () {
		if (Player.PoisonCards >= PoisonNextTierCards && Player.PoisonTier <= 12) {
			Player.PoisonCards -= PoisonNextTierCards;
			Player.PoisonTier += 1;
			Player.Experience += spellManager.Poison.ExperiencePerTier;
			Player.Trophys += spellManager.Poison.TrophysPerTier;
			wizardUI.UpgradeTierPoisonUI ();
			CheckPoisonTierCards ();
			CalculatePoisonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculatePoisonStats () {
		if (Player.PoisonTier >= 1) {
			spellManager.Poison.Power = (float)spellManager.Poison.DefaultPower + ((spellManager.Poison.DefaultPower/5) * Player.PoisonLevel) + (spellManager.Poison.DefaultPower * Player.PoisonTier);
			spellManager.Poison.Cooldown = (float) spellManager.Poison.DefaultCooldown - ((spellManager.Poison.DefaultCooldown/20) * Player.PoisonTier);
		} else {
			spellManager.Poison.Power = 0f;
			spellManager.Poison.Cooldown = 0f;
		}
	}

	public void CalculateNewPoisonCost() {
		x = (float) Mathf.Pow(1.15f , Player.PoisonLevel);
		Player.PoisonElixCost = Mathf.FloorToInt((float) spellManager.Poison.DefaultElixCost * x);
		wizardUI.UpgradePoisonUI ();
	}

	public void CheckPoisonTierCards () {
		if (Player.PoisonTier == 0) {
			PoisonNextTierCards = Player.CardsToTier1;
		} else if (Player.PoisonTier == 1) {
			PoisonNextTierCards = Player.CardsToTier2;
		} else if (Player.PoisonTier == 2) {
			PoisonNextTierCards = Player.CardsToTier3;
		} else if (Player.PoisonTier == 3) {
			PoisonNextTierCards = Player.CardsToTier4;
		} else if (Player.PoisonTier == 4) {
			PoisonNextTierCards = Player.CardsToTier5;
		} else if (Player.PoisonTier == 5) {
			PoisonNextTierCards = Player.CardsToTier6;
		} else if (Player.PoisonTier == 6) {
			PoisonNextTierCards = Player.CardsToTier7;
		} else if (Player.PoisonTier == 7) {
			PoisonNextTierCards = Player.CardsToTier8;
		} else if (Player.PoisonTier == 8) {
			PoisonNextTierCards = Player.CardsToTier9;
		} else if (Player.PoisonTier == 9) {
			PoisonNextTierCards = Player.CardsToTier10;
		} else if (Player.PoisonTier == 10) {
			PoisonNextTierCards = Player.CardsToTier11;
		} else if (Player.PoisonTier == 11) {
			PoisonNextTierCards = Player.CardsToTier12;
		} else if (Player.PoisonTier == 12) {
			PoisonNextTierCards = Player.CardsToTier13;
		} else if (Player.PoisonTier == 13) {
			PoisonNextTierCards = 0;
		} else {
			PoisonNextTierCards = 0;
		}
	}

	public void UpgradeMirror () {
		if (Player.Elix >= Player.MirrorElixCost) {
			Player.Elix -= Player.MirrorElixCost;
			Player.MirrorLevel += 1;
			Player.Experience += spellManager.Mirror.ExperiencePerLevel;
			Player.Trophys += spellManager.Mirror.TrophysPerLevel;
			CalculateMirrorStats ();
			CalculateNewMirrorCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierMirror () {
		if (Player.MirrorCards >= MirrorNextTierCards && Player.MirrorTier <= 12) {
			Player.MirrorCards -= MirrorNextTierCards;
			Player.MirrorTier += 1;
			Player.Experience += spellManager.Mirror.ExperiencePerTier;
			Player.Trophys += spellManager.Mirror.TrophysPerTier;
			wizardUI.UpgradeTierMirrorUI ();
			CheckMirrorTierCards ();
			CalculateMirrorStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateMirrorStats () {
		if (Player.MirrorTier >= 1) {
			spellManager.Mirror.Power = (float)spellManager.Mirror.DefaultPower + ((spellManager.Mirror.DefaultPower/5) * Player.MirrorLevel) + (spellManager.Mirror.DefaultPower * Player.MirrorTier);
			spellManager.Mirror.Cooldown = (float) spellManager.Mirror.DefaultCooldown - ((spellManager.Mirror.DefaultCooldown/20) * Player.MirrorTier);
		} else {
			spellManager.Mirror.Power = 0f;
			spellManager.Mirror.Cooldown = 0f;
		}
	}

	public void CalculateNewMirrorCost() {
		x = (float) Mathf.Pow(1.15f , Player.MirrorLevel);
		Player.MirrorElixCost = Mathf.FloorToInt((float) spellManager.Mirror.DefaultElixCost * x);
		wizardUI.UpgradeMirrorUI ();
	}

	public void CheckMirrorTierCards () {
		if (Player.MirrorTier == 0) {
			MirrorNextTierCards = Player.CardsToTier1;
		} else if (Player.MirrorTier == 1) {
			MirrorNextTierCards = Player.CardsToTier2;
		} else if (Player.MirrorTier == 2) {
			MirrorNextTierCards = Player.CardsToTier3;
		} else if (Player.MirrorTier == 3) {
			MirrorNextTierCards = Player.CardsToTier4;
		} else if (Player.MirrorTier == 4) {
			MirrorNextTierCards = Player.CardsToTier5;
		} else if (Player.MirrorTier == 5) {
			MirrorNextTierCards = Player.CardsToTier6;
		} else if (Player.MirrorTier == 6) {
			MirrorNextTierCards = Player.CardsToTier7;
		} else if (Player.MirrorTier == 7) {
			MirrorNextTierCards = Player.CardsToTier8;
		} else if (Player.MirrorTier == 8) {
			MirrorNextTierCards = Player.CardsToTier9;
		} else if (Player.MirrorTier == 9) {
			MirrorNextTierCards = Player.CardsToTier10;
		} else if (Player.MirrorTier == 10) {
			MirrorNextTierCards = Player.CardsToTier11;
		} else if (Player.MirrorTier == 11) {
			MirrorNextTierCards = Player.CardsToTier12;
		} else if (Player.MirrorTier == 12) {
			MirrorNextTierCards = Player.CardsToTier13;
		} else if (Player.MirrorTier == 13) {
			MirrorNextTierCards = 0;
		} else {
			MirrorNextTierCards = 0;
		}
	}

	public void UpgradeGraveyard () {
		if (Player.Elix >= Player.GraveyardElixCost) {
			Player.Elix -= Player.GraveyardElixCost;
			Player.GraveyardLevel += 1;
			Player.Experience += spellManager.Graveyard.ExperiencePerLevel;
			Player.Trophys += spellManager.Graveyard.TrophysPerLevel;
			CalculateGraveyardStats ();
			CalculateNewGraveyardCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierGraveyard () {
		if (Player.GraveyardCards >= GraveyardNextTierCards && Player.GraveyardTier <= 12) {
			Player.GraveyardCards -= GraveyardNextTierCards;
			Player.GraveyardTier += 1;
			Player.Experience += spellManager.Graveyard.ExperiencePerTier;
			Player.Trophys += spellManager.Graveyard.TrophysPerTier;
			wizardUI.UpgradeTierGraveyardUI ();
			CheckGraveyardTierCards ();
			CalculateGraveyardStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateGraveyardStats () {
		if (Player.GraveyardTier >= 1) {
			spellManager.Graveyard.Power = (float)spellManager.Graveyard.DefaultPower + ((spellManager.Graveyard.DefaultPower/5) * Player.GraveyardLevel) + (spellManager.Graveyard.DefaultPower * Player.GraveyardTier);
			spellManager.Graveyard.Cooldown = (float) spellManager.Graveyard.DefaultCooldown - ((spellManager.Graveyard.DefaultCooldown/20) * Player.GraveyardTier);
		} else {
			spellManager.Graveyard.Power = 0f;
			spellManager.Graveyard.Cooldown = 0f;
		}
	}

	public void CalculateNewGraveyardCost() {
		x = (float) Mathf.Pow(1.15f , Player.GraveyardLevel);
		Player.GraveyardElixCost = Mathf.FloorToInt((float) spellManager.Graveyard.DefaultElixCost * x);
		wizardUI.UpgradeGraveyardUI ();
	}

	public void CheckGraveyardTierCards () {
		if (Player.GraveyardTier == 0) {
			GraveyardNextTierCards = Player.CardsToTier1;
		} else if (Player.GraveyardTier == 1) {
			GraveyardNextTierCards = Player.CardsToTier2;
		} else if (Player.GraveyardTier == 2) {
			GraveyardNextTierCards = Player.CardsToTier3;
		} else if (Player.GraveyardTier == 3) {
			GraveyardNextTierCards = Player.CardsToTier4;
		} else if (Player.GraveyardTier == 4) {
			GraveyardNextTierCards = Player.CardsToTier5;
		} else if (Player.GraveyardTier == 5) {
			GraveyardNextTierCards = Player.CardsToTier6;
		} else if (Player.GraveyardTier == 6) {
			GraveyardNextTierCards = Player.CardsToTier7;
		} else if (Player.GraveyardTier == 7) {
			GraveyardNextTierCards = Player.CardsToTier8;
		} else if (Player.GraveyardTier == 8) {
			GraveyardNextTierCards = Player.CardsToTier9;
		} else if (Player.GraveyardTier == 9) {
			GraveyardNextTierCards = Player.CardsToTier10;
		} else if (Player.GraveyardTier == 10) {
			GraveyardNextTierCards = Player.CardsToTier11;
		} else if (Player.GraveyardTier == 11) {
			GraveyardNextTierCards = Player.CardsToTier12;
		} else if (Player.GraveyardTier == 12) {
			GraveyardNextTierCards = Player.CardsToTier13;
		} else if (Player.GraveyardTier == 13) {
			GraveyardNextTierCards = 0;
		} else {
			GraveyardNextTierCards = 0;
		}
	}

	public void UpgradeTheLog () {
		if (Player.Elix >= Player.TheLogElixCost) {
			Player.Elix -= Player.TheLogElixCost;
			Player.TheLogLevel += 1;
			Player.Experience += spellManager.TheLog.ExperiencePerLevel;
			Player.Trophys += spellManager.TheLog.TrophysPerLevel;
			CalculateTheLogStats ();
			CalculateNewTheLogCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierTheLog () {
		if (Player.TheLogCards >= TheLogNextTierCards && Player.TheLogTier <= 12) {
			Player.TheLogCards -= TheLogNextTierCards;
			Player.TheLogTier += 1;
			Player.Experience += spellManager.TheLog.ExperiencePerTier;
			Player.Trophys += spellManager.TheLog.TrophysPerTier;
			wizardUI.UpgradeTierTheLogUI ();
			CheckTheLogTierCards ();
			CalculateTheLogStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateTheLogStats () {
		if (Player.TheLogTier >= 1) {
			spellManager.TheLog.Power = (float)spellManager.TheLog.DefaultPower + ((spellManager.TheLog.DefaultPower/5) * Player.TheLogLevel) + (spellManager.TheLog.DefaultPower * Player.TheLogTier);
			spellManager.TheLog.Cooldown = (float) spellManager.TheLog.DefaultCooldown - ((spellManager.TheLog.DefaultCooldown/20) * Player.TheLogTier);
		} else {
			spellManager.TheLog.Power = 0f;
			spellManager.TheLog.Cooldown = 0f;
		}
	}

	public void CalculateNewTheLogCost() {
		x = (float) Mathf.Pow(1.15f , Player.TheLogLevel);
		Player.TheLogElixCost = Mathf.FloorToInt((float) spellManager.TheLog.DefaultElixCost * x);
		wizardUI.UpgradeTheLogUI ();
	}

	public void CheckTheLogTierCards () {
		if (Player.TheLogTier == 0) {
			TheLogNextTierCards = Player.CardsToTier1;
		} else if (Player.TheLogTier == 1) {
			TheLogNextTierCards = Player.CardsToTier2;
		} else if (Player.TheLogTier == 2) {
			TheLogNextTierCards = Player.CardsToTier3;
		} else if (Player.TheLogTier == 3) {
			TheLogNextTierCards = Player.CardsToTier4;
		} else if (Player.TheLogTier == 4) {
			TheLogNextTierCards = Player.CardsToTier5;
		} else if (Player.TheLogTier == 5) {
			TheLogNextTierCards = Player.CardsToTier6;
		} else if (Player.TheLogTier == 6) {
			TheLogNextTierCards = Player.CardsToTier7;
		} else if (Player.TheLogTier == 7) {
			TheLogNextTierCards = Player.CardsToTier8;
		} else if (Player.TheLogTier == 8) {
			TheLogNextTierCards = Player.CardsToTier9;
		} else if (Player.TheLogTier == 9) {
			TheLogNextTierCards = Player.CardsToTier10;
		} else if (Player.TheLogTier == 10) {
			TheLogNextTierCards = Player.CardsToTier11;
		} else if (Player.TheLogTier == 11) {
			TheLogNextTierCards = Player.CardsToTier12;
		} else if (Player.TheLogTier == 12) {
			TheLogNextTierCards = Player.CardsToTier13;
		} else if (Player.TheLogTier == 13) {
			TheLogNextTierCards = 0;
		} else {
			TheLogNextTierCards = 0;
		}
	}

	public void UpgradeTornado () {
		if (Player.Elix >= Player.TornadoElixCost) {
			Player.Elix -= Player.TornadoElixCost;
			Player.TornadoLevel += 1;
			Player.Experience += spellManager.Tornado.ExperiencePerLevel;
			Player.Trophys += spellManager.Tornado.TrophysPerLevel;
			CalculateTornadoStats ();
			CalculateNewTornadoCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierTornado () {
		if (Player.TornadoCards >= TornadoNextTierCards && Player.TornadoTier <= 12) {
			Player.TornadoCards -= TornadoNextTierCards;
			Player.TornadoTier += 1;
			Player.Experience += spellManager.Tornado.ExperiencePerTier;
			Player.Trophys += spellManager.Tornado.TrophysPerTier;
			wizardUI.UpgradeTierTornadoUI ();
			CheckTornadoTierCards ();
			CalculateTornadoStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateTornadoStats () {
		if (Player.TornadoTier >= 1) {
			spellManager.Tornado.Power = (float)spellManager.Tornado.DefaultPower + ((spellManager.Tornado.DefaultPower/5) * Player.TornadoLevel) + (spellManager.Tornado.DefaultPower * Player.TornadoTier);
			spellManager.Tornado.Cooldown = (float) spellManager.Tornado.DefaultCooldown - ((spellManager.Tornado.DefaultCooldown/20) * Player.TornadoTier);
		} else {
			spellManager.Tornado.Power = 0f;
			spellManager.Tornado.Cooldown = 0f;
		}
	}

	public void CalculateNewTornadoCost() {
		x = (float) Mathf.Pow(1.15f , Player.TornadoLevel);
		Player.TornadoElixCost = Mathf.FloorToInt((float) spellManager.Tornado.DefaultElixCost * x);
		wizardUI.UpgradeTornadoUI ();
	}

	public void CheckTornadoTierCards () {
		if (Player.TornadoTier == 0) {
			TornadoNextTierCards = Player.CardsToTier1;
		} else if (Player.TornadoTier == 1) {
			TornadoNextTierCards = Player.CardsToTier2;
		} else if (Player.TornadoTier == 2) {
			TornadoNextTierCards = Player.CardsToTier3;
		} else if (Player.TornadoTier == 3) {
			TornadoNextTierCards = Player.CardsToTier4;
		} else if (Player.TornadoTier == 4) {
			TornadoNextTierCards = Player.CardsToTier5;
		} else if (Player.TornadoTier == 5) {
			TornadoNextTierCards = Player.CardsToTier6;
		} else if (Player.TornadoTier == 6) {
			TornadoNextTierCards = Player.CardsToTier7;
		} else if (Player.TornadoTier == 7) {
			TornadoNextTierCards = Player.CardsToTier8;
		} else if (Player.TornadoTier == 8) {
			TornadoNextTierCards = Player.CardsToTier9;
		} else if (Player.TornadoTier == 9) {
			TornadoNextTierCards = Player.CardsToTier10;
		} else if (Player.TornadoTier == 10) {
			TornadoNextTierCards = Player.CardsToTier11;
		} else if (Player.TornadoTier == 11) {
			TornadoNextTierCards = Player.CardsToTier12;
		} else if (Player.TornadoTier == 12) {
			TornadoNextTierCards = Player.CardsToTier13;
		} else if (Player.TornadoTier == 13) {
			TornadoNextTierCards = 0;
		} else {
			TornadoNextTierCards = 0;
		}
	}

	public void UpgradeClone () {
		if (Player.Elix >= Player.CloneElixCost) {
			Player.Elix -= Player.CloneElixCost;
			Player.CloneLevel += 1;
			Player.Experience += spellManager.Clone.ExperiencePerLevel;
			Player.Trophys += spellManager.Clone.TrophysPerLevel;
			CalculateCloneStats ();
			CalculateNewCloneCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierClone () {
		if (Player.CloneCards >= CloneNextTierCards && Player.CloneTier <= 12) {
			Player.CloneCards -= CloneNextTierCards;
			Player.CloneTier += 1;
			Player.Experience += spellManager.Clone.ExperiencePerTier;
			Player.Trophys += spellManager.Clone.TrophysPerTier;
			wizardUI.UpgradeTierCloneUI ();
			CheckCloneTierCards ();
			CalculateCloneStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateCloneStats () {
		if (Player.CloneTier >= 1) {
			spellManager.Clone.Power = (float)spellManager.Clone.DefaultPower + ((spellManager.Clone.DefaultPower/5) * Player.CloneLevel) + (spellManager.Clone.DefaultPower * Player.CloneTier);
			spellManager.Clone.Cooldown = (float) spellManager.Clone.DefaultCooldown - ((spellManager.Clone.DefaultCooldown/20) * Player.CloneTier);
		} else {
			spellManager.Clone.Power = 0f;
			spellManager.Clone.Cooldown = 0f;
		}
	}

	public void CalculateNewCloneCost() {
		x = (float) Mathf.Pow(1.15f , Player.CloneLevel);
		Player.CloneElixCost = Mathf.FloorToInt((float) spellManager.Clone.DefaultElixCost * x);
		wizardUI.UpgradeCloneUI ();
	}

	public void CheckCloneTierCards () {
		if (Player.CloneTier == 0) {
			CloneNextTierCards = Player.CardsToTier1;
		} else if (Player.CloneTier == 1) {
			CloneNextTierCards = Player.CardsToTier2;
		} else if (Player.CloneTier == 2) {
			CloneNextTierCards = Player.CardsToTier3;
		} else if (Player.CloneTier == 3) {
			CloneNextTierCards = Player.CardsToTier4;
		} else if (Player.CloneTier == 4) {
			CloneNextTierCards = Player.CardsToTier5;
		} else if (Player.CloneTier == 5) {
			CloneNextTierCards = Player.CardsToTier6;
		} else if (Player.CloneTier == 6) {
			CloneNextTierCards = Player.CardsToTier7;
		} else if (Player.CloneTier == 7) {
			CloneNextTierCards = Player.CardsToTier8;
		} else if (Player.CloneTier == 8) {
			CloneNextTierCards = Player.CardsToTier9;
		} else if (Player.CloneTier == 9) {
			CloneNextTierCards = Player.CardsToTier10;
		} else if (Player.CloneTier == 10) {
			CloneNextTierCards = Player.CardsToTier11;
		} else if (Player.CloneTier == 11) {
			CloneNextTierCards = Player.CardsToTier12;
		} else if (Player.CloneTier == 12) {
			CloneNextTierCards = Player.CardsToTier13;
		} else if (Player.CloneTier == 13) {
			CloneNextTierCards = 0;
		} else {
			CloneNextTierCards = 0;
		}
	}

	public void UpgradeHeal () {
		if (Player.Elix >= Player.HealElixCost) {
			Player.Elix -= Player.HealElixCost;
			Player.HealLevel += 1;
			Player.Experience += spellManager.Heal.ExperiencePerLevel;
			Player.Trophys += spellManager.Heal.TrophysPerLevel;
			CalculateHealStats ();
			CalculateNewHealCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierHeal () {
		if (Player.HealCards >= HealNextTierCards && Player.HealTier <= 12) {
			Player.HealCards -= HealNextTierCards;
			Player.HealTier += 1;
			Player.Experience += spellManager.Heal.ExperiencePerTier;
			Player.Trophys += spellManager.Heal.TrophysPerTier;
			wizardUI.UpgradeTierHealUI ();
			CheckHealTierCards ();
			CalculateHealStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateHealStats () {
		if (Player.HealTier >= 1) {
			spellManager.Heal.Power = (float)spellManager.Heal.DefaultPower + ((spellManager.Heal.DefaultPower/5) * Player.HealLevel) + (spellManager.Heal.DefaultPower * Player.HealTier);
			spellManager.Heal.Cooldown = (float) spellManager.Heal.DefaultCooldown - ((spellManager.Heal.DefaultCooldown/20) * Player.HealTier);
		} else {
			spellManager.Heal.Power = 0f;
			spellManager.Heal.Cooldown = 0f;
		}
	}

	public void CalculateNewHealCost() {
		x = (float) Mathf.Pow(1.15f , Player.HealLevel);
		Player.HealElixCost = Mathf.FloorToInt((float) spellManager.Heal.DefaultElixCost * x);
		wizardUI.UpgradeHealUI ();
	}

	public void CheckHealTierCards () {
		if (Player.HealTier == 0) {
			HealNextTierCards = Player.CardsToTier1;
		} else if (Player.HealTier == 1) {
			HealNextTierCards = Player.CardsToTier2;
		} else if (Player.HealTier == 2) {
			HealNextTierCards = Player.CardsToTier3;
		} else if (Player.HealTier == 3) {
			HealNextTierCards = Player.CardsToTier4;
		} else if (Player.HealTier == 4) {
			HealNextTierCards = Player.CardsToTier5;
		} else if (Player.HealTier == 5) {
			HealNextTierCards = Player.CardsToTier6;
		} else if (Player.HealTier == 6) {
			HealNextTierCards = Player.CardsToTier7;
		} else if (Player.HealTier == 7) {
			HealNextTierCards = Player.CardsToTier8;
		} else if (Player.HealTier == 8) {
			HealNextTierCards = Player.CardsToTier9;
		} else if (Player.HealTier == 9) {
			HealNextTierCards = Player.CardsToTier10;
		} else if (Player.HealTier == 10) {
			HealNextTierCards = Player.CardsToTier11;
		} else if (Player.HealTier == 11) {
			HealNextTierCards = Player.CardsToTier12;
		} else if (Player.HealTier == 12) {
			HealNextTierCards = Player.CardsToTier13;
		} else if (Player.HealTier == 13) {
			HealNextTierCards = 0;
		} else {
			HealNextTierCards = 0;
		}
	}

	public void UpgradeBarbarianBarrel () {
		if (Player.Elix >= Player.BarbarianBarrelElixCost) {
			Player.Elix -= Player.BarbarianBarrelElixCost;
			Player.BarbarianBarrelLevel += 1;
			Player.Experience += spellManager.BarbarianBarrel.ExperiencePerLevel;
			Player.Trophys += spellManager.BarbarianBarrel.TrophysPerLevel;
			CalculateBarbarianBarrelStats ();
			CalculateNewBarbarianBarrelCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void UpgradeTierBarbarianBarrel () {
		if (Player.BarbarianBarrelCards >= BarbarianBarrelNextTierCards && Player.BarbarianBarrelTier <= 12) {
			Player.BarbarianBarrelCards -= BarbarianBarrelNextTierCards;
			Player.BarbarianBarrelTier += 1;
			Player.Experience += spellManager.BarbarianBarrel.ExperiencePerTier;
			Player.Trophys += spellManager.BarbarianBarrel.TrophysPerTier;
			wizardUI.UpgradeTierBarbarianBarrelUI ();
			CheckBarbarianBarrelTierCards ();
			CalculateBarbarianBarrelStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
			spellEffects.CheckSpellTiers ();
		}
	}

	public void CalculateBarbarianBarrelStats () {
		if (Player.BarbarianBarrelTier >= 1) {
			spellManager.BarbarianBarrel.Power = (float)spellManager.BarbarianBarrel.DefaultPower + ((spellManager.BarbarianBarrel.DefaultPower/5) * Player.BarbarianBarrelLevel) + (spellManager.BarbarianBarrel.DefaultPower * Player.BarbarianBarrelTier);
			spellManager.BarbarianBarrel.Cooldown = (float) spellManager.BarbarianBarrel.DefaultCooldown - ((spellManager.BarbarianBarrel.DefaultCooldown/20) * Player.BarbarianBarrelTier);
		} else {
			spellManager.BarbarianBarrel.Power = 0f;
			spellManager.BarbarianBarrel.Cooldown = 0f;
		}
	}

	public void CalculateNewBarbarianBarrelCost() {
		x = (float) Mathf.Pow(1.15f , Player.BarbarianBarrelLevel);
		Player.BarbarianBarrelElixCost = Mathf.FloorToInt((float) spellManager.BarbarianBarrel.DefaultElixCost * x);
		wizardUI.UpgradeBarbarianBarrelUI ();
	}

	public void CheckBarbarianBarrelTierCards () {
		if (Player.BarbarianBarrelTier == 0) {
			BarbarianBarrelNextTierCards = Player.CardsToTier1;
		} else if (Player.BarbarianBarrelTier == 1) {
			BarbarianBarrelNextTierCards = Player.CardsToTier2;
		} else if (Player.BarbarianBarrelTier == 2) {
			BarbarianBarrelNextTierCards = Player.CardsToTier3;
		} else if (Player.BarbarianBarrelTier == 3) {
			BarbarianBarrelNextTierCards = Player.CardsToTier4;
		} else if (Player.BarbarianBarrelTier == 4) {
			BarbarianBarrelNextTierCards = Player.CardsToTier5;
		} else if (Player.BarbarianBarrelTier == 5) {
			BarbarianBarrelNextTierCards = Player.CardsToTier6;
		} else if (Player.BarbarianBarrelTier == 6) {
			BarbarianBarrelNextTierCards = Player.CardsToTier7;
		} else if (Player.BarbarianBarrelTier == 7) {
			BarbarianBarrelNextTierCards = Player.CardsToTier8;
		} else if (Player.BarbarianBarrelTier == 8) {
			BarbarianBarrelNextTierCards = Player.CardsToTier9;
		} else if (Player.BarbarianBarrelTier == 9) {
			BarbarianBarrelNextTierCards = Player.CardsToTier10;
		} else if (Player.BarbarianBarrelTier == 10) {
			BarbarianBarrelNextTierCards = Player.CardsToTier11;
		} else if (Player.BarbarianBarrelTier == 11) {
			BarbarianBarrelNextTierCards = Player.CardsToTier12;
		} else if (Player.BarbarianBarrelTier == 12) {
			BarbarianBarrelNextTierCards = Player.CardsToTier13;
		} else if (Player.BarbarianBarrelTier == 13) {
			BarbarianBarrelNextTierCards = 0;
		} else {
			BarbarianBarrelNextTierCards = 0;
		}
	}
}
