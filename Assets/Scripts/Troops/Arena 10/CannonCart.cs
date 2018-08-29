using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCart : MonoBehaviour {

	public TroopManager troopManager;

	private float CannonCartCoinsPerTime;
	private float CannonCartCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + CannonCartCoinDuration;
			Player.Coins += CannonCartCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += CannonCartCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CannonCartCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.CannonCartTier > 0) {
			CannonCartCoinDuration = (float)troopManager.CannonCart.CoinCollectDuration;
			CannonCartCoinsPerTime = (float)troopManager.CannonCart.CoinsPerTime;
		}
	}
}
