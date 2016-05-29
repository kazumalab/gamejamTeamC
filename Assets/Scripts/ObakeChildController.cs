using UnityEngine;
using System.Collections;

public class ObakeChildController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + Mathf.Sin (Time.time) / 10f , this.transform.position.z);
	}
}
