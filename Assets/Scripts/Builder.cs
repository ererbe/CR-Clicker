using System.Collections;
using UnityEngine;

public class Builder : MonoBehaviour {

	public BuilderUI builderUI;
	public BuildingManager buildingManager;
	public ArenaTextUI arenaTextUI;
	public ExperienceUI experienceUI;

	public static int GoblinHutNextTierCards;
	public static int TombstoneNextTierCards;
	public static int BombTowerNextTierCards;
	public static int CannonNextTierCards;
	public static int BarbarianHutNextTierCards;
	public static int XBowNextTierCards;
	public static int TeslaNextTierCards;
	public static int InfernoTowerNextTierCards;
	public static int FurnaceNextTierCards;
	public static int MortarNextTierCards;
	public static int ElixirCollectorNextTierCards;

	private float x;

	void Awake () {
		UpdateBuildingStatistics ();
	}
	
	void UpdateBuildingStatistics () {
		CalculateGoblinHutStats ();
		CalculateTombstoneStats ();
		CalculateBombTowerStats ();
		CalculateCannonStats ();
		CalculateBarbarianHutStats ();
		CalculateXBowStats ();
		CalculateTeslaStats ();
		CalculateInfernoTowerStats ();
		CalculateFurnaceStats ();
		CalculateMortarStats ();
		CalculateElixirCollectorStats ();

		CheckGoblinHutTierCards ();
		CheckTombstoneTierCards ();
		CheckBombTowerTierCards ();
		CheckCannonTierCards ();
		CheckBarbarianHutTierCards ();
		CheckXBowTierCards ();
		CheckTeslaTierCards ();
		CheckInfernoTowerTierCards ();
		CheckFurnaceTierCards ();
		CheckMortarTierCards ();
		CheckElixirCollectorTierCards ();

		CalculateNewGoblinHutCost ();
		CalculateNewTombstoneCost ();
		CalculateNewBombTowerCost ();
		CalculateNewCannonCost ();
		CalculateNewBarbarianHutCost ();
		CalculateNewXBowCost ();
		CalculateNewTeslaCost ();
		CalculateNewInfernoTowerCost ();
		CalculateNewFurnaceCost ();
		CalculateNewMortarCost ();
		CalculateNewElixirCollectorCost ();

		CalculateNewElixStats ();
	}

	void CalculateNewElixStats () {
		Player.ElixPerClick = (float) 0.1f + buildingManager.BombTower.ElixClickProduction + buildingManager.Cannon.ElixClickProduction + buildingManager.Tesla.ElixClickProduction + buildingManager.InfernoTower.ElixClickProduction;
		Player.ElixPerSecound = (float) 0.5f + buildingManager.GoblinHut.ElixProduction + buildingManager.Tombstone.ElixProduction + buildingManager.BarbarianHut.ElixProduction + buildingManager.XBow.ElixProduction + buildingManager.Furnace.ElixProduction + buildingManager.Mortar.ElixProduction + buildingManager.Mortar.ElixProduction + buildingManager.ElixirCollector.ElixProduction;
	}

	//-----Passive-----
	//GoblinHut

