using UnityEngine;
using System.Collections;

public class SpearTrupControllar : MonoBehaviour {

    private bool falg = false;

    public int speed = 30;
	private GameObject fadeManager;

	// Use this for initialization
	void Start () {
		fadeManager = GameObject.Find ("Stair");
	}
	
	// Update is called once per frame
	void Update () {
		if (falg && this.transform.position.y <= 6.4f)
        {
			falg = false;
            transform.Translate(Vector3.up * (Time.deltaTime * speed));
        }

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
		{
            falg = true;
			StartCoroutine (InObakeGameOver ());
        }
    }

	IEnumerator InObakeGameOver() {
		fadeManager.GetComponent<FadeManager> ().isEndFade = true;
		yield return new WaitForSeconds (1);
		fadeManager.GetComponent<FadeManager> ().isFade = true;
	}
}
