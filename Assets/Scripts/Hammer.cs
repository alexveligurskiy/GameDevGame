using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
	
	public float speed = 100f;


	void Update ()
	{
		transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}
}