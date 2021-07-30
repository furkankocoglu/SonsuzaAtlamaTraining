using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SahneGecis : MonoBehaviour {
	public static SahneGecis ornek;
	[SerializeField]
	private GameObject fadePanel;
	[SerializeField]
	private Animator fadeAnim;

	void Awake(){
		TekYap ();
	}

	void TekYap(){
		if (ornek!=null) {
			Destroy (gameObject);
		} else {
			ornek = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void LoadLevel(string bolum){
		StartCoroutine (FadeInOut(bolum));
	}

	IEnumerator FadeInOut(string bolum){
		fadePanel.SetActive (true);
		fadeAnim.Play ("FadeIn");
		yield return StartCoroutine (YeniCoroutine.GercekZamaniBekle (1f));
		Application.LoadLevel (bolum);
		fadeAnim.Play ("FadeOut");
		yield return StartCoroutine(YeniCoroutine.GercekZamaniBekle(.7f));
		fadePanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
