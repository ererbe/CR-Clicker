using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour {

	public GameObject FaderGameObject;
	public GameObject KasernGameObject;
	public Image img;
	public Image img2;
	public AnimationCurve curve;
	public AnimationCurve curve2;

	public float fadeTime = 1f;

	void Start () {
		img.color = new Color (0f, 0f, 0f, 255f);
	}

	public void StartFade ()
	{
		StartCoroutine(FadeIn());
	}

	IEnumerator FadeIn ()
	{
		float t = fadeTime;

		while (t > 0f)
		{
			t -= Time.deltaTime;
			float a = curve.Evaluate(t);
			img.color = new Color (0f, 0f, 0f, a);
			float b = curve2.Evaluate (t);
			img2.color = new Color (255f, 255f, 255f, b);
			yield return 0;
		}

		FaderGameObject.SetActive (false);
	}
}
