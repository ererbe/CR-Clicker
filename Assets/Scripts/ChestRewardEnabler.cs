using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRewardEnabler : MonoBehaviour {

	public ChestRewardUI chestRewardUI;

	void OnEnable () {
		chestRewardUI.ShowChestTextureChestClosed ();
	}
}
