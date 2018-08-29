using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ElixTextUI : MonoBehaviour {

	public Text ElixText;

	void Update () {
		Player.ElixInt = (int)Player.Elix;
		ElixText.text = Player.ElixInt.ToString ();
	}
}
