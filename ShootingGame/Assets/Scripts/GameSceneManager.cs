using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour {

	public GameObject textTimerObj;
	private Text textTimer;
	private int gameTime = 150;

	private int timeMinutes;
	private int timeSeconds;
	private string timeString;
	// Use this for initialization
	void Start () {
		textTimer = textTimerObj.GetComponent<Text> ();
		InvokeRepeating ("TimeCounter", 0f, 1f);
	}

	private void TimeCounter() {
		if (gameTime > 0)
		{
			timeMinutes = (int)(gameTime / 60);
			timeSeconds = gameTime % 60;
			timeString = timeMinutes.ToString ("D1") + "\' " + timeSeconds.ToString ("D2") + "\"";

			textTimer.text = timeString;
			gameTime -= 1;
		} 
		else
		{
			Debug.Log ("Game Over");
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
