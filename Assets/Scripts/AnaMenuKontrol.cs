using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnaMenuKontrol : MonoBehaviour {
	[SerializeField]
	private Button muzikBtn;
	[SerializeField]
	private Sprite[] muzikAcikKapali;
	// Use this for initialization
	void Start () {
		if (OyunTercihleri.GetirMuzikDurumu()==1) {
			MuzikKontrol.ornek.OynatMuzik (true);
			muzikBtn.image.sprite = muzikAcikKapali [1];
		} 
		else {
			MuzikKontrol.ornek.OynatMuzik (false);
			muzikBtn.image.sprite = muzikAcikKapali [0];
		}
	}
	public void OyunuBaslat(){
		OyunYoneticisi.ornek.oyunAnaMenudenBaslatildi = true;
		OyunYoneticisi.ornek.oyunKarakterOlunceTekrarBasladi = false;
		SahneGecis.ornek.LoadLevel ("oyunDort");
        GoogleMobileAdsDeno.bannerView.Destroy();
	}
	public void HighScore(){
		Application.LoadLevel ("YuksekSkor");
        GoogleMobileAdsDeno.bannerView.Destroy();
    }
	public void Options(){
		Application.LoadLevel ("Ayarlar");
        GoogleMobileAdsDeno.bannerView.Destroy();
    }
	public void OyunuKapat(){
		Application.Quit ();
	}
	public void MuzikButton(){
		if (OyunTercihleri.GetirMuzikDurumu()==0) {
			OyunTercihleri.AyarlaMuzikDurumu (1);
			MuzikKontrol.ornek.OynatMuzik (true);
			muzikBtn.image.sprite = muzikAcikKapali [1];
		}
		else if (OyunTercihleri.GetirMuzikDurumu()==1) {
			OyunTercihleri.AyarlaMuzikDurumu (0);
			MuzikKontrol.ornek.OynatMuzik (false);
			muzikBtn.image.sprite = muzikAcikKapali [0];
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
