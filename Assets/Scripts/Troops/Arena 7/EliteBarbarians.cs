using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteBarbarians : MonoBehaviour {

	public TroopManager troopManager;

	private float EliteBarbariansCoinsPerTime;
	private float EliteBarbariansCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + EliteBarbariansCoinDuration;
			Player.Coins += EliteBarbariansCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += EliteBarbariansCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.EliteBarbariansCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.EliteBarbariansTier > 0) {
			EliteBarbariansCoinDuration = (float)troopManager.EliteBarbarians.CoinCollectDuration;
			EliteBarbariansCoinsPerTime = (float)troopManager.EliteBarbarians.CoinsPerTime;
		}
	}
}
