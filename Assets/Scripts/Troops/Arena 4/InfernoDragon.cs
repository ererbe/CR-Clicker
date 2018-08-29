using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfernoDragon : MonoBehaviour {

	public TroopManager troopManager;

	private float InfernoDragonCoinsPerTime;
	private float InfernoDragonCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + InfernoDragonCoinDuration;
			Player.Coins += InfernoDragonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += InfernoDragonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.InfernoDragonCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.InfernoDragonTier > 0) {
			InfernoDragonCoinDuration = (float)troopManager.InfernoDragon.CoinCollectDuration;
			InfernoDragonCoinsPerTime = (float)troopManager.InfernoDragon.CoinsPerTime;
		}
	}
}
