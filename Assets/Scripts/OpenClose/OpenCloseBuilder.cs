using System.Collections;
using UnityEngine;

public class OpenCloseBuilder : MonoBehaviour {

	public GameObject Builder;

	public void OpenBuilder() {
		Builder.SetActive (true);
	}

	public void CloseBuilder() {
		Builder.SetActive (false);
	}
}
