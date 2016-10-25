using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MainMenueController : MonoBehaviour {


    [SerializeField]
    private Button musicBtn;

    [SerializeField]
    private Sprite[] musicIcons;


	// Use this for initialization
	void Start () {
        CheckToPlayTheMusic();

    }

    void CheckToPlayTheMusic()
    {
        if(GamePreferences.GetMusicStatus() == 1)
        {
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        }
        else
        {
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
    }

    public void StatGame()
    {
        GameManager.instance.gameStartedFromMainMenue = true;
        //Application.LoadLevel("Gameplay");
        SceneFader.instance.LoadLevel("Gameplay");

    }

    public void HighScoreMenu()
    {
        Application.LoadLevel("HighScore");
    }


    public void OptionsMenue()
    {
        Application.LoadLevel("OptionsMenue");
    }

    public void QuitGame()
    {
        Application.Quit();

    }

    public void MusicButton()
    {
        if(GamePreferences.GetMusicStatus() == 0)
        {
            GamePreferences.SetMusicStatus(1);
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        }else if (GamePreferences.GetMusicStatus() == 1)
        {
            GamePreferences.SetMusicStatus(0);
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
    }
}
