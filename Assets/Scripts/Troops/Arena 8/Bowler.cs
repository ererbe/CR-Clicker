using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour {

	public TroopManager troopManager;

	private float BowlerCoinsPerTime;
	private float BowlerCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BowlerCoinDuration;
			Player.Coins += BowlerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BowlerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BowlerCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BowlerTier > 0) {
			BowlerCoinDuration = (float)troopManager.Bowler.CoinCollectDuration;
			BowlerCoinsPerTime = (float)troopManager.Bowler.CoinsPerTime;
		}
	}
}
