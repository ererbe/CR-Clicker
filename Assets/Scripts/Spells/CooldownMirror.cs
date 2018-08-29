using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownMirror : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject MirrorButton;
	public Image MirrorFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Mirror.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		MirrorFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			MirrorButton.SetActive (true);
			spellManager.MirrorReady = true;
			gameObject.SetActive (false);
		}
	}
}
