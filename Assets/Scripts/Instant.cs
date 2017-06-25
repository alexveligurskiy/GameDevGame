using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour {
	public GameObject LeftLattice;// = new GameObject ();
	//public GameObject RightLattice;// = new GameObject ();
	// Use this for initialization
	public float XPos = -6.5f;
	public float YPos = 4f;
	public int totalNumber = 5;
	void Start(){
		for(int i=0; i<totalNumber; i++)
		{
			// Use Random.Range to grab randomized x,y and z values within our min/max ranges:
			//var randomX : int = Random.Range(minX, maxX);
			//var randomY : int = Random.Range(minY, maxY);

			YPos += 4f;

			GameObject.Instantiate(LeftLattice,new Vector3(XPos,YPos,-1),Quaternion.identity);  
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
