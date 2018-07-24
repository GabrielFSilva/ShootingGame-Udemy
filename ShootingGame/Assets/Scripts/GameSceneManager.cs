using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour {

    //Objects
	public GameObject textTimerObj;
    public GameObject textScoreObj;
    public CrossHair crossHair;
    public Bazooka bazooka;
    public CanvasGroup gameOverPanel;

    //Timer
    private Text textTimer;
	private int gameTime = 150;
	private int timeMinutes;
	private int timeSeconds;
	private string timeString;

    //Shoots
    private Text textScore;

	// Use this for initialization
	void Start () {
		textTimer = textTimerObj.GetComponent<Text> ();
        textScore = textScoreObj.GetComponent<Text> ();
		InvokeRepeating ("TimeCounter", 0f, 1f);
        textScore.text = bazooka.enemiesKilled.ToString() + " / " + bazooka.roundsShot.ToString();
	}

	private void TimeCounter() {
		if (gameTime >= 0)
		{
			timeMinutes = (int)(gameTime / 60);
			timeSeconds = gameTime % 60;
			timeString = timeMinutes.ToString ("D1") + "\' " + timeSeconds.ToString ("D2") + "\"";

			textTimer.text = timeString;
			gameTime -= 1;
		} 
		else
		{
            Time.timeScale = 0f;
            bazooka.paused = true;
            crossHair.paused = true;
            gameOverPanel.alpha = 1f;
            gameOverPanel.interactable = true;
            gameOverPanel.blocksRaycasts = true;

        }
	}
	// Update is called once per frame
	void Update () {
        textScore.text = bazooka.enemiesKilled.ToString() + " / " + bazooka.roundsShot.ToString();
    }

    public void RestartAction()
    {
        gameTime = 150;
        Time.timeScale = 1f;
        bazooka.roundsShot = 0;
        bazooka.enemiesKilled = 0;
        bazooka.paused = false;
        crossHair.paused = false;
        gameOverPanel.alpha = 0f;
        gameOverPanel.interactable = false;
        gameOverPanel.blocksRaycasts = false;
        TimeCounter();
    }
}
