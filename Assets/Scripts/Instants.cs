using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instants : MonoBehaviour {
	public GameObject LeftLattice;
	public GameObject RightLattice;
	public GameObject Hammer1;
	public GameObject Hammer2;
	public GameObject Coin;
	// Use this for initialization
	//public float XPosLL = -10f;
	public float YPos = 4f;


	//public float XPosRL = 9f;

	// Use this for initialization


	//public float XPosLH = -4f;



	//public float XPosRH = 3f;

	void Start(){
		
		InvokeRepeating("Generate", 2.0f, 1.5f);
	}

	void Generate(){
		YPos += 10f;
		int r = Random.Range (-12, -6);
		GameObject.Instantiate (LeftLattice, new Vector3 (r, YPos, -1), Quaternion.identity);
		GameObject.Instantiate (RightLattice, new Vector3 (r+19, YPos, -1), Quaternion.identity);
		GameObject.Instantiate (Hammer1, new Vector3 (r+6, YPos, -1), Quaternion.identity);
		GameObject.Instantiate (Hammer2, new Vector3 (r+13, YPos, -1), Quaternion.identity);
		GameObject.Instantiate (Coin, new Vector3 (r+9.5f, YPos, -1), Quaternion.identity);
	}

}
