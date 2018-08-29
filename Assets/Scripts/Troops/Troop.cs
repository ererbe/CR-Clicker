using System.Collections;
using UnityEngine;

[System.Serializable]
public class Troop {

	public string TroopNameEnglisch;
	public string TroopNameGerman;

	public int DefaultElixCost;
	public float DefaultCoinsPerTime;
	public float DefaultCoinCollectDuration;

	public float CoinsPerTime;
	public float CoinCollectDuration;

	public int ExperiencePerTier;
	public float TrophysPerTier;
	public float CoinsPerTimeAddPerTier;
	public float CoinsCollectDurationChangePerTier;

	public int ExperiencePerLevel;
	public float TrophysPerLevel;
	public float CoinsPerTimeAddPerLevel;
}
