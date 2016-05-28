using UnityEngine;
using System.Collections;

public class StornControllar : MonoBehaviour {

    private int Range = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            Destroy(this.GetComponent<Rigidbody>());
        }
        
    }
}
