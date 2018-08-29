using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babarians : MonoBehaviour {

	public TroopManager troopManager;

	private float BabariansCoinsPerTime;
	private float BabariansCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BabariansCoinDuration;
			Player.Coins += BabariansCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BabariansCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BabariansCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BabariansTier > 0) {
			BabariansCoinDuration = (float)troopManager.Babarians.CoinCollectDuration;
			BabariansCoinsPerTime = (float)troopManager.Babarians.CoinsPerTime;
		}
	}
}
