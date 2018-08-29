using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bats : MonoBehaviour {

	public TroopManager troopManager;

	private float BatsCoinsPerTime;
	private float BatsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BatsCoinDuration;
			Player.Coins += BatsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BatsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BatsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BatsTier > 0) {
			BatsCoinDuration = (float)troopManager.Bats.CoinCollectDuration;
			BatsCoinsPerTime = (float)troopManager.Bats.CoinsPerTime;
		}
	}
}
