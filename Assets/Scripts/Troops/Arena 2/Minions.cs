using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour {

	public TroopManager troopManager;

	private float MinionsCoinsPerTime;
	private float MinionsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MinionsCoinDuration;
			Player.Coins += MinionsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MinionsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MinionsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MinionsTier > 0) {
			MinionsCoinDuration = (float)troopManager.Minions.CoinCollectDuration;
			MinionsCoinsPerTime = (float)troopManager.Minions.CoinsPerTime;
		}
	}
}
