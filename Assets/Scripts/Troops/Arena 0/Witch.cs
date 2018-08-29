using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour {

	public TroopManager troopManager;

	private float WitchCoinsPerTime;
	private float WitchCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + WitchCoinDuration;
			Player.Coins += WitchCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += WitchCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.WitchCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.WitchTier > 0) {
			WitchCoinDuration = (float)troopManager.Witch.CoinCollectDuration;
			WitchCoinsPerTime = (float)troopManager.Witch.CoinsPerTime;
		}
	}
}
