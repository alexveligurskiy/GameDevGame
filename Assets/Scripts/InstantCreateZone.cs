using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantCreateZone : MonoBehaviour {
	
	public GameObject DeatZoneHoriz;
	// Use this for initialization

	public float XPosD = 0;
	public float YPosD = 4f;

	public int totalNumber = 5;
	void Start(){
		OnTriggerEnter2D ();

	}

	void OnTriggerEnter2D() {


		for (int i = 0; i < totalNumber; i++) {
			// Use Random.Range to grab randomized x,y and z values within our min/max ranges:
			//var randomX : int = Random.Range(minX, maxX);
			//var randomY : int = Random.Range(minY, maxY);


			YPosD += 8f;


			GameObject.Instantiate (DeatZoneHoriz, new Vector3 (XPosD, YPosD, -1), Quaternion.identity);

		}

	}
}
