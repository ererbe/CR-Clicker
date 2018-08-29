using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartDebugger : MonoBehaviour {

	public Fader fader;
	public GameObject KasernGameObject;
	public GameObject BuilderGameObject;
	public float DebugTime = 1f;

	public GameObject GameStartDebuggerGameObject;

	void Start () {
		StartCoroutine (KasernDebug());
	}

	IEnumerator KasernDebug ()
	{
		float t = DebugTime;

		while (t > 0f)
		{
			t -= Time.deltaTime;
			yield return 0;
		}

		KasernGameObject.SetActive (true);
		KasernGameObject.SetActive (false);
		BuilderGameObject.SetActive (true);
		BuilderGameObject.SetActive (false);

		fader.StartFade ();

		GameStartDebuggerGameObject.SetActive (false);
	}
}
