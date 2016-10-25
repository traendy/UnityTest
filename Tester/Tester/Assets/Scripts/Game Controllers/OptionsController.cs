using UnityEngine;
using System.Collections;

public class OptionsController : MonoBehaviour {

    [SerializeField]
    private GameObject easySign, mediumSing, hardSign;

	// Use this for initialization
	void Start () {
        SetTheDifficulty();
	}

    void SetInitialDifficulty(string Difficulty)
    {
        switch (Difficulty)
        {
            case "easy":
                //easySign.SetActive(true);
                mediumSing.SetActive(false);
                hardSign.SetActive(false);
                break;
            case "medium":
                easySign.SetActive(false);
                //mediumSing.SetActive(true);
                hardSign.SetActive(false);

                break;
            case "hard":
                easySign.SetActive(false);
                mediumSing.SetActive(false);
               // hardSign.SetActive(true);
                break;
        }
    }

    void SetTheDifficulty()
    {
        if(GamePreferences.GetEasyDifficultyState() == 1)
        {
            SetInitialDifficulty("easy");
        }
        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetInitialDifficulty("medium");
        }
        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetInitialDifficulty("hard");
        }
    }

    public void EasyDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(1);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(0);

        easySign.SetActive(true);
        mediumSing.SetActive(false);
        hardSign.SetActive(false);

    }

    public void MediumDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(1);
        GamePreferences.SetHardDifficultyState(0);

        easySign.SetActive(false);
        mediumSing.SetActive(true);
        hardSign.SetActive(false);
    }

    public void HardDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(1);

        easySign.SetActive(false);
        mediumSing.SetActive(false);
        hardSign.SetActive(true);
    }


    public void GoBackToMainMenue()
    {
        Application.LoadLevel("MainMenue");
         
    }
}
