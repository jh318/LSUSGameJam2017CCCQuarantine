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
        instance.p1ScoreUI.text = "Player 1 score: " + instance.scoreP1;
        instance.p2ScoreUI.text = "Player 2 score: " + instance.scoreP2;
    }

    private void Start()
    {
        

    }

    public static void UpdateP1Score()
    {
        instance.scoreP1 += 1;
        Debug.Log("Player 1 score: " + instance.scoreP1);
        instance.p1ScoreUI.text = "Player 1 score: " + instance.scoreP1;
    }

    public static void UpdateP2Score()
    {
        instance.scoreP2 += 1;
        Debug.Log("Player 2 score: " + instance.scoreP2);
        instance.p2ScoreUI.text = "Player 2 score: " + instance.scoreP2;
    }

}
