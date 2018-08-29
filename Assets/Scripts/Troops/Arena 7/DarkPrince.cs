using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkPrince : MonoBehaviour {

	public TroopManager troopManager;

	private float DarkPrinceCoinsPerTime;
	private float DarkPrinceCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + DarkPrinceCoinDuration;
			Player.Coins += DarkPrinceCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += DarkPrinceCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.DarkPrinceCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.DarkPrinceTier > 0) {
			DarkPrinceCoinDuration = (float)troopManager.DarkPrince.CoinCollectDuration;
			DarkPrinceCoinsPerTime = (float)troopManager.DarkPrince.CoinsPerTime;
		}
	}
}
