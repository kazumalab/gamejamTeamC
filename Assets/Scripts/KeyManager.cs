using UnityEngine;
using System.Collections;

public class KeyManager : MonoBehaviour {
	private GameObject deathlifeManager;
	// Use this for initialization
	void Start () {
		deathlifeManager = GameObject.Find ("DeathLifeManager");
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Player") {
			if (!deathlifeManager.GetComponent<DeathLifeManager> ().DeathMode) { // death modeの場合は取れない
				this.transform.root.GetComponent<AudioSource>().Play();
				col.transform.GetComponentInChildren<PlayerController> ().haveKey = true;
				Destroy (this.gameObject);
			}
		}
	}
}
