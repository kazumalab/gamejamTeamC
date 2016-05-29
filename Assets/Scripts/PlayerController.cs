using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// --------------------------

	public GameObject heads;
	public GameObject deathlifeManager;
	public GameObject fadeManager;
	private CharacterController cc;
	public bool haveKey = false;
	public AudioClip voice;
	public Image keyss;


	// --------------------------

	void Start () {
		fadeManager = GameObject.Find ("Stair");
		cc = heads.GetComponent<CharacterController> ();
	}
	
	void Update () {

		Debug.Log (haveKey + "have key?");

		if (haveKey) {
			keyss.gameObject.SetActive (true);
		}

		Ray ray = Camera.main.ScreenPointToRay (new Vector3 ((float)Screen.width / 2f, (float)Screen.height / 2f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100)) {
			if (hit.collider.gameObject.tag == "Enemy") {
				if (Input.GetMouseButton (0)) {
					Destroy (hit.collider.gameObject);
				}
			}
            if (hit.collider.gameObject.tag == "Trup")
            {
                Destroy(hit.collider.gameObject);
				if (!deathlifeManager.GetComponent<DeathLifeManager> ().DeathMode) {
					fadeManager.GetComponent<FadeManager> ().isDeathEnd = true;
					this.GetComponent<AudioSource> ().clip = voice;
					StartCoroutine (DeathByFallStone ());
				}
            }
		}
			

		Vector3 v3 = new Vector3 (0, 0, 0);

		v3.y -= 1000f * Time.deltaTime;

		Vector2 mouseSpeed = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));
		PlayerCameraRotate (mouseSpeed);
		PlayerMove ();

		cc.Move (v3 * Time.deltaTime);

	}


	void PlayerCameraRotate(Vector2 v) {
			heads.transform.Rotate (new Vector3 (0, v.x, 0));
			transform.Rotate (new Vector3 (-v.y, 0, 0));
	}

	void PlayerMove() {
		if (!fadeManager.GetComponent<FadeManager> ().isDeathEnd) {
			float dx = Input.GetAxis ("Vertical");
			heads.transform.position += heads.transform.TransformDirection (Vector3.forward) * dx * 2;
		}
	}

	IEnumerator DeathByFallStone() {
		yield return new WaitForSeconds (2);
		this.GetComponent<AudioSource> ().Play ();
		fadeManager.GetComponent<FadeManager> ().isDeathEnd = true;
		fadeManager.GetComponent<FadeManager> ().isFade = true;
	}

//	void OnTriggerEnter(Collider col) {
//		if (col.gameObject.tag == "warp") {
//			deathlifeManager.GetComponent<DeathLifeManager> ().isFadeOn = true;
//		}
//	}

}
