using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour {

	public HeroCopter copter;

	void Update () {
		//Отримуємо доступ до компонента Transform
		//це Скорочення до GetComponent<Transform>
		Transform copter_transform = copter.transform;

		//Отримуємо доступ до компонента Transform камери
		Transform camera_transform = this.transform;

		//Отримуємо доступ до координат кролика
		Vector3 copter_position = copter_transform.position;
		Vector3 camera_position = camera_transform.position;

		//Рухаємо камеру тільки по X,Y
		//camera_position.x = copter_position.x;
		camera_position.y = copter_position.y;

		//Встановлюємо координати камери
		camera_transform.position = camera_position;
	}
}