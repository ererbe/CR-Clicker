using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FrozenElix : MonoBehaviour {

	public GameObject gethit;

	public GameObject ElixParticles;

	private float nextElix;

	void Update () {

		// Player.Elix += (float)(Player.ElixPerSecound * Time.deltaTime);

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
							Player.FreezeTouchCount += 1;
							Player.FrozenElixClicks += 1;

							if (Player.ShowParticles == true) {
								GameObject particle = (GameObject)Instantiate (ElixParticles, hit.transform.position, hit.transform.rotation);
								Destroy (particle, 6f);
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
