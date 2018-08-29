using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour {

	public TroopManager troopManager;

	private float SkeletonCoinsPerTime;
	private float SkeletonCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + SkeletonCoinDuration;
			Player.Coins += SkeletonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += SkeletonCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.SkeletonCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.SkeletonTier > 0) {
			SkeletonCoinDuration = (float)troopManager.Skeleton.CoinCollectDuration;
			SkeletonCoinsPerTime = (float)troopManager.Skeleton.CoinsPerTime;
		}
	}
}
