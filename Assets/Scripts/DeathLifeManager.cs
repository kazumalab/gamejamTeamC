using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathLifeManager : MonoBehaviour {

	// ---------------------------

	private float count = 0f;
	private bool isAlphaTop = false;
	public bool isFadeOn = false; // trueにするだけでフェードイン発動

	[Header("--フェードに使う--")]
	public Image fadeImage;

	// ---------------------------

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		FadeInAndOut (fadeImage);
	}


	void setAlpha(Image image,float alpha) {
		image.color = new Color (image.color.r, image.color.g, image.color.b, alpha);
	}

	void FadeInAndOut(Image image) {
		if (isFadeOn) {
			if (!isAlphaTop) {
				count += 0.025f;
			} else {
				count -= 0.025f;
				if (image.color.a <= 0f) {
					isFadeOn = false;
					isAlphaTop = false;
				}
			}
			setAlpha (image, count);
			if (image.color.a >= 1f) {
				isAlphaTop = true;
			}
		}
	}
}
