using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownBarbarianBarrel : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject BarbarianBarrelButton;
	public Image BarbarianBarrelFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.BarbarianBarrel.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		BarbarianBarrelFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			BarbarianBarrelButton.SetActive (true);
			spellManager.BarbarianBarrelReady = true;
			gameObject.SetActive (false);
		}
	}
}
