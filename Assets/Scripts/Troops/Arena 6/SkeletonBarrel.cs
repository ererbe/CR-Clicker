using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonBarrel : MonoBehaviour {

	public TroopManager troopManager;

	private float SkeletonBarrelCoinsPerTime;
	private float SkeletonBarrelCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + SkeletonBarrelCoinDuration;
			Player.Coins += SkeletonBarrelCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += SkeletonBarrelCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.SkeletonBarrelCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.SkeletonBarrelTier > 0) {
			SkeletonBarrelCoinDuration = (float)troopManager.SkeletonBarrel.CoinCollectDuration;
			SkeletonBarrelCoinsPerTime = (float)troopManager.SkeletonBarrel.CoinsPerTime;
		}
	}
}
