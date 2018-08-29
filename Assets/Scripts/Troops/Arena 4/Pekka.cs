using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pekka : MonoBehaviour {

	public TroopManager troopManager;

	private float PekkaCoinsPerTime;
	private float PekkaCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + PekkaCoinDuration;
			Player.Coins += PekkaCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += PekkaCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.PekkaCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.PekkaTier > 0) {
			PekkaCoinDuration = (float)troopManager.Pekka.CoinCollectDuration;
			PekkaCoinsPerTime = (float)troopManager.Pekka.CoinsPerTime;
		}
	}
}
