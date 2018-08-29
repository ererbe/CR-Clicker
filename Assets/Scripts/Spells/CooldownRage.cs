using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownRage : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject RageButton;
	public Image RageFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Rage.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		RageFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			RageButton.SetActive (true);
			spellManager.RageReady = true;
			gameObject.SetActive (false);
		}
	}
}
