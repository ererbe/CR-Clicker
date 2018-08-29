using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CrownTextUI : MonoBehaviour {

	public Text CrownText;

	void Update () {
		CrownText.text = Player.Crowns.ToString ();
	}
}
