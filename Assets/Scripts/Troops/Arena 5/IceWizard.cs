using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWizard : MonoBehaviour {

	public TroopManager troopManager;

	private float IceWizardCoinsPerTime;
	private float IceWizardCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + IceWizardCoinDuration;
			Player.Coins += IceWizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += IceWizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.IceWizardCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.IceWizardTier > 0) {
			IceWizardCoinDuration = (float)troopManager.IceWizard.CoinCollectDuration;
			IceWizardCoinsPerTime = (float)troopManager.IceWizard.CoinsPerTime;
		}
	}
}
