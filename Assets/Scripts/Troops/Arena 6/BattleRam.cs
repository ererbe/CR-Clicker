using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleRam : MonoBehaviour {

	public TroopManager troopManager;

	private float BattleRamCoinsPerTime;
	private float BattleRamCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + BattleRamCoinDuration;
			Player.Coins += BattleRamCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += BattleRamCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.BattleRamCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.BattleRamTier > 0) {
			BattleRamCoinDuration = (float)troopManager.BattleRam.CoinCollectDuration;
			BattleRamCoinsPerTime = (float)troopManager.BattleRam.CoinsPerTime;
		}
	}
}
