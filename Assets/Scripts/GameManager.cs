using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// ---------------------------

	public GameObject deathlifeManager;
	public GameObject Obake;
	private DeathLifeManager deathorlife;
	private bool isDeathorLife;

	// ---------------------------

	// Use this for initialization
	void Start () {
		deathorlife = deathlifeManager.GetComponent<DeathLifeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ( deathorlife.DeathMode ) {
			if (!GameObject.Find ("Obake(Clone)")) {
				Instantiate (Obake);
			}
		}

		if (deathorlife.LifeMode) {
			if (GameObject.Find ("Obake(Clone)")) { // deathMode -> LifeMode になったときにお化けを消去
				Destroy (GameObject.Find ("Obake(Clone)"));
			}
		}
	}
}
