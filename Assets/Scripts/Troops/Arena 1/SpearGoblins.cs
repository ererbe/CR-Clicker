using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearGoblins : MonoBehaviour {

	public TroopManager troopManager;

	private float SpearGoblinsCoinsPerTime;
	private float SpearGoblinsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + SpearGoblinsCoinDuration;
			Player.Coins += SpearGoblinsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += SpearGoblinsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.SpearGoblinsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.SpearGoblinsTier > 0) {
			SpearGoblinsCoinDuration = (float)troopManager.SpearGoblins.CoinCollectDuration;
			SpearGoblinsCoinsPerTime = (float)troopManager.SpearGoblins.CoinsPerTime;
		}
	}
}
