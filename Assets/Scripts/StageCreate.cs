using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageCreate : MonoBehaviour {

	public GameObject wallprefab;

    public GameObject[] walls;

	public GameObject[] wallsChild_1;
	public GameObject[] wallsChild_2;
	public GameObject[] wallsChild_3;
	public GameObject[] wallsChild_4;
	public GameObject[] wallsChild_5;
	public GameObject[] wallsChild_6;
	public GameObject[] wallsChild_7;
	public GameObject[] wallsChild_8;
	public GameObject[] wallsChild_9;

	private int i = 0;
	private int ran = 0;
	private int beforran = 1;

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

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_1 [i] = walls [0].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_2 [i] = walls [1].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_3 [i] = walls [2].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_4 [i] = walls [3].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_5 [i] = walls [4].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_6 [i] = walls [5].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_7 [i] = walls [6].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_8 [i] = walls [7].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		ResetI ();
		for (int z = -200; z < 250; z += 50) {
			wallsChild_9 [i] = walls [8].transform.FindChild ("point(z:" + z.ToString () + ")").gameObject;
			i++;
		}
        

		for (int i = 0; i < 9; i++)
		{
			ran = Random.Range (1, 5);
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			Instantiate (wallprefab, wallsChild_1[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_2[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_3[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_4[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_5[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_6[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_7[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_8[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}

		for (int i = 0; i < 9; i++)
		{
			if (ran == 1 || ran == 2) {
				if (beforran == ran + 2) {
					ran++;
				}
			} else if (ran == 3 || ran == 4) {
				if (beforran == ran - 2) {
					ran++;
				}
			}
			beforran = ran;
			ran = Random.Range (1, 5);
			Instantiate (wallprefab, wallsChild_9[i].transform.position, Quaternion.Euler(wallprefab.transform.rotation.x, wallprefab.transform.rotation.y + 90f * ran, wallprefab.transform.rotation.z));
			i++;
		}
	}

	void ResetI() {
		i = 0;
	}

    // Update is called once per frame
    void Update()
    {
        
	
	}
}
