using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ArenaTextUI : MonoBehaviour {

	public Image Arena;

	public Sprite Arena0;
	public Sprite Arena1;
	public Sprite Arena2;
	public Sprite Arena3;
	public Sprite Arena4;
	public Sprite Arena5;
	public Sprite Arena6;
	public Sprite Arena7;
	public Sprite Arena8;
	public Sprite Arena9;
	public Sprite Arena10;
	public Sprite Arena11;
	public Sprite Arena12;
	public Sprite League1;
	public Sprite League2;
	public Sprite League3;
	public Sprite League4;
	public Sprite League5;
	public Sprite League6;
	public Sprite League7;
	public Sprite League8;
	public Sprite League9;

	public void Start () {
		ArenaCheck ();
	}

	public void ArenaCheck () {
		if (Player.Trophys >= 0) {
			Player.Arena = 0;
			Arena.sprite = Arena0;
			Debug.Log (Player.Arena);
		} if (Player.Trophys >= 100) {
			Player.Arena = 1;
			Arena.sprite = Arena1;
			Debug.Log (Player.Arena);
		} if (Player.Trophys >= 400) {
			Player.Arena = 2;
			Arena.sprite = Arena2;
			Debug.Log (Player.Arena);
		} if (Player.Trophys >= 800) {
			Player.Arena = 3;
			Arena.sprite = Arena3;
			Debug.Log (Player.Arena);
		} if (Player.Trophys >= 1100) {
			Player.Arena = 4;
			Arena.sprite = Arena4;
			Debug.Log (Player.Arena);
		} if (Player.Trophys >= 1400) {
			Player.Arena = 5;
			Arena.sprite = Arena5;
		} if (Player.Trophys >= 1700) {
			Player.Arena = 6;
			Arena.sprite = Arena6;
		} if (Player.Trophys >= 2000) {
			Player.Arena = 7;
			Arena.sprite = Arena7;
		} if (Player.Trophys >= 2300) {
			Player.Arena = 8;
			Arena.sprite = Arena8;
		} if (Player.Trophys >= 2600) {
			Player.Arena = 9;
			Arena.sprite = Arena9;
		} if (Player.Trophys >= 3000) {
			Player.Arena = 10;
			Arena.sprite = Arena10;
		} if (Player.Trophys >= 3400) {
			Player.Arena = 11;
			Arena.sprite = Arena11;
		} if (Player.Trophys >= 3800) {
			Player.Arena = 12;
			Arena.sprite = Arena12;
		} if (Player.Trophys >= 4000) {
			Player.Arena = 13;
			Arena.sprite = League1;
		} if (Player.Trophys >= 4300) {
			Player.Arena = 14;
			Arena.sprite = League2;
		} if (Player.Trophys >= 4600) {
			Player.Arena = 15;
			Arena.sprite = League3;
		} if (Player.Trophys >= 4900) {
			Player.Arena = 16;
			Arena.sprite = League4;
		} if (Player.Trophys >= 5200) {
			Player.Arena = 17;
			Arena.sprite = League5;
		} if (Player.Trophys >= 5500) {
			Player.Arena = 18;
			Arena.sprite = League6;
		} if (Player.Trophys >= 5800) {
			Player.Arena = 19;
			Arena.sprite = League7;
		} if (Player.Trophys >= 6100) {
			Player.Arena = 20;
			Arena.sprite = League8;
		} if (Player.Trophys >= 6400) {
			Player.Arena = 21;
			Arena.sprite = League9;
		}
	}
}
