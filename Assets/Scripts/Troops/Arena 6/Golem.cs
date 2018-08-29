using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour {

	public TroopManager troopManager;

	private float GolemCoinsPerTime;
	private float GolemCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GolemCoinDuration;
			Player.Coins += GolemCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GolemCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GolemCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GolemTier > 0) {
			GolemCoinDuration = (float)troopManager.Golem.CoinCollectDuration;
			GolemCoinsPerTime = (float)troopManager.Golem.CoinsPerTime;
		}
	}
}
