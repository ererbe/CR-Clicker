using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownPoison : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject PoisonButton;
	public Image PoisonFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Poison.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		PoisonFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			PoisonButton.SetActive (true);
			spellManager.PoisonReady = true;
			gameObject.SetActive (false);
		}
	}
}
