using UnityEngine;
using System.Collections;

public class SpearTrupControllar : MonoBehaviour {

    private bool falg = false;

    public int speed = 12;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (falg == true && transform.position.y < 6)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * speed) );
        }

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //transform.Translate(Vector3.up * 5);
            falg = true;

        }
    }
}
