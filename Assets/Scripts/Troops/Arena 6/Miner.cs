using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : MonoBehaviour {

	public TroopManager troopManager;

	private float MinerCoinsPerTime;
	private float MinerCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MinerCoinDuration;
			Player.Coins += MinerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MinerCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MinerCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MinerTier > 0) {
			MinerCoinDuration = (float)troopManager.Miner.CoinCollectDuration;
			MinerCoinsPerTime = (float)troopManager.Miner.CoinsPerTime;
		}
	}
}
