using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownArrows : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject ArrowsButton;
	public Image ArrowsFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Arrows.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		ArrowsFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			ArrowsButton.SetActive (true);
			spellManager.ArrowsReady = true;
			gameObject.SetActive (false);
		}
	}
}
