using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownClone : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject CloneButton;
	public Image CloneFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Clone.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		CloneFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			CloneButton.SetActive (true);
			spellManager.CloneReady = true;
			gameObject.SetActive (false);
		}
	}
}
