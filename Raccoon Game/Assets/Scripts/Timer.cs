using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60.0f;
    public Text timeLeftText;
    public float timeTaken = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        timeLeftText.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime; //This is used as the time remaining counter.
        timeTaken += Time.deltaTime; //This is used to tell the player the best time.
        int minutes = Mathf.FloorToInt(timeLeft / 60f);
        int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
        string timeLeftString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeLeftText.text = "Time remaining: " + timeLeftString;
      
        if (timeLeft < 40)
        {
            timeLeftText.color = Color.yellow;
            if (timeLeft < 20)
            {
                timeLeftText.color = Color.red;
            }
        }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }

    }
}
