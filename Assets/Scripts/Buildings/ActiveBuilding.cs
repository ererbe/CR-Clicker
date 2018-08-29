using System.Collections;
using UnityEngine;

[System.Serializable]
public class ActiveBuilding {

	public string BuildingNameEnglisch;
	public string BuildingNameGerman;

	public int DefaultElixCost;

	public float DefaultElixClickProduction;

	public float ElixClickProduction;

	public int ExperiencePerTier;
	public float TrophysPerTier;
	public float ElixClickProductionAddPerTier;

	public int ExperiencePerLevel;
	public float TrophysPerLevel;
	public float ElixClickProductionAddPerLevel;
}
