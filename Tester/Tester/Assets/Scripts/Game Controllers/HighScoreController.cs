using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {


    [SerializeField]
    private Text scoreText, coinText;
	// Use this for initialization
	void Start () {
        SetTheScoreBasedOnDifficulty();
	}

    void SetScore(int score, int coinScore)
    {
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();
    }

    void SetTheScoreBasedOnDifficulty()
    {
        if(GamePreferences.GetEasyDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetEasyDifficultyScore(), GamePreferences.GetEasyDifficultyCoinScore());
        }

        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetMediumDifficultyScore(), GamePreferences.GetMediumDifficultyCoinScore());
        }

        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetHardDifficultyScore(), GamePreferences.GetHardDifficultyCoinScore());
        }
    }
	
	public void GoBackToMainMenue()
    {
        Application.LoadLevel("MainMenue");
    }
}
