using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceUI : MonoBehaviour {

	public Text PlayerLevel;

	public Image Progressbar;

	public Text PlayerExperience;

	private int ExpToLevel2 = 10;
	private int ExpToLevel3 = 25;
	private int ExpToLevel4 = 50;
	private int ExpToLevel5 = 100;
	private int ExpToLevel6 = 250;
	private int ExpToLevel7 = 500;
	private int ExpToLevel8 = 1000;
	private int ExpToLevel9 = 2500;
	private int ExpToLevel10 = 5000;
	private int ExpToLevel11 = 7500;
	private int ExpToLevel12 = 10000;
	private int ExpToLevel13 = 15000;
	private int ExpToLevel14 = 20000;
	private int ExpToLevel15 = 25000;
	private int ExpToLevel16 = 30000;
	private int ExpToLevel17 = 35000;
	private int ExpToLevel18 = 40000;
	private int ExpToLevel19 = 50000;
	private int ExpToLevel20 = 75000;
	private int ExpToLevelOther = 100000;


	private float ExpToNextLevel;

	void Start () {
		CalculateExpToNextLevel ();
	}

	public void ExpChange () {
		float progress = (float)Player.Experience / ExpToNextLevel; 
		Progressbar.fillAmount = progress;
		PlayerExperience.text = Player.Experience.ToString ();
		if (Player.Experience >= ExpToNextLevel) {
			Player.PlayerLevel += 1;
			Player.Experience -= (int) ExpToNextLevel;
			CalculateExpToNextLevel ();
		}
	}

	void CalculateExpToNextLevel () {
		PlayerLevel.text = Player.PlayerLevel.ToString ();
		if (Player.PlayerLevel == 1) {
			ExpToNextLevel = ExpToLevel2;
		} else if (Player.PlayerLevel == 2) {
			ExpToNextLevel = ExpToLevel3;
		} else if (Player.PlayerLevel == 3) {
			ExpToNextLevel = ExpToLevel4;
		} else if (Player.PlayerLevel == 4) {
			ExpToNextLevel = ExpToLevel5;
		} else if (Player.PlayerLevel == 5) {
			ExpToNextLevel = ExpToLevel6;
		} else if (Player.PlayerLevel == 6) {
			ExpToNextLevel = ExpToLevel7;
		} else if (Player.PlayerLevel == 7) {
			ExpToNextLevel = ExpToLevel8;
		} else if (Player.PlayerLevel == 8) {
			ExpToNextLevel = ExpToLevel9;
		} else if (Player.PlayerLevel == 9) {
			ExpToNextLevel = ExpToLevel10;
		} else if (Player.PlayerLevel == 10) {
			ExpToNextLevel = ExpToLevel11;
		} else if (Player.PlayerLevel == 11) {
			ExpToNextLevel = ExpToLevel12;
		} else if (Player.PlayerLevel == 12) {
			ExpToNextLevel = ExpToLevel13;
		} else if (Player.PlayerLevel == 13) {
			ExpToNextLevel = ExpToLevel14;
		} else if (Player.PlayerLevel == 14) {
			ExpToNextLevel = ExpToLevel15;
		} else if (Player.PlayerLevel == 15) {
			ExpToNextLevel = ExpToLevel16;
		} else if (Player.PlayerLevel == 16) {
			ExpToNextLevel = ExpToLevel17;
		} else if (Player.PlayerLevel == 17) {
			ExpToNextLevel = ExpToLevel18;
		} else if (Player.PlayerLevel == 18) {
			ExpToNextLevel = ExpToLevel19;
		} else if (Player.PlayerLevel == 19) {
			ExpToNextLevel = ExpToLevel20;
		} else {
			ExpToNextLevel = ExpToLevelOther;
		}
		ExpChange ();
	}
}
