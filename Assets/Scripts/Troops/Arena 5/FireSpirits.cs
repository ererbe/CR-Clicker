using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpirits : MonoBehaviour {

	public TroopManager troopManager;

	private float FireSpiritsCoinsPerTime;
	private float FireSpiritsCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + FireSpiritsCoinDuration;
			Player.Coins += FireSpiritsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += FireSpiritsCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.FireSpiritsCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.FireSpiritsTier > 0) {
			FireSpiritsCoinDuration = (float)troopManager.FireSpirits.CoinCollectDuration;
			FireSpiritsCoinsPerTime = (float)troopManager.FireSpirits.CoinsPerTime;
		}
	}
}
