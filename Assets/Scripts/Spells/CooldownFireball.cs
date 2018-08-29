using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownFireball : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject FireballButton;
	public Image FireballFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Fireball.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		FireballFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			FireballButton.SetActive (true);
			spellManager.FireballReady = true;
			gameObject.SetActive (false);
		}
	}
}
