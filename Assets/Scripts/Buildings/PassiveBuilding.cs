using System.Collections;
using UnityEngine;

[System.Serializable]
public class PassiveBuilding {

	public string BuildingNameEnglisch;
	public string BuildingNameGerman;

	public int DefaultElixCost;

	public float DefaultElixProduction;

	public float ElixProduction;

	public int ExperiencePerTier;
	public float TrophysPerTier;
	public float ElixProductionAddPerTier;

	public int ExperiencePerLevel;
	public float TrophysPerLevel;
	public float ElixProductionAddPerLevel;
}
