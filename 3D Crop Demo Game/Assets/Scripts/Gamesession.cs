using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamesession : MonoBehaviour
{
    int score = 0;
    
    public int GetScore()
    {
        return score;
    }
    
    public void  AddToScore(int ScoreValue)
    {
        score += ScoreValue;
    }

    
}
