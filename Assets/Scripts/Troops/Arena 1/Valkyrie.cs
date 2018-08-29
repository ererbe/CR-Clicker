using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valkyrie : MonoBehaviour {

	public TroopManager troopManager;

	private float ValkyrieCoinsPerTime;
	private float ValkyrieCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ValkyrieCoinDuration;
			Player.Coins += ValkyrieCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ValkyrieCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ValkyrieCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ValkyrieTier > 0) {
			ValkyrieCoinDuration = (float)troopManager.Valkyrie.CoinCollectDuration;
			ValkyrieCoinsPerTime = (float)troopManager.Valkyrie.CoinsPerTime;
		}
	}
}
