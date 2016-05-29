using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour { // ここでゲームオーバー処理とクリア処理

	public bool isFade = false;
	private float count = 1f;



	public bool isFastFade;
	public bool isEndFade = false;
	public bool isDeathEnd = false;

	public Image FadeImage;

	public Image HaveNotKey;

	// Use this for initialization
	void Start () {
		isFade = true;
		isFastFade = true;
		setAlpha (FadeImage, count);
	}

	void Update () {
		if (HaveNotKey != null) {
			//HaveNotKey.gameObject.SetActive (false);
		}
		if (isFastFade) {
			FadeIn (FadeImage);
		}

		if (isEndFade) {
			FadeOut (FadeImage);
		}

		if (isDeathEnd) {
			FadeOut (FadeImage);
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) { // Goalにたどり着いたとき
		if (col.gameObject.tag == "Player") {
			if (col.transform.GetComponentInChildren<PlayerController> ().haveKey) {
				GameManager.Score++; // is static
				isFade = true;
				isEndFade = true;
			} else { 
				HaveNotKey.gameObject.SetActive (true);
			}
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Player") {
			HaveNotKey.gameObject.SetActive (false);
		}
	}

	void setAlpha(Image image,float alpha) {
		image.color = new Color (image.color.r, image.color.g, image.color.b, alpha);
	}

	public void FadeOut(Image image) {
		if (isFade) {
			count += 0.025f;
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				isFade = false;
				if (isEndFade) {
					SceneManager.LoadScene (1);
				} else if (isDeathEnd) {
					SceneManager.LoadScene (2);
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
