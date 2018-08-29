using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {

	public TroopManager troopManager;

	private float KnightCoinsPerTime;
	private float KnightCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + KnightCoinDuration;
			Player.Coins += KnightCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += KnightCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.KnightCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.KnightTier > 0) {
			KnightCoinDuration = (float)troopManager.Knight.CoinCollectDuration;
			KnightCoinsPerTime = (float)troopManager.Knight.CoinsPerTime;
		}
	}
}
