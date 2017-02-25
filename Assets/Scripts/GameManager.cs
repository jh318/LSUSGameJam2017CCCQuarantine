using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static int scoreP1 = 0;
    static int scoreP2 = 0;

    private void Start()
    {
        
    }

    public static void UpdateP1Score()
    {
        scoreP1 += 1;
        Debug.Log("Player 1 score: " + scoreP1);
    }

    public static void UpdateP2Score()
    {
        scoreP2 += 1;
        Debug.Log("Player 2 score: " + scoreP2);
    }

}
