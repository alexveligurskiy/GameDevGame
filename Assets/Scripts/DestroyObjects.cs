using UnityEngine;
using System.Collections;

public class DestroyObjects : MonoBehaviour {

	void OnBecameInvisible(){
		
		Debug.Log(this.gameObject.name);
		Destroy(this.gameObject);
	}
}