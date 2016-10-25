using UnityEngine;
using System.Collections;

public class GamePreferences {


    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyScore = "EasyDifficultyScore";
    public static string MediumDifficultyScore = "MediumDifficultyScore";
    public static string HardDifficultyScore = "HardDifficultyScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

    public static string IsMusicOn = "IsMusicOn";

    // NOte we are going to use Integers to represent boolean variables
    // 0- false, 1 - true



    public static void SetEasyDifficultyState(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficulty, difficulty);
    }

    public static int GetEasyDifficultyState()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
    }


    public static void SetMusicStatus(int state)
    {
        PlayerPrefs.SetInt(GamePreferences.IsMusicOn, state);
    }

    public static int GetMusicStatus()
    {
        return PlayerPrefs.GetInt(GamePreferences.IsMusicOn);
    }


    public static void SetMediumDifficultyState(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficulty, difficulty);
    }

    public static int GetMediumDifficultyState()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
    }
    public static void SetHardDifficultyState(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficulty, difficulty);
    }

    public static int GetHardDifficultyState()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
    }

    public static void SetHardDifficultyScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyScore, Score);
    }

    public static int GetHardDifficultyScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyScore);
    }

    public static void SetEasydDifficultyScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyScore, Score);
    }

    public static int GetEasyDifficultyScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyScore);
    }

    public static void SetMediumDifficultyScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyScore, Score);
    }

    public static int GetMediumDifficultyScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyScore);
    }


    public static void SetEasyDifficultyCoinScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyCoinScore, Score);
    }

    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoinScore);
    }

    public static void SetMediumDifficultyCoinScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyCoinScore, Score);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoinScore);
    }

    public static void SetHardDifficultyCoinScore(int Score)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyCoinScore, Score);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoinScore);
    }

}
