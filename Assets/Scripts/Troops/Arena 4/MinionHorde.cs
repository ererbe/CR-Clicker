using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionHorde : MonoBehaviour {

	public TroopManager troopManager;

	private float MinionHordeCoinsPerTime;
	private float MinionHordeCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MinionHordeCoinDuration;
			Player.Coins += MinionHordeCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MinionHordeCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MinionHordeCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MinionHordeTier > 0) {
			MinionHordeCoinDuration = (float)troopManager.MinionHorde.CoinCollectDuration;
			MinionHordeCoinsPerTime = (float)troopManager.MinionHorde.CoinsPerTime;
		}
	}
}
