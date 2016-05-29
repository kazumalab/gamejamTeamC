﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// ---------------------------

	public GameObject deathlifeManager;
	public GameObject Obake;

	public static int Score = 1;
	public Text scoreText;

	private DeathLifeManager deathorlife;
	private bool isDeathorLife;

	// ---------------------------

	// Use this for initialization
	void Start () {
		deathorlife = deathlifeManager.GetComponent<DeathLifeManager> ();
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = "現在 : " + Score + "階";

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
