using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownFreeze : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject FreezeButton;
	public Image FreezeFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Freeze.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		FreezeFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			FreezeButton.SetActive (true);
			spellManager.FreezeReady = true;
			gameObject.SetActive (false);
		}
	}
}
