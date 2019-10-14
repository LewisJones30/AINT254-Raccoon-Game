using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    public void AddPoint()
    {
        score = score + 1;
        if (score > 10)
        {
            Debug.Log("Score achieved!"); //Remove in end release
            //Complete game here
            scoreText.text = "Score: " + score + "/10";
        }
        else
        {
            //Update UI score here
            scoreText.text = "Score: " + score + "/10";
        }
    }
    public void MinusPoint()
    {
        score = score - 1;
        if (score < 0)
        {
            score = 0;
            scoreText.text = "Score: " + score + "/10";
        }

        Debug.Log("Score: " + score); //Remove in end release
        scoreText.text = "Score: " + score + "/10";
        //Update UI score here
    }
}
