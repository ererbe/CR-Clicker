using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaKnight : MonoBehaviour {

	public TroopManager troopManager;

	private float MegaKnightCoinsPerTime;
	private float MegaKnightCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MegaKnightCoinDuration;
			Player.Coins += MegaKnightCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MegaKnightCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MegaKnightCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MegaKnightTier > 0) {
			MegaKnightCoinDuration = (float)troopManager.MegaKnight.CoinCollectDuration;
			MegaKnightCoinsPerTime = (float)troopManager.MegaKnight.CoinsPerTime;
		}
	}
}