	public void UpgradeGoblinHut () {
		if (Player.Elix >= Player.GoblinHutElixCost) {
			Player.Elix -= Player.GoblinHutElixCost;
			Player.GoblinHutLevel += 1;
			Player.Experience += buildingManager.GoblinHut.ExperiencePerLevel;
			Player.Trophys += buildingManager.GoblinHut.TrophysPerLevel;
			CalculateGoblinHutStats ();
			CalculateNewGoblinHutCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateGoblinHutStats () {
		if (Player.GoblinHutTier >= 1) {
			buildingManager.GoblinHut.ElixProduction = (float)buildingManager.GoblinHut.DefaultElixProduction + (buildingManager.GoblinHut.ElixProductionAddPerLevel * Player.GoblinHutLevel) + (buildingManager.GoblinHut.ElixProductionAddPerTier * Player.GoblinHutTier);
		} else {
			buildingManager.GoblinHut.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewGoblinHutCost() {
		x = (float) Mathf.Pow(1.15f , Player.GoblinHutLevel);
		Player.GoblinHutElixCost = Mathf.FloorToInt((float) buildingManager.GoblinHut.DefaultElixCost * x);
		builderUI.UpgradeGoblinHutUI ();
	}

	public void CheckGoblinHutTierCards () {
		if (Player.GoblinHutTier == 0) {
			GoblinHutNextTierCards = Player.CardsToTier1;
		} else if (Player.GoblinHutTier == 1) {
			GoblinHutNextTierCards = Player.CardsToTier2;
		} else if (Player.GoblinHutTier == 2) {
			GoblinHutNextTierCards = Player.CardsToTier3;
		} else if (Player.GoblinHutTier == 3) {
			GoblinHutNextTierCards = Player.CardsToTier4;
		} else if (Player.GoblinHutTier == 4) {
			GoblinHutNextTierCards = Player.CardsToTier5;
		} else if (Player.GoblinHutTier == 5) {
			GoblinHutNextTierCards = Player.CardsToTier6;
		} else if (Player.GoblinHutTier == 6) {
			GoblinHutNextTierCards = Player.CardsToTier7;
		} else if (Player.GoblinHutTier == 7) {
			GoblinHutNextTierCards = Player.CardsToTier8;
		} else if (Player.GoblinHutTier == 8) {
			GoblinHutNextTierCards = Player.CardsToTier9;
		} else if (Player.GoblinHutTier == 9) {
			GoblinHutNextTierCards = Player.CardsToTier10;
		} else if (Player.GoblinHutTier == 10) {
			GoblinHutNextTierCards = Player.CardsToTier11;
		} else if (Player.GoblinHutTier == 11) {
			GoblinHutNextTierCards = Player.CardsToTier12;
		} else if (Player.GoblinHutTier == 12) {
			GoblinHutNextTierCards = Player.CardsToTier13;
		} else if (Player.GoblinHutTier == 13) {
			GoblinHutNextTierCards = 0;
		} else {
			GoblinHutNextTierCards = 0;
		}
	}

	public void UpgradeTierGoblinHut () {
		if (Player.GoblinHutCards >= GoblinHutNextTierCards && Player.GoblinHutTier <= 12) {
			Player.GoblinHutCards -= GoblinHutNextTierCards;
			Player.GoblinHutTier += 1;
			Player.Experience += buildingManager.GoblinHut.ExperiencePerTier;
			Player.Trophys += buildingManager.GoblinHut.TrophysPerTier;
			builderUI.UpgradeTierGoblinHutUI ();
			CheckGoblinHutTierCards ();
			CalculateGoblinHutStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//Tombstone

	public void UpgradeTombstone () {
		if (Player.Elix >= Player.TombstoneElixCost) {
			Player.Elix -= Player.TombstoneElixCost;
			Player.TombstoneLevel += 1;
			Player.Experience += buildingManager.Tombstone.ExperiencePerLevel;
			Player.Trophys += buildingManager.Tombstone.TrophysPerLevel;
			CalculateTombstoneStats ();
			CalculateNewTombstoneCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateTombstoneStats () {
		if (Player.TombstoneTier >= 1) {
			buildingManager.Tombstone.ElixProduction = (float)buildingManager.Tombstone.DefaultElixProduction + (buildingManager.Tombstone.ElixProductionAddPerLevel * Player.TombstoneLevel) + (buildingManager.Tombstone.ElixProductionAddPerTier * Player.TombstoneTier);
		} else {
			buildingManager.Tombstone.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewTombstoneCost() {
		x = (float) Mathf.Pow(1.15f , Player.TombstoneLevel);
		Player.TombstoneElixCost = Mathf.FloorToInt((float) buildingManager.Tombstone.DefaultElixCost * x);
		builderUI.UpgradeTombstoneUI ();
	}

	public void CheckTombstoneTierCards () {
		if (Player.TombstoneTier == 0) {
			TombstoneNextTierCards = Player.CardsToTier1;
		} else if (Player.TombstoneTier == 1) {
			TombstoneNextTierCards = Player.CardsToTier2;
		} else if (Player.TombstoneTier == 2) {
			TombstoneNextTierCards = Player.CardsToTier3;
		} else if (Player.TombstoneTier == 3) {
			TombstoneNextTierCards = Player.CardsToTier4;
		} else if (Player.TombstoneTier == 4) {
			TombstoneNextTierCards = Player.CardsToTier5;
		} else if (Player.TombstoneTier == 5) {
			TombstoneNextTierCards = Player.CardsToTier6;
		} else if (Player.TombstoneTier == 6) {
			TombstoneNextTierCards = Player.CardsToTier7;
		} else if (Player.TombstoneTier == 7) {
			TombstoneNextTierCards = Player.CardsToTier8;
		} else if (Player.TombstoneTier == 8) {
			TombstoneNextTierCards = Player.CardsToTier9;
		} else if (Player.TombstoneTier == 9) {
			TombstoneNextTierCards = Player.CardsToTier10;
		} else if (Player.TombstoneTier == 10) {
			TombstoneNextTierCards = Player.CardsToTier11;
		} else if (Player.TombstoneTier == 11) {
			TombstoneNextTierCards = Player.CardsToTier12;
		} else if (Player.TombstoneTier == 12) {
			TombstoneNextTierCards = Player.CardsToTier13;
		} else if (Player.TombstoneTier == 13) {
			TombstoneNextTierCards = 0;
		} else {
			TombstoneNextTierCards = 0;
		}
	}

	public void UpgradeTierTombstone () {
		if (Player.TombstoneCards >= TombstoneNextTierCards && Player.TombstoneTier <= 12) {
			Player.TombstoneCards -= TombstoneNextTierCards;
			Player.TombstoneTier += 1;
			Player.Experience += buildingManager.Tombstone.ExperiencePerTier;
			Player.Trophys += buildingManager.Tombstone.TrophysPerTier;
			builderUI.UpgradeTierTombstoneUI ();
			CheckTombstoneTierCards ();
			CalculateTombstoneStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//BarbarianHut

	public void UpgradeBarbarianHut () {
		if (Player.Elix >= Player.BarbarianHutElixCost) {
			Player.Elix -= Player.BarbarianHutElixCost;
			Player.BarbarianHutLevel += 1;
			Player.Experience += buildingManager.BarbarianHut.ExperiencePerLevel;
			Player.Trophys += buildingManager.BarbarianHut.TrophysPerLevel;
			CalculateBarbarianHutStats ();
			CalculateNewBarbarianHutCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBarbarianHutStats () {
		if (Player.BarbarianHutTier >= 1) {
			buildingManager.BarbarianHut.ElixProduction = (float)buildingManager.BarbarianHut.DefaultElixProduction + (buildingManager.BarbarianHut.ElixProductionAddPerLevel * Player.BarbarianHutLevel) + (buildingManager.BarbarianHut.ElixProductionAddPerTier * Player.BarbarianHutTier);
		} else {
			buildingManager.BarbarianHut.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewBarbarianHutCost() {
		x = (float) Mathf.Pow(1.15f , Player.BarbarianHutLevel);
		Player.BarbarianHutElixCost = Mathf.FloorToInt((float) buildingManager.BarbarianHut.DefaultElixCost * x);
		builderUI.UpgradeBarbarianHutUI ();
	}

	public void CheckBarbarianHutTierCards () {
		if (Player.BarbarianHutTier == 0) {
			BarbarianHutNextTierCards = Player.CardsToTier1;
		} else if (Player.BarbarianHutTier == 1) {
			BarbarianHutNextTierCards = Player.CardsToTier2;
		} else if (Player.BarbarianHutTier == 2) {
			BarbarianHutNextTierCards = Player.CardsToTier3;
		} else if (Player.BarbarianHutTier == 3) {
			BarbarianHutNextTierCards = Player.CardsToTier4;
		} else if (Player.BarbarianHutTier == 4) {
			BarbarianHutNextTierCards = Player.CardsToTier5;
		} else if (Player.BarbarianHutTier == 5) {
			BarbarianHutNextTierCards = Player.CardsToTier6;
		} else if (Player.BarbarianHutTier == 6) {
			BarbarianHutNextTierCards = Player.CardsToTier7;
		} else if (Player.BarbarianHutTier == 7) {
			BarbarianHutNextTierCards = Player.CardsToTier8;
		} else if (Player.BarbarianHutTier == 8) {
			BarbarianHutNextTierCards = Player.CardsToTier9;
		} else if (Player.BarbarianHutTier == 9) {
			BarbarianHutNextTierCards = Player.CardsToTier10;
		} else if (Player.BarbarianHutTier == 10) {
			BarbarianHutNextTierCards = Player.CardsToTier11;
		} else if (Player.BarbarianHutTier == 11) {
			BarbarianHutNextTierCards = Player.CardsToTier12;
		} else if (Player.BarbarianHutTier == 12) {
			BarbarianHutNextTierCards = Player.CardsToTier13;
		} else if (Player.BarbarianHutTier == 13) {
			BarbarianHutNextTierCards = 0;
		} else {
			BarbarianHutNextTierCards = 0;
		}
	}

	public void UpgradeTierBarbarianHut () {
		if (Player.BarbarianHutCards >= BarbarianHutNextTierCards && Player.BarbarianHutTier <= 12) {
			Player.BarbarianHutCards -= BarbarianHutNextTierCards;
			Player.BarbarianHutTier += 1;
			Player.Experience += buildingManager.BarbarianHut.ExperiencePerTier;
			Player.Trophys += buildingManager.BarbarianHut.TrophysPerTier;
			builderUI.UpgradeTierBarbarianHutUI ();
			CheckBarbarianHutTierCards ();
			CalculateBarbarianHutStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//XBow

	public void UpgradeXBow () {
		if (Player.Elix >= Player.XBowElixCost) {
			Player.Elix -= Player.XBowElixCost;
			Player.XBowLevel += 1;
			Player.Experience += buildingManager.XBow.ExperiencePerLevel;
			Player.Trophys += buildingManager.XBow.TrophysPerLevel;
			CalculateXBowStats ();
			CalculateNewXBowCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateXBowStats () {
		if (Player.XBowTier >= 1) {
			buildingManager.XBow.ElixProduction = (float)buildingManager.XBow.DefaultElixProduction + (buildingManager.XBow.ElixProductionAddPerLevel * Player.XBowLevel) + (buildingManager.XBow.ElixProductionAddPerTier * Player.XBowTier);
		} else {
			buildingManager.XBow.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewXBowCost() {
		x = (float) Mathf.Pow(1.15f , Player.XBowLevel);
		Player.XBowElixCost = Mathf.FloorToInt((float) buildingManager.XBow.DefaultElixCost * x);
		builderUI.UpgradeXBowUI ();
	}

	public void CheckXBowTierCards () {
		if (Player.XBowTier == 0) {
			XBowNextTierCards = Player.CardsToTier1;
		} else if (Player.XBowTier == 1) {
			XBowNextTierCards = Player.CardsToTier2;
		} else if (Player.XBowTier == 2) {
			XBowNextTierCards = Player.CardsToTier3;
		} else if (Player.XBowTier == 3) {
			XBowNextTierCards = Player.CardsToTier4;
		} else if (Player.XBowTier == 4) {
			XBowNextTierCards = Player.CardsToTier5;
		} else if (Player.XBowTier == 5) {
			XBowNextTierCards = Player.CardsToTier6;
		} else if (Player.XBowTier == 6) {
			XBowNextTierCards = Player.CardsToTier7;
		} else if (Player.XBowTier == 7) {
			XBowNextTierCards = Player.CardsToTier8;
		} else if (Player.XBowTier == 8) {
			XBowNextTierCards = Player.CardsToTier9;
		} else if (Player.XBowTier == 9) {
			XBowNextTierCards = Player.CardsToTier10;
		} else if (Player.XBowTier == 10) {
			XBowNextTierCards = Player.CardsToTier11;
		} else if (Player.XBowTier == 11) {
			XBowNextTierCards = Player.CardsToTier12;
		} else if (Player.XBowTier == 12) {
			XBowNextTierCards = Player.CardsToTier13;
		} else if (Player.XBowTier == 13) {
			XBowNextTierCards = 0;
		} else {
			XBowNextTierCards = 0;
		}
	}

	public void UpgradeTierXBow () {
		if (Player.XBowCards >= XBowNextTierCards && Player.XBowTier <= 12) {
			Player.XBowCards -= XBowNextTierCards;
			Player.XBowTier += 1;
			Player.Experience += buildingManager.XBow.ExperiencePerTier;
			Player.Trophys += buildingManager.XBow.TrophysPerTier;
			builderUI.UpgradeTierXBowUI ();
			CheckXBowTierCards ();
			CalculateXBowStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//Furnace

	public void UpgradeFurnace () {
		if (Player.Elix >= Player.FurnaceElixCost) {
			Player.Elix -= Player.FurnaceElixCost;
			Player.FurnaceLevel += 1;
			Player.Experience += buildingManager.Furnace.ExperiencePerLevel;
			Player.Trophys += buildingManager.Furnace.TrophysPerLevel;
			CalculateFurnaceStats ();
			CalculateNewFurnaceCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateFurnaceStats () {
		if (Player.FurnaceTier >= 1) {
			buildingManager.Furnace.ElixProduction = (float)buildingManager.Furnace.DefaultElixProduction + (buildingManager.Furnace.ElixProductionAddPerLevel * Player.FurnaceLevel) + (buildingManager.Furnace.ElixProductionAddPerTier * Player.FurnaceTier);
		} else {
			buildingManager.Furnace.ElixProduction = 0f;
		} 
		CalculateNewElixStats ();
	}

	public void CalculateNewFurnaceCost() {
		x = (float) Mathf.Pow(1.15f , Player.FurnaceLevel);
		Player.FurnaceElixCost = Mathf.FloorToInt((float) buildingManager.Furnace.DefaultElixCost * x);
		builderUI.UpgradeFurnaceUI ();
	}

	public void CheckFurnaceTierCards () {
		if (Player.FurnaceTier == 0) {
			FurnaceNextTierCards = Player.CardsToTier1;
		} else if (Player.FurnaceTier == 1) {
			FurnaceNextTierCards = Player.CardsToTier2;
		} else if (Player.FurnaceTier == 2) {
			FurnaceNextTierCards = Player.CardsToTier3;
		} else if (Player.FurnaceTier == 3) {
			FurnaceNextTierCards = Player.CardsToTier4;
		} else if (Player.FurnaceTier == 4) {
			FurnaceNextTierCards = Player.CardsToTier5;
		} else if (Player.FurnaceTier == 5) {
			FurnaceNextTierCards = Player.CardsToTier6;
		} else if (Player.FurnaceTier == 6) {
			FurnaceNextTierCards = Player.CardsToTier7;
		} else if (Player.FurnaceTier == 7) {
			FurnaceNextTierCards = Player.CardsToTier8;
		} else if (Player.FurnaceTier == 8) {
			FurnaceNextTierCards = Player.CardsToTier9;
		} else if (Player.FurnaceTier == 9) {
			FurnaceNextTierCards = Player.CardsToTier10;
		} else if (Player.FurnaceTier == 10) {
			FurnaceNextTierCards = Player.CardsToTier11;
		} else if (Player.FurnaceTier == 11) {
			FurnaceNextTierCards = Player.CardsToTier12;
		} else if (Player.FurnaceTier == 12) {
			FurnaceNextTierCards = Player.CardsToTier13;
		} else if (Player.FurnaceTier == 13) {
			FurnaceNextTierCards = 0;
		} else {
			FurnaceNextTierCards = 0;
		}
	}

	public void UpgradeTierFurnace () {
		if (Player.FurnaceCards >= FurnaceNextTierCards && Player.FurnaceTier <= 12) {
			Player.FurnaceCards -= FurnaceNextTierCards;
			Player.FurnaceTier += 1;
			Player.Experience += buildingManager.Furnace.ExperiencePerTier;
			Player.Trophys += buildingManager.Furnace.TrophysPerTier;
			builderUI.UpgradeTierFurnaceUI ();
			CheckFurnaceTierCards ();
			CalculateFurnaceStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//Mortar

	public void UpgradeMortar () {
		if (Player.Elix >= Player.MortarElixCost) {
			Player.Elix -= Player.MortarElixCost;
			Player.MortarLevel += 1;
			Player.Experience += buildingManager.Mortar.ExperiencePerLevel;
			Player.Trophys += buildingManager.Mortar.TrophysPerLevel;
			CalculateMortarStats ();
			CalculateNewMortarCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateMortarStats () {
		if (Player.MortarTier >= 1) {
			buildingManager.Mortar.ElixProduction = (float)buildingManager.Mortar.DefaultElixProduction + (buildingManager.Mortar.ElixProductionAddPerLevel * Player.MortarLevel) + (buildingManager.Mortar.ElixProductionAddPerTier * Player.MortarTier);
		} else {
			buildingManager.Mortar.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewMortarCost() {
		x = (float) Mathf.Pow(1.15f , Player.MortarLevel);
		Player.MortarElixCost = Mathf.FloorToInt((float) buildingManager.Mortar.DefaultElixCost * x);
		builderUI.UpgradeMortarUI ();
	}

	public void CheckMortarTierCards () {
		if (Player.MortarTier == 0) {
			MortarNextTierCards = Player.CardsToTier1;
		} else if (Player.MortarTier == 1) {
			MortarNextTierCards = Player.CardsToTier2;
		} else if (Player.MortarTier == 2) {
			MortarNextTierCards = Player.CardsToTier3;
		} else if (Player.MortarTier == 3) {
			MortarNextTierCards = Player.CardsToTier4;
		} else if (Player.MortarTier == 4) {
			MortarNextTierCards = Player.CardsToTier5;
		} else if (Player.MortarTier == 5) {
			MortarNextTierCards = Player.CardsToTier6;
		} else if (Player.MortarTier == 6) {
			MortarNextTierCards = Player.CardsToTier7;
		} else if (Player.MortarTier == 7) {
			MortarNextTierCards = Player.CardsToTier8;
		} else if (Player.MortarTier == 8) {
			MortarNextTierCards = Player.CardsToTier9;
		} else if (Player.MortarTier == 9) {
			MortarNextTierCards = Player.CardsToTier10;
		} else if (Player.MortarTier == 10) {
			MortarNextTierCards = Player.CardsToTier11;
		} else if (Player.MortarTier == 11) {
			MortarNextTierCards = Player.CardsToTier12;
		} else if (Player.MortarTier == 12) {
			MortarNextTierCards = Player.CardsToTier13;
		} else if (Player.MortarTier == 13) {
			MortarNextTierCards = 0;
		} else {
			MortarNextTierCards = 0;
		}
	}

	public void UpgradeTierMortar () {
		if (Player.MortarCards >= MortarNextTierCards && Player.MortarTier <= 12) {
			Player.MortarCards -= MortarNextTierCards;
			Player.MortarTier += 1;
			Player.Experience += buildingManager.Mortar.ExperiencePerTier;
			Player.Trophys += buildingManager.Mortar.TrophysPerTier;
			builderUI.UpgradeTierMortarUI ();
			CheckMortarTierCards ();
			CalculateMortarStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//ElixirCollector

	public void UpgradeElixirCollector () {
		if (Player.Elix >= Player.ElixirCollectorElixCost) {
			Player.Elix -= Player.ElixirCollectorElixCost;
			Player.ElixirCollectorLevel += 1;
			Player.Experience += buildingManager.ElixirCollector.ExperiencePerLevel;
			Player.Trophys += buildingManager.ElixirCollector.TrophysPerLevel;
			CalculateElixirCollectorStats ();
			CalculateNewElixirCollectorCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateElixirCollectorStats () {
		if (Player.ElixirCollectorTier >= 1) {
			buildingManager.ElixirCollector.ElixProduction = (float)buildingManager.ElixirCollector.DefaultElixProduction + (buildingManager.ElixirCollector.ElixProductionAddPerLevel * Player.ElixirCollectorLevel) + (buildingManager.ElixirCollector.ElixProductionAddPerTier * Player.ElixirCollectorTier);
		} else {
			buildingManager.ElixirCollector.ElixProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewElixirCollectorCost() {
		x = (float) Mathf.Pow(1.15f , Player.ElixirCollectorLevel);
		Player.ElixirCollectorElixCost = Mathf.FloorToInt((float) buildingManager.ElixirCollector.DefaultElixCost * x);
		builderUI.UpgradeElixirCollectorUI ();
	}

	public void CheckElixirCollectorTierCards () {
		if (Player.ElixirCollectorTier == 0) {
			ElixirCollectorNextTierCards = Player.CardsToTier1;
		} else if (Player.ElixirCollectorTier == 1) {
			ElixirCollectorNextTierCards = Player.CardsToTier2;
		} else if (Player.ElixirCollectorTier == 2) {
			ElixirCollectorNextTierCards = Player.CardsToTier3;
		} else if (Player.ElixirCollectorTier == 3) {
			ElixirCollectorNextTierCards = Player.CardsToTier4;
		} else if (Player.ElixirCollectorTier == 4) {
			ElixirCollectorNextTierCards = Player.CardsToTier5;
		} else if (Player.ElixirCollectorTier == 5) {
			ElixirCollectorNextTierCards = Player.CardsToTier6;
		} else if (Player.ElixirCollectorTier == 6) {
			ElixirCollectorNextTierCards = Player.CardsToTier7;
		} else if (Player.ElixirCollectorTier == 7) {
			ElixirCollectorNextTierCards = Player.CardsToTier8;
		} else if (Player.ElixirCollectorTier == 8) {
			ElixirCollectorNextTierCards = Player.CardsToTier9;
		} else if (Player.ElixirCollectorTier == 9) {
			ElixirCollectorNextTierCards = Player.CardsToTier10;
		} else if (Player.ElixirCollectorTier == 10) {
			ElixirCollectorNextTierCards = Player.CardsToTier11;
		} else if (Player.ElixirCollectorTier == 11) {
			ElixirCollectorNextTierCards = Player.CardsToTier12;
		} else if (Player.ElixirCollectorTier == 12) {
			ElixirCollectorNextTierCards = Player.CardsToTier13;
		} else if (Player.ElixirCollectorTier == 13) {
			ElixirCollectorNextTierCards = 0;
		} else {
			ElixirCollectorNextTierCards = 0;
		}
	}

	public void UpgradeTierElixirCollector () {
		if (Player.ElixirCollectorCards >= ElixirCollectorNextTierCards && Player.ElixirCollectorTier <= 12) {
			Player.ElixirCollectorCards -= ElixirCollectorNextTierCards;
			Player.ElixirCollectorTier += 1;
			Player.Experience += buildingManager.ElixirCollector.ExperiencePerTier;
			Player.Trophys += buildingManager.ElixirCollector.TrophysPerTier;
			builderUI.UpgradeTierElixirCollectorUI ();
			CheckElixirCollectorTierCards ();
			CalculateElixirCollectorStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//-----aktive-----
	//BombTower

	public void UpgradeBombTower () {
		if (Player.Elix >= Player.BombTowerElixCost) {
			Player.Elix -= Player.BombTowerElixCost;
			Player.BombTowerLevel += 1;
			Player.Experience += buildingManager.BombTower.ExperiencePerLevel;
			Player.Trophys += buildingManager.BombTower.TrophysPerLevel;
			CalculateBombTowerStats ();
			CalculateNewBombTowerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateBombTowerStats () {
		if (Player.BombTowerTier >= 1) {
			buildingManager.BombTower.ElixClickProduction = (float)buildingManager.BombTower.DefaultElixClickProduction + (buildingManager.BombTower.ElixClickProductionAddPerLevel * Player.BombTowerLevel) + (buildingManager.BombTower.ElixClickProductionAddPerTier * Player.BombTowerTier);
		} else {
			buildingManager.BombTower.ElixClickProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewBombTowerCost() {
		x = (float) Mathf.Pow(1.15f , Player.BombTowerLevel);
		Player.BombTowerElixCost = Mathf.FloorToInt((float) buildingManager.BombTower.DefaultElixCost * x);
		builderUI.UpgradeBombTowerUI ();
	}

	public void CheckBombTowerTierCards () {
		if (Player.BombTowerTier == 0) {
			BombTowerNextTierCards = Player.CardsToTier1;
		} else if (Player.BombTowerTier == 1) {
			BombTowerNextTierCards = Player.CardsToTier2;
		} else if (Player.BombTowerTier == 2) {
			BombTowerNextTierCards = Player.CardsToTier3;
		} else if (Player.BombTowerTier == 3) {
			BombTowerNextTierCards = Player.CardsToTier4;
		} else if (Player.BombTowerTier == 4) {
			BombTowerNextTierCards = Player.CardsToTier5;
		} else if (Player.BombTowerTier == 5) {
			BombTowerNextTierCards = Player.CardsToTier6;
		} else if (Player.BombTowerTier == 6) {
			BombTowerNextTierCards = Player.CardsToTier7;
		} else if (Player.BombTowerTier == 7) {
			BombTowerNextTierCards = Player.CardsToTier8;
		} else if (Player.BombTowerTier == 8) {
			BombTowerNextTierCards = Player.CardsToTier9;
		} else if (Player.BombTowerTier == 9) {
			BombTowerNextTierCards = Player.CardsToTier10;
		} else if (Player.BombTowerTier == 10) {
			BombTowerNextTierCards = Player.CardsToTier11;
		} else if (Player.BombTowerTier == 11) {
			BombTowerNextTierCards = Player.CardsToTier12;
		} else if (Player.BombTowerTier == 12) {
			BombTowerNextTierCards = Player.CardsToTier13;
		} else if (Player.BombTowerTier == 13) {
			BombTowerNextTierCards = 0;
		} else {
			BombTowerNextTierCards = 0;
		}
	}

	public void UpgradeTierBombTower () {
		if (Player.BombTowerCards >= BombTowerNextTierCards && Player.BombTowerTier <= 12) {
			Player.BombTowerCards -= BombTowerNextTierCards;
			Player.BombTowerTier += 1;
			Player.Experience += buildingManager.BombTower.ExperiencePerTier;
			Player.Trophys += buildingManager.BombTower.TrophysPerTier;
			builderUI.UpgradeTierBombTowerUI ();
			CheckBombTowerTierCards ();
			CalculateBombTowerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//Cannon

	public void UpgradeCannon () {
		if (Player.Elix >= Player.CannonElixCost) {
			Player.Elix -= Player.CannonElixCost;
			Player.CannonLevel += 1;
			Player.Experience += buildingManager.Cannon.ExperiencePerLevel;
			Player.Trophys += buildingManager.Cannon.TrophysPerLevel;
			CalculateCannonStats ();
			CalculateNewCannonCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateCannonStats () {
		if (Player.CannonTier >= 1) {
			buildingManager.Cannon.ElixClickProduction = (float)buildingManager.Cannon.DefaultElixClickProduction + (buildingManager.Cannon.ElixClickProductionAddPerLevel * Player.CannonLevel) + (buildingManager.Cannon.ElixClickProductionAddPerTier * Player.CannonTier);
		} else {
			buildingManager.Cannon.ElixClickProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewCannonCost() {
		x = (float) Mathf.Pow(1.15f , Player.CannonLevel);
		Player.CannonElixCost = Mathf.FloorToInt((float) buildingManager.Cannon.DefaultElixCost * x);
		builderUI.UpgradeCannonUI ();
	}

	public void CheckCannonTierCards () {
		if (Player.CannonTier == 0) {
			CannonNextTierCards = Player.CardsToTier1;
		} else if (Player.CannonTier == 1) {
			CannonNextTierCards = Player.CardsToTier2;
		} else if (Player.CannonTier == 2) {
			CannonNextTierCards = Player.CardsToTier3;
		} else if (Player.CannonTier == 3) {
			CannonNextTierCards = Player.CardsToTier4;
		} else if (Player.CannonTier == 4) {
			CannonNextTierCards = Player.CardsToTier5;
		} else if (Player.CannonTier == 5) {
			CannonNextTierCards = Player.CardsToTier6;
		} else if (Player.CannonTier == 6) {
			CannonNextTierCards = Player.CardsToTier7;
		} else if (Player.CannonTier == 7) {
			CannonNextTierCards = Player.CardsToTier8;
		} else if (Player.CannonTier == 8) {
			CannonNextTierCards = Player.CardsToTier9;
		} else if (Player.CannonTier == 9) {
			CannonNextTierCards = Player.CardsToTier10;
		} else if (Player.CannonTier == 10) {
			CannonNextTierCards = Player.CardsToTier11;
		} else if (Player.CannonTier == 11) {
			CannonNextTierCards = Player.CardsToTier12;
		} else if (Player.CannonTier == 12) {
			CannonNextTierCards = Player.CardsToTier13;
		} else if (Player.CannonTier == 13) {
			CannonNextTierCards = 0;
		} else {
			CannonNextTierCards = 0;
		}
	}

	public void UpgradeTierCannon () {
		if (Player.CannonCards >= CannonNextTierCards && Player.CannonTier <= 12) {
			Player.CannonCards -= CannonNextTierCards;
			Player.CannonTier += 1;
			Player.Experience += buildingManager.Cannon.ExperiencePerTier;
			Player.Trophys += buildingManager.Cannon.TrophysPerTier;
			builderUI.UpgradeTierCannonUI ();
			CheckCannonTierCards ();
			CalculateCannonStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//Tesla

	public void UpgradeTesla () {
		if (Player.Elix >= Player.TeslaElixCost) {
			Player.Elix -= Player.TeslaElixCost;
			Player.TeslaLevel += 1;
			Player.Experience += buildingManager.Tesla.ExperiencePerLevel;
			Player.Trophys += buildingManager.Tesla.TrophysPerLevel;
			CalculateTeslaStats ();
			CalculateNewTeslaCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateTeslaStats () {
		if (Player.TeslaTier >= 1) {
			buildingManager.Tesla.ElixClickProduction = (float)buildingManager.Tesla.DefaultElixClickProduction + (buildingManager.Tesla.ElixClickProductionAddPerLevel * Player.TeslaLevel) + (buildingManager.Tesla.ElixClickProductionAddPerTier * Player.TeslaTier);
		} else {
			buildingManager.Tesla.ElixClickProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewTeslaCost() {
		x = (float) Mathf.Pow(1.15f , Player.TeslaLevel);
		Player.TeslaElixCost = Mathf.FloorToInt((float) buildingManager.Tesla.DefaultElixCost * x);
		builderUI.UpgradeTeslaUI ();
	}

	public void CheckTeslaTierCards () {
		if (Player.TeslaTier == 0) {
			TeslaNextTierCards = Player.CardsToTier1;
		} else if (Player.TeslaTier == 1) {
			TeslaNextTierCards = Player.CardsToTier2;
		} else if (Player.TeslaTier == 2) {
			TeslaNextTierCards = Player.CardsToTier3;
		} else if (Player.TeslaTier == 3) {
			TeslaNextTierCards = Player.CardsToTier4;
		} else if (Player.TeslaTier == 4) {
			TeslaNextTierCards = Player.CardsToTier5;
		} else if (Player.TeslaTier == 5) {
			TeslaNextTierCards = Player.CardsToTier6;
		} else if (Player.TeslaTier == 6) {
			TeslaNextTierCards = Player.CardsToTier7;
		} else if (Player.TeslaTier == 7) {
			TeslaNextTierCards = Player.CardsToTier8;
		} else if (Player.TeslaTier == 8) {
			TeslaNextTierCards = Player.CardsToTier9;
		} else if (Player.TeslaTier == 9) {
			TeslaNextTierCards = Player.CardsToTier10;
		} else if (Player.TeslaTier == 10) {
			TeslaNextTierCards = Player.CardsToTier11;
		} else if (Player.TeslaTier == 11) {
			TeslaNextTierCards = Player.CardsToTier12;
		} else if (Player.TeslaTier == 12) {
			TeslaNextTierCards = Player.CardsToTier13;
		} else if (Player.TeslaTier == 13) {
			TeslaNextTierCards = 0;
		} else {
			TeslaNextTierCards = 0;
		}
	}

	public void UpgradeTierTesla () {
		if (Player.TeslaCards >= TeslaNextTierCards && Player.TeslaTier <= 12) {
			Player.TeslaCards -= TeslaNextTierCards;
			Player.TeslaTier += 1;
			Player.Experience += buildingManager.Tesla.ExperiencePerTier;
			Player.Trophys += buildingManager.Tesla.TrophysPerTier;
			builderUI.UpgradeTierTeslaUI ();
			CheckTeslaTierCards ();
			CalculateTeslaStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	//InfernoTower

	public void UpgradeInfernoTower () {
		if (Player.Elix >= Player.InfernoTowerElixCost) {
			Player.Elix -= Player.InfernoTowerElixCost;
			Player.InfernoTowerLevel += 1;
			Player.Experience += buildingManager.InfernoTower.ExperiencePerLevel;
			Player.Trophys += buildingManager.InfernoTower.TrophysPerLevel;
			CalculateInfernoTowerStats ();
			CalculateNewInfernoTowerCost ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}

	public void CalculateInfernoTowerStats () {
		if (Player.InfernoTowerTier >= 1) {
			buildingManager.InfernoTower.ElixClickProduction = (float)buildingManager.InfernoTower.DefaultElixClickProduction + (buildingManager.InfernoTower.ElixClickProductionAddPerLevel * Player.InfernoTowerLevel) + (buildingManager.InfernoTower.ElixClickProductionAddPerTier * Player.InfernoTowerTier);
		} else {
			buildingManager.InfernoTower.ElixClickProduction = 0f;
		}
		CalculateNewElixStats ();
	}

	public void CalculateNewInfernoTowerCost() {
		x = (float) Mathf.Pow(1.15f , Player.InfernoTowerLevel);
		Player.InfernoTowerElixCost = Mathf.FloorToInt((float) buildingManager.InfernoTower.DefaultElixCost * x);
		builderUI.UpgradeInfernoTowerUI ();
	}

	public void CheckInfernoTowerTierCards () {
		if (Player.InfernoTowerTier == 0) {
			InfernoTowerNextTierCards = Player.CardsToTier1;
		} else if (Player.InfernoTowerTier == 1) {
			InfernoTowerNextTierCards = Player.CardsToTier2;
		} else if (Player.InfernoTowerTier == 2) {
			InfernoTowerNextTierCards = Player.CardsToTier3;
		} else if (Player.InfernoTowerTier == 3) {
			InfernoTowerNextTierCards = Player.CardsToTier4;
		} else if (Player.InfernoTowerTier == 4) {
			InfernoTowerNextTierCards = Player.CardsToTier5;
		} else if (Player.InfernoTowerTier == 5) {
			InfernoTowerNextTierCards = Player.CardsToTier6;
		} else if (Player.InfernoTowerTier == 6) {
			InfernoTowerNextTierCards = Player.CardsToTier7;
		} else if (Player.InfernoTowerTier == 7) {
			InfernoTowerNextTierCards = Player.CardsToTier8;
		} else if (Player.InfernoTowerTier == 8) {
			InfernoTowerNextTierCards = Player.CardsToTier9;
		} else if (Player.InfernoTowerTier == 9) {
			InfernoTowerNextTierCards = Player.CardsToTier10;
		} else if (Player.InfernoTowerTier == 10) {
			InfernoTowerNextTierCards = Player.CardsToTier11;
		} else if (Player.InfernoTowerTier == 11) {
			InfernoTowerNextTierCards = Player.CardsToTier12;
		} else if (Player.InfernoTowerTier == 12) {
			InfernoTowerNextTierCards = Player.CardsToTier13;
		} else if (Player.InfernoTowerTier == 13) {
			InfernoTowerNextTierCards = 0;
		} else {
			InfernoTowerNextTierCards = 0;
		}
	}

	public void UpgradeTierInfernoTower () {
		if (Player.InfernoTowerCards >= InfernoTowerNextTierCards && Player.InfernoTowerTier <= 12) {
			Player.InfernoTowerCards -= InfernoTowerNextTierCards;
			Player.InfernoTowerTier += 1;
			Player.Experience += buildingManager.InfernoTower.ExperiencePerTier;
			Player.Trophys += buildingManager.InfernoTower.TrophysPerTier;
			builderUI.UpgradeTierInfernoTowerUI ();
			CheckInfernoTowerTierCards ();
			CalculateInfernoTowerStats ();
			arenaTextUI.ArenaCheck ();
			experienceUI.ExpChange ();
		}
	}
}
