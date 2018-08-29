using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princess : MonoBehaviour {

	public TroopManager troopManager;

	private float PrincessCoinsPerTime;
	private float PrincessCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + PrincessCoinDuration;
			Player.Coins += PrincessCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += PrincessCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.PrincessCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.PrincessTier > 0) {
			PrincessCoinDuration = (float)troopManager.Princess.CoinCollectDuration;
			PrincessCoinsPerTime = (float)troopManager.Princess.CoinsPerTime;
		}
	}
}
