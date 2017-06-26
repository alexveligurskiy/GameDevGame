using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantLeft : MonoBehaviour {
	public GameObject LeftLattice;

	// Use this for initialization
	public float XPosL = -6.5f;
	public float YPosL = 4f;



	void Start(){
		
		InvokeRepeating("Generate", 2.0f, 1.5f);
	}

	void Generate(){
		YPosL += 8f;
		GameObject.Instantiate (LeftLattice, new Vector3 (XPosL, YPosL, -1), Quaternion.identity);
	}

}
