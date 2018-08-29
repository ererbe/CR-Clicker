using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour {

	public GameObject Credits;

	public Text CrownParticle;
	public Text LegendaryParticle;
	public Text EpicParticle;
	public Text RareParticle;
	public Text CommonParticle;
	public Text ShowParticle;
	public Text GemParticle;
	public Text ShowChestParticle;
	public Text Language;
	public Text ShowChestTexture;
	public Text ShowElixAnimation;
	public Text ShowSpellOutput;
	public Text ShowSpellParticle;

	public Text CrownParticleText;
	public Text LegendaryParticleText;
	public Text EpicParticleText;
	public Text RareParticleText;
	public Text CommonParticleText;
	public Text ShowParticleText;
	public Text GemParticleText;
	public Text ShowChestParticleText;
	public Text SaveText;
	public Text ExitGameText;
	public Text ShowChestTextureText;
	public Text ShowElixAnimationText;
	public Text ShowSpellOutputText;
	public Text ShowSpellParticleText;

	void Start () {
		CheckShowParticle ();
		CheckLanguage ();
		CheckGemParticle ();
		CheckLegendaryParticle ();
		CheckEpicParticle ();
		CheckRareParticle ();
		CheckCommonParticle ();
		CheckCrownParticle ();
		CheckShowChestParticle ();
		CheckShowChestTexture ();
		CheckShowElixAnimation ();
		CheckShowSpellOutput ();
		CheckShowSpellParticle ();
	}

	public void CloseGame () {
		Application.Quit ();
	}

	void OnEnable () {
		OptionLanguage ();
	}

	public void OptionLanguage () {
		if (Player.Language == 1) {
			ShowParticleText.text = "Show Elixir Particle";
			ShowChestParticleText.text = "Show Chest Particle";
			ShowChestTextureText.text = "Show Chest Texture";
			SaveText.text = "Save";
			ExitGameText.text = "Exit Game";
			CrownParticleText.text = "Crown Particle";
			LegendaryParticleText.text = "Legendary Particle";
			EpicParticleText.text = "Epic Particle";
			RareParticleText.text = "Rare Particle";
			CommonParticleText.text = "Common Particle";
			GemParticleText.text = "Show Gem Particle";
			ShowElixAnimationText.text = "Play Elixir Animation";
			ShowElixAnimationText.text = "Show Spell Output ";
			ShowElixAnimationText.text = "Show Spell Particle ";
		} else if (Player.Language == 2) {
			ShowParticleText.text = "Zeige Elixier Partikel";
			ShowChestParticleText.text = "Zeige Truhen Partikel";
			ShowChestTextureText.text = "Zeige Truhen Textur";
			SaveText.text = "Speichern";
			ExitGameText.text = "Spiel Verlassen";
			CrownParticleText.text = "Krohnen Partikel";
			LegendaryParticleText.text = "Legendär-Partikel";
			EpicParticleText.text = "Epic-Partikel";
			RareParticleText.text = "Rare-Partikel";
			CommonParticleText.text = "Common-Partikel";
			GemParticleText.text = "Zeige Gem Partikel";
			ShowElixAnimationText.text = "Spiele Elixier Animation ab";
			ShowElixAnimationText.text = "Zeige Zauber Einkommen";
			ShowElixAnimationText.text = "Zeige Zauber Partikel";
		}
	}

	public void ShowCredits () {
		Credits.SetActive (true);
	}

	public void HideCredits () {
		Credits.SetActive (false);
	}

	// change

	public void ChangeCrownParticle () {
		if (Player.CrownParticles == 1) {
			Player.CrownParticles = 2;
			if (Player.Language == 1) {
				CrownParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Besonders 1";
			}
		} else if (Player.CrownParticles == 2) {
			Player.CrownParticles = 3;
			if (Player.Language == 1) {
				CrownParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Besonders 2";
			}
		} else if (Player.CrownParticles == 3) {
			Player.CrownParticles = 4;
			if (Player.Language == 1) {
				CrownParticle.text = "Off";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Aus";
			}
		} else if (Player.CrownParticles == 4) {
			Player.CrownParticles = 1;
			if (Player.Language == 1) {
				CrownParticle.text = "Default";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Standart";
			}
		}
	}

	public void ChangeLegendaryParticle () {
		if (Player.LegendaryParticleNumber == 1) {
			Player.LegendaryParticleNumber = 2;
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 1";
			}
		} else if (Player.LegendaryParticleNumber == 2) {
			Player.LegendaryParticleNumber = 3;
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 2";
			}
		} else if (Player.LegendaryParticleNumber == 3) {
			Player.LegendaryParticleNumber = 4;
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 3";
			}
		} else if (Player.LegendaryParticleNumber == 4) {
			Player.LegendaryParticleNumber = 5;
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 4";
			}
		} else if (Player.LegendaryParticleNumber == 5) {
			Player.LegendaryParticleNumber = 1;
			if (Player.Language == 1) {
				LegendaryParticle.text = "Default";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Standart";
			}
		}
	}

	public void ChangeEpicParticle () {
		if (Player.EpicParticleNumber == 1) {
			Player.EpicParticleNumber = 2;
			if (Player.Language == 1) {
				EpicParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 1";
			}
		} else if (Player.EpicParticleNumber == 2) {
			Player.EpicParticleNumber = 3;
			if (Player.Language == 1) {
				EpicParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 2";
			}
		} else if (Player.EpicParticleNumber == 3) {
			Player.EpicParticleNumber = 4;
			if (Player.Language == 1) {
				EpicParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 3";
			}
		} else if (Player.EpicParticleNumber == 4) {
			Player.EpicParticleNumber = 5;
			if (Player.Language == 1) {
				EpicParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 4";
			}
		} else if (Player.EpicParticleNumber == 5) {
			Player.EpicParticleNumber = 1;
			if (Player.Language == 1) {
				EpicParticle.text = "Default";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Standart";
			}
		}
	}

	public void ChangeRareParticle () {
		if (Player.RareParticleNumber == 1) {
			Player.RareParticleNumber = 2;
			if (Player.Language == 1) {
				RareParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 1";
			}
		} else if (Player.RareParticleNumber == 2) {
			Player.RareParticleNumber = 3;
			if (Player.Language == 1) {
				RareParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 2";
			}
		} else if (Player.RareParticleNumber == 3) {
			Player.RareParticleNumber = 4;
			if (Player.Language == 1) {
				RareParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 3";
			}
		} else if (Player.RareParticleNumber == 4) {
			Player.RareParticleNumber = 5;
			if (Player.Language == 1) {
				RareParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 4";
			}
		} else if (Player.RareParticleNumber == 5) {
			Player.RareParticleNumber = 1;
			if (Player.Language == 1) {
				RareParticle.text = "Default";
			} else if (Player.Language == 2) {
				RareParticle.text = "Standart";
			}
		}
	}

	public void ChangeCommonParticle () {
		if (Player.CommonParticleNumber == 1) {
			Player.CommonParticleNumber = 2;
			if (Player.Language == 1) {
				CommonParticle.text = "Short";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Kurz";
			}
		} else if (Player.CommonParticleNumber == 2) {
			Player.CommonParticleNumber = 3;
			if (Player.Language == 1) {
				CommonParticle.text = "Very Short";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Sehr Kurz";
			}
		} else if (Player.CommonParticleNumber == 3) {
			Player.CommonParticleNumber = 4;
			if (Player.Language == 1) {
				CommonParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Besonders 1";
			}
		} else if (Player.CommonParticleNumber == 4) {
			Player.CommonParticleNumber = 5;
			if (Player.Language == 1) {
				CommonParticle.text = "Crazy";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Verrückt";
			}
		} else if (Player.CommonParticleNumber == 5) {
			Player.CommonParticleNumber = 1;
			if (Player.Language == 1) {
				CommonParticle.text = "Default";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Standart";
			}
		}
	}

		public void ChangeShowParticle () {
			if (Player.ShowParticles == true) {
				if (Player.Language == 1) {
					ShowParticle.text = "Off";
				} else if (Player.Language == 2) {
					ShowParticle.text = "Aus";
				}
				Player.ShowParticles = false;
			} else if (Player.ShowParticles == false) {
				if (Player.Language == 1) {
					ShowParticle.text = "On";
				} else if (Player.Language == 2) {
					ShowParticle.text = "An";
				}
				Player.ShowParticles = true;
			}
		}

	public void ChangeGemParticle () {
		if (Player.GemParticleNumber == 0) {
			Player.GemParticleNumber = 1;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 1) {
			Player.GemParticleNumber = 2;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 2) {
			Player.GemParticleNumber = 3;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 3) {
			Player.GemParticleNumber = 4;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 4) {
			Player.GemParticleNumber = 5;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 5) {
			Player.GemParticleNumber = 6;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 6) {
			Player.GemParticleNumber = 7;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber ==7) {
			Player.GemParticleNumber = 8;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 8) {
			Player.GemParticleNumber = 9;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 9) {
			Player.GemParticleNumber = 10;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 10) {
			Player.GemParticleNumber = 11;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 11) {
			Player.GemParticleNumber = 12;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 12) {
			Player.GemParticleNumber = 13;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 13) {
			Player.GemParticleNumber = 14;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 14) {
			Player.GemParticleNumber = 15;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 15) {
			Player.GemParticleNumber = 16;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 16) {
			Player.GemParticleNumber = 17;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 17) {
			Player.GemParticleNumber = 18;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 18) {
			Player.GemParticleNumber = 19;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 19) {
			Player.GemParticleNumber = 20;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 20) {
			Player.GemParticleNumber = 21;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 21) {
			Player.GemParticleNumber = 22;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 22) {
			Player.GemParticleNumber = 23;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 23) {
			Player.GemParticleNumber = 24;
			CheckGemParticle ();
		} else if (Player.GemParticleNumber == 24) {
			Player.GemParticleNumber = 0;
			CheckGemParticle ();
		}
	}

	public void ChangeShowChestParticle () {
		if (Player.ShowChestParticles == true) {
			if (Player.Language == 1) {
				ShowChestParticle.text = "Off";
			} else if (Player.Language == 2) {
				ShowChestParticle.text = "Aus";
			}
			Player.ShowChestParticles = false;
		} else if (Player.ShowChestParticles == false) {
			if (Player.Language == 1) {
				ShowChestParticle.text = "On";
			} else if (Player.Language == 2) {
				ShowChestParticle.text = "An";
			}
			Player.ShowChestParticles = true;
		}
	}

	public void ChangeShowChestTexture () {
		if (Player.ShowChestTexture == true) {
			if (Player.Language == 1) {
				ShowChestTexture.text = "Off";
			} else if (Player.Language == 2) {
				ShowChestTexture.text = "Aus";
			}
			Player.ShowChestTexture = false;
		} else if (Player.ShowChestTexture == false) {
			if (Player.Language == 1) {
				ShowChestTexture.text = "On";
			} else if (Player.Language == 2) {
				ShowChestTexture.text = "An";
			}
			Player.ShowChestTexture = true;
		}
	}

	public void ChangeShowElixAnimation () {
		if (Player.ShowElixAnimation == true) {
			if (Player.Language == 1) {
				ShowElixAnimation.text = "Off";
			} else if (Player.Language == 2) {
				ShowElixAnimation.text = "Aus";
			}
			Player.ShowElixAnimation = false;
		} else if (Player.ShowElixAnimation == false) {
			if (Player.Language == 1) {
				ShowElixAnimation.text = "On";
			} else if (Player.Language == 2) {
				ShowElixAnimation.text = "An";
			}
			Player.ShowElixAnimation = true;
		}
	}

	public void ChangeShowSpellOutput () {
		if (Player.ShowSpellOutput == true) {
			if (Player.Language == 1) {
				ShowSpellOutput.text = "Off";
			} else if (Player.Language == 2) {
				ShowSpellOutput.text = "Aus";
			}
			Player.ShowSpellOutput = false;
		} else if (Player.ShowSpellOutput == false) {
			if (Player.Language == 1) {
				ShowSpellOutput.text = "On";
			} else if (Player.Language == 2) {
				ShowSpellOutput.text = "An";
			}
			Player.ShowSpellOutput = true;
		}
	}

	public void ChangeShowSpellParticle () {
		if (Player.ShowSpellParticle == true) {
			if (Player.Language == 1) {
				ShowSpellParticle.text = "Off";
			} else if (Player.Language == 2) {
				ShowSpellParticle.text = "Aus";
			}
			Player.ShowSpellParticle = false;
		} else if (Player.ShowSpellParticle == false) {
			if (Player.Language == 1) {
				ShowSpellParticle.text = "On";
			} else if (Player.Language == 2) {
				ShowSpellParticle.text = "An";
			}
			Player.ShowSpellParticle = true;
		}
	}

	public void ChangeLanguage () {
		if (Player.Language == 1) {
			Language.text = "German";
			Player.Language = 2;
		} else if (Player.Language == 2) {
			Language.text = "Englisch";
			Player.Language = 1;
		}
	}

	// Check 

	public void CheckShowParticle () {
		if (Player.ShowParticles == true) {
			if (Player.Language == 1) {
				ShowParticle.text = "On";
			} else if (Player.Language == 2) {
				ShowParticle.text = "An";
			}
		} else if (Player.ShowParticles == false) {
			if (Player.Language == 1) {
				ShowParticle.text = "Off";
			} else if (Player.Language == 2) {
				ShowParticle.text = "Aus";
			}
		}
	}

	public void CheckGemParticle () {
		if (Player.GemParticleNumber == 0) {
			if (Player.Language == 1) {
				GemParticle.text = "Off";
			} else if (Player.Language == 2) {
				GemParticle.text = "Aus";
			}
		} else if (Player.GemParticleNumber == 1) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D (Rotating) - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D (Rotierend) - Niedrig";
			}
		} else if (Player.GemParticleNumber == 2) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D (Rotating) - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D (Rotierend) - Mittel";
			}
		} else if (Player.GemParticleNumber == 3) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D (Rotating) - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D (Rotierend) - Hoch";
			}
		} else if (Player.GemParticleNumber == 4) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D (Rotating) - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D (Rotierend) - sehr Hoch";
			}
		} else if (Player.GemParticleNumber == 5) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D - Niedrig";
			}
		} else if (Player.GemParticleNumber == 6) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D - Mittel";
			}
		} else if (Player.GemParticleNumber ==7) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D - Hoch";
			}
		} else if (Player.GemParticleNumber == 8) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle 3D - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel 3D - sehr Hoch";
			}
		} else if (Player.GemParticleNumber == 9) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default (Rotating) - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart (Rotierend) - Niedrig";
			}
		} else if (Player.GemParticleNumber == 10) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default (Rotating) - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart (Rotierend) - Mittel";
			}
		} else if (Player.GemParticleNumber == 11) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default (Rotating) - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart (Rotierend) - Hoch";
			}
		} else if (Player.GemParticleNumber == 12) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default (Rotating) - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart (Rotierend) - sehr Hoch";
			}
		} else if (Player.GemParticleNumber == 13) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart - Niedrig";
			}
		} else if (Player.GemParticleNumber == 14) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart - Mittel";
			}
		} else if (Player.GemParticleNumber == 15) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart - Hoch";
			}
		} else if (Player.GemParticleNumber == 16) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Default - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Standart - sehr Hoch";
			}
		} else if (Player.GemParticleNumber == 17) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel (Rotating) - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach (Rotierend) - Niedrig";
			}
		} else if (Player.GemParticleNumber == 18) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel (Rotating) - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach (Rotierend) - Mittel";
			}
		} else if (Player.GemParticleNumber == 19) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel (Rotating) - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach (Rotierend) - Hoch";
			}
		} else if (Player.GemParticleNumber == 20) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel (Rotating) - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach (Rotierend) - sehr Hoch";
			}
		} else if (Player.GemParticleNumber == 21) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel - Low";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach - Niedrig";
			}
		} else if (Player.GemParticleNumber == 22) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel - Middle";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach - Mittel";
			}
		} else if (Player.GemParticleNumber == 23) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel - High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach - Hoch";
			}
		} else if (Player.GemParticleNumber == 24) {
			if (Player.Language == 1) {
				GemParticle.text = "Gem Particle Simpel - Very High";
			} else if (Player.Language == 2) {
				GemParticle.text = "Gem Partikel Einfach - sehr Hoch";
			}
		}
	}

	public void CheckShowChestParticle () {
		if (Player.ShowChestParticles == true) {
			if (Player.Language == 1) {
				ShowChestParticle.text = "On";
			} else if (Player.Language == 2) {
				ShowChestParticle.text = "An";
			}
		} else if (Player.ShowChestParticles == false) {
			if (Player.Language == 1) {
				ShowChestParticle.text = "Off";
			} else if (Player.Language == 2) {
				ShowChestParticle.text = "Aus";
			}
		}
	}

	public void CheckShowChestTexture () {
		if (Player.ShowChestTexture == true) {
			if (Player.Language == 1) {
				ShowChestTexture.text = "On";
			} else if (Player.Language == 2) {
				ShowChestTexture.text = "An";
			}
		} else if (Player.ShowChestTexture == false) {
			if (Player.Language == 1) {
				ShowChestTexture.text = "Off";
			} else if (Player.Language == 2) {
				ShowChestTexture.text = "Aus";
			}
		}
	}

	public void CheckShowElixAnimation () {
		if (Player.ShowElixAnimation == true) {
			if (Player.Language == 1) {
				ShowElixAnimation.text = "On";
			} else if (Player.Language == 2) {
				ShowElixAnimation.text = "An";
			}
		} else if (Player.ShowElixAnimation == false) {
			if (Player.Language == 1) {
				ShowElixAnimation.text = "Off";
			} else if (Player.Language == 2) {
				ShowElixAnimation.text = "Aus";
			}
		}
	}

	public void CheckShowSpellOutput () {
		if (Player.ShowSpellOutput == true) {
			if (Player.Language == 1) {
				ShowSpellOutput.text = "On";
			} else if (Player.Language == 2) {
				ShowSpellOutput.text = "An";
			}
		} else if (Player.ShowSpellOutput == false) {
			if (Player.Language == 1) {
				ShowSpellOutput.text = "Off";
			} else if (Player.Language == 2) {
				ShowSpellOutput.text = "Aus";
			}
		}
	}

	public void CheckShowSpellParticle () {
		if (Player.ShowSpellParticle == true) {
			if (Player.Language == 1) {
				ShowSpellParticle.text = "On";
			} else if (Player.Language == 2) {
				ShowSpellParticle.text = "An";
			}
		} else if (Player.ShowSpellParticle == false) {
			if (Player.Language == 1) {
				ShowSpellParticle.text = "Off";
			} else if (Player.Language == 2) {
				ShowSpellParticle.text = "Aus";
			}
		}
	}

	public void CheckLanguage () {
		if (Player.Language == 1) {
			Language.text = "Englisch";
		} else if (Player.Language == 2) {
			Language.text = "German";
		}
	}

	public void CheckLegendaryParticle () {
		if (Player.LegendaryParticleNumber == 1) {
			if (Player.Language == 1) {
				LegendaryParticle.text = "Default";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Standart";
			}
		} else if (Player.LegendaryParticleNumber == 2) {
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 1";
			}
		} else if (Player.LegendaryParticleNumber == 3) {
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 2";
			}
		} else if (Player.LegendaryParticleNumber == 4) {
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 3";
			}
		} else if (Player.LegendaryParticleNumber == 5) {
			if (Player.Language == 1) {
				LegendaryParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				LegendaryParticle.text = "Besonders 4";
			}
		}
	}

	public void CheckEpicParticle () {
		if (Player.EpicParticleNumber == 1) {
			if (Player.Language == 1) {
				EpicParticle.text = "Default";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Standart";
			}
		} else if (Player.EpicParticleNumber == 2) {
			if (Player.Language == 1) {
				EpicParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 1";
			}
		} else if (Player.EpicParticleNumber == 3) {
			if (Player.Language == 1) {
				EpicParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 2";
			}
		} else if (Player.EpicParticleNumber == 4) {
			if (Player.Language == 1) {
				EpicParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 3";
			}
		} else if (Player.EpicParticleNumber == 5) {
			if (Player.Language == 1) {
				EpicParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				EpicParticle.text = "Besonders 4";
			}
		}
	}

	public void CheckRareParticle () {
		if (Player.RareParticleNumber == 1) {
			if (Player.Language == 1) {
				RareParticle.text = "Default";
			} else if (Player.Language == 2) {
				RareParticle.text = "Standart";
			}
		} else if (Player.RareParticleNumber == 2) {
			if (Player.Language == 1) {
				RareParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 1";
			}
		} else if (Player.RareParticleNumber == 3) {
			if (Player.Language == 1) {
				RareParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 2";
			}
		} else if (Player.RareParticleNumber == 4) {
			if (Player.Language == 1) {
				RareParticle.text = "Special 3";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 3";
			}
		} else if (Player.RareParticleNumber == 5) {
			if (Player.Language == 1) {
				RareParticle.text = "Special 4";
			} else if (Player.Language == 2) {
				RareParticle.text = "Besonders 4";
			}
		}
	}

	public void CheckCommonParticle () {
		if (Player.CommonParticleNumber == 1) {
			if (Player.Language == 1) {
				CommonParticle.text = "Default";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Standart";
			}
		} else if (Player.CommonParticleNumber == 2) {
			if (Player.Language == 1) {
				CommonParticle.text = "Short";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Kurz";
			}
		} else if (Player.CommonParticleNumber == 3) {
			if (Player.Language == 1) {
				CommonParticle.text = "Very Short";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Sehr Kurz";
			}
		} else if (Player.CommonParticleNumber == 4) {
			if (Player.Language == 1) {
				CommonParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Besonders 1";
			}
		} else if (Player.CommonParticleNumber == 5) {
			if (Player.Language == 1) {
				CommonParticle.text = "Crazy";
			} else if (Player.Language == 2) {
				CommonParticle.text = "Verrückt";
			}
		}
	}

	public void CheckCrownParticle () {
		if (Player.CrownParticles == 1) {
			if (Player.Language == 1) {
				CrownParticle.text = "Default";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Standart";
			}
		} else if (Player.CrownParticles == 2) {
			if (Player.Language == 1) {
				CrownParticle.text = "Special 1";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Besonders 1";
			}
		} else if (Player.CrownParticles == 3) {
			if (Player.Language == 1) {
				CrownParticle.text = "Special 2";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Special 3";
			}
		} else if (Player.CrownParticles == 4) {
			if (Player.Language == 1) {
				CrownParticle.text = "Off";
			} else if (Player.Language == 2) {
				CrownParticle.text = "Aus";
			}
		}
	}
}
