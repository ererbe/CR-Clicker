using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpellEffects : MonoBehaviour {

	public SpellManager spellManager;

	public GameObject ArrowsButton;
	public GameObject FireballButton;
	public GameObject GoblinBarrelButton;
	public GameObject LightningButton;
	public GameObject RageButton;
	public GameObject RocketButton;
	public GameObject FreezeButton;
	public GameObject ZapButton;
	public GameObject PoisonButton;
	public GameObject MirrorButton;
	public GameObject GraveyardButton;
	public GameObject TheLogButton;
	public GameObject TornadoButton;
	public GameObject CloneButton;
	public GameObject HealButton;
	public GameObject BarbarianBarrelButton;

	private float OutputDuration = 3f;

	void Start () {
//		CheckLoadedCooldowns ();
		CheckSpellTiers ();
	}

//	void CheckLoadedCooldowns () {
//		if (cooldownArrows.CooldownTime <= spellManager.Arrows.Cooldown) {
//			spellManager.ArrowsReady = false;
//		} else {
//			spellManager.ArrowsReady = true;
//		}
//		Player.FinishedControl = true;
//	}

	public void CheckSpellTiers () {
		if (Player.ArrowsTier == 0) {
			ArrowsButton.SetActive (false);
		} else {
			if (spellManager.ArrowsReady == true) {
				ArrowsButton.SetActive (true);
			} else {
				ArrowsButton.SetActive (false);
			}
		}
		if (Player.FireballTier == 0) {
			FireballButton.SetActive (false);
		} else {
			if (spellManager.FireballReady == true) {
				FireballButton.SetActive (true);
			} else {
				FireballButton.SetActive (false);
			}
		}
		if (Player.GoblinBarrelTier == 0) {
			GoblinBarrelButton.SetActive (false);
		} else {
			if (spellManager.GoblinBarrelReady == true) {
				GoblinBarrelButton.SetActive (true);
			} else {
				GoblinBarrelButton.SetActive (false);
			}
		}
		if (Player.LightningTier == 0) {
			LightningButton.SetActive (false);
		} else {
			if (spellManager.LightningReady == true) {
				LightningButton.SetActive (true);
			} else {
				LightningButton.SetActive (false);
			}
		}
		if (Player.RageTier == 0) {
			RageButton.SetActive (false);
		} else {
			if (spellManager.RageReady == true) {
				RageButton.SetActive (true);
			} else {
				RageButton.SetActive (false);
			}
		}
		if (Player.RocketTier == 0) {
			RocketButton.SetActive (false);
		} else {
			if (spellManager.RocketReady == true) {
				RocketButton.SetActive (true);
			} else {
				RocketButton.SetActive (false);
			}
		}
		if (Player.FreezeTier == 0) {
			FreezeButton.SetActive (false);
		} else {
			if (spellManager.FreezeReady == true) {
				FreezeButton.SetActive (true);
			} else {
				FreezeButton.SetActive (false);
			}
		}
		if (Player.ZapTier == 0) {
			ZapButton.SetActive (false);
		} else {
			if (spellManager.ZapReady == true) {
				ZapButton.SetActive (true);
			} else {
				ZapButton.SetActive (false);
			}
		}
		if (Player.PoisonTier == 0) {
			PoisonButton.SetActive (false);
		} else {
			if (spellManager.PoisonReady == true) {
				PoisonButton.SetActive (true);
			} else {
				PoisonButton.SetActive (false);
			}
		}
		if (Player.MirrorTier == 0) {
			MirrorButton.SetActive (false);
		} else {
			if (spellManager.MirrorReady == true) {
				MirrorButton.SetActive (true);
			} else {
				MirrorButton.SetActive (false);
			}
		}
		if (Player.GraveyardTier == 0) {
			GraveyardButton.SetActive (false);
		} else {
			if (spellManager.GraveyardReady == true) {
				GraveyardButton.SetActive (true);
			} else {
				GraveyardButton.SetActive (false);
			}
		}
		if (Player.TheLogTier == 0) {
			TheLogButton.SetActive (false);
		} else {
			if (spellManager.TheLogReady == true) {
				TheLogButton.SetActive (true);
			} else {
				TheLogButton.SetActive (false);
			}
		}
		if (Player.TornadoTier == 0) {
			TornadoButton.SetActive (false);
		} else {
			if (spellManager.TornadoReady == true) {
				TornadoButton.SetActive (true);
			} else {
				TornadoButton.SetActive (false);
			}
		}
		if (Player.CloneTier == 0) {
			CloneButton.SetActive (false);
		} else {
			if (spellManager.CloneReady == true) {
				CloneButton.SetActive (true);
			} else {
				CloneButton.SetActive (false);
			}
		}
		if (Player.HealTier == 0) {
			HealButton.SetActive (false);
		} else {
			if (spellManager.HealReady == true) {
				HealButton.SetActive (true);
			} else {
				HealButton.SetActive (false);
			}
		}
		if (Player.BarbarianBarrelTier == 0) {
			BarbarianBarrelButton.SetActive (false);
		} else {
			if (spellManager.BarbarianBarrelReady == true) {
				BarbarianBarrelButton.SetActive (true);
			} else {
				BarbarianBarrelButton.SetActive (false);
			}
		}
	}

	public CooldownArrows cooldownArrows;
	public Transform ArrowsEffectOrigin;
	public GameObject ArrowsParticle1;
	public GameObject ArrowsParticle2;
	public GameObject ArrowsParticle3;
	public GameObject ArrowsParticle4;
	public GameObject ArrowsParticle5;
	public GameObject ArrowsParticle6;
	public Text ArrowsOutputText;
	public GameObject ArrowsOutput;
	private int ArrowCount;
	
	public void UseArrows () {
		if (Player.ArrowsTier >= 1) {
			ArrowsButton.SetActive (false);
			spellManager.ArrowsReady = false;
			cooldownArrows.gameObject.SetActive (true);
			cooldownArrows.StartCooldown ();
			Player.Coins += spellManager.Arrows.Power * Player.MirrorMulti * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.Arrows.Power * Player.MirrorMulti * Player.MirrorMulti;
			Player.UsedArrows += 1;
//			if (Player.ShowSpellParticle) {
//				GameObject particle = (GameObject)Instantiate (ArrowsParticle1, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
//				Destroy (particle, 10f);
//			}
			if (Player.ShowSpellParticle) {
				for (int i = 0; i < 20; i++)
				{
					ArrowCount = Random.Range (1,7);
					if (ArrowCount == 1) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle1, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					} if (ArrowCount == 2) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle2, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					} if (ArrowCount == 3) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle3, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					} if (ArrowCount == 4) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle4, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					} if (ArrowCount == 5) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle5, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					} if (ArrowCount == 6) {
					GameObject particle = (GameObject)Instantiate (ArrowsParticle6, ArrowsEffectOrigin.transform.position, ArrowsEffectOrigin.transform.rotation);
					Destroy (particle, 10f);
					}
				}
			}
			if (Player.ShowSpellOutput = true) {
				ArrowsOutputText.text = "Arrows: +" + (spellManager.Arrows.Power * Player.MirrorMulti).ToString() + " coins";
				ArrowsOutput.SetActive (true);
				StartCoroutine (ArrowsOutputTime());
			}
		}
	}

	IEnumerator ArrowsOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		ArrowsOutput.SetActive (false);
	}

	public CooldownFireball cooldownFireball;
	public Transform FireballEffectOrigin;
	public GameObject FireballParticle;
	public Text FireballOutputText;
	public GameObject FireballOutput;
	private float FireballOutputFloat;

	public void UseFireball () {
		if (Player.FireballTier >= 1) {
			FireballButton.SetActive (false);
			spellManager.FireballReady = false;
			cooldownFireball.gameObject.SetActive (true);
			cooldownFireball.StartCooldown ();
			FireballOutputFloat = 0f;
			Player.Coins += spellManager.Fireball.Power * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.Fireball.Power * Player.MirrorMulti;
			FireballOutputFloat += spellManager.Fireball.Power * Player.MirrorMulti;
			Player.UsedFireball += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (FireballParticle, FireballEffectOrigin.transform.position, FireballEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
				StartCoroutine (FireballFire());
		}
	}

	IEnumerator FireballFire () {
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		FireballOutputFloat += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		FireballOutputFloat += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		FireballOutputFloat += (spellManager.Fireball.Power / 12) * Player.MirrorMulti;
		if (Player.ShowSpellOutput = true) {
			FireballOutputText.text = "Fireball: +" + FireballOutputFloat.ToString() + " coins";
			FireballOutput.SetActive (true);
			StartCoroutine (FireballOutputTime());
		}
	}

	IEnumerator FireballOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		FireballOutput.SetActive (false);
	}

	public CooldownGoblinBarrel cooldownGoblinBarrel;
	public Transform GoblinBarrelEffectOrigin;
	public GameObject GoblinBarrelParticle;
	public Text GoblinBarrelOutputText;
	public GameObject GoblinBarrelOutput;
	private int GoblinBarrelRandInt;
	private float GoblinBarrelOutputFloat;

	public void UseGoblinBarrel () {
		if (Player.GoblinBarrelTier >= 1) {
			GoblinBarrelButton.SetActive (false);
			spellManager.GoblinBarrelReady = false;
			cooldownGoblinBarrel.gameObject.SetActive (true);
			cooldownGoblinBarrel.StartCooldown ();
			GoblinBarrelRandInt = Random.Range (0, 32);
			GoblinBarrelOutputFloat = (spellManager.GoblinBarrel.Power / 16) * GoblinBarrelRandInt * Player.MirrorMulti;
			Player.Coins += GoblinBarrelOutputFloat;
			Player.CollectedCoins += GoblinBarrelOutputFloat;
			Player.UsedGoblinBarrel += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (GoblinBarrelParticle, GoblinBarrelEffectOrigin.transform.position, GoblinBarrelEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				GoblinBarrelOutputText.text = "GoblinBarrel: +" + GoblinBarrelOutputFloat.ToString() + " coins";
				GoblinBarrelOutput.SetActive (true);
				StartCoroutine (GoblinBarrelOutputTime());
			}
		}
	}

	IEnumerator GoblinBarrelOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		GoblinBarrelOutput.SetActive (false);
	}

	public CooldownLightning cooldownLightning;
	public Transform LightningEffectOrigin;
	public GameObject LightningParticle;
	public Text LightningOutputText;
	public GameObject LightningOutput;
	private int LightningRandInt;
	private float LightningOutputFloat;

	public void UseLightning () {
		if (Player.LightningTier >= 1) {
			LightningButton.SetActive (false);
			spellManager.LightningReady = false;
			cooldownLightning.gameObject.SetActive (true);
			cooldownLightning.StartCooldown ();
			LightningRandInt = Random.Range (1, 4);
			LightningOutputFloat = (spellManager.Lightning.Power / 2) * LightningRandInt * Player.MirrorMulti;
			Player.Coins += LightningOutputFloat;
			Player.CollectedCoins += LightningOutputFloat;
			Player.UsedLightning += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (LightningParticle, LightningEffectOrigin.transform.position, LightningEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				LightningOutputText.text = "Lightning: +" + LightningOutputFloat.ToString() + " coins";
				LightningOutput.SetActive (true);
				StartCoroutine (LightningOutputTime());
			}
		}
	}

	IEnumerator LightningOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		LightningOutput.SetActive (false);
	}

	public CooldownRage cooldownRage;
	public Transform RageEffectOrigin;
	public GameObject RageParticle;
	public Text RageOutputText;
	public GameObject RageOutput;
	private float RageOutputFloat;
	public GameObject RageEffect;
	public Animation RageEffectAnimation;

	public void UseRage () {
		if (Player.RageTier >= 1) {
			RageButton.SetActive (false);
			spellManager.RageReady = false;
			cooldownRage.gameObject.SetActive (true);
			cooldownRage.StartCooldown ();
			RageOutputFloat = 1f + spellManager.Rage.Power;
			Player.RageMulti = 1f + spellManager.Rage.Power;
			StartCoroutine (RageEffectTimer());
			Player.UsedRage += 1;
			if (Player.ShowSpellParticle) {
				RageEffect.SetActive (true);
				RageEffectAnimation.Play ();
//				GameObject particle = (GameObject)Instantiate (RageParticle, RageEffectOrigin.transform.position, RageEffectOrigin.transform.rotation);
//				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				RageOutputText.text = "Rage: " + RageOutputFloat.ToString() + " coin multiplikator";
				RageOutput.SetActive (true);
				StartCoroutine (RageOutputTime());
			}
		}
	}

	IEnumerator RageEffectTimer () {
		yield return new WaitForSeconds (10f);
		Player.RageMulti = 1f;
		yield return new WaitForSeconds (2f);
		RageEffect.SetActive (false);
	}

	IEnumerator RageOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		RageOutput.SetActive (false);
	}

	public CooldownRocket cooldownRocket;
	public Transform RocketEffectOrigin;
	public GameObject RocketParticle;
	public Text RocketOutputText;
	public GameObject RocketOutput;

	public void UseRocket () {
		if (Player.RocketTier >= 1) {
			RocketButton.SetActive (false);
			spellManager.RocketReady = false;
			cooldownRocket.gameObject.SetActive (true);
			cooldownRocket.StartCooldown ();
			Player.Coins += spellManager.Rocket.Power * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.Rocket.Power * Player.MirrorMulti;
			Player.UsedRocket += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (RocketParticle, RocketEffectOrigin.transform.position, RocketEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				RocketOutputText.text = "Rocket: +" + (spellManager.Rocket.Power * Player.MirrorMulti).ToString() + " coins";
				RocketOutput.SetActive (true);
				StartCoroutine (RocketOutputTime());
			}
		}
	}

	IEnumerator RocketOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		RocketOutput.SetActive (false);
	}

	public CooldownFreeze cooldownFreeze;
	public GameObject FreezeElix;
	public GameObject Elix;
	public Text FreezeElixOutputText;
	public Text FreezeCrownOutputText;
	public GameObject FreezeOutput;
	private float FreezeElixOutput;
	private int FreezeCrownOutput;

	public void UseFreeze () {
		if (Player.FreezeTier >= 1) {
			FreezeButton.SetActive (false);
			spellManager.FreezeReady = false;
			cooldownFreeze.gameObject.SetActive (true);
			cooldownFreeze.StartCooldown ();
			Elix.SetActive (false);
			FreezeElix.SetActive (true);
			Player.UsedFreeze += 1;
			StartCoroutine (FreezeEffectTimer());
		}
	}

	IEnumerator FreezeEffectTimer () {
		yield return new WaitForSeconds (15f);
		FreezeElixOutput = (float)Player.FrozenElixClicks * Player.ElixPerClick * spellManager.Freeze.Power * Player.MirrorMulti;
		Player.Elix += FreezeElixOutput;
		Player.CollectedElix += FreezeElixOutput;
		FreezeCrownOutput = Mathf.RoundToInt (Player.FrozenElixClicks * Player.MirrorMulti);
		Player.Crowns += FreezeCrownOutput;
		Player.ClanChestCrowns += FreezeCrownOutput;
		Player.CollectedCrowns += FreezeCrownOutput;
		if (Player.ShowSpellOutput = true) {
			FreezeElixOutputText.text = "Freeze: " + FreezeElixOutput.ToString() + " Elixir";
			FreezeCrownOutputText.text = "Freeze: " + FreezeCrownOutput.ToString() + " Crowns";
			FreezeOutput.SetActive (true);
			StartCoroutine (FreezeOutputTime());
		}
		Elix.SetActive (true);
		FreezeElix.SetActive (false);
		Player.FreezeTouchCount = 0;
	}

	IEnumerator FreezeOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		FreezeOutput.SetActive (false);
	}

	public CooldownZap cooldownZap;
	public Transform ZapEffectOrigin;
	public GameObject ZapParticle;
	public Text ZapOutputText;
	public GameObject ZapOutput;

	public void UseZap () {
		if (Player.ZapTier >= 1) {
			ZapButton.SetActive (false);
			spellManager.ZapReady = false;
			cooldownZap.gameObject.SetActive (true);
			cooldownZap.StartCooldown ();
			Player.Coins += spellManager.Zap.Power * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.Zap.Power * Player.MirrorMulti;
			Player.UsedZap += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (ZapParticle, ZapEffectOrigin.transform.position, ZapEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				ZapOutputText.text = "Zap: +" + (spellManager.Zap.Power * Player.MirrorMulti).ToString() + " coins";
				ZapOutput.SetActive (true);
				StartCoroutine (ZapOutputTime());
			}
		}
	}

	IEnumerator ZapOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		ZapOutput.SetActive (false);
	}

	public CooldownPoison cooldownPoison;
	public Transform PoisonEffectOrigin;
	public GameObject PoisonParticle;
	public Text PoisonOutputText;
	public GameObject PoisonOutput;
	private float PoisonOutputFloat;

	public void UsePoison () {
		if (Player.PoisonTier >= 1) {
			PoisonButton.SetActive (false);
			spellManager.PoisonReady = false;
			cooldownPoison.gameObject.SetActive (true);
			cooldownPoison.StartCooldown ();
			PoisonOutputFloat = 0f;
			Player.UsedPoison += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (PoisonParticle, PoisonEffectOrigin.transform.position, PoisonEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			StartCoroutine (PoisonFire());
		}
	}

	IEnumerator PoisonFire () {
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10 * Player.MirrorMulti);
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		Player.Coins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		PoisonOutputFloat += (spellManager.Poison.Power / 10) * Player.MirrorMulti;
		if (Player.ShowSpellOutput = true) {
			PoisonOutputText.text = "Poison: +" + PoisonOutputFloat.ToString() + " coins";
			PoisonOutput.SetActive (true);
			StartCoroutine (PoisonOutputTime());
		}
	}

	IEnumerator PoisonOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		PoisonOutput.SetActive (false);
	}

	public CooldownMirror cooldownMirror;
	public Transform MirrorEffectOrigin;
	public GameObject MirrorParticle;
	public Text MirrorOutputText;
	public GameObject MirrorOutput;
	private float MirrorOutputFloat;

	public void UseMirror () {
		if (Player.MirrorTier >= 1) {
			MirrorButton.SetActive (false);
			spellManager.MirrorReady = false;
			cooldownMirror.gameObject.SetActive (true);
			cooldownMirror.StartCooldown ();
			MirrorOutputFloat = 1f + spellManager.Mirror.Power;
			Player.MirrorMulti = 1f + spellManager.Mirror.Power;
			StartCoroutine (MirrorEffectTimer());
			Player.UsedMirror += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (MirrorParticle, MirrorEffectOrigin.transform.position, MirrorEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				MirrorOutputText.text = "Mirror: " + MirrorOutputFloat.ToString() + " multiplikator";
				MirrorOutput.SetActive (true);
				StartCoroutine (MirrorOutputTime());
			}
		}
	}

	IEnumerator MirrorEffectTimer () {
		yield return new WaitForSeconds (20f);
		Player.MirrorMulti = 1f;
	}

	IEnumerator MirrorOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		MirrorOutput.SetActive (false);
	}

	public CooldownGraveyard cooldownGraveyard;
	public Transform GraveyardEffectOrigin;
	public GameObject GraveyardParticle;
	public Text GraveyardOutputText;
	public GameObject GraveyardOutput;
	private float GraveyardOutputFloat;
	private int GraveyardRandInt;

	public void UseGraveyard () {
		if (Player.GraveyardTier >= 1) {
			GraveyardButton.SetActive (false);
			spellManager.GraveyardReady = false;
			cooldownGraveyard.gameObject.SetActive (true);
			cooldownGraveyard.StartCooldown ();
			GraveyardOutputFloat = 0f;
			Player.UsedGraveyard += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (GraveyardParticle, GraveyardEffectOrigin.transform.position, GraveyardEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			StartCoroutine (GraveyardFire());
		}
	}

	IEnumerator GraveyardFire () {
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (0.5f);
		GraveyardRandInt = Random.Range (0, 6);
		Player.Coins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		GraveyardOutputFloat += (spellManager.Graveyard.Power / 30) * GraveyardRandInt * Player.MirrorMulti;
		if (Player.ShowSpellOutput = true) {
			GraveyardOutputText.text = "Graveyard: +" + GraveyardOutputFloat.ToString() + " coins";
			GraveyardOutput.SetActive (true);
			StartCoroutine (GraveyardOutputTime());
		}
	}

	IEnumerator GraveyardOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		GraveyardOutput.SetActive (false);
	}

	public CooldownTheLog cooldownTheLog;
	public Transform TheLogEffectOrigin;
	public GameObject TheLogParticle;
	public Text TheLogOutputText;
	public GameObject TheLogOutput;

	public void UseTheLog () {
		if (Player.TheLogTier >= 1) {
			TheLogButton.SetActive (false);
			spellManager.TheLogReady = false;
			cooldownTheLog.gameObject.SetActive (true);
			cooldownTheLog.StartCooldown ();
			Player.Coins += spellManager.TheLog.Power * Player.MirrorMulti * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.TheLog.Power * Player.MirrorMulti * Player.MirrorMulti;
			Player.UsedTheLog += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (TheLogParticle, TheLogEffectOrigin.transform.position, TheLogEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				TheLogOutputText.text = "TheLog: +" + (spellManager.TheLog.Power * Player.MirrorMulti).ToString() + " coins";
				TheLogOutput.SetActive (true);
				StartCoroutine (TheLogOutputTime());
			}
		}
	}

	IEnumerator TheLogOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		TheLogOutput.SetActive (false);
	}

	public CooldownTornado cooldownTornado;
	public Transform TornadoEffectOrigin;
	public GameObject TornadoParticle;
	public Text TornadoOutputText;
	public GameObject TornadoOutput;
	private float TornadoOutputFloat;

	public void UseTornado () {
		if (Player.TornadoTier >= 1) {
			TornadoButton.SetActive (false);
			spellManager.TornadoReady = false;
			cooldownTornado.gameObject.SetActive (true);
			cooldownTornado.StartCooldown ();
			TornadoOutputFloat = 1f + spellManager.Tornado.Power;
			Player.TornadoMulti = 1f + spellManager.Tornado.Power;
			StartCoroutine (TornadoEffectTimer());
			Player.UsedTornado += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (TornadoParticle, TornadoEffectOrigin.transform.position, TornadoEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				TornadoOutputText.text = "Tornado: " + TornadoOutputFloat.ToString() + " click multiplikator";
				TornadoOutput.SetActive (true);
				StartCoroutine (TornadoOutputTime());
			}
		}
	}

	IEnumerator TornadoEffectTimer () {
		yield return new WaitForSeconds (10f);
		Player.TornadoMulti = 1f;
	}

	IEnumerator TornadoOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		TornadoOutput.SetActive (false);
	}

	public CooldownClone cooldownClone;
	public Transform CloneEffectOrigin;
	public GameObject CloneParticle;
	public Text CloneOutputText;
	public GameObject CloneOutput;
	private float CloneOutputFloat;

	public void UseClone () {
		if (Player.CloneTier >= 1) {
			CloneButton.SetActive (false);
			spellManager.CloneReady = false;
			cooldownClone.gameObject.SetActive (true);
			cooldownClone.StartCooldown ();
			CloneOutputFloat = 1f + spellManager.Clone.Power;
			Player.CloneMulti = 1f + spellManager.Clone.Power;
			StartCoroutine (CloneEffectTimer());
			Player.UsedClone += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (CloneParticle, CloneEffectOrigin.transform.position, CloneEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				CloneOutputText.text = "Clone: " + CloneOutputFloat.ToString() + " elixir multiplikator";
				CloneOutput.SetActive (true);
				StartCoroutine (CloneOutputTime());
			}
		}
	}

	IEnumerator CloneEffectTimer () {
		yield return new WaitForSeconds (15f);
		Player.CloneMulti = 1f;
	}

	IEnumerator CloneOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		CloneOutput.SetActive (false);
	}

	public CooldownHeal cooldownHeal;
	public Transform HealEffectOrigin;
	public GameObject HealParticle;
	public Text HealCoinOutputText;
	public Text HealGemOutputText;
	public GameObject HealOutput;
	private float HealCoinOutputFloat;
	private float HealGemOutputFloat;

	public void UseHeal () {
		if (Player.HealTier >= 1) {
			HealButton.SetActive (false);
			spellManager.HealReady = false;
			cooldownHeal.gameObject.SetActive (true);
			cooldownHeal.StartCooldown ();
			HealCoinOutputFloat = spellManager.Heal.Power;
			HealGemOutputFloat = spellManager.Heal.Power / 100;
			Player.HealIsActive = true;
			StartCoroutine (HealEffectTimer());
			Player.UsedHeal += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (HealParticle, HealEffectOrigin.transform.position, HealEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			if (Player.ShowSpellOutput = true) {
				HealCoinOutputText.text = "Heal: " + HealCoinOutputFloat.ToString() + " coins per click";
				HealGemOutputText.text = "Heal: " + HealGemOutputFloat.ToString() + " gems per click";
				HealOutput.SetActive (true);
				StartCoroutine (HealOutputTime());
			}
		}
	}

	IEnumerator HealEffectTimer () {
		yield return new WaitForSeconds (15f);
		Player.HealIsActive = false;
	}

	IEnumerator HealOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		HealOutput.SetActive (false);
	}

	public CooldownBarbarianBarrel cooldownBarbarianBarrel;
	public Transform BarbarianBarrelEffectOrigin;
	public GameObject BarbarianBarrelParticle;
	public Text BarbarianBarrelOutputText;
	public GameObject BarbarianBarrelOutput;
	private float BarbarianBarrelOutputFloat;
	private int BarbarianBarrelRandInt;

	public void UseBarbarianBarrel () {
		if (Player.BarbarianBarrelTier >= 1) {
			BarbarianBarrelButton.SetActive (false);
			spellManager.BarbarianBarrelReady = false;
			cooldownBarbarianBarrel.gameObject.SetActive (true);
			cooldownBarbarianBarrel.StartCooldown ();
			BarbarianBarrelOutputFloat = 0f;
			Player.Coins += spellManager.BarbarianBarrel.Power * 0.5f * Player.MirrorMulti;
			Player.CollectedCoins += spellManager.BarbarianBarrel.Power * 0.5f * Player.MirrorMulti;
			BarbarianBarrelOutputFloat += spellManager.BarbarianBarrel.Power * 0.5f * Player.MirrorMulti;
			Player.UsedBarbarianBarrel += 1;
			if (Player.ShowSpellParticle) {
				GameObject particle = (GameObject)Instantiate (BarbarianBarrelParticle, BarbarianBarrelEffectOrigin.transform.position, BarbarianBarrelEffectOrigin.transform.rotation);
				Destroy (particle, 10f);
			}
			StartCoroutine (BarbarianBarrelFire());
		}
	}

	IEnumerator BarbarianBarrelFire () {
		yield return new WaitForSeconds (1f);
		BarbarianBarrelRandInt = Random.Range (0, 2);
		Player.Coins += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		BarbarianBarrelOutputFloat += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		yield return new WaitForSeconds (1f);
		BarbarianBarrelRandInt = Random.Range (0, 2);
		Player.Coins += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		Player.CollectedCoins += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		BarbarianBarrelOutputFloat += (spellManager.BarbarianBarrel.Power / 2) * BarbarianBarrelRandInt * Player.MirrorMulti;
		if (Player.ShowSpellOutput = true) {
			BarbarianBarrelOutputText.text = "BarbarianBarrel: +" + BarbarianBarrelOutputFloat.ToString() + " coins";
			BarbarianBarrelOutput.SetActive (true);
			StartCoroutine (BarbarianBarrelOutputTime());
		}
	}

	IEnumerator BarbarianBarrelOutputTime () {
		yield return new WaitForSeconds (OutputDuration);
		BarbarianBarrelOutput.SetActive (false);
	}

}
