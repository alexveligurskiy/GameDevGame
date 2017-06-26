using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseWindow : MonoBehaviour {

	public GameObject Window;
	public MyButton HomeButton;
	public MyButton RestartButton;


	void Start () {
		
		RestartButton.signalOnClick.AddListener (this.onRestart);
		HomeButton.signalOnClick.AddListener (this.onPlay);

	}
	void onPlay(){
		SceneManager.LoadScene("StartScene");
	}
	void onRestart() {
		//Do something
		SceneManager.LoadScene("GameScene");
		Time.timeScale = 1;
	}


}
