﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    int scoreP1 = 0;
    int scoreP2 = 0;
	float timer = 0.0f; 

    public Text p1ScoreUI;
    public Text p2ScoreUI;
	public Text timerUI;
	public Text catCountUI;
	public int catCount = 0; // needs to equal # of cats that begin in scene.


    private void Awake()
    {
		if (instance == null)
			instance = this;
        p1ScoreUI.text = "Player 1 score: " + scoreP1;
        p2ScoreUI.text = "Player 2 score: " + scoreP2;
    }

    private void Update()
    {
		timer += Time.deltaTime;
		timerUI.text = "Time: " + Mathf.Round (timer);
		catCountUI.text = "Kittens: " + catCount;

    }

    public void UpdateP1Score()
    {
        scoreP1 += 1;
        Debug.Log("Player 1 score: " + scoreP1);
        p1ScoreUI.text = "Player 1 score: " + scoreP1;
    }

    public void UpdateP2Score()
    {
        scoreP2 += 1;
        Debug.Log("Player 2 score: " + scoreP2);
        p2ScoreUI.text = "Player 2 score: " + scoreP2;
    }

}
