using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextUI : MonoBehaviour {

	public Text CoinText;

	void Update () {
		Player.CoinsInt = (int)Player.Coins;
		CoinText.text = Player.CoinsInt.ToString ();
	}
}
