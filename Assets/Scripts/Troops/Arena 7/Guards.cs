using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guards : MonoBehaviour {

	public TroopManager troopManager;

	private float GuardsCoinsPerTime;
	private float GuardsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GuardsCoinDuration;
			Player.Coins += GuardsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GuardsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GuardsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GuardsTier > 0) {
			GuardsCoinDuration = (float)troopManager.Guards.CoinCollectDuration;
			GuardsCoinsPerTime = (float)troopManager.Guards.CoinsPerTime;
		}
	}
}
