﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

    public static GamePlayController instance;


    [SerializeField]
    private Text scoreText, coinText, lifeText, gameOverScoreText, GameOverCoinText;


    [SerializeField]
    private GameObject pausePanel, gameOverPanel;

    [SerializeField]
    private GameObject readyButton;
    // Use this for initialization
    void Awake () {
        MakeInstance();
	}

    void Start()
    {
        Time.timeScale = 0f;
    }
	
	// Update is called once per frame
	void MakeInstance () {
	    if(instance == null)
        {
            instance = this;
        }
	}

    public void GameOverShowPanel(int finalScore, int finalCoinScore)
    {
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = finalScore.ToString();
        GameOverCoinText.text = finalCoinScore.ToString();
        StartCoroutine(GameOverLoadMainMenue());
    }

    IEnumerator GameOverLoadMainMenue()
    {
        yield return new WaitForSeconds(3f);
        
        SceneFader.instance.LoadLevel("MainMenue");
    }

    public void PlayerDiedRestartTheGame()
    {
        StartCoroutine(PlayerDiedRestart());
    }

    IEnumerator PlayerDiedRestart()
    {
        yield return new WaitForSeconds(1f);
        SceneFader.instance.LoadLevel("Gameplay");
    }


    public void SetScore (int Score)
    {
        scoreText.text = "x" + Score;
    }

    public void SetCoinScore (int coinScore)
    {
        coinText.text = "x" + coinScore;
    }

    public void SetLifeScore(int lifeScore)
    {
        lifeText.text = "x" + lifeScore;
    }

    public void PauseTheGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ResumeTheGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneFader.instance.LoadLevel("MainMenue");
    }

    public void StartTheGame()
    {
        Time.timeScale = 1f;
        readyButton.SetActive(false);
    }

}
