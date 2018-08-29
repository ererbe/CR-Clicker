using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRewardUI : MonoBehaviour {

	public GameObject ChestRewardCanvas;
	public GameObject HiddenChestRewardCard;
	public GameObject ChestRewardCard;
	[Space]
	public GameObject MissingChest;
	public GameObject WoodenChestClosed;
	public GameObject WoodenChestOpen;
	public GameObject SilverChestClosed;
	public GameObject SilverChestOpen;
	public GameObject GoldChestClosed;
	public GameObject GoldChestOpen;
	public GameObject GiantChestClosed;
	public GameObject GiantChestOpen;
	public GameObject EpicChestClosed;
	public GameObject EpicChestOpen;
	public GameObject MagicalChestClosed;
	public GameObject MagicalChestOpen;
	public GameObject SuperMagicalChestClosed;
	public GameObject SuperMagicalChestOpen;
	public GameObject LegendaryChestClosed;
	public GameObject LegendaryChestOpen;
	public GameObject CrownChestClosed;
	public GameObject CrownChestOpen;
	public GameObject ClanChestClosed;
	public GameObject ClanChestOpen;
	[Space]
	public GameObject Gem;
	public Transform GemEffectTransform;
	public GameObject GemEffect3DRotate1;
	public GameObject GemEffect3DRotate3;
	public GameObject GemEffect3DRotate5;
	public GameObject GemEffect3DRotate10;
	public GameObject GemEffect3D1;
	public GameObject GemEffect3D3;
	public GameObject GemEffect3D5;
	public GameObject GemEffect3D10;
	public GameObject GemEffectDefaultRotate1;
	public GameObject GemEffectDefaultRotate3;
	public GameObject GemEffectDefaultRotate5;
	public GameObject GemEffectDefaultRotate10;
	public GameObject GemEffectDefault1;
	public GameObject GemEffectDefault3;
	public GameObject GemEffectDefault5;
	public GameObject GemEffectDefault10;
	public GameObject GemEffectSimpleRotate1;
	public GameObject GemEffectSimpleRotate3;
	public GameObject GemEffectSimpleRotate5;
	public GameObject GemEffectSimpleRotate10;
	public GameObject GemEffectSimple1;
	public GameObject GemEffectSimple3;
	public GameObject GemEffectSimple5;
	public GameObject GemEffectSimple10;
	[Space]
	public GameObject CommonEffect;
	public GameObject CommonEffectShort;
	public GameObject CommonEffectVeryShort;
	public GameObject CommonEffectSpecial1;
	public GameObject CommonEffectCrazy;
	[Space]
	public GameObject RareEffect;
	public GameObject RareEffect2;
	public GameObject RareEffect3;
	public GameObject RareEffect4;
	public GameObject RareEffect5;
	[Space]
	public GameObject EpicEffect;
	public GameObject EpicEffect2;
	public GameObject EpicEffect3;
	public GameObject EpicEffect4;
	public GameObject EpicEffect5;
	[Space]
	public GameObject LegendaryEffect;
	public GameObject LegendaryEffect2;
	public GameObject LegendaryEffect3;
	public GameObject LegendaryEffect4;
	public GameObject LegendaryEffect5;

	public Transform EffectPosition;

	public bool ActivateGemParticles;
	public int RarityNumber;

	public int ChestNumber;

	private bool CardIsShown = false;

	public void GetRarityNumber (int Rarity) {
		RarityNumber = Rarity;
	}

	public void GetChestNumber (int Chest) {
		ChestNumber = Chest;
	}

	public void ToggleActivateGemParticles (bool Activate) {
		if (Activate == true) {
			ActivateGemParticles = true;
		} else if (Activate == false) {
			ActivateGemParticles = false;
		}
	}

	public void ShowCard () {
		if (CardIsShown == false) {
			HiddenChestRewardCard.SetActive (false);
			ChestRewardCard.SetActive (true);
			Gem.SetActive (true);
			if (ActivateGemParticles == true) {
				if (Player.GemParticleNumber != 0) {
					if (Player.GemParticleNumber == 1) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3DRotate1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 2) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3DRotate3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 3) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3DRotate5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 4) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3DRotate10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 5) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3D1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 6) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3D3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 7) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3D5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 8) {
						GameObject effectgem = (GameObject)Instantiate (GemEffect3D10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 9) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefaultRotate1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 10) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefaultRotate3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 11) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefaultRotate5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 12) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefaultRotate10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 13) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefault1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 14) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefault3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 15) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefault5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 16) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectDefault10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 17) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimpleRotate1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 18) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimpleRotate3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 19) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimpleRotate5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					}  else if (Player.GemParticleNumber == 20) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimpleRotate10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 21) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimple1, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 22) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimple3, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 23) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimple5, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					} else if (Player.GemParticleNumber == 24) {
						GameObject effectgem = (GameObject)Instantiate (GemEffectSimple10, GemEffectTransform.transform.position, GemEffectTransform.transform.rotation);
						Destroy (effectgem, 8f);
					}
				}
			}
			if (Player.ShowChestParticles == true) {
				if (RarityNumber == 1) {
					if (Player.CommonParticleNumber == 1) {
						GameObject effectIns = (GameObject)Instantiate (CommonEffect, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 5.5f);
					} else if (Player.CommonParticleNumber == 2) {
						GameObject effectIns = (GameObject)Instantiate (CommonEffectShort, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 2.2f);
					} else if (Player.CommonParticleNumber == 3) {
						GameObject effectIns = (GameObject)Instantiate (CommonEffectVeryShort, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 1.2f);
					} else if (Player.CommonParticleNumber == 4) {
						GameObject effectIns = (GameObject)Instantiate (CommonEffectSpecial1, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 5.5f);
					} else if (Player.CommonParticleNumber == 5) {
						GameObject effectIns = (GameObject)Instantiate (CommonEffectCrazy, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 15f);
					}
				} else if (RarityNumber == 2) {
					if (Player.RareParticleNumber == 1) {
						GameObject effectIns = (GameObject)Instantiate (RareEffect, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.RareParticleNumber == 2) {
						GameObject effectIns = (GameObject)Instantiate (RareEffect2, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.RareParticleNumber == 3) {
						GameObject effectIns = (GameObject)Instantiate (RareEffect3, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.RareParticleNumber == 4) {
						GameObject effectIns = (GameObject)Instantiate (RareEffect4, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.RareParticleNumber == 5) {
						GameObject effectIns = (GameObject)Instantiate (RareEffect5, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					}
				} else if (RarityNumber == 3) {
					if (Player.EpicParticleNumber == 1) {
						GameObject effectIns = (GameObject)Instantiate (EpicEffect, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.EpicParticleNumber == 2) {
						GameObject effectIns = (GameObject)Instantiate (EpicEffect2, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.EpicParticleNumber == 3) {
						GameObject effectIns = (GameObject)Instantiate (EpicEffect3, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.EpicParticleNumber == 4) {
						GameObject effectIns = (GameObject)Instantiate (EpicEffect4, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.EpicParticleNumber == 5) {
						GameObject effectIns = (GameObject)Instantiate (EpicEffect5, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					}
				} else if (RarityNumber == 4) {
					if (Player.LegendaryParticleNumber == 1) {
						GameObject effectIns = (GameObject)Instantiate (LegendaryEffect, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.LegendaryParticleNumber == 2) {
						GameObject effectIns = (GameObject)Instantiate (LegendaryEffect2, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.LegendaryParticleNumber == 3) {
						GameObject effectIns = (GameObject)Instantiate (LegendaryEffect3, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.LegendaryParticleNumber == 4) {
						GameObject effectIns = (GameObject)Instantiate (LegendaryEffect4, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					} else if (Player.LegendaryParticleNumber == 5) {
						GameObject effectIns = (GameObject)Instantiate (LegendaryEffect5, EffectPosition.transform.position, EffectPosition.transform.rotation);
						Destroy (effectIns, 6f);
					}
				} else {
					Debug.Log ("failed to get Rarity (ChestRewardUI)");
				}
			}
			ShowChestTextureChestOpen ();
			CardIsShown = true;
		} else if (CardIsShown == true) {
			HiddenChestRewardCard.SetActive (true);
			ChestRewardCard.SetActive (false);
			ChestRewardCanvas.SetActive (false);
			Gem.SetActive (false);
			CardIsShown = false;
		}
	}

	public void ShowChestTextureChestClosed () {
		GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("ChestTexture");
		foreach (GameObject go in gameObjectArray) {
			go.SetActive (false);
		}
		if (Player.ShowChestTexture == true) {
			if (ChestNumber == 1) {
				WoodenChestClosed.SetActive (true);
			} else if (ChestNumber == 2) {
				SilverChestClosed.SetActive (true);
			} else if (ChestNumber == 3) {
				GoldChestClosed.SetActive (true);
			} else if (ChestNumber == 4) {
				GiantChestClosed.SetActive (true);
			} else if (ChestNumber == 5) {
				EpicChestClosed.SetActive (true);
			} else if (ChestNumber == 6) {
				MagicalChestClosed.SetActive (true);
			} else if (ChestNumber == 7) {
				SuperMagicalChestClosed.SetActive (true);
			} else if (ChestNumber == 8) {
				LegendaryChestClosed.SetActive (true);
			} else if (ChestNumber == 9) {
				CrownChestClosed.SetActive (true);
			} else if (ChestNumber == 10) {
				ClanChestClosed.SetActive (true);
			}
		}
	}

	public void ShowChestTextureChestOpen () {
		GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("ChestTexture");
		foreach (GameObject go in gameObjectArray) {
			go.SetActive (false);
		}
		if (Player.ShowChestTexture == true) {
			if (ChestNumber == 1) {
				WoodenChestOpen.SetActive (true);
			} else if (ChestNumber == 2) {
				SilverChestOpen.SetActive (true);
			} else if (ChestNumber == 3) {
				GoldChestOpen.SetActive (true);
			} else if (ChestNumber == 4) {
				GiantChestOpen.SetActive (true);
			} else if (ChestNumber == 5) {
				EpicChestOpen.SetActive (true);
			} else if (ChestNumber == 6) {
				MagicalChestOpen.SetActive (true);
			} else if (ChestNumber == 7) {
				SuperMagicalChestOpen.SetActive (true);
			} else if (ChestNumber == 8) {
				LegendaryChestOpen.SetActive (true);
			} else if (ChestNumber == 9) {
				CrownChestOpen.SetActive (true);
			} else if (ChestNumber == 10) {
				ClanChestOpen.SetActive (true);
			}
		}
	}

}