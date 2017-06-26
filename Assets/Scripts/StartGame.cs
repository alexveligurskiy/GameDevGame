using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	public MyButton PlayButton;
	public MyButton PauseButton;
	public GameObject Window;
	void Start () {
		PlayButton.signalOnClick.AddListener (this.onPlay);
		PauseButton.signalOnClick.AddListener(this.onPause);
	}
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed");
			Time.timeScale = 1;
			GameObject obj = GameObject.Find("UI Root").AddChild(this.Window);

			obj.transform.position = this.transform.position;
			obj.transform.position += new Vector3(-9.0f, -4.0f, 0.0f);

			PauseWindow Window = obj.GetComponent<PauseWindow>();
		}
	}
	void onPlay() {
		//Do something
		SceneManager.LoadScene("GameScene");
		Time.timeScale = 1;
	}
	void onPause(){

		Time.timeScale = 1;
		GameObject obj = GameObject.Find("UI Root").AddChild(this.Window);

		obj.transform.position = this.transform.position;
		obj.transform.position += new Vector3(-9.0f, -4.0f, 0.0f);

		PauseWindow Window = obj.GetComponent<PauseWindow>();


	}
}
