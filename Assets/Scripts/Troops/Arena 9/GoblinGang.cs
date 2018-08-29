using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinGang : MonoBehaviour {

	public TroopManager troopManager;

	private float GoblinGangCoinsPerTime;
	private float GoblinGangCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GoblinGangCoinDuration;
			Player.Coins += GoblinGangCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GoblinGangCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GoblinGangCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GoblinGangTier > 0) {
			GoblinGangCoinDuration = (float)troopManager.GoblinGang.CoinCollectDuration;
			GoblinGangCoinsPerTime = (float)troopManager.GoblinGang.CoinsPerTime;
		}
	}
}
