using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownGoblinBarrel : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject GoblinBarrelButton;
	public Image GoblinBarrelFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.GoblinBarrel.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		GoblinBarrelFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			GoblinBarrelButton.SetActive (true);
			spellManager.GoblinBarrelReady = true;
			gameObject.SetActive (false);
		}
	}
}
