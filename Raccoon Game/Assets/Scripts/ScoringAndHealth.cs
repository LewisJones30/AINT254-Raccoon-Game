using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ScoringAndHealth : MonoBehaviour
{
    public int score = 0;
    public int scoreToWin;
    public int maxHealth = 3;
    public int health;
    public Text scoreText, healthText;
    public UnityEvent onZeroHealth, onGameCompletion;
    public bool doublePoints = false; //This will be changed through the double points routine in collision detection.
    // Start is called before the first frame update
    public void AddPoint()
    {
        if (doublePoints == true)
        {
            score = score + 2;
        }
        else
        {
            score = score + 1;
        }
        if (score > scoreToWin - 1)
        {
            onGameCompletion.Invoke();
        }
        else
        {
            //Update UI score here
            scoreText.text = "Score: " + score + "/" + scoreToWin;
        }
    }
    void Start()
    {
        health = maxHealth;
        scoreText.text = "Score: " + score + "/" + scoreToWin;
        healthText.text = "Health " + health + "/" + maxHealth;
    }
    public void DamagePlayer()
    {
        health = health - 1;
        healthText.text = "Health: " + health + "/" + maxHealth;
        if (health < 1)
        {
            onZeroHealth.Invoke();
        }
        //Update UI score here
    }
}
