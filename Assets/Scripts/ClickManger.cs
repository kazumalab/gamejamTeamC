using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickManger : MonoBehaviour {

	public GameObject fadeManager;
	public Image fade;
	private bool isFade = false;
	private float count = 0f;

	public GameObject HowToCanvas;

	private int SceneNumber = 1;


	// Use this for initialization
	void Update () {
		FadeOut (fade, SceneNumber);
	}
	
	// Update is called once per frame
	public void OnClickStart () {
		SceneNumber = 1;
		isFade = true;
	}

	public void ClickHowToPlay() {
		HowToCanvas.SetActive (true);
	}

	public void OnReturnTitle () {
		SceneNumber = 0;
		isFade = true;
	}

	void setAlpha(Image image,float alpha) {
		image.color = new Color (image.color.r, image.color.g, image.color.b, alpha);
	}

	public void FadeOut(Image image, int num) {
		if (isFade) {
			count += 0.025f;
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				isFade = false;
				SceneManager.LoadScene (num);
			}
		}
	}
}
