using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoyalGiant : MonoBehaviour {

	public TroopManager troopManager;

	private float RoyalGiantCoinsPerTime;
	private float RoyalGiantCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + RoyalGiantCoinDuration;
			Player.Coins += RoyalGiantCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += RoyalGiantCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.RoyalGiantCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.RoyalGiantTier > 0) {
			RoyalGiantCoinDuration = (float)troopManager.RoyalGiant.CoinCollectDuration;
			RoyalGiantCoinsPerTime = (float)troopManager.RoyalGiant.CoinsPerTime;
		}
	}
}
