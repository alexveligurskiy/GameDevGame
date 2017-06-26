using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour {

	public MyButton PauseButton;
	public GameObject Window;
	void Start () {
		
		PauseButton.signalOnClick.AddListener(this.onPause);
	}
	void onPlay() {
		//Do something
		//SceneManager.LoadScene("GameScene");
	}
	void onPause(){

		Time.timeScale = 0;
		GameObject obj = GameObject.Find("UI Root").AddChild(this.Window);

		obj.transform.position = this.transform.position;
		obj.transform.position += new Vector3(-9.0f, -4.0f, 0.0f);

		PauseWindow Window = obj.GetComponent<PauseWindow>();


	}
}
