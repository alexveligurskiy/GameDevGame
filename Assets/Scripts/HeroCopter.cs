using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCopter : MonoBehaviour {
	public float speed = 5;
	int value = 0;
	Rigidbody2D myBody = null;

	void Awake()
	{
		
	}
	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D> ();
		LevelController.current.setStartPosition (transform.position);
		GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
	}
		
	// Update is called once per frame
	void Update () {
		
		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		if (Input.GetMouseButtonDown (0)) {
			if (value == 0) {

				sr.flipX = true;
				GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
				value++;

			} else if (value == 1) {

				sr.flipX = false;
				GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
				value--;

			}
		}
			
		transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
	}

	static void SetNewParent(Transform obj, Transform new_parent) {
		if(obj.transform.parent != new_parent) {
			//Засікаємо позицію у Глобальних координатах
			Vector3 pos = obj.transform.position;
			//Встановлюємо нового батька
			obj.transform.parent = new_parent;
			//Після зміни батька координати кролика зміняться
			//Оскільки вони тепер відносно іншого об’єкта
			//повертаємо кролика в ті самі глобальні координати
			obj.transform.position = pos;
		}
	}

}
