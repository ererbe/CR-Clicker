using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executioner : MonoBehaviour {

	public TroopManager troopManager;

	private float ExecutionerCoinsPerTime;
	private float ExecutionerCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ExecutionerCoinDuration;
			Player.Coins += ExecutionerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ExecutionerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ExecutionerCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ExecutionerTier > 0) {
			ExecutionerCoinDuration = (float)troopManager.Executioner.CoinCollectDuration;
			ExecutionerCoinsPerTime = (float)troopManager.Executioner.CoinsPerTime;
		}
	}
}
