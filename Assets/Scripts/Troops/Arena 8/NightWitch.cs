using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightWitch : MonoBehaviour {

	public TroopManager troopManager;

	private float NightWitchCoinsPerTime;
	private float NightWitchCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + NightWitchCoinDuration;
			Player.Coins += NightWitchCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += NightWitchCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.NightWitchCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.NightWitchTier > 0) {
			NightWitchCoinDuration = (float)troopManager.NightWitch.CoinCollectDuration;
			NightWitchCoinsPerTime = (float)troopManager.NightWitch.CoinsPerTime;
		}
	}
}
