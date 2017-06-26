using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantHammer1 : MonoBehaviour {
	public GameObject Hammer1;

	// Use this for initialization

	public float XPosL = -3.2f;
	public float YPosL = 3.2f;

	void Start(){

		InvokeRepeating("Generate", 2.0f, 1.0f);
		InvokeRepeating("Destroy", 2.0f, 1.0f);
	}

	void Generate(){
		YPosL += 8f;
		GameObject.Instantiate (Hammer1, new Vector3 (XPosL, YPosL, -1), Quaternion.identity);
	}
}
