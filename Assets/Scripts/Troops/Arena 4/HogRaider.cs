using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HogRaider : MonoBehaviour {

	public TroopManager troopManager;

	private float HogRaiderCoinsPerTime;
	private float HogRaiderCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + HogRaiderCoinDuration;
			Player.Coins += HogRaiderCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += HogRaiderCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.HogRaiderCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.HogRaiderTier > 0) {
			HogRaiderCoinDuration = (float)troopManager.HogRaider.CoinCollectDuration;
			HogRaiderCoinsPerTime = (float)troopManager.HogRaider.CoinsPerTime;
		}
	}
}
