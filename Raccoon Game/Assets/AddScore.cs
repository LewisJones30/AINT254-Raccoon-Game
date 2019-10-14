using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    public void AddPoint()
    {
        score = score + 1;
        if (score > 10)
        {
            Debug.Log("Score achieved!"); //Remove in end release
            //Complete game here
        }
        else
        {
            //Update UI score here
        }
    }
    public void MinusPoint()
    {
        score = score - 1;
        Debug.Log("Score: " + score); //Remove in end release
        //Update UI score here
    }
}
