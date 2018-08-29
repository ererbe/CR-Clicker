using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musketeer : MonoBehaviour {

	public TroopManager troopManager;

	private float MusketeerCoinsPerTime;
	private float MusketeerCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MusketeerCoinDuration;
			Player.Coins += MusketeerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MusketeerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MusketeerCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MusketeerTier > 0) {
			MusketeerCoinDuration = (float)troopManager.Musketeer.CoinCollectDuration;
			MusketeerCoinsPerTime = (float)troopManager.Musketeer.CoinsPerTime;
		}
	}
}
