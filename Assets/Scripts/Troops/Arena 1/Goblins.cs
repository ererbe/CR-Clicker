using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblins : MonoBehaviour {

	public TroopManager troopManager;

	private float GoblinsCoinsPerTime;
	private float GoblinsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + GoblinsCoinDuration;
			Player.Coins += GoblinsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += GoblinsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.GoblinsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.GoblinsTier > 0) {
			GoblinsCoinDuration = (float)troopManager.Goblins.CoinCollectDuration;
			GoblinsCoinsPerTime = (float)troopManager.Goblins.CoinsPerTime;
		}
	}
}
