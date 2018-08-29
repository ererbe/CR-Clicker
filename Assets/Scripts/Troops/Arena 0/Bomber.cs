using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour {

	public TroopManager troopManager;

	private float BomberCoinsPerTime;
	private float BomberCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BomberCoinDuration;
			Player.Coins += BomberCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BomberCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BomberCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BomberTier > 0) {
			BomberCoinDuration = (float)troopManager.Bomber.CoinCollectDuration;
			BomberCoinsPerTime = (float)troopManager.Bomber.CoinsPerTime;
		}
	}
}
