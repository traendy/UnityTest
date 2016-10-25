﻿using UnityEngine;
using System.Collections;

public class SceneFader : MonoBehaviour {

    public static SceneFader instance;

    [SerializeField]
    private GameObject fadePanel;

    [SerializeField]
    private Animator fadeAnim;
	// Use this for initialization
	void Start () {
        makeSingleton();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void makeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadLevel(string level)
    {
        StartCoroutine(FadeInOut(level));
    }

    IEnumerator FadeInOut(string level)
    {
        fadePanel.SetActive(true);
        fadeAnim.Play("FadeIn");

        yield return StartCoroutine(MyCoroutine.WaitforRealSeconds(1f));

        Application.LoadLevel(level);
        fadeAnim.Play("FadeOut");

        yield return StartCoroutine(MyCoroutine.WaitforRealSeconds(0.7f));

        fadePanel.SetActive(false);
    }
}
