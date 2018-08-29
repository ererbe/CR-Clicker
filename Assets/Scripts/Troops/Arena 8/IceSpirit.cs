using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpirit : MonoBehaviour {

	public TroopManager troopManager;

	private float IceSpiritCoinsPerTime;
	private float IceSpiritCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + IceSpiritCoinDuration;
			Player.Coins += IceSpiritCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += IceSpiritCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.IceSpiritCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.IceSpiritTier > 0) {
			IceSpiritCoinDuration = (float)troopManager.IceSpirit.CoinCollectDuration;
			IceSpiritCoinsPerTime = (float)troopManager.IceSpirit.CoinsPerTime;
		}
	}
}
