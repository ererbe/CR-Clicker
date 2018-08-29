using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownLightning : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject LightningButton;
	public Image LightningFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Lightning.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		LightningFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			LightningButton.SetActive (true);
			spellManager.LightningReady = true;
			gameObject.SetActive (false);
		}
	}
}
