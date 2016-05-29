using UnityEngine;
using System.Collections;

public class ObakeController : MonoBehaviour {

	private GameObject Player;
	private float speed = 20.0f;
	private GameObject FadeManager;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Heads");
		FadeManager = GameObject.Find ("Stair");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt (Player.transform.position);
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			Debug.Log ("hit");
			StartCoroutine (InObakeGameOver());
		}
	}

	IEnumerator InObakeGameOver() {
		yield return new WaitForSeconds (2);
		FadeManager.GetComponent<FadeManager> ().isFade = true;
		FadeManager.GetComponent<FadeManager> ().isEndFade = true;
	}
}
