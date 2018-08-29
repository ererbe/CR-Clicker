using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownGraveyard : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject GraveyardButton;
	public Image GraveyardFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Graveyard.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		GraveyardFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			GraveyardButton.SetActive (true);
			spellManager.GraveyardReady = true;
			gameObject.SetActive (false);
		}
	}
}
