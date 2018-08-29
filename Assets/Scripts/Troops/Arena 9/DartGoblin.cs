using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartGoblin : MonoBehaviour {

	public TroopManager troopManager;

	private float DartGoblinCoinsPerTime;
	private float DartGoblinCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + DartGoblinCoinDuration;
			Player.Coins += DartGoblinCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += DartGoblinCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.DartGoblinCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.DartGoblinTier > 0) {
			DartGoblinCoinDuration = (float)troopManager.DartGoblin.CoinCollectDuration;
			DartGoblinCoinsPerTime = (float)troopManager.DartGoblin.CoinsPerTime;
		}
	}
}
