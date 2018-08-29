using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceGolem : MonoBehaviour {

	public TroopManager troopManager;

	private float IceGolemCoinsPerTime;
	private float IceGolemCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + IceGolemCoinDuration;
			Player.Coins += IceGolemCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += IceGolemCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.IceGolemCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.IceGolemTier > 0) {
			IceGolemCoinDuration = (float)troopManager.IceGolem.CoinCollectDuration;
			IceGolemCoinsPerTime = (float)troopManager.IceGolem.CoinsPerTime;
		}
	}
}
