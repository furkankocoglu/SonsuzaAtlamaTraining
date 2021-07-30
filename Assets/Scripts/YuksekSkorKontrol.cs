using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YuksekSkorKontrol : MonoBehaviour {
	[SerializeField]
	private Text skorTxt,altinSkorTxt;
	// Use this for initialization
	void Start () {
		AyarlaZorlukSeviyesineGoreSkor ();
	}
	void SkorAyarla(int skor,int altinSkor){
		skorTxt.text = skor.ToString ();
		altinSkorTxt.text = altinSkor.ToString ();
	}

	void AyarlaZorlukSeviyesineGoreSkor(){
		if (OyunTercihleri.GetirKolayZorlukDurumu()==1) {
			SkorAyarla (OyunTercihleri.GetirKolayZorlukYuksekSkor(),OyunTercihleri.GetirKolayZorlukAltinSkor());
		}
		if (OyunTercihleri.GetirNormalZorlukDurumu()==1) {
			SkorAyarla (OyunTercihleri.GetirNormalZorlukYuksekSkor(),OyunTercihleri.GetirNormalZorlukAltinSkor());
		}
		if (OyunTercihleri.GetirYuksekZorlukDurumu()==1) {
			SkorAyarla (OyunTercihleri.GetirYuksekZorlukYuksekSkor(),OyunTercihleri.GetirYuksekZorlukAltinSkor());
		}
	}

	public void AnaMenuyeDon(){
		Application.LoadLevel ("MainMenu");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
