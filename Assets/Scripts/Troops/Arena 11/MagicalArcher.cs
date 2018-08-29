using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalArcher : MonoBehaviour {

	public TroopManager troopManager;

	private float MagicalArcherCoinsPerTime;
	private float MagicalArcherCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MagicalArcherCoinDuration;
			Player.Coins += MagicalArcherCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MagicalArcherCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MagicalArcherCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MagicalArcherTier > 0) {
			MagicalArcherCoinDuration = (float)troopManager.MagicalArcher.CoinCollectDuration;
			MagicalArcherCoinsPerTime = (float)troopManager.MagicalArcher.CoinsPerTime;
		}
	}
}
