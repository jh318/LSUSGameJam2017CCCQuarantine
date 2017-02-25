using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    int scoreP1 = 0;
    int scoreP2 = 0;
    
    public Text p1ScoreUI;
    public Text p2ScoreUI;

    private void Awake()
    {
		if (instance == null)
			instance = this;
        p1ScoreUI.text = "Player 1 score: " + scoreP1;
        p2ScoreUI.text = "Player 2 score: " + scoreP2;
    }

    private void Start()
    {
        

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
