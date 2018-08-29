using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMachine : MonoBehaviour {

	public TroopManager troopManager;

	private float FlyingMachineCoinsPerTime;
	private float FlyingMachineCoinDuration;

	private float NextTime;

	void Start () {
		NewStats ();
	}

	void Update () {
		if (Time.time > NextTime) {
			NextTime = Time.time + FlyingMachineCoinDuration;
			Player.Coins += FlyingMachineCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.CollectedCoins += FlyingMachineCoinsPerTime * Player.RageMulti * Player.MirrorMulti;
			Player.FlyingMachineCoinTimes += 1;
		}
	}

	public void NewStats () {
		if (Player.FlyingMachineTier > 0) {
			FlyingMachineCoinDuration = (float)troopManager.FlyingMachine.CoinCollectDuration;
			FlyingMachineCoinsPerTime = (float)troopManager.FlyingMachine.CoinsPerTime;
		}
	}
}
