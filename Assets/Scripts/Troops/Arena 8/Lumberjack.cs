using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumberjack : MonoBehaviour {

	public TroopManager troopManager;

	private float LumberjackCoinsPerTime;
	private float LumberjackCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + LumberjackCoinDuration;
			Player.Coins += LumberjackCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += LumberjackCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.LumberjackCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.LumberjackTier > 0) {
			LumberjackCoinDuration = (float)troopManager.Lumberjack.CoinCollectDuration;
			LumberjackCoinsPerTime = (float)troopManager.Lumberjack.CoinsPerTime;
		}
	}
}
