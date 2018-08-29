using System.Collections;
using UnityEngine;

public class OpenCloseOptions : MonoBehaviour {

	public GameObject Options;

	public void OpenOptions() {
		Options.SetActive (true);
	}

	public void CloseOptions() {
		Options.SetActive (false);
	}
}
