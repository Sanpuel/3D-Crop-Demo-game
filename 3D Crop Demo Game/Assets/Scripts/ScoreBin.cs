using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBin : MonoBehaviour
    
{
    [SerializeField] int scoreValue = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Crop")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<Gamesession>().AddToScore(scoreValue);
        }
    }
}
