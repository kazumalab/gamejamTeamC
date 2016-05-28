using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// --------------------------

	public GameObject heads;
	public GameObject hunmer;

	public Canvas HaveItemList;
	public Sprite[] Itemimages;
	public GameObject item;

	private Animator anim;

	// --------------------------

	void Start () {
		anim = hunmer.GetComponent<Animator> ();
	}
	
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (new Vector3 ((float)Screen.width / 2f, (float)Screen.height / 2f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 3)) {
			if (Input.GetMouseButton (0)) {
				SwingHummer (hit.collider.gameObject);
			}

		}



		Vector2 mouseSpeed = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));
		PlayerCameraRotate (mouseSpeed);
		PlayerMove ();
	}


	void PlayerCameraRotate(Vector2 v) {
		
		heads.transform.Rotate (new Vector3 (0, v.x, 0));
		transform.Rotate (new Vector3 (-v.y, 0, 0));
	}

	void PlayerMove() {
		float dx = Input.GetAxis ("Vertical");
		heads.transform.position += heads.transform.TransformDirection (Vector3.forward) * dx / 10f;
	}

	void SwingHummer(GameObject obj) {
		anim.SetTrigger ("attack");
		if (obj != null) {
			
			Sprite sprite = obj.GetComponent<Image> ().sprite;
			Destroy (obj);

			// ここにアイテムボタンを生成コードを入れる
			GameObject items = (GameObject)Instantiate(item);
			items.GetComponent<Button> ().image.sprite = sprite;
			items.transform.parent = HaveItemList.transform;
		}
	}

}
