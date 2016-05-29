using UnityEngine;
using System.Collections;

public class SwitchTrup : MonoBehaviour {

    private int OnTiem;

    //IEnumerator PushButton()
    //{
    //    yield return new WaitForSeconds(5);
    //    if(){

    //    }
    //}

    //void buttonPush(){
    //    Start cornrutime(PushButton());

    //}

	// Use this for initialization
	void Start () {
        OnTiem = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
        

	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (++OnTiem > 10)
            {
                other.transform.Translate(Vector3.down * 15);
            }
        }

    }

}
