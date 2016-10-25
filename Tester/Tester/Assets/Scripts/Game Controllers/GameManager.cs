using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [HideInInspector]
    public bool gameStartedFromMainMenue, gameRestartetAfterPlayerDied;


    [HideInInspector]
    public int score, coinScore, lifeScore;
	// Use this for initialization
	void Awake () {
        MakeSingleton();
	}

    void Start()
    {
        InitializeVatriables();
    }

    void OnLevelWasLoaded()
    {
        if (Application.loadedLevelName == "Gameplay") {
            if (gameRestartetAfterPlayerDied)
            {
                GamePlayController.instance.SetScore(score);
                GamePlayController.instance.SetCoinScore(coinScore);
                GamePlayController.instance.SetLifeScore(lifeScore);

                PlayerScore.scoreCount = score;
                PlayerScore.coinCount = coinScore;
                PlayerScore.lifeCount = lifeScore;
            }
            else if(gameStartedFromMainMenue)
            {

                PlayerScore.scoreCount = 0;
                PlayerScore.coinCount = 0;
                PlayerScore.lifeCount = 2;

                GamePlayController.instance.SetScore(0);
                GamePlayController.instance.SetCoinScore(0);
                GamePlayController.instance.SetLifeScore(2);
            }

        }
    }
	
	void InitializeVatriables()
    {
        if (!PlayerPrefs.HasKey("Game Initialized"))
        {
            GamePreferences.SetEasyDifficultyState(0);
            GamePreferences.SetEasyDifficultyCoinScore(0);
            GamePreferences.SetEasydDifficultyScore(0);

            GamePreferences.SetMediumDifficultyState(1);
            GamePreferences.SetMediumDifficultyCoinScore(0);
            GamePreferences.SetMediumDifficultyScore(0);

            GamePreferences.SetHardDifficultyState(0);
            GamePreferences.SetHardDifficultyCoinScore(0);
            GamePreferences.SetHardDifficultyScore(0);

            GamePreferences.SetMusicStatus(0);
            // really importent see if at top
            PlayerPrefs.SetInt("Game Initialized", 1);
        }
    }
   

	void MakeSingleton () {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    public void CheckGameStatus(int score, int coinScore, int lifeScore)
    {
        if (lifeScore < 0)
        {
            if(GamePreferences.GetEasyDifficultyState() == 1)
            {
                int highscore = GamePreferences.GetEasyDifficultyScore();
                int coinhighScore = GamePreferences.GetEasyDifficultyCoinScore();

                if(highscore < score)
                {
                    GamePreferences.SetEasydDifficultyScore(score);
                }
                if(coinhighScore < coinScore)
                {
                    GamePreferences.SetEasyDifficultyCoinScore(coinScore);
                }
            }

            if (GamePreferences.GetMediumDifficultyState() == 1)
            {
                int highscore = GamePreferences.GetMediumDifficultyScore();
                int coinhighScore = GamePreferences.GetMediumDifficultyCoinScore();

                if (highscore < score)
                {
                    GamePreferences.SetMediumDifficultyScore(score);
                }
                if (coinhighScore < coinScore)
                {
                    GamePreferences.SetMediumDifficultyCoinScore(coinScore);
                }
            }

            if (GamePreferences.GetHardDifficultyState() == 1)
            {
                int highscore = GamePreferences.GetHardDifficultyScore();
                int coinhighScore = GamePreferences.GetHardDifficultyCoinScore();

                if (highscore < score)
                {
                    GamePreferences.SetHardDifficultyScore(score);
                }
                if (coinhighScore < coinScore)
                {
                    GamePreferences.SetHardDifficultyCoinScore(coinScore);
                }
            }

            gameStartedFromMainMenue = false;
            gameRestartetAfterPlayerDied = false;

            GamePlayController.instance.GameOverShowPanel(score, coinScore);
        }
        else
        {
            this.score = score;
            this.coinScore = coinScore;
            this.lifeScore = lifeScore;

            gameRestartetAfterPlayerDied = true;
            gameStartedFromMainMenue = false;

            GamePlayController.instance.PlayerDiedRestartTheGame();

        }
    }
}
