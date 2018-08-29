using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownHeal : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject HealButton;
	public Image HealFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Heal.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		HealFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			HealButton.SetActive (true);
			spellManager.HealReady = true;
			gameObject.SetActive (false);
		}
	}
}
