using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantRight : MonoBehaviour {
	public GameObject RightLattice;

	// Use this for initialization

	public float XPosR = 6.5f;
	public float YPosR = 4f;

	void Start(){

		InvokeRepeating("Generate", 2.0f, 1.5f);
		//InvokeRepeating("Destroy", 2.0f, 1.5f);
	}

	void Generate(){
		YPosR += 8f;
		GameObject.Instantiate (RightLattice, new Vector3 (XPosR, YPosR, -1), Quaternion.identity);
	}
}
