using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoyalGhost : MonoBehaviour {

	public TroopManager troopManager;

	private float RoyalGhostCoinsPerTime;
	private float RoyalGhostCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + RoyalGhostCoinDuration;
			Player.Coins += RoyalGhostCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += RoyalGhostCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.RoyalGhostCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.RoyalGhostTier > 0) {
			RoyalGhostCoinDuration = (float)troopManager.RoyalGhost.CoinCollectDuration;
			RoyalGhostCoinsPerTime = (float)troopManager.RoyalGhost.CoinsPerTime;
		}
	}
}
