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

	public int catCount = 0; // needs to equal # of cats that begin in scene.


    public Text p1ScoreUI;
    public Text p2ScoreUI;
	public Text timerUI;
	public Text catCountUI;
	public Text gameOverUI;

	public AudioClip[] catsMeow;
	public AudioSource sound;
	public AudioSource musicPitch;

    private void Awake()
    {
		if (instance == null)
			instance = this;
        p1ScoreUI.text = "Player 1 score: " + scoreP1;
        p2ScoreUI.text = "Player 2 score: " + scoreP2;
    }

	void Start(){
		StartCoroutine ("Meow");
	}

    private void Update()
    {
		timer += Time.deltaTime;
		timerUI.text = "Time: " + Mathf.Round (timer);
		catCountUI.text = "Kittens: " + catCount;
		if (catCount <= 0) {
			//Win
			Debug.LogWarning("win");
			gameOverUI.text = "Catastrophe Averted: \nMission Successful";
		}
		if (catCount >= 1000) {
			//Lose
			Debug.LogWarning("Lose");
			gameOverUI.text = "Catastrophic Crisis Imminent: Abort Mission";
		}
		musicPitch.pitch = catCount * .0003f + 1;

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

	IEnumerator Meow(){
		yield return new WaitForSeconds (3);
		while (catCount > 0) {
		yield return new WaitForSeconds (Random.Range (3, 10));
		sound.clip = catsMeow[Random.Range(0, catsMeow.Length)];
		sound.Play();
		Debug.LogWarning ("meow");
		}
	}

}
