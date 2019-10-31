using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ScoringAndHealth : MonoBehaviour
{
    public int score = 0;
    public int health = 3;
    public Text scoreText, healthText;
    public UnityEvent onZeroHealth, onGameCompletion;
    // Start is called before the first frame update
    public void AddPoint()
    {
        score = score + 1;
        if (score > 9)
        {
            onGameCompletion.Invoke();
        }
        else
        {
            //Update UI score here
            scoreText.text = "Score: " + score + "/10";
        }
    }
    public void DamagePlayer()
    {
        health = health - 1;
        healthText.text = "Health: " + health + "/3";
        if (health < 1)
        {
            onZeroHealth.Invoke();
        }
        //Update UI score here
    }
}
