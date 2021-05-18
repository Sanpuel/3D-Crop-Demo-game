using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int scoreValue = 1;
    public int hp = 1;
    public void ReduceHP(int damage) 
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
        FindObjectOfType<Gamesession>().AddToScore(scoreValue);
    }
}

