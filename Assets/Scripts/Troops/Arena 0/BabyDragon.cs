using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDragon : MonoBehaviour {

	public TroopManager troopManager;

	private float BabyDragonCoinsPerTime;
	private float BabyDragonCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BabyDragonCoinDuration;
			Player.Coins += BabyDragonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BabyDragonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BabyDragonCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BabyDragonTier > 0) {
			BabyDragonCoinDuration = (float)troopManager.BabyDragon.CoinCollectDuration;
			BabyDragonCoinsPerTime = (float)troopManager.BabyDragon.CoinsPerTime;
		}
	}
}
