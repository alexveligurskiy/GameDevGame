using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathHere : MonoBehaviour {
	
	public GameObject Window;

	public void onCopterDeath(HeroCopter copter) {
		//При смерті кролика повертаємо на початкову позицію
		//copter.transform.position = this.startingPosition;
		SceneManager.LoadScene("EndScene");
		Time.timeScale = 1;
	}
	//Стандартна функція, яка викличеться,
	//коли поточний об’єкт зіштовхнеться із іншим
	void OnTriggerEnter2D(Collider2D collider) {
		
		HeroCopter copter = collider.GetComponent<HeroCopter> ();

		if(copter != null) {
			//Повідомляємо рівень, про смерть кролика

			onCopterDeath (copter);

		}
	}

}