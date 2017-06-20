using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCopter : MonoBehaviour {
	public float speed = 5;

	Rigidbody2D myBody = null;

	void Awake()
	{
		
	}
	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D> ();
		LevelController.current.setStartPosition (transform.position);

	}
		
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
	}
	void FixedUpdate (){
		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		//Animator animator = GetComponent<Animator> ();

		float value = Input.GetAxis ("Horizontal");
		if (Mathf.Abs (value) > 0) {
			Vector2 vel = myBody.velocity;
			vel.x = value * speed;
			myBody.velocity = vel;
		}
		if(value < 0) {
			
			sr.flipX = false;

			//transform.Translate(Vector3.left * Time.deltaTime*10, Space.World);
		} else if(value > 0) {
			
			sr.flipX = true;
			//transform.Translate(Vector3.right * Time.deltaTime*10, Space.World);
		}


		/*
		 * 
		if (this.dead){
			animator.SetBool("dead", true);
			timeToWait -= Time.deltaTime;

			if (currentHealth > 0) {
				if (timeToWait <= 0) {
					dead = false;
					animator.SetBool ("dead", false);
					//LevelControll.current.onRabbitDeath (this);
					StartCoroutine ("dead");

				} else { 
					return;
				}
			} else if (currentHealth <= 0){
				if (timeToWait <= 0) {
					animator.SetBool("dead", true);

					this.GetComponent<BoxCollider2D>().isTrigger = true;
					if (myBody != null) 
						Destroy(myBody);
					
					currentHealth = 1;

					//yield return new WaitForSeconds(3.0f);

					animator.SetBool("dead", false);

					//LevelControll.current.onRabbitDeath(this);

					this.GetComponent<BoxCollider2D>().isTrigger = false;
					myBody = this.gameObject.AddComponent<Rigidbody2D>();
					myBody.freezeRotation = true;

					//////////////////////////needs changing!
					/// 
				}
			}

		}




		*/
			

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
