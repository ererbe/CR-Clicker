using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TrophyTextUI : MonoBehaviour {

	public Text TrophyText;

	void Update () {
		Player.TrophysInt = (int)Player.Trophys;
		TrophyText.text = Player.TrophysInt.ToString ();
	}
}
