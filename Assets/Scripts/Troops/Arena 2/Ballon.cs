using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

	public TroopManager troopManager;

	private float BallonCoinsPerTime;
	private float BallonCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BallonCoinDuration;
			Player.Coins += BallonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BallonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BallonCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BallonTier > 0) {
			BallonCoinDuration = (float)troopManager.Ballon.CoinCollectDuration;
			BallonCoinsPerTime = (float)troopManager.Ballon.CoinsPerTime;
		}
	}
}
