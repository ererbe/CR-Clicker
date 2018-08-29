using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPekka : MonoBehaviour {

	public TroopManager troopManager;

	private float MiniPekkaCoinsPerTime;
	private float MiniPekkaCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + MiniPekkaCoinDuration;
			Player.Coins += MiniPekkaCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += MiniPekkaCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.MiniPekkaCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.MiniPekkaTier > 0) {
			MiniPekkaCoinDuration = (float)troopManager.MiniPekka.CoinCollectDuration;
			MiniPekkaCoinsPerTime = (float)troopManager.MiniPekka.CoinsPerTime;
		}
	}
}
