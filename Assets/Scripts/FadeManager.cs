using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour {

	private bool isFade = false;
	private float count = 1f;


	private bool isFastFade;
	private bool isEndFade = false;

	public Image FadeImage;

	// Use this for initialization
	void Start () {
		isFade = true;
		isFastFade = true;
		setAlpha (FadeImage, count);
	}

	void Update () {
		if (isFastFade) {
			FadeIn (FadeImage);
		}

		if (isEndFade) {
			FadeOut (FadeImage);
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			isFade = true;
			isEndFade = true;
		}
	}

	void setAlpha(Image image,float alpha) {
		image.color = new Color (image.color.r, image.color.g, image.color.b, alpha);
	}

	void FadeOut(Image image) {
		if (isFade) {
			count += 0.025f;
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				isFade = false;
				if (isEndFade) {
					SceneManager.LoadScene (0);
				}
			}
		}
	}

	void FadeIn(Image image) {
		if (isFade) {
			count -= 0.025f;
			setAlpha (image, count);
			if (image.color.a <= 0f) {
				isFade = false;
				isFastFade = false;
			}
		}
	}

}
