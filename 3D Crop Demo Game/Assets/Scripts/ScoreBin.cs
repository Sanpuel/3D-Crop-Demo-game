using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBin : MonoBehaviour
    
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
        }
    }
}