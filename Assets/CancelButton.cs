using UnityEngine;
using System.Collections;

public class CancelButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void PushCancelButton () {
		this.transform.root.gameObject.SetActive (false);
	}
}
