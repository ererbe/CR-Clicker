using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownZap : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject ZapButton;
	public Image ZapFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Zap.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		ZapFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			ZapButton.SetActive (true);
			spellManager.ZapReady = true;
			gameObject.SetActive (false);
		}
	}
}
