using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chests : MonoBehaviour {

	public ChestRewardUI chestRewardUI;

	public GameObject ChestRewardUI;
	public Image HiddenChestRewardCard;
	public Image ChestRewardCard;
	public Text ChestRewardCardAmount;

	public Text GemRewardAmount;
	private int GetGem;

	public Text CrownChestCostText;
	public Text WoodenChestCostText;
	public Text SilverChestCostText;
	public Text GoldChestCostText;
	public Text GiantChestCostText;
	public Text EpicChestCostText;
	public Text MagicalChestCostText;
	public Text SuperMagicalChestCostText;
	public Text LegendaryChestCostText;
	public Text DraftChestCostText;

	public Text WoodenChestNameText;
	public Text WoodenChestPricePerChestText;

	public Text SilverChestNameText;
	public Text SilverChestPricePerChestText;

	public Text GoldChestNameText;
	public Text GoldChestPricePerChestText;

	public Text GiantChestNameText;
	public Text GiantChestPricePerChestText;

	public Text EpicChestNameText;
	public Text EpicChestPricePerChestText;

	public Text MagicalChestNameText;
	public Text MagicalChestPricePerChestText;

	public Text SuperMagicalChestNameText;
	public Text SuperMagicalChestPricePerChestText;

	public Text LegendaryChestNameText;
	public Text LegendaryChestPricePerChestText;

	public Text DraftChestNameText;
	public Text DraftChestPricePerChestText;

	public Text CrownChestNameText;
	public Text CrownChestPricePerChestText;

	public Text ClanChestNameText;
	public Text ClanChestTierText;
	public Text ClanChestPriceNextTierText;
	public Text ClanChestCurrentCrownsText;
	public Text ClanChestOpenText;
	public Image ClanChestProgressBar;

	public Sprite CommonHidden;
	public Sprite RareHidden;
	public Sprite EpicHidden;
	public Sprite LegendaryHidden;

	public Sprite Skeleton;
	public Sprite Archers;
	public Sprite Knight;
	public Sprite Bomber;
	public Sprite SkeletonArmy;
	public Sprite Musketeer;
	public Sprite MiniPekka;
	public Sprite BabyDragon;
	public Sprite Giant;
	public Sprite Prince;
	public Sprite Witch;
	public Sprite Goblins;
	public Sprite SpearGoblins;
	public Sprite Valkyrie;
	public Sprite Minions;
	public Sprite Ballon;
	public Sprite GiantSkeleton;
	public Sprite Babarians;
	public Sprite HogRaider;
	public Sprite InfernoDragon;
	public Sprite MinionHorde;
	public Sprite Pekka;
	public Sprite LavaHound;
	public Sprite FireSpirits;
	public Sprite IceWizard;
	public Sprite Wizard;
	public Sprite SkeletonBarrel;
	public Sprite Miner;
	public Sprite BattleRam;
	public Sprite Sparky;
	public Sprite Golem;
	public Sprite MegaMinion;
	public Sprite Guards;
	public Sprite Princess;
	public Sprite DarkPrince;
	public Sprite ElectroWizard;
	public Sprite RoyalGiant;
	public Sprite EliteBarbarians;
	public Sprite ThreeMusketeers;
	public Sprite IceSpirit;
	public Sprite Bats;
	public Sprite IceGolem;
	public Sprite NightWitch;
	public Sprite Lumberjack;
	public Sprite Bowler;
	public Sprite GoblinGang;
	public Sprite DartGoblin;
	public Sprite Bandit;
	public Sprite FlyingMachine;
	public Sprite Hunter;
	public Sprite Executioner;
	public Sprite RoyalGhost;
	public Sprite CannonCart;
	public Sprite MegaKnight;
	public Sprite Zappies;
	public Sprite MagicalArcher;

	public Sprite GoblinHut;
	public Sprite Tombstone;
	public Sprite BombTower;
	public Sprite Cannon;
	public Sprite XBow;
	public Sprite BarbarianHut;
	public Sprite Tesla;
	public Sprite InfernoTower;
	public Sprite Furnace;
	public Sprite Mortar;
	public Sprite ElixirCollector;

	public Sprite Arrows;
	public Sprite Fireball;
	public Sprite GoblinBarrel;
	public Sprite Lightning;
	public Sprite Rage;
	public Sprite Rocket;
	public Sprite Freeze;
	public Sprite Zap;
	public Sprite Poison;
	public Sprite Graveyard;
	public Sprite Mirror;
	public Sprite TheLog;
	public Sprite Tornado;
	public Sprite Clone;
	public Sprite Heal;
	public Sprite BarbarianBarrel;

	public int DefaultWoodenChestCoinCost;
	public int DefaultSilverChestCoinCost;
	public int DefaultGoldChestCoinCost;
	public int DefaultGiantChestCoinCost;
	public int DefaultEpicChestGemsCost;
	public int DefaultMagicalChestCoinCost;
	public int DefaultSuperMagicalChestCoinCost;
	public int DefaultLegendaryChestGemsCost;
	public int DefaultDraftChestCoinCost;

	public int DefaultCrownChestCrownCost;

	public int WoodenChestCoinCostAddPerArena;
	public int SilverChestCoinCostAddPerArena;
	public int GoldChestCoinCostAddPerArena;
	public int GiantChestCoinCostAddPerArena;
//	public int EpicChestGemsCostAddPerArena;
	public int MagicalChestCoinCostAddPerArena;
	public int SuperMagicalChestCoinCostAddPerArena;
//	public int LegendaryChestGemsCostAddPerArena;
	public int DraftChestCoinCostAddPerArena;

	private int WoodenChestCost;
	private int SilverChestCost;
	private int GoldChestCost;
	private int GiantChestCost;
	private int EpicChestCost;
	private int MagicalChestCost;
	private int SuperMagicalChestCost;
	private int LegendaryChestCost;
	private int DraftChestCost;
	private int CrownChestCost;
//	private int ClanChestCost;

	private int ClanChestCrownsToTier1 = 70;
	private int ClanChestCrownsToTier2 = 90;
	private int ClanChestCrownsToTier3 = 110;
	private int ClanChestCrownsToTier4 = 130;
	private int ClanChestCrownsToTier5 = 150;
	private int ClanChestCrownsToTier6 = 170;
	private int ClanChestCrownsToTier7 = 190;
	private int ClanChestCrownsToTier8 = 210;
	private int ClanChestCrownsToTier9 = 230;
	private int ClanChestCrownsToTier10 = 250;

	private int TotalClanChestCrownsToTier1 = 70;
	private int TotalClanChestCrownsToTier2 = 160;
	private int TotalClanChestCrownsToTier3 = 270;
	private int TotalClanChestCrownsToTier4 = 400;
	private int TotalClanChestCrownsToTier5 = 550;
	private int TotalClanChestCrownsToTier6 = 720;
	private int TotalClanChestCrownsToTier7 = 910;
	private int TotalClanChestCrownsToTier8 = 1120;
	private int TotalClanChestCrownsToTier9 = 1350;
	private int TotalClanChestCrownsToTier10 =1600;

	public int Rarity;
	private int Card;

	private int Price;

	private int CrownChestCardGetAmount;

	void OnEnable () {
		CheckClanChestTier ();
	}

	void CheckClanChestTier () {
		if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier1 && Player.ClanChestCrowns < TotalClanChestCrownsToTier2) {
			Player.ClanChestTier = 1;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier2 && Player.ClanChestCrowns < TotalClanChestCrownsToTier3) {
			Player.ClanChestTier = 2;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier3 && Player.ClanChestCrowns < TotalClanChestCrownsToTier4) {
			Player.ClanChestTier = 3;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier4 && Player.ClanChestCrowns < TotalClanChestCrownsToTier5) {
			Player.ClanChestTier = 4;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier5 && Player.ClanChestCrowns < TotalClanChestCrownsToTier6) {
			Player.ClanChestTier = 5;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier6 && Player.ClanChestCrowns < TotalClanChestCrownsToTier7) {
			Player.ClanChestTier = 6;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier7 && Player.ClanChestCrowns < TotalClanChestCrownsToTier8) {
			Player.ClanChestTier = 7;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier8 && Player.ClanChestCrowns < TotalClanChestCrownsToTier9) {
			Player.ClanChestTier = 8;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier9 && Player.ClanChestCrowns < TotalClanChestCrownsToTier10) {
			Player.ClanChestTier = 9;
		} else if (Player.ClanChestCrowns >= TotalClanChestCrownsToTier10) {
			Player.ClanChestTier = 10;
		} else {
			Player.ClanChestTier = 0;
		}
		CheckUIStats ();
		CheckUILanguage ();
	}

	void CheckUILanguage () {
		if (Player.Language == 1) {
			WoodenChestNameText.text = "Wooden Chest";
			WoodenChestPricePerChestText.text = "Price per Chest";
			SilverChestNameText.text = "Silver Chest";
			SilverChestPricePerChestText.text = "Price per Chest";
			GoldChestNameText.text = "Gold Chest";
			GoldChestPricePerChestText.text = "Price per Chest";
			GiantChestNameText.text = "Giant Chest";
			GiantChestPricePerChestText.text = "Price per Chest";
			EpicChestNameText.text = "Epic Chest";
			EpicChestPricePerChestText.text = "Price per Chest";
			MagicalChestNameText.text = "Magical Chest";
			MagicalChestPricePerChestText.text = "Price per Chest";
			SuperMagicalChestNameText.text = "Super Magical Chest";
			SuperMagicalChestPricePerChestText.text = "Price per Chest";
			LegendaryChestNameText.text = "Legendary Chest";
			LegendaryChestPricePerChestText.text = "Price per Chest";
			DraftChestNameText.text = "Draft Chest";
			DraftChestPricePerChestText.text = "Price per Chest";
			CrownChestNameText.text = "Crown Chest";
			CrownChestPricePerChestText.text = "Price per Chest";
			ClanChestNameText.text = "Clan Chest";
			ClanChestOpenText.text = "Open";
		} else if (Player.Language == 2) {
			WoodenChestNameText.text = "Holztruhe";
			WoodenChestPricePerChestText.text = "Preis pro Truhe";
			SilverChestNameText.text = "Silbertruhe";
			SilverChestPricePerChestText.text = "Preis pro Truhe";
			GoldChestNameText.text = "Goldtruhe";
			GoldChestPricePerChestText.text = "Preis pro Truhe";
			GiantChestNameText.text = "Riesentruhe";
			GiantChestPricePerChestText.text = "Preis pro Truhe";
			EpicChestNameText.text = "Epische Truhe";
			EpicChestPricePerChestText.text = "Preis pro Truhe";
			MagicalChestNameText.text = "Magietruhe";
			MagicalChestPricePerChestText.text = "Preis pro Truhe";
			SuperMagicalChestNameText.text = "Super-Magietruhe";
			SuperMagicalChestPricePerChestText.text = "Preis pro Truhe";
			LegendaryChestNameText.text = "Legendäre Truhe";
			LegendaryChestPricePerChestText.text = "Preis pro Truhe";
			DraftChestNameText.text = "Auswahltruhe";
			DraftChestPricePerChestText.text = "Preis pro Truhe";
			CrownChestNameText.text = "Krohnentruhe";
			CrownChestPricePerChestText.text = "Preis pro Truhe";
			ClanChestNameText.text = "Clan Chest";
			ClanChestOpenText.text = "Open";
		}
	}

	public void OpenChestRewardUI () {
		CheckUIStats ();
		UpdateUIStats ();
		ChestRewardUI.SetActive (true);
	}

	public void CloseChestRewardUI () {
		ChestRewardUI.SetActive (false);
	}
	
	public void CheckUIStats () {
		WoodenChestCost = (int) DefaultWoodenChestCoinCost + (WoodenChestCoinCostAddPerArena * Player.Arena);
		SilverChestCost = (int) DefaultSilverChestCoinCost + (SilverChestCoinCostAddPerArena * Player.Arena);
		GoldChestCost = (int) DefaultGoldChestCoinCost + (GoldChestCoinCostAddPerArena * Player.Arena);
		GiantChestCost = (int) DefaultGiantChestCoinCost + (GiantChestCoinCostAddPerArena * Player.Arena);
		MagicalChestCost = (int) DefaultMagicalChestCoinCost + (MagicalChestCoinCostAddPerArena * Player.Arena);
		SuperMagicalChestCost = (int) DefaultSuperMagicalChestCoinCost + (SuperMagicalChestCoinCostAddPerArena * Player.Arena);
		DraftChestCost = (int) DefaultDraftChestCoinCost + (DraftChestCoinCostAddPerArena * Player.Arena);
		EpicChestCost = DefaultEpicChestGemsCost;
		LegendaryChestCost = DefaultLegendaryChestGemsCost;
		CrownChestCost = DefaultCrownChestCrownCost;
		UpdateUIStats ();
	}

	public void UpdateUIStats () {
		WoodenChestCostText.text = WoodenChestCost.ToString();
		SilverChestCostText.text = SilverChestCost.ToString();
		GoldChestCostText.text = GoldChestCost.ToString();
		GiantChestCostText.text = GiantChestCost.ToString();
		EpicChestCostText.text = EpicChestCost.ToString();
		MagicalChestCostText.text = MagicalChestCost.ToString();
		SuperMagicalChestCostText.text = SuperMagicalChestCost.ToString();
		LegendaryChestCostText.text = LegendaryChestCost.ToString();
		DraftChestCostText.text = DraftChestCost.ToString ();
		CrownChestCostText.text = CrownChestCost.ToString();
		Debug.Log (Player.ClanChestCrowns + " clan chest crowns");
		if (Player.ClanChestTier == 0) {
			ClanChestTierText.text = 0.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier1.ToString ();
			ClanChestCurrentCrownsText.text = Player.ClanChestCrowns.ToString ();
			ClanChestProgressBar.fillAmount = ((float)Player.ClanChestCrowns / ClanChestCrownsToTier1);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 1) {
			ClanChestTierText.text = 1.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier2.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier1).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier1) / ClanChestCrownsToTier2);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 2) {
			ClanChestTierText.text = 2.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier3.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier2).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier2) / ClanChestCrownsToTier3);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 3) {
			ClanChestTierText.text = 3.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier4.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier3).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier3) / ClanChestCrownsToTier4);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 4) {
			ClanChestTierText.text = 4.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier5.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier4).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier4) / ClanChestCrownsToTier5);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 5) {
			ClanChestTierText.text = 5.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier6.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier5).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier5) / ClanChestCrownsToTier6);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 6) {
			ClanChestTierText.text = 6.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier7.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier6).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier6) / ClanChestCrownsToTier7);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 7) {
			ClanChestTierText.text = 7.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier8.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier7).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier7) / ClanChestCrownsToTier8);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 8) {
			ClanChestTierText.text = 8.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier9.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier8).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier8) / ClanChestCrownsToTier9);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 9) {
			ClanChestTierText.text = 9.ToString ();
			ClanChestPriceNextTierText.text = ClanChestCrownsToTier10.ToString ();
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier9).ToString ();
			ClanChestProgressBar.fillAmount = ((float)(Player.ClanChestCrowns - TotalClanChestCrownsToTier9) / ClanChestCrownsToTier10);
			ClanChestProgressBar.color = Color.white;
		} if (Player.ClanChestTier == 10) {
			ClanChestTierText.text = 10.ToString ();
			ClanChestPriceNextTierText.text = "Max.";
			ClanChestCurrentCrownsText.text = (Player.ClanChestCrowns - TotalClanChestCrownsToTier10).ToString ();
			ClanChestProgressBar.fillAmount = (1);
			ClanChestProgressBar.color = new Color32(30,200,0,255);
		}
	}

	public void ChangeRarityNumber (int Number) {
		chestRewardUI.GetRarityNumber (Number); 
	}

	public void ChangeChestNumber (int Number) {
		chestRewardUI.GetChestNumber (Number);
	}

	void Legendary (int Amount) {
		//Legendary
		if (Player.Arena == 0) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden; //arena 0-3 -> epic, other -> legendary
			Card = Random.Range (1,5);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena0)");
			}
		} else if (Player.Arena == 1) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden; 
			Card = Random.Range (1,7);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena1)");
			}
		} else if (Player.Arena == 2) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden;
			Card = Random.Range (1,9);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena2)");
			}
		} else if (Player.Arena == 3) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden;
			Card = Random.Range (1,11);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.XBowCards += Amount;
				ChestRewardCard.sprite = XBow;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena3)");
			}
		} else if (Player.Arena == 4) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,3);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena4)");
			}
		} else if (Player.Arena == 5) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,5);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena5)");
			}
		} else if (Player.Arena == 6) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,8);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.TheLogCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.MinerCards += Amount;
				ChestRewardCard.sprite = Miner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.SparkyCards += Amount;
				ChestRewardCard.sprite = Sparky;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena6)");
			}
		} else if (Player.Arena == 7) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,10);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.TheLogCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.MinerCards += Amount;
				ChestRewardCard.sprite = Miner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.SparkyCards += Amount;
				ChestRewardCard.sprite = Sparky;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.PrincessCards += Amount;
				ChestRewardCard.sprite = Princess;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ElectroWizardCards += Amount;
				ChestRewardCard.sprite = ElectroWizard;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena7)");
			}
		} else if (Player.Arena == 8) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,12);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.TheLogCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.MinerCards += Amount;
				ChestRewardCard.sprite = Miner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.SparkyCards += Amount;
				ChestRewardCard.sprite = Sparky;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.PrincessCards += Amount;
				ChestRewardCard.sprite = Princess;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ElectroWizardCards += Amount;
				ChestRewardCard.sprite = ElectroWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.NightWitchCards += Amount;
				ChestRewardCard.sprite = NightWitch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.LumberjackCards += Amount;
				ChestRewardCard.sprite = Lumberjack;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena8)");
			}
		} else if (Player.Arena == 9) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,13);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.TheLogCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.MinerCards += Amount;
				ChestRewardCard.sprite = Miner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.SparkyCards += Amount;
				ChestRewardCard.sprite = Sparky;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.PrincessCards += Amount;
				ChestRewardCard.sprite = Princess;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ElectroWizardCards += Amount;
				ChestRewardCard.sprite = ElectroWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.NightWitchCards += Amount;
				ChestRewardCard.sprite = NightWitch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.LumberjackCards += Amount;
				ChestRewardCard.sprite = Lumberjack;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.BanditCards += Amount;
				ChestRewardCard.sprite = Bandit;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena9)");
			}
		} else if (Player.Arena == 10) {
			ChangeRarityNumber (4);
			HiddenChestRewardCard.sprite = LegendaryHidden;
			Card = Random.Range (1,15);
			if (Card == 1) {
				Player.InfernoDragonCards += Amount;
				ChestRewardCard.sprite = InfernoDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.LavaHoundCards += Amount;
				ChestRewardCard.sprite = LavaHound;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.IceWizardCards += Amount;
				ChestRewardCard.sprite = IceWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.GraveyardCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.TheLogCards += Amount;
				ChestRewardCard.sprite = Graveyard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.MinerCards += Amount;
				ChestRewardCard.sprite = Miner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.SparkyCards += Amount;
				ChestRewardCard.sprite = Sparky;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.PrincessCards += Amount;
				ChestRewardCard.sprite = Princess;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ElectroWizardCards += Amount;
				ChestRewardCard.sprite = ElectroWizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.NightWitchCards += Amount;
				ChestRewardCard.sprite = NightWitch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.LumberjackCards += Amount;
				ChestRewardCard.sprite = Lumberjack;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.BanditCards += Amount;
				ChestRewardCard.sprite = Bandit;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.MegaKnightCards += Amount;
				ChestRewardCard.sprite = MegaKnight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.RoyalGhostCards += Amount;
				ChestRewardCard.sprite = RoyalGhost;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena10)");
			}
		} else if (Player.Arena == 11 || Player.Arena == 12 || Player.Arena == 13 || Player.Arena == 14 || Player.Arena == 15 || Player.Arena == 16 || Player.Arena == 17 || Player.Arena == 18 || Player.Arena == 19 || Player.Arena == 20 || Player.Arena == 21) {
				ChangeRarityNumber (4);
				HiddenChestRewardCard.sprite = LegendaryHidden;
				Card = Random.Range (1,16);
				if (Card == 1) {
					Player.InfernoDragonCards += Amount;
					ChestRewardCard.sprite = InfernoDragon;
					ChestRewardUI.SetActive (true);
				} else if (Card == 2) {
					Player.LavaHoundCards += Amount;
					ChestRewardCard.sprite = LavaHound;
					ChestRewardUI.SetActive (true);
				} else if (Card == 3) {
					Player.IceWizardCards += Amount;
					ChestRewardCard.sprite = IceWizard;
					ChestRewardUI.SetActive (true);
				} else if (Card == 4) {
					Player.GraveyardCards += Amount;
					ChestRewardCard.sprite = Graveyard;
					ChestRewardUI.SetActive (true);
				} else if (Card == 5) {
					Player.TheLogCards += Amount;
					ChestRewardCard.sprite = Graveyard;
					ChestRewardUI.SetActive (true);
				} else if (Card == 6) {
					Player.MinerCards += Amount;
					ChestRewardCard.sprite = Miner;
					ChestRewardUI.SetActive (true);
				} else if (Card == 7) {
					Player.SparkyCards += Amount;
					ChestRewardCard.sprite = Sparky;
					ChestRewardUI.SetActive (true);
				} else if (Card == 8) {
					Player.PrincessCards += Amount;
					ChestRewardCard.sprite = Princess;
					ChestRewardUI.SetActive (true);
				} else if (Card == 9) {
					Player.ElectroWizardCards += Amount;
					ChestRewardCard.sprite = ElectroWizard;
					ChestRewardUI.SetActive (true);
				} else if (Card == 10) {
					Player.NightWitchCards += Amount;
					ChestRewardCard.sprite = NightWitch;
					ChestRewardUI.SetActive (true);
				} else if (Card == 11) {
					Player.LumberjackCards += Amount;
					ChestRewardCard.sprite = Lumberjack;
					ChestRewardUI.SetActive (true);
				} else if (Card == 12) {
					Player.BanditCards += Amount;
					ChestRewardCard.sprite = Bandit;
					ChestRewardUI.SetActive (true);
				} else if (Card == 13) {
					Player.MegaKnightCards += Amount;
					ChestRewardCard.sprite = MegaKnight;
					ChestRewardUI.SetActive (true);
				} else if (Card == 14) {
					Player.RoyalGhostCards += Amount;
					ChestRewardCard.sprite = RoyalGhost;
					ChestRewardUI.SetActive (true);
				} else if (Card == 15) {
					Player.MagicalArcherCards += Amount;
					ChestRewardCard.sprite = MagicalArcher;
					ChestRewardUI.SetActive (true);
				} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (legendary-arena11)");
			}
		} else {
			//					Player.Coins += WoodenChestCost * Amount;
			Debug.Log ("failed to get the arena (legendary)");
		}
	}

	void Epic (int Amount) {
		//Epic
		HiddenChestRewardCard.sprite = EpicHidden;
		ChangeRarityNumber (3);
		if (Player.Arena == 0) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden; //arena 0-3 -> epic, other -> legendary
			Card = Random.Range (1,5);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena0)");
			}
		} else if (Player.Arena == 1) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden; 
			Card = Random.Range (1,7);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena1)");
			}
		} else if (Player.Arena == 2) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden;
			Card = Random.Range (1,9);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena2)");
			}
		} else if (Player.Arena == 3) {
			ChangeRarityNumber (3);
			HiddenChestRewardCard.sprite = EpicHidden;
			Card = Random.Range (1,11);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.XBowCards += Amount;
				ChestRewardCard.sprite = XBow;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena3)");
			}
		} else if (Player.Arena == 4) {
			Card = Random.Range (1,12);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena4)");
			}
		} else if (Player.Arena == 5) {
			Card = Random.Range (1,14);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena5)");
			}
		}	 else if (Player.Arena == 6) {
			Card = Random.Range (1,16);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GolemCards += Amount;
				ChestRewardCard.sprite = Golem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.TornadoCards += Amount;
				ChestRewardCard.sprite = Tornado;
				ChestRewardUI.SetActive (true);
			}  else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena6)");
			}
		} else if (Player.Arena == 7) {
			Card = Random.Range (1,18);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GolemCards += Amount;
				ChestRewardCard.sprite = Golem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.GuardsCards += Amount;
				ChestRewardCard.sprite = Guards;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.DarkPrinceCards += Amount;
				ChestRewardCard.sprite = DarkPrince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.TornadoCards += Amount;
				ChestRewardCard.sprite = Tornado;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena7)");
			}
		} else if (Player.Arena == 8) {
			Card = Random.Range (1,20);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GolemCards += Amount;
				ChestRewardCard.sprite = Golem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.GuardsCards += Amount;
				ChestRewardCard.sprite = Guards;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.DarkPrinceCards += Amount;
				ChestRewardCard.sprite = DarkPrince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.BowlerCards += Amount;
				ChestRewardCard.sprite = Bowler;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.TornadoCards += Amount;
				ChestRewardCard.sprite = Tornado;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.CloneCards += Amount;
				ChestRewardCard.sprite = Clone;
				ChestRewardUI.SetActive (true);
			}  else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena8)");
			}
		} else if (Player.Arena == 9) {
			Card = Random.Range (1,22);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GolemCards += Amount;
				ChestRewardCard.sprite = Golem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.GuardsCards += Amount;
				ChestRewardCard.sprite = Guards;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.DarkPrinceCards += Amount;
				ChestRewardCard.sprite = DarkPrince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.BowlerCards += Amount;
				ChestRewardCard.sprite = Bowler;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.HunterCards += Amount;
				ChestRewardCard.sprite = Hunter;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.ExecutionerCards += Amount;
				ChestRewardCard.sprite = Executioner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.TornadoCards += Amount;
				ChestRewardCard.sprite = Tornado;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.CloneCards += Amount;
				ChestRewardCard.sprite = Clone;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena9)");
			}
		} else if (Player.Arena == 10 || Player.Arena == 11 || Player.Arena == 12 || Player.Arena == 13 || Player.Arena == 14 || Player.Arena == 15 || Player.Arena == 16 || Player.Arena == 17 || Player.Arena == 18 || Player.Arena == 19 || Player.Arena == 20 || Player.Arena == 21) {
			Card = Random.Range (1,24);
			if (Card == 1) {
				Player.SkeletonArmyCards += Amount;
				ChestRewardCard.sprite = SkeletonArmy;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.BabyDragonCards += Amount;
				ChestRewardCard.sprite = BabyDragon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.PrinceCards += Amount;
				ChestRewardCard.sprite = Prince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.WitchCards += Amount;
				ChestRewardCard.sprite = Witch;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.BallonCards += Amount;
				ChestRewardCard.sprite = Ballon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GiantSkeletonCards += Amount;
				ChestRewardCard.sprite = GiantSkeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.PekkaCards += Amount;
				ChestRewardCard.sprite = Pekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GolemCards += Amount;
				ChestRewardCard.sprite = Golem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.GuardsCards += Amount;
				ChestRewardCard.sprite = Guards;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.DarkPrinceCards += Amount;
				ChestRewardCard.sprite = DarkPrince;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.BowlerCards += Amount;
				ChestRewardCard.sprite = Bowler;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.HunterCards += Amount;
				ChestRewardCard.sprite = Hunter;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.ExecutionerCards += Amount;
				ChestRewardCard.sprite = Executioner;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.CannonCartCards += Amount;
				ChestRewardCard.sprite = CannonCart;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.GoblinBarrelCards += Amount;
				ChestRewardCard.sprite = GoblinBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.LightningCards += Amount;
				ChestRewardCard.sprite = Lightning;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.RageCards += Amount;
				ChestRewardCard.sprite = Rage;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.FreezeCards += Amount;
				ChestRewardCard.sprite = Freeze;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.PoisonCards += Amount;
				ChestRewardCard.sprite = Poison;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.MirrorCards += Amount;
				ChestRewardCard.sprite = Mirror;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.TornadoCards += Amount;
				ChestRewardCard.sprite = Tornado;
				ChestRewardUI.SetActive (true);
			} else if (Card == 22) {
				Player.CloneCards += Amount;
				ChestRewardCard.sprite = Clone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 23) {
				Player.BarbarianBarrelCards += Amount;
				ChestRewardCard.sprite = BarbarianBarrel;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (epic-arena10)");
			}
		} else {
			//					Player.Coins += WoodenChestCost * Amount;
			Debug.Log ("failed to get the arena (epic)");
		}
	}

	void Rare (int Amount) {
		//Rare
		HiddenChestRewardCard.sprite = RareHidden;
		ChangeRarityNumber (2);
		if (Player.Arena == 0) {
			Card = Random.Range (1,5);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena0)");
			}
		} else if (Player.Arena == 1) {
			Card = Random.Range (1,7);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena1)");
			}
		} else if (Player.Arena == 2) {
			Card = Random.Range (1,9);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena2)");
			}
		} else if (Player.Arena == 3) {
			Card = Random.Range (1,11);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena3)");
			}
		} else if (Player.Arena == 4) {
			Card = Random.Range (1,13);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena4)");
			}
		} else if (Player.Arena == 5) {
			Card = Random.Range (1,15);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena5)");
			}
		} else if (Player.Arena == 6) {
			Card = Random.Range (1,17);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena6)");
			}
		} else if (Player.Arena == 7) {
			Card = Random.Range (1,19);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.MegaMinionCards += Amount;
				ChestRewardCard.sprite = MegaMinion;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ThreeMusketeersCards += Amount;
				ChestRewardCard.sprite = ThreeMusketeers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena7)");
			}
		} else if (Player.Arena == 8) {
			Card = Random.Range (1,20);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.MegaMinionCards += Amount;
				ChestRewardCard.sprite = MegaMinion;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ThreeMusketeersCards += Amount;
				ChestRewardCard.sprite = ThreeMusketeers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.IceGolemCards += Amount;
				ChestRewardCard.sprite = IceGolem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (woodchest-rare-arena8)");
			}
		} else if (Player.Arena == 9 || Player.Arena == 10) {
			Card = Random.Range (1,22);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.MegaMinionCards += Amount;
				ChestRewardCard.sprite = MegaMinion;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ThreeMusketeersCards += Amount;
				ChestRewardCard.sprite = ThreeMusketeers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.IceGolemCards += Amount;
				ChestRewardCard.sprite = IceGolem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.DartGoblinCards += Amount;
				ChestRewardCard.sprite = DartGoblin;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.FlyingMachineCards += Amount;
				ChestRewardCard.sprite = FlyingMachine;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else {
			//						Player.Coins += WoodenChestCost * Amount;
			Debug.Log ("failed to get the card (rare-arena9)");
			}
		} else if (Player.Arena == 10) {
			Card = Random.Range (1,23);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
					Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
					ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.MegaMinionCards += Amount;
				ChestRewardCard.sprite = MegaMinion;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ThreeMusketeersCards += Amount;
				ChestRewardCard.sprite = ThreeMusketeers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.IceGolemCards += Amount;
				ChestRewardCard.sprite = IceGolem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.DartGoblinCards += Amount;
				ChestRewardCard.sprite = DartGoblin;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.FlyingMachineCards += Amount;
				ChestRewardCard.sprite = FlyingMachine;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else if (Card == 22) {
				Player.HealCards += Amount;
				ChestRewardCard.sprite = Heal;
				ChestRewardUI.SetActive (true);
			} else {
			//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena10)");
			}
		} else if (Player.Arena == 11 || Player.Arena == 12 || Player.Arena == 13 || Player.Arena == 14 || Player.Arena == 15 || Player.Arena == 16 || Player.Arena == 17 || Player.Arena == 18 || Player.Arena == 19 || Player.Arena == 20 || Player.Arena == 21) {
			Card = Random.Range (1,24);
			if (Card == 1) {
				Player.MusketeerCards += Amount;
				ChestRewardCard.sprite = Musketeer;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.MiniPekkaCards += Amount;
				ChestRewardCard.sprite = MiniPekka;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.GiantCards += Amount;
				ChestRewardCard.sprite = Giant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.ValkyrieCards += Amount;
				ChestRewardCard.sprite = Valkyrie;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.HogRaiderCards += Amount;
				ChestRewardCard.sprite = HogRaider;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.WizardCards += Amount;
				ChestRewardCard.sprite = Wizard;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.BattleRamCards += Amount;
				ChestRewardCard.sprite = BattleRam;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.MegaMinionCards += Amount;
				ChestRewardCard.sprite = MegaMinion;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.ThreeMusketeersCards += Amount;
				ChestRewardCard.sprite = ThreeMusketeers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.IceGolemCards += Amount;
				ChestRewardCard.sprite = IceGolem;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.DartGoblinCards += Amount;
				ChestRewardCard.sprite = DartGoblin;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.FlyingMachineCards += Amount;
				ChestRewardCard.sprite = FlyingMachine;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.GoblinHutCards += Amount;
				ChestRewardCard.sprite = GoblinHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.TombstoneCards += Amount;
				ChestRewardCard.sprite = Tombstone;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.BombTowerCards += Amount;
				ChestRewardCard.sprite = BombTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.BarbarianHutCards += Amount;
				ChestRewardCard.sprite = BarbarianHut;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.InfernoTowerCards += Amount;
				ChestRewardCard.sprite = InfernoTower;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.FurnaceCards += Amount;
				ChestRewardCard.sprite = Furnace;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.ElixirCollectorCards += Amount;
				ChestRewardCard.sprite = ElixirCollector;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.ZappiesCards += Amount;
				ChestRewardCard.sprite = Zappies;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.FireballCards += Amount;
				ChestRewardCard.sprite = Fireball;
				ChestRewardUI.SetActive (true);
			} else if (Card == 22) {
				Player.RocketCards += Amount;
				ChestRewardCard.sprite = Rocket;
				ChestRewardUI.SetActive (true);
			} else if (Card == 23) {
				Player.HealCards += Amount;
				ChestRewardCard.sprite = Heal;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (rare-arena11ormore)");
			}
		} else {
			//					Player.Coins += WoodenChestCost * Amount;
			Debug.Log ("failed to get the arena (woodchest-rare)");
		}
	}

	void Common (int Amount) {
		//Common
		HiddenChestRewardCard.sprite = CommonHidden;
		ChangeRarityNumber (1);
		if (Player.Arena == 0) {
			Card = Random.Range (1,6);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena0)");
			}
		} else if (Player.Arena == 1) {
			Card = Random.Range (1,8);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena1)");
			}
		} else if (Player.Arena == 2) {
			Card = Random.Range (1,9);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena2)");
			}
		} else if (Player.Arena == 3) {
			Card = Random.Range (1,11);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			}  else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena3)");
			}
		} else if (Player.Arena == 4) {
			Card = Random.Range (1,12);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			}  else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena4)");
			}
		} else if (Player.Arena == 5) {
			Card = Random.Range (1,15);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			}  else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.MinionHordeCards += Amount;
				ChestRewardCard.sprite = MinionHorde;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.FireSpiritsCards += Amount;
				ChestRewardCard.sprite = FireSpirits;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.ZapCards += Amount;
				ChestRewardCard.sprite = Zap;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena5)");
			}
		} else if (Player.Arena == 6) {
			Card = Random.Range (1,17);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			}  else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.MinionHordeCards += Amount;
				ChestRewardCard.sprite = MinionHorde;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.FireSpiritsCards += Amount;
				ChestRewardCard.sprite = FireSpirits;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.SkeletonBarrelCards += Amount;
				ChestRewardCard.sprite = SkeletonBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.MortarCards += Amount;
				ChestRewardCard.sprite = Mortar;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.ZapCards += Amount;
				ChestRewardCard.sprite = Zap;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena6)");
			}
		} else if (Player.Arena == 7) {
			Card = Random.Range (1,19);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.MinionHordeCards += Amount;
				ChestRewardCard.sprite = MinionHorde;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.FireSpiritsCards += Amount;
				ChestRewardCard.sprite = FireSpirits;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.SkeletonBarrelCards += Amount;
				ChestRewardCard.sprite = SkeletonBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.RoyalGiantCards += Amount;
				ChestRewardCard.sprite = RoyalGiant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.EliteBarbariansCards += Amount;
				ChestRewardCard.sprite = EliteBarbarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.MortarCards += Amount;
				ChestRewardCard.sprite = Mortar;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.ZapCards += Amount;
				ChestRewardCard.sprite = Zap;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena7)");
			}
		} else if (Player.Arena == 8) {
			Card = Random.Range (1,21);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			} else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.MinionHordeCards += Amount;
				ChestRewardCard.sprite = MinionHorde;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.FireSpiritsCards += Amount;
				ChestRewardCard.sprite = FireSpirits;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.SkeletonBarrelCards += Amount;
				ChestRewardCard.sprite = SkeletonBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.RoyalGiantCards += Amount;
				ChestRewardCard.sprite = RoyalGiant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.EliteBarbariansCards += Amount;
				ChestRewardCard.sprite = EliteBarbarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.IceSpiritCards += Amount;
				ChestRewardCard.sprite = IceSpirit;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.BatsCards += Amount;
				ChestRewardCard.sprite = Bats;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.MortarCards += Amount;
				ChestRewardCard.sprite = Mortar;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.ZapCards += Amount;
				ChestRewardCard.sprite = Zap;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena8)");
			}
		} else if (Player.Arena == 9 || Player.Arena == 10 || Player.Arena == 11 || Player.Arena == 12 || Player.Arena == 13 || Player.Arena == 14 || Player.Arena == 15 || Player.Arena == 16 || Player.Arena == 17 || Player.Arena == 18 || Player.Arena == 19 || Player.Arena == 20 || Player.Arena == 21) {
			Card = Random.Range (1,22);
			if (Card == 1) {
				Player.SkeletonCards += Amount;
				ChestRewardCard.sprite = Skeleton;
				ChestRewardUI.SetActive (true);
			} else if (Card == 2) {
				Player.ArchersCards += Amount;
				ChestRewardCard.sprite = Archers;
				ChestRewardUI.SetActive (true);
			} else if (Card == 3) {
				Player.KnightCards += Amount;
				ChestRewardCard.sprite = Knight;
				ChestRewardUI.SetActive (true);
			} else if (Card == 4) {
				Player.BomberCards += Amount;
				ChestRewardCard.sprite = Bomber;
				ChestRewardUI.SetActive (true);
			}  else if (Card == 5) {
				Player.GoblinsCards += Amount;
				ChestRewardCard.sprite = Goblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 6) {
				Player.SpearGoblinsCards += Amount;
				ChestRewardCard.sprite = SpearGoblins;
				ChestRewardUI.SetActive (true);
			} else if (Card == 7) {
				Player.MinionsCards += Amount;
				ChestRewardCard.sprite = Minions;
				ChestRewardUI.SetActive (true);
			} else if (Card == 8) {
				Player.BabariansCards += Amount;
				ChestRewardCard.sprite = Babarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 9) {
				Player.MinionHordeCards += Amount;
				ChestRewardCard.sprite = MinionHorde;
				ChestRewardUI.SetActive (true);
			} else if (Card == 10) {
				Player.FireSpiritsCards += Amount;
				ChestRewardCard.sprite = FireSpirits;
				ChestRewardUI.SetActive (true);
			} else if (Card == 11) {
				Player.SkeletonBarrelCards += Amount;
				ChestRewardCard.sprite = SkeletonBarrel;
				ChestRewardUI.SetActive (true);
			} else if (Card == 12) {
				Player.RoyalGiantCards += Amount;
				ChestRewardCard.sprite = RoyalGiant;
				ChestRewardUI.SetActive (true);
			} else if (Card == 13) {
				Player.EliteBarbariansCards += Amount;
				ChestRewardCard.sprite = EliteBarbarians;
				ChestRewardUI.SetActive (true);
			} else if (Card == 14) {
				Player.IceSpiritCards += Amount;
				ChestRewardCard.sprite = IceSpirit;
				ChestRewardUI.SetActive (true);
			} else if (Card == 15) {
				Player.BatsCards += Amount;
				ChestRewardCard.sprite = Bats;
				ChestRewardUI.SetActive (true);
			} else if (Card == 16) {
				Player.GoblinGangCards += Amount;
				ChestRewardCard.sprite = GoblinGang;
				ChestRewardUI.SetActive (true);
			} else if (Card == 17) {
				Player.CannonCards += Amount;
				ChestRewardCard.sprite = Cannon;
				ChestRewardUI.SetActive (true);
			} else if (Card == 18) {
				Player.TeslaCards += Amount;
				ChestRewardCard.sprite = Tesla;
				ChestRewardUI.SetActive (true);
			} else if (Card == 19) {
				Player.MortarCards += Amount;
				ChestRewardCard.sprite = Mortar;
				ChestRewardUI.SetActive (true);
			} else if (Card == 20) {
				Player.ArrowsCards += Amount;
				ChestRewardCard.sprite = Arrows;
				ChestRewardUI.SetActive (true);
			} else if (Card == 21) {
				Player.ZapCards += Amount;
				ChestRewardCard.sprite = Zap;
				ChestRewardUI.SetActive (true);
			} else {
				//						Player.Coins += WoodenChestCost * Amount;
				Debug.Log ("failed to get the card (common-arena9ormore)");
			}
		} else {
			//					Player.Coins += WoodenChestCost * Amount;
			Debug.Log ("failed to get the arena (common)");
		}
	}

	public void BuyWoodenChest (int Amount) {
		Price = WoodenChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (1);
			ChestRewardCardAmount.text = Amount.ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 4) {
				Legendary (Amount);
			} else if (Rarity <= 24 && Rarity >=5) {
				Epic (Amount);
			} else if (Rarity <= 124 && Rarity >=25) {
				Rare (Amount);
			} else {
				Common (Amount);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 30) {
				Player.Gems += Amount;
				GemRewardAmount.text = Amount.ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuySilverChest (int Amount) {
		Price = SilverChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (2);
			ChestRewardCardAmount.text = Amount.ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 6) {
				Legendary (Amount);
			} else if (Rarity <= 38 && Rarity >=7) {
				Epic (Amount);
			} else if (Rarity <= 174 && Rarity >=39) {
				Rare (Amount);
			} else {
				Common (Amount);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 25) {
				Player.Gems += Amount * 2;
				GemRewardAmount.text = (Amount * 2).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuyGoldChest (int Amount) {
		Price = GoldChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (3);
			ChestRewardCardAmount.text = (Amount * 2).ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 8) {
				Legendary (Amount * 2);
			} else if (Rarity <= 50 && Rarity >=9) {
				Epic (Amount * 2);
			} else if (Rarity <= 224 && Rarity >=51) {
				Rare (Amount * 2);
			} else {
				Common (Amount * 2);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 40) {
				Player.Gems += Amount * 3;
				GemRewardAmount.text = (Amount * 3).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuyGiantChest (int Amount) {
		Price = GiantChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (4);
			ChestRewardCardAmount.text = (Amount * 3).ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 10) {
				Legendary (Amount * 3);
			} else if (Rarity <= 61 && Rarity >=11) {
				Epic (Amount * 3);
			} else if (Rarity <= 252 && Rarity >=62) {
				Rare (Amount * 3);
			} else {
				Common (Amount * 3);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 15) {
				Player.Gems += Amount * 10;
				GemRewardAmount.text = (Amount * 10).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuyEpicChest (int Amount) {
		Price = EpicChestCost * Amount;
		Debug.Log (Price);
		if (Player.Gems >= Price) {
			Player.Gems -= Price;
			ChangeChestNumber (5);
			ChestRewardCardAmount.text = Amount.ToString () + "x";
			Epic (Amount);
			chestRewardUI.ToggleActivateGemParticles (true);
			GemRewardAmount.text = "0";
		}
	}

	public void BuyMagicalChest (int Amount) {
		Price = MagicalChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (6);
			ChestRewardCardAmount.text = (Amount * 5).ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 25) {
				Legendary (Amount * 5);
			} else if (Rarity <= 121 && Rarity >=26) {
				Epic (Amount * 5);
			} else if (Rarity <= 500 && Rarity >=122) {
				Rare (Amount * 5);
			} else {
				Common (Amount * 5);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 50) {
				Player.Gems += Amount * 5;
				GemRewardAmount.text = (Amount * 5).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuySuperMagicalChest (int Amount) {
		Price = SuperMagicalChestCost * Amount;
		Debug.Log (Price);
		if (Player.Coins >= Price) {
			Player.Coins -= Price;
			ChangeChestNumber (7);
			ChestRewardCardAmount.text = (Amount * 10).ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 50) {
				Legendary (Amount * 10);
			} else if (Rarity <= 250 && Rarity >=51) {
				Epic (Amount * 10);
			} else if (Rarity <= 750 && Rarity >=251) {
				Rare (Amount * 10);
			} else {
				Common (Amount * 10);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 75) {
				Player.Gems += Amount * 10;
				GemRewardAmount.text = (Amount * 10).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void BuyLegendaryChest (int Amount) {
		Price = LegendaryChestCost * Amount;
		Debug.Log (Price);
		if (Player.Arena >= 4) {
			if (Player.Gems >= Price) {
				Player.Gems -= Price;
				ChangeChestNumber (8);
				ChestRewardCardAmount.text = Amount.ToString () + "x";
				Legendary (Amount);
				chestRewardUI.ToggleActivateGemParticles (false);
				GemRewardAmount.text = "0";
			}
		}
	}

	public void BuyCrownChest (int Amount) {
		Price = CrownChestCost * Amount;
		Debug.Log (Price);
		if (Player.Crowns >= Price) {
			Player.Crowns -= Price;
			ChangeChestNumber (9);
			CrownChestCardGetAmount = Amount * (int)(1 + (Mathf.Floor ((float)Player.Arena / 2)));
			ChestRewardCardAmount.text = CrownChestCardGetAmount.ToString () + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 9) {
				Legendary (CrownChestCardGetAmount);
			} else if (Rarity <= 55 && Rarity >=10) {
				Epic (CrownChestCardGetAmount);
			} else if (Rarity <= 236 && Rarity >=56) {
				Rare (CrownChestCardGetAmount);
			} else {
				Common (CrownChestCardGetAmount);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 40) {
				Player.Gems += Amount * 4;
				GemRewardAmount.text = (Amount * 4).ToString ();
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
		}
	}

	public void OpenClanChest () {
		ChangeChestNumber (10);
		if (Player.ClanChestTier == 1) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier1;
			ChestRewardCardAmount.text = "25" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 4) {
				Legendary (25);
			} else if (Rarity <= 24 && Rarity >=5) {
				Epic (25);
			} else if (Rarity <= 124 && Rarity >=25) {
				Rare (25);
			} else {
				Common (25);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 30) {
				Player.Gems += 10;
				GemRewardAmount.text = "10";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 2) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier2;
			ChestRewardCardAmount.text = "50" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 6) {
				Legendary (50);
			} else if (Rarity <= 38 && Rarity >=7) {
				Epic (50);
			} else if (Rarity <= 174 && Rarity >=39) {
				Rare (50);
			} else {
				Common (50);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 25) {
				Player.Gems += 40;
				GemRewardAmount.text = "40";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 3) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier3;
			ChestRewardCardAmount.text = "75" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 8) {
				Legendary (75);
			} else if (Rarity <= 50 && Rarity >=9) {
				Epic (75);
			} else if (Rarity <= 224 && Rarity >=51) {
				Rare (75);
			} else {
				Common (75);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 40) {
				Player.Gems += 90;
				GemRewardAmount.text = "90";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 4) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier4;
			ChestRewardCardAmount.text = "100" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 9) {
				Legendary (100);
			} else if (Rarity <= 55 && Rarity >=10) {
				Epic (100);
			} else if (Rarity <= 236 && Rarity >=56) {
				Rare (100);
			} else {
				Common (100);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 15) {
				Player.Gems += 400;
				GemRewardAmount.text = "400";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 5) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier5;
			ChestRewardCardAmount.text = "125" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 10) {
				Legendary (125);
			} else if (Rarity <= 61 && Rarity >=11) {
				Epic (125);
			} else if (Rarity <= 252 && Rarity >=62) {
				Rare (125);
			} else {
				Common (125);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 50) {
				Player.Gems += 300;
				GemRewardAmount.text = "300";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 6) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier6;
			ChestRewardCardAmount.text = "150" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 25) {
				Legendary (150);
			} else if (Rarity <= 121 && Rarity >=26) {
				Epic (150);
			} else if (Rarity <= 500 && Rarity >=122) {
				Rare (150);
			} else {
				Common (150);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 75) {
				Player.Gems += 600;
				GemRewardAmount.text = "600";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 7) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier7;
			ChestRewardCardAmount.text = "175" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 50) {
				Legendary (175);
			} else if (Rarity <= 250 && Rarity >=51) {
				Epic (175);
			} else if (Rarity <= 750 && Rarity >=251) {
				Rare (175);
			} else {
				Common (175);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 80) {
				Player.Gems += 750;
				GemRewardAmount.text = "750";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 8) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier8;
			ChestRewardCardAmount.text = "200" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 60) {
				Legendary (200);
			} else if (Rarity <= 275 && Rarity >=61) {
				Epic (200);
			} else if (Rarity <= 800 && Rarity >=276) {
				Rare (200);
			} else {
				Common (200);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 85) {
				Player.Gems += 900;
				GemRewardAmount.text = "900";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 9) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier9;
			ChestRewardCardAmount.text = "225" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 75) {
				Legendary (225);
			} else if (Rarity <= 300 && Rarity >=76) {
				Epic (225);
			} else if (Rarity <= 875 && Rarity >=301) {
				Rare (225);
			} else {
				Common (225);
			}
			GetGem = Random.Range (1, 101);
			if (GetGem <= 90) {
				Player.Gems += 1000;
				GemRewardAmount.text = "1000";
				chestRewardUI.ToggleActivateGemParticles (true);
			} else {
				GemRewardAmount.text = "0";
				chestRewardUI.ToggleActivateGemParticles (false);
			}
			CheckClanChestTier ();
		} else if (Player.ClanChestTier == 10) {
			Player.ClanChestCrowns -= TotalClanChestCrownsToTier10;
			ChestRewardCardAmount.text = "250" + "x";
			Rarity = Random.Range (1, 1001);
			if (Rarity <= 100) {
				Legendary (250);
			} else if (Rarity <= 350 && Rarity >=101) {
				Epic (250);
			} else if (Rarity <= 950 && Rarity >=351) {
				Rare (250);
			} else {
				Common (250);
			}
			Player.Gems += 1200;
			GemRewardAmount.text = "1200";
			CheckClanChestTier ();
			chestRewardUI.ToggleActivateGemParticles (true);
		} else {
			return;
		}
	}
}
