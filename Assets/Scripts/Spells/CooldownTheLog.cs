using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownTheLog : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject TheLogButton;
	public Image TheLogFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.TheLog.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		TheLogFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			TheLogButton.SetActive (true);
			spellManager.TheLogReady = true;
			gameObject.SetActive (false);
		}
	}
}
