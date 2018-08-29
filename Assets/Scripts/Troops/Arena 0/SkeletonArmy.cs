using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonArmy : MonoBehaviour {

	public TroopManager troopManager;

	private float SkeletonArmyCoinsPerTime;
	private float SkeletonArmyCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + SkeletonArmyCoinDuration;
			Player.Coins += SkeletonArmyCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += SkeletonArmyCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.SkeletonArmyCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.SkeletonArmyTier > 0) {
			SkeletonArmyCoinDuration = (float)troopManager.SkeletonArmy.CoinCollectDuration;
			SkeletonArmyCoinsPerTime = (float)troopManager.SkeletonArmy.CoinsPerTime;
		}
	}
}
