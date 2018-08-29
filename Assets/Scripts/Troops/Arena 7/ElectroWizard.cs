using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroWizard : MonoBehaviour {

	public TroopManager troopManager;

	private float ElectroWizardCoinsPerTime;
	private float ElectroWizardCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + ElectroWizardCoinDuration;
			Player.Coins += ElectroWizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += ElectroWizardCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.ElectroWizardCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.ElectroWizardTier > 0) {
			ElectroWizardCoinDuration = (float)troopManager.ElectroWizard.CoinCollectDuration;
			ElectroWizardCoinsPerTime = (float)troopManager.ElectroWizard.CoinsPerTime;
		}
	}
}
