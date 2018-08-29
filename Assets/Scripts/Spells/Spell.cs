using System.Collections;
using UnityEngine;

[System.Serializable]
public class Spell {

	public string SpellNameEnglisch;
	public string SpellNameGerman;

	public int DefaultElixCost;
	public float DefaultPower;
	public float DefaultCooldown;

	public float Power;
	public float Cooldown;

	public int ExperiencePerTier;
	public float TrophysPerTier;

	public int ExperiencePerLevel;
	public float TrophysPerLevel;

}
