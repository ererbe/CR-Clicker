using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparky : MonoBehaviour {

	public TroopManager troopManager;

	private float SparkyCoinsPerTime;
	private float SparkyCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + SparkyCoinDuration;
			Player.Coins += SparkyCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += SparkyCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.SparkyCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.SparkyTier > 0) {
			SparkyCoinDuration = (float)troopManager.Sparky.CoinCollectDuration;
			SparkyCoinsPerTime = (float)troopManager.Sparky.CoinsPerTime;
		}
	}
}
