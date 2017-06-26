using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantHammer2 : MonoBehaviour {

	public GameObject Hammer2;

	// Use this for initialization

	public float XPosR = 3.2f;
	public float YPosR = 3.2f;

	void Start(){

		InvokeRepeating("Generate", 2.0f, 1.0f);
		InvokeRepeating("Destroy", 2.0f, 1.0f);
	}

	void Generate(){
		YPosR += 8f;
		GameObject.Instantiate (Hammer2, new Vector3 (XPosR, YPosR, -1), Quaternion.identity);
	}
}
