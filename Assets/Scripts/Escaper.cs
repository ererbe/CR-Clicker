using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escaper : MonoBehaviour {

	public GameObject GOToClose;

	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			GOToClose.SetActive (false);
		}
	}
}
