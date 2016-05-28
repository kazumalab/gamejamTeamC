using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageCreate : MonoBehaviour {

    public GameObject[] walls;

    private GameObject[] wallsChild_1;
    private GameObject[] wallsChild_2;
    private GameObject[] wallsChild_3;
    private GameObject[] wallsChild_4;
    private GameObject[] wallsChild_5;
    private GameObject[] wallsChild_6;
    private GameObject[] wallsChild_7;
    private GameObject[] wallsChild_8;
    private GameObject[] wallsChild_9;

	// Use this for initialization
	void Start () {
        wallsChild_1 = new GameObject[walls.Length];
        wallsChild_2 = new GameObject[walls.Length];
        wallsChild_3 = new GameObject[walls.Length];
        wallsChild_4 = new GameObject[walls.Length];
        wallsChild_5 = new GameObject[walls.Length];
        wallsChild_6 = new GameObject[walls.Length];
        wallsChild_7 = new GameObject[walls.Length];
        wallsChild_8 = new GameObject[walls.Length];
        wallsChild_9 = new GameObject[walls.Length];
        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                Debug.Log(walls[0].transform.FindChild("point(z:" + z.ToString() + ")").gameObject);
                wallsChild_1[i] = walls[0].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_2[i] = walls[1].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_3[i] = walls[2].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_4[i] = walls[3].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_5[i] = walls[4].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_6[i] = walls[5].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_7[i] = walls[6].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_8[i] = walls[7].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int z = -200; z < 200; z += 50)
            {
                wallsChild_9[i] = walls[8].transform.FindChild("point(z:" + z.ToString() + ")").gameObject;
            }
        }

        

	}

    // Update is called once per frame
    void Update()
    {
        
	
	}
}
