using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	public MyButton PlayButton;

	void Start () {
		PlayButton.signalOnClick.AddListener (this.onPlay);
	}
	void onPlay() {
		//Do something
		SceneManager.LoadScene("GameScene");
	}
}
