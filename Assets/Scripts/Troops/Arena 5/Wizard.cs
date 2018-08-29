using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour {

	public TroopManager troopManager;

	private float WizardCoinsPerTime;
	private float WizardCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + WizardCoinDuration;
			Player.Coins += WizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += WizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.WizardCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.WizardTier > 0) {
			WizardCoinDuration = (float)troopManager.Wizard.CoinCollectDuration;
			WizardCoinsPerTime = (float)troopManager.Wizard.CoinsPerTime;
		}
	}
}
