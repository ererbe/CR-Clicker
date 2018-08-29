using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Elix : MonoBehaviour {

	public GameObject gethit;

	public GameObject ElixParticles;
	public Transform ParticlePosition;

	private float nextElix;

	public GameObject CrownParticle1;
	public GameObject CrownParticle2;
	public GameObject CrownParticle3;

	private int Crown;

	public Animation ElixAnimation;

	public SpellManager spellManager;

	void Update () {
		
//		if (Time.time > nextElix) {
//			nextElix = Time.time + 1f;
//			Player.Elix += Player.ElixPerSecound;
//			Player.CollectedElix += Player.ElixPerSecound;
//		}

		Player.Elix += (float)(Player.ElixPerSecound * Time.deltaTime  * Player.MirrorMulti * Player.CloneMulti);
//		Player.ClanChestCrowns += 1;

		//pc
//		if (Input.GetButtonDown ("Fire1")) {
//			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//			RaycastHit hit;
//			Physics.Raycast (ray, out hit);


//			if (!EventSystem.current.IsPointerOverGameObject ()) {
//				if (hit.collider.gameObject == gethit) {
//					Player.Elix += Player.ElixPerClick;
//					Player.ElixClicks += 1;
					

//				if (Player.ShowElixAnimation == true) {
//					ElixAnimation.Play();
//				}
//
//					if (Player.ShowParticles == true) {
//						GameObject particle = (GameObject)Instantiate (ElixParticles, ParticlePosition.transform.position, ParticlePosition.transform.rotation);
//						Destroy (particle, 6f);
//					}
//				}
//			}
//		}

		// mobile
		int nbTouches = Input.touchCount;

		if (nbTouches > 0) {
			for (int i = 0; i < nbTouches; i++) {
				Touch touch = Input.GetTouch (i);

				if (touch.phase == TouchPhase.Began) {
					Ray ray = Camera.main.ScreenPointToRay (touch.position);
					RaycastHit hit;
					Physics.Raycast (ray, out hit);

					if (!IsPointerOverUIObject ()) {
						if (hit.collider.gameObject == gethit) {
							Player.Elix += Player.ElixPerClick * Player.MirrorMulti * Player.TornadoMulti * Player.CloneMulti;
							Player.CollectedElix += Player.ElixPerClick * Player.MirrorMulti * Player.TornadoMulti * Player.CloneMulti;
							Player.ElixClicks += 1;

							if (Player.ShowElixAnimation == true) {
								ElixAnimation.Play();
							}

							if (Player.HealIsActive) {
								Player.Coins += spellManager.Heal.Power * Player.MirrorMulti * Player.TornadoMulti;
								Player.CollectedCoins += spellManager.Heal.Power * Player.MirrorMulti * Player.TornadoMulti;
								Player.Gems += (spellManager.Heal.Power/100) * Player.MirrorMulti * Player.TornadoMulti;
								Player.CollectedJewels += (spellManager.Heal.Power/100) * Player.MirrorMulti * Player.TornadoMulti;
							}

							if (Player.ShowParticles == true) {
								GameObject particle = (GameObject)Instantiate (ElixParticles, ParticlePosition.transform.position, ParticlePosition.transform.rotation);
								Destroy (particle, 6f);
							}

							Crown = Random.Range (1, 11);

							if (Crown == 1) {
								Player.Crowns += Mathf.RoundToInt(1 * Player.MirrorMulti * Player.TornadoMulti);
								Player.CollectedCrowns += Mathf.RoundToInt(1 * Player.MirrorMulti * Player.TornadoMulti);
								Player.ClanChestCrowns += Mathf.RoundToInt(1 * Player.MirrorMulti * Player.TornadoMulti);
								if (Player.CrownParticles == 4) {
									return;
								} else if (Player.CrownParticles == 1) {
									GameObject particle = (GameObject)Instantiate (CrownParticle1, ParticlePosition.transform.position, ParticlePosition.transform.rotation);
									Destroy (particle, 6f);
								} else if (Player.CrownParticles == 2) {
									GameObject particle = (GameObject)Instantiate (CrownParticle2, ParticlePosition.transform.position, ParticlePosition.transform.rotation);
									Destroy (particle, 6f);
								} else if (Player.CrownParticles == 3) {
									GameObject particle = (GameObject)Instantiate (CrownParticle3, ParticlePosition.transform.position, ParticlePosition.transform.rotation);
									Destroy (particle, 6f);
								}
							}
						}
					}
				}
			}
		}
	}

	private bool IsPointerOverUIObject() {
		PointerEventData eventDataCurrentPosition = new PointerEventData (EventSystem.current);
		eventDataCurrentPosition.position = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

		List<RaycastResult> results = new List<RaycastResult> ();
		EventSystem.current.RaycastAll (eventDataCurrentPosition, results);
		return results.Count > 0;
	}
}
