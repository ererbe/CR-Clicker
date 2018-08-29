using System.Collections;
using UnityEngine;

public class OpenCloseKasern : MonoBehaviour {

	public GameObject Kasern;

	public void OpenKasern() {
		Kasern.SetActive (true);
	}

	public void CloseKasern() {
		Kasern.SetActive (false);
	}
}
