using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OynanabilirlikKontrol : MonoBehaviour {
	[SerializeField]
	private GameObject durdurPanel,oyunSonuPanel;
	[SerializeField]
	private GameObject hazirBtn;
	[SerializeField]
	private Text skorText, altinText, canText,oyunSonuSkorText,oyunSonuAltinText;
	public static OynanabilirlikKontrol ornek;

	void Start(){

		Time.timeScale = 0f;
	}

	void Awake(){
		OrnekYap ();
	}

	void OrnekYap(){
		if (ornek==null) {
			ornek = this;
		}
	}

	public void SkorHesapla(int skor){
		skorText.text = "x" + skor;
	}

	public void AltinHesapla(int altinSkor){
		altinText.text = "x" + altinSkor;
	}

	public void CanHesapla(int canSkor){
		canText.text = "x" + canSkor;
	}

	public void OyunuDurdur(){
		Time.timeScale = 0f;
		durdurPanel.SetActive (true);
	}

	public void OyunuSurdur(){
		Time.timeScale = 1f;
		durdurPanel.SetActive (false);
	}

	public void OyunuKapat(){
		Time.timeScale = 1f;
		SahneGecis.ornek.LoadLevel ("MainMenu");
	}

	public void OyunSonuPanelAc(int sonSkor,int sonAltinSkor){
		oyunSonuPanel.SetActive (true);
		oyunSonuSkorText.text = sonSkor.ToString ();
		oyunSonuAltinText.text = sonAltinSkor.ToString ();
		StartCoroutine (OyunSonuPanelYukle());
	}

	IEnumerator OyunSonuPanelYukle(){
		yield return new WaitForSeconds (3f);
		SahneGecis.ornek.LoadLevel ("MainMenu");
	}

	public void KarakterOlunceOyunuYenidenBaslat(){
		StartCoroutine (KarakterOlunceYenidenBaslat());
	}

	IEnumerator KarakterOlunceYenidenBaslat(){
		yield return new WaitForSeconds (1f);
		SahneGecis.ornek.LoadLevel ("oyunDort");
	}

	public void OyunuBaslat(){
		Time.timeScale = 1f;
		hazirBtn.SetActive (false);
	}
}
