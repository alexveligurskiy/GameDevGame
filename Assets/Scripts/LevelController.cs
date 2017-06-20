using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	public static LevelController current;

	Vector3 startingPosition;

	void Awake() {
		current = this;
	}
	public void setStartPosition(Vector3 pos) {
		this.startingPosition = pos;
	}
	public void onCopterDeath(HeroCopter copter) {
		//При смерті кролика повертаємо на початкову позицію
		copter.transform.position = this.startingPosition;
	}

}