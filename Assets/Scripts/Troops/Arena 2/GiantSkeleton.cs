using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSkeleton : MonoBehaviour {

	public TroopManager troopManager;

	private float GiantSkeletonCoinsPerTime;
	private float GiantSkeletonCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GiantSkeletonCoinDuration;
			Player.Coins += GiantSkeletonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GiantSkeletonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GiantSkeletonCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GiantSkeletonTier > 0) {
			GiantSkeletonCoinDuration = (float)troopManager.GiantSkeleton.CoinCollectDuration;
			GiantSkeletonCoinsPerTime = (float)troopManager.GiantSkeleton.CoinsPerTime;
		}
	}
}
