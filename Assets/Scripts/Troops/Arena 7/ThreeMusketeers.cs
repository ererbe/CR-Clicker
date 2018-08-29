using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeMusketeers : MonoBehaviour {

	public TroopManager troopManager;

	private float ThreeMusketeersCoinsPerTime;
	private float ThreeMusketeersCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ThreeMusketeersCoinDuration;
			Player.Coins += ThreeMusketeersCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ThreeMusketeersCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ThreeMusketeersCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ThreeMusketeersTier > 0) {
			ThreeMusketeersCoinDuration = (float)troopManager.ThreeMusketeers.CoinCollectDuration;
			ThreeMusketeersCoinsPerTime = (float)troopManager.ThreeMusketeers.CoinsPerTime;
		}
	}
}
