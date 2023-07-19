using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollison : MonoBehaviour
{
    private Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target"))
        {
            // Collision logic...
            score.AddScore(1); // Increase the score by 1 when the collision occurs
            
             Destroy(gameObject); // Destroy the object
        }
    }
}