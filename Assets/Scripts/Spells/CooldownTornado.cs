using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownTornado : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject TornadoButton;
	public Image TornadoFillImage;

	private float CooldownDuration;
	public float CooldownTime;

	public void StartCooldown () {
		GetCooldown ();
		CooldownTime = 0f;
	}

	public void GetCooldown () {
		CooldownDuration = spellManager.Tornado.Cooldown;
	}

	void Update () {
		CooldownTime += Time.deltaTime;
		TornadoFillImage.fillAmount = (float)CooldownTime/CooldownDuration;
		if (CooldownTime >= CooldownDuration) {
			TornadoButton.SetActive (true);
			spellManager.TornadoReady = true;
			gameObject.SetActive (false);
		}
	}
}
