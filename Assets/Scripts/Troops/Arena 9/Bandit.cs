using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandit : MonoBehaviour {

	public TroopManager troopManager;

	private float BanditCoinsPerTime;
	private float BanditCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BanditCoinDuration;
			Player.Coins += BanditCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BanditCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BanditCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BanditTier > 0) {
			BanditCoinDuration = (float)troopManager.Bandit.CoinCollectDuration;
			BanditCoinsPerTime = (float)troopManager.Bandit.CoinsPerTime;
		}
	}
}
