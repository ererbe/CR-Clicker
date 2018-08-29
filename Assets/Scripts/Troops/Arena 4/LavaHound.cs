using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaHound : MonoBehaviour {

	public TroopManager troopManager;

	private float LavaHoundCoinsPerTime;
	private float LavaHoundCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + LavaHoundCoinDuration;
			Player.Coins += LavaHoundCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += LavaHoundCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.LavaHoundCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.LavaHoundTier > 0) {
			LavaHoundCoinDuration = (float)troopManager.LavaHound.CoinCollectDuration;
			LavaHoundCoinsPerTime = (float)troopManager.LavaHound.CoinsPerTime;
		}
	}
}
