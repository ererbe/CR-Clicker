using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prince : MonoBehaviour {

	public TroopManager troopManager;

	private float PrinceCoinsPerTime;
	private float PrinceCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + PrinceCoinDuration;
			Player.Coins += PrinceCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += PrinceCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.PrinceCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.PrinceTier > 0) {
			PrinceCoinDuration = (float)troopManager.Prince.CoinCollectDuration;
			PrinceCoinsPerTime = (float)troopManager.Prince.CoinsPerTime;
		}
	}
}
