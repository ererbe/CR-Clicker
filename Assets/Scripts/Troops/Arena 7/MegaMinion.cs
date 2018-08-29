using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaMinion : MonoBehaviour {

	public TroopManager troopManager;

	private float MegaMinionCoinsPerTime;
	private float MegaMinionCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MegaMinionCoinDuration;
			Player.Coins += MegaMinionCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MegaMinionCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MegaMinionCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MegaMinionTier > 0) {
			MegaMinionCoinDuration = (float)troopManager.MegaMinion.CoinCollectDuration;
			MegaMinionCoinsPerTime = (float)troopManager.MegaMinion.CoinsPerTime;
		}
	}
}
