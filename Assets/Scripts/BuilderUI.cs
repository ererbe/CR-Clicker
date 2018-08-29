using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BuilderUI : MonoBehaviour {

	public BuildingManager buildingManager;

	public Text CostTextGoblinHut;
	public Text CostTextTombstone;
	public Text CostTextBombTower;
	public Text CostTextCannon;
	public Text CostTextBarbarianHut;
	public Text CostTextXBow;
	public Text CostTextTesla;
	public Text CostTextInfernoTower;
	public Text CostTextFurnace;
	public Text CostTextMortar;
	public Text CostTextElixirCollector;

	void OnEnable () {
		UpdateAnything ();
	}
	
	public void UpdateAnything () {
		if (Player.Language == 1) {
			GoblinHutName.text = buildingManager.GoblinHut.BuildingNameEnglisch;
			TombstoneName.text = buildingManager.Tombstone.BuildingNameEnglisch;
			BombTowerName.text = buildingManager.BombTower.BuildingNameEnglisch;
			CannonName.text = buildingManager.Cannon.BuildingNameEnglisch;
			BarbarianHutName.text = buildingManager.BarbarianHut.BuildingNameEnglisch;
			XBowName.text = buildingManager.XBow.BuildingNameEnglisch;
			TeslaName.text = buildingManager.Tesla.BuildingNameEnglisch;
			InfernoTowerName.text = buildingManager.InfernoTower.BuildingNameEnglisch;
			FurnaceName.text = buildingManager.Furnace.BuildingNameEnglisch;
			MortarName.text = buildingManager.Mortar.BuildingNameEnglisch;
			ElixirCollectorName.text = buildingManager.ElixirCollector.BuildingNameEnglisch;

			CostTextGoblinHut.text = "Cost:";
			CostTextTombstone.text = "Cost:";
			CostTextBombTower.text = "Cost:";
			CostTextCannon.text = "Cost:";
			CostTextBarbarianHut.text = "Cost:";
			CostTextXBow.text = "Cost:";
			CostTextTesla.text = "Cost:";
			CostTextInfernoTower.text = "Cost:";
			CostTextFurnace.text = "Cost:";
			CostTextMortar.text = "Cost:";
			CostTextElixirCollector.text = "Cost:";

		} else if (Player.Language == 2) {
			GoblinHutName.text = buildingManager.GoblinHut.BuildingNameGerman;
			TombstoneName.text = buildingManager.Tombstone.BuildingNameGerman;
			BombTowerName.text = buildingManager.BombTower.BuildingNameGerman;
			CannonName.text = buildingManager.Cannon.BuildingNameGerman;
			BarbarianHutName.text = buildingManager.BarbarianHut.BuildingNameGerman;
			XBowName.text = buildingManager.XBow.BuildingNameGerman;
			TeslaName.text = buildingManager.Tesla.BuildingNameGerman;
			InfernoTowerName.text = buildingManager.InfernoTower.BuildingNameGerman;
			FurnaceName.text = buildingManager.Furnace.BuildingNameGerman;
			MortarName.text = buildingManager.Mortar.BuildingNameGerman;
			ElixirCollectorName.text = buildingManager.ElixirCollector.BuildingNameGerman;

			CostTextGoblinHut.text = "Kosten:";
			CostTextTombstone.text = "Kosten:";
			CostTextBombTower.text = "Kosten:";
			CostTextCannon.text = "Kosten:";
			CostTextBarbarianHut.text = "Kosten:";
			CostTextXBow.text = "Kosten:";
			CostTextTesla.text = "Kosten:";
			CostTextInfernoTower.text = "Kosten:";
			CostTextFurnace.text = "Kosten:";
			CostTextMortar.text = "Kosten:";
			CostTextElixirCollector.text = "Kosten:";
		}
		CheckGoblinHutUI ();
		CheckTombstoneUI ();
		CheckBombTowerUI ();
		CheckCannonUI ();
		CheckBarbarianHutUI ();
		CheckXBowUI ();
		CheckTeslaUI ();
		CheckInfernoTowerUI ();
		CheckFurnaceUI ();
		CheckMortarUI ();
		CheckElixirCollectorUI ();
	}

	public Text GoblinHutName;
	public Text GoblinHutCost;
	public Text GoblinHutLevel;
	public Text GoblinHutTier;
	public Text GoblinHutCardCurrent;
	public Text GoblinHutCardNextTier;
	public Image GoblinHutTierProgress;

	void CheckGoblinHutUI () {
		GoblinHutCost.text = Player.GoblinHutElixCost.ToString ();  
		GoblinHutLevel.text = Player.GoblinHutLevel.ToString ();
		GoblinHutTier.text = Player.GoblinHutTier.ToString ();
		GoblinHutCardCurrent.text = Player.GoblinHutCards.ToString ();
		GoblinHutCardNextTier.text = Builder.GoblinHutNextTierCards.ToString();
		GoblinHutTierProgress.fillAmount = (float) Player.GoblinHutCards / Builder.GoblinHutNextTierCards;
	}

	public void UpgradeGoblinHutUI () {
		GoblinHutCost.text = Player.GoblinHutElixCost.ToString ();
		GoblinHutLevel.text = Player.GoblinHutLevel.ToString ();
	}

	public void UpgradeTierGoblinHutUI () {
		GoblinHutTier.text = Player.GoblinHutTier.ToString ();
		GoblinHutCardCurrent.text = Player.GoblinHutCards.ToString ();
		GoblinHutCardNextTier.text = Builder.GoblinHutNextTierCards.ToString();
		GoblinHutTierProgress.fillAmount = (float) Player.GoblinHutCards / Builder.GoblinHutNextTierCards;
	}

	public Text TombstoneName;
	public Text TombstoneCost;
	public Text TombstoneLevel;
	public Text TombstoneTier;
	public Text TombstoneCardCurrent;
	public Text TombstoneCardNextTier;
	public Image TombstoneTierProgress;

	void CheckTombstoneUI () {
		TombstoneCost.text = Player.TombstoneElixCost.ToString ();  
		TombstoneLevel.text = Player.TombstoneLevel.ToString ();
		TombstoneTier.text = Player.TombstoneTier.ToString ();
		TombstoneCardCurrent.text = Player.TombstoneCards.ToString ();
		TombstoneCardNextTier.text = Builder.TombstoneNextTierCards.ToString();
		TombstoneTierProgress.fillAmount = (float) Player.TombstoneCards / Builder.TombstoneNextTierCards;
	}

	public void UpgradeTombstoneUI () {
		TombstoneCost.text = Player.TombstoneElixCost.ToString ();
		TombstoneLevel.text = Player.TombstoneLevel.ToString ();
	}

	public void UpgradeTierTombstoneUI () {
		TombstoneTier.text = Player.TombstoneTier.ToString ();
		TombstoneCardCurrent.text = Player.TombstoneCards.ToString ();
		TombstoneCardNextTier.text = Builder.TombstoneNextTierCards.ToString();
		TombstoneTierProgress.fillAmount = (float) Player.TombstoneCards / Builder.TombstoneNextTierCards;
	}

	public Text BombTowerName;
	public Text BombTowerCost;
	public Text BombTowerLevel;
	public Text BombTowerTier;
	public Text BombTowerCardCurrent;
	public Text BombTowerCardNextTier;
	public Image BombTowerTierProgress;

	void CheckBombTowerUI () {
		BombTowerCost.text = Player.BombTowerElixCost.ToString ();  
		BombTowerLevel.text = Player.BombTowerLevel.ToString ();
		BombTowerTier.text = Player.BombTowerTier.ToString ();
		BombTowerCardCurrent.text = Player.BombTowerCards.ToString ();
		BombTowerCardNextTier.text = Builder.BombTowerNextTierCards.ToString();
		BombTowerTierProgress.fillAmount = (float) Player.BombTowerCards / Builder.BombTowerNextTierCards;
	}

	public void UpgradeBombTowerUI () {
		BombTowerCost.text = Player.BombTowerElixCost.ToString ();
		BombTowerLevel.text = Player.BombTowerLevel.ToString ();
	}

	public void UpgradeTierBombTowerUI () {
		BombTowerTier.text = Player.BombTowerTier.ToString ();
		BombTowerCardCurrent.text = Player.BombTowerCards.ToString ();
		BombTowerCardNextTier.text = Builder.BombTowerNextTierCards.ToString();
		BombTowerTierProgress.fillAmount = (float) Player.BombTowerCards / Builder.BombTowerNextTierCards;
	}

	public Text CannonName;
	public Text CannonCost;
	public Text CannonLevel;
	public Text CannonTier;
	public Text CannonCardCurrent;
	public Text CannonCardNextTier;
	public Image CannonTierProgress;

	void CheckCannonUI () {
		CannonCost.text = Player.CannonElixCost.ToString ();  
		CannonLevel.text = Player.CannonLevel.ToString ();
		CannonTier.text = Player.CannonTier.ToString ();
		CannonCardCurrent.text = Player.CannonCards.ToString ();
		CannonCardNextTier.text = Builder.CannonNextTierCards.ToString();
		CannonTierProgress.fillAmount = (float) Player.CannonCards / Builder.CannonNextTierCards;
	}

	public void UpgradeCannonUI () {
		CannonCost.text = Player.CannonElixCost.ToString ();
		CannonLevel.text = Player.CannonLevel.ToString ();
	}

	public void UpgradeTierCannonUI () {
		CannonTier.text = Player.CannonTier.ToString ();
		CannonCardCurrent.text = Player.CannonCards.ToString ();
		CannonCardNextTier.text = Builder.CannonNextTierCards.ToString();
		CannonTierProgress.fillAmount = (float) Player.CannonCards / Builder.CannonNextTierCards;
	}

	public Text BarbarianHutName;
	public Text BarbarianHutCost;
	public Text BarbarianHutLevel;
	public Text BarbarianHutTier;
	public Text BarbarianHutCardCurrent;
	public Text BarbarianHutCardNextTier;
	public Image BarbarianHutTierProgress;

	void CheckBarbarianHutUI () {
		BarbarianHutCost.text = Player.BarbarianHutElixCost.ToString ();  
		BarbarianHutLevel.text = Player.BarbarianHutLevel.ToString ();
		BarbarianHutTier.text = Player.BarbarianHutTier.ToString ();
		BarbarianHutCardCurrent.text = Player.BarbarianHutCards.ToString ();
		BarbarianHutCardNextTier.text = Builder.BarbarianHutNextTierCards.ToString();
		BarbarianHutTierProgress.fillAmount = (float) Player.BarbarianHutCards / Builder.BarbarianHutNextTierCards;
	}

	public void UpgradeBarbarianHutUI () {
		BarbarianHutCost.text = Player.BarbarianHutElixCost.ToString ();
		BarbarianHutLevel.text = Player.BarbarianHutLevel.ToString ();
	}

	public void UpgradeTierBarbarianHutUI () {
		BarbarianHutTier.text = Player.BarbarianHutTier.ToString ();
		BarbarianHutCardCurrent.text = Player.BarbarianHutCards.ToString ();
		BarbarianHutCardNextTier.text = Builder.BarbarianHutNextTierCards.ToString();
		BarbarianHutTierProgress.fillAmount = (float) Player.BarbarianHutCards / Builder.BarbarianHutNextTierCards;
	}

	public Text XBowName;
	public Text XBowCost;
	public Text XBowLevel;
	public Text XBowTier;
	public Text XBowCardCurrent;
	public Text XBowCardNextTier;
	public Image XBowTierProgress;

	void CheckXBowUI () {
		XBowCost.text = Player.XBowElixCost.ToString ();  
		XBowLevel.text = Player.XBowLevel.ToString ();
		XBowTier.text = Player.XBowTier.ToString ();
		XBowCardCurrent.text = Player.XBowCards.ToString ();
		XBowCardNextTier.text = Builder.XBowNextTierCards.ToString();
		XBowTierProgress.fillAmount = (float) Player.XBowCards / Builder.XBowNextTierCards;
	}

	public void UpgradeXBowUI () {
		XBowCost.text = Player.XBowElixCost.ToString ();
		XBowLevel.text = Player.XBowLevel.ToString ();
	}

	public void UpgradeTierXBowUI () {
		XBowTier.text = Player.XBowTier.ToString ();
		XBowCardCurrent.text = Player.XBowCards.ToString ();
		XBowCardNextTier.text = Builder.XBowNextTierCards.ToString();
		XBowTierProgress.fillAmount = (float) Player.XBowCards / Builder.XBowNextTierCards;
	}

	public Text TeslaName;
	public Text TeslaCost;
	public Text TeslaLevel;
	public Text TeslaTier;
	public Text TeslaCardCurrent;
	public Text TeslaCardNextTier;
	public Image TeslaTierProgress;

	void CheckTeslaUI () {
		TeslaCost.text = Player.TeslaElixCost.ToString ();  
		TeslaLevel.text = Player.TeslaLevel.ToString ();
		TeslaTier.text = Player.TeslaTier.ToString ();
		TeslaCardCurrent.text = Player.TeslaCards.ToString ();
		TeslaCardNextTier.text = Builder.TeslaNextTierCards.ToString();
		TeslaTierProgress.fillAmount = (float) Player.TeslaCards / Builder.TeslaNextTierCards;
	}

	public void UpgradeTeslaUI () {
		TeslaCost.text = Player.TeslaElixCost.ToString ();
		TeslaLevel.text = Player.TeslaLevel.ToString ();
	}

	public void UpgradeTierTeslaUI () {
		TeslaTier.text = Player.TeslaTier.ToString ();
		TeslaCardCurrent.text = Player.TeslaCards.ToString ();
		TeslaCardNextTier.text = Builder.TeslaNextTierCards.ToString();
		TeslaTierProgress.fillAmount = (float) Player.TeslaCards / Builder.TeslaNextTierCards;
	}

	public Text InfernoTowerName;
	public Text InfernoTowerCost;
	public Text InfernoTowerLevel;
	public Text InfernoTowerTier;
	public Text InfernoTowerCardCurrent;
	public Text InfernoTowerCardNextTier;
	public Image InfernoTowerTierProgress;

	void CheckInfernoTowerUI () {
		InfernoTowerCost.text = Player.InfernoTowerElixCost.ToString ();  
		InfernoTowerLevel.text = Player.InfernoTowerLevel.ToString ();
		InfernoTowerTier.text = Player.InfernoTowerTier.ToString ();
		InfernoTowerCardCurrent.text = Player.InfernoTowerCards.ToString ();
		InfernoTowerCardNextTier.text = Builder.InfernoTowerNextTierCards.ToString();
		InfernoTowerTierProgress.fillAmount = (float) Player.InfernoTowerCards / Builder.InfernoTowerNextTierCards;
	}

	public void UpgradeInfernoTowerUI () {
		InfernoTowerCost.text = Player.InfernoTowerElixCost.ToString ();
		InfernoTowerLevel.text = Player.InfernoTowerLevel.ToString ();
	}

	public void UpgradeTierInfernoTowerUI () {
		InfernoTowerTier.text = Player.InfernoTowerTier.ToString ();
		InfernoTowerCardCurrent.text = Player.InfernoTowerCards.ToString ();
		InfernoTowerCardNextTier.text = Builder.InfernoTowerNextTierCards.ToString();
		InfernoTowerTierProgress.fillAmount = (float) Player.InfernoTowerCards / Builder.InfernoTowerNextTierCards;
	}

	public Text FurnaceName;
	public Text FurnaceCost;
	public Text FurnaceLevel;
	public Text FurnaceTier;
	public Text FurnaceCardCurrent;
	public Text FurnaceCardNextTier;
	public Image FurnaceTierProgress;

	void CheckFurnaceUI () {
		FurnaceCost.text = Player.FurnaceElixCost.ToString ();  
		FurnaceLevel.text = Player.FurnaceLevel.ToString ();
		FurnaceTier.text = Player.FurnaceTier.ToString ();
		FurnaceCardCurrent.text = Player.FurnaceCards.ToString ();
		FurnaceCardNextTier.text = Builder.FurnaceNextTierCards.ToString();
		FurnaceTierProgress.fillAmount = (float) Player.FurnaceCards / Builder.FurnaceNextTierCards;
	}

	public void UpgradeFurnaceUI () {
		FurnaceCost.text = Player.FurnaceElixCost.ToString ();
		FurnaceLevel.text = Player.FurnaceLevel.ToString ();
	}

	public void UpgradeTierFurnaceUI () {
		FurnaceTier.text = Player.FurnaceTier.ToString ();
		FurnaceCardCurrent.text = Player.FurnaceCards.ToString ();
		FurnaceCardNextTier.text = Builder.FurnaceNextTierCards.ToString();
		FurnaceTierProgress.fillAmount = (float) Player.FurnaceCards / Builder.FurnaceNextTierCards;
	}

	public Text MortarName;
	public Text MortarCost;
	public Text MortarLevel;
	public Text MortarTier;
	public Text MortarCardCurrent;
	public Text MortarCardNextTier;
	public Image MortarTierProgress;

	void CheckMortarUI () {
		MortarCost.text = Player.MortarElixCost.ToString ();  
		MortarLevel.text = Player.MortarLevel.ToString ();
		MortarTier.text = Player.MortarTier.ToString ();
		MortarCardCurrent.text = Player.MortarCards.ToString ();
		MortarCardNextTier.text = Builder.MortarNextTierCards.ToString();
		MortarTierProgress.fillAmount = (float) Player.MortarCards / Builder.MortarNextTierCards;
	}

	public void UpgradeMortarUI () {
		MortarCost.text = Player.MortarElixCost.ToString ();
		MortarLevel.text = Player.MortarLevel.ToString ();
	}

	public void UpgradeTierMortarUI () {
		MortarTier.text = Player.MortarTier.ToString ();
		MortarCardCurrent.text = Player.MortarCards.ToString ();
		MortarCardNextTier.text = Builder.MortarNextTierCards.ToString();
		MortarTierProgress.fillAmount = (float) Player.MortarCards / Builder.MortarNextTierCards;
	}

	public Text ElixirCollectorName;
	public Text ElixirCollectorCost;
	public Text ElixirCollectorLevel;
	public Text ElixirCollectorTier;
	public Text ElixirCollectorCardCurrent;
	public Text ElixirCollectorCardNextTier;
	public Image ElixirCollectorTierProgress;

	void CheckElixirCollectorUI () {
		ElixirCollectorCost.text = Player.ElixirCollectorElixCost.ToString ();  
		ElixirCollectorLevel.text = Player.ElixirCollectorLevel.ToString ();
		ElixirCollectorTier.text = Player.ElixirCollectorTier.ToString ();
		ElixirCollectorCardCurrent.text = Player.ElixirCollectorCards.ToString ();
		ElixirCollectorCardNextTier.text = Builder.ElixirCollectorNextTierCards.ToString();
		ElixirCollectorTierProgress.fillAmount = (float) Player.ElixirCollectorCards / Builder.ElixirCollectorNextTierCards;
	}

	public void UpgradeElixirCollectorUI () {
		ElixirCollectorCost.text = Player.ElixirCollectorElixCost.ToString ();
		ElixirCollectorLevel.text = Player.ElixirCollectorLevel.ToString ();
	}

	public void UpgradeTierElixirCollectorUI () {
		ElixirCollectorTier.text = Player.ElixirCollectorTier.ToString ();
		ElixirCollectorCardCurrent.text = Player.ElixirCollectorCards.ToString ();
		ElixirCollectorCardNextTier.text = Builder.ElixirCollectorNextTierCards.ToString();
		ElixirCollectorTierProgress.fillAmount = (float) Player.ElixirCollectorCards / Builder.ElixirCollectorNextTierCards;
	}
}
