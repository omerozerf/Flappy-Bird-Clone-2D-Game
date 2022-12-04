using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollusion : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    
    public int score = 0;

    private void Update()
    {
        ScoreUpdate();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Obstacle"))
        {
            Debug.Log("Died.");
            Time.timeScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Point"))
        {
            Debug.Log("Point");
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Ground"))
        {
            Debug.Log("Died.");
            Time.timeScale = 0;
        }
    }

    private void ScoreUpdate()
    {
        scoreText.text = score.ToString();
    }
    
    
}
