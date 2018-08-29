using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownRocket : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject RocketButton;
	public Image RocketFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Rocket.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		RocketFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			RocketButton.SetActive (true);
			spellManager.RocketReady = true;
			gameObject.SetActive (false);
		}
	}
}
