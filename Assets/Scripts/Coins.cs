using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	


	public GameObject Coin;

	public float XPosC = 0;
	public float YPosC = 4f;



	void Start(){

		InvokeRepeating("Generate", 2.0f, 1.5f);
	}

	void Generate(){
		YPosC += 8f;
		GameObject.Instantiate (Coin, new Vector3 (XPosC, YPosC, -1), Quaternion.identity);
	}

}
