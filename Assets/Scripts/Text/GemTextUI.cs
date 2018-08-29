using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GemTextUI : MonoBehaviour {

	public Text GemText;

	void Update () {
		Player.GemsInt = (int)Player.Gems;
		GemText.text = Player.GemsInt.ToString ();
	}
}
