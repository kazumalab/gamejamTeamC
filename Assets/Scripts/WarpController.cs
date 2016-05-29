using UnityEngine;
using System.Collections;

public class WarpController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") { 
			other.transform.GetComponentInChildren<PlayerController> ().deathlifeManager.GetComponent<DeathLifeManager> ().isFadeOn = true;
		}
	}
}
