using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archers : MonoBehaviour {

	public TroopManager troopManager;

	private float ArchersCoinsPerTime;
	private float ArchersCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ArchersCoinDuration;
			Player.Coins += ArchersCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ArchersCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ArchersCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ArchersTier > 0) {
			ArchersCoinDuration = (float)troopManager.Archers.CoinCollectDuration;
			ArchersCoinsPerTime = (float)troopManager.Archers.CoinsPerTime;
		}
	}
}
