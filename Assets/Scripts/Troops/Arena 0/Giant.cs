using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant : MonoBehaviour {

	public TroopManager troopManager;

	private float GiantCoinsPerTime;
	private float GiantCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GiantCoinDuration;
			Player.Coins += GiantCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GiantCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GiantCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GiantTier > 0) {
			GiantCoinDuration = (float)troopManager.Giant.CoinCollectDuration;
			GiantCoinsPerTime = (float)troopManager.Giant.CoinsPerTime;
		}
	}
}
