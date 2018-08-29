using System.Collections;
using UnityEngine;

public class OpenCloseWizard : MonoBehaviour {

	public GameObject Wizard;

	public void OpenWizard() {
		Wizard.SetActive (true);
	}

	public void CloseWizard() {
		Wizard.SetActive (false);
	}
}
