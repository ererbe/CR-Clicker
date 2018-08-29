using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zappies : MonoBehaviour {

	public TroopManager troopManager;

	private float ZappiesCoinsPerTime;
	private float ZappiesCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ZappiesCoinDuration;
			Player.Coins += ZappiesCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ZappiesCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ZappiesCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ZappiesTier > 0) {
			ZappiesCoinDuration = (float)troopManager.Zappies.CoinCollectDuration;
			ZappiesCoinsPerTime = (float)troopManager.Zappies.CoinsPerTime;
		}
	}
}
