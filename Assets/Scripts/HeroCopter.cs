using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeroCopter : MonoBehaviour {
	public static HeroCopter current;
	public float speed = 5;
	int value = 0;

	public UILabel CountScore;

	int count;
	Rigidbody2D myBody = null;

	void Awake()
	{
		current = this;
	}
	Vector3 startingPosition;


	public void setStartPosition(Vector3 pos) {
		this.startingPosition = pos;
	}
	// Use this for initialization
	void Start () {
		//count = 0;
		SetCountText ();



		myBody = this.GetComponent<Rigidbody2D> ();
		current.setStartPosition (transform.position);
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

	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.gameObject.CompareTag ("Coin")){
			collider.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
	public void SetCountText (){
		CountScore.text = count.ToString ();

	}
}
