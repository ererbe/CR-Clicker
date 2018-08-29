using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour {

	public TroopManager troopManager;

	private float HunterCoinsPerTime;
	private float HunterCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + HunterCoinDuration;
			Player.Coins += HunterCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += HunterCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.HunterCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.HunterTier > 0) {
			HunterCoinDuration = (float)troopManager.Hunter.CoinCollectDuration;
			HunterCoinsPerTime = (float)troopManager.Hunter.CoinsPerTime;
		}
	}
}
