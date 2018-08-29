using System.Collections;
using UnityEngine;

public class OpenCloseChestShop : MonoBehaviour {

	public GameObject ChestShop;

	public void OpenChestShop() {
		ChestShop.SetActive (true);
	}

	public void CloseChestShop() {
		ChestShop.SetActive (false);
	}
}
