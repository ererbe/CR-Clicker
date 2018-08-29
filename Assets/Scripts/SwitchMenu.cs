using System.Collections;
using UnityEngine;

public class SwitchMenu : MonoBehaviour {

	public GameObject NormalMenu;
	public GameObject SpellMenu;

	public SpellEffects spellEffect;

	public WizardShop wizardShop;

	public void ToggleMenu () {

		if (NormalMenu.activeSelf) {
			NormalMenu.SetActive(false);
			wizardShop.UpdateSpellStatistics ();
			spellEffect.CheckSpellTiers ();
			SpellMenu.SetActive(true);
		} else {
			NormalMenu.SetActive(true);
			SpellMenu.SetActive(false);
		}
	}
}
