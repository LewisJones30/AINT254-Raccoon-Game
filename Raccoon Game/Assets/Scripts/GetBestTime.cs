using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetBestTime : MonoBehaviour
{
    public Text bestTime, newHighScore, playerTime;
    float bestTimeFloat, playerTimeFloat;
    // Start is called before the first frame update
    void Start()
    {
        {
            //Update bestTime text.
            bestTimeFloat = PlayerPrefs.GetFloat("BestTime");
            int minutes = Mathf.FloorToInt(bestTimeFloat / 60f);
            int seconds = Mathf.FloorToInt(bestTimeFloat - minutes * 60);
            Debug.Log(minutes.ToString());
            Debug.Log(seconds.ToString());
            Debug.Log(PlayerPrefs.GetFloat("BestTime").ToString());
            if (minutes + seconds == 0)
            {
                string bestTimeString = "No best time recorded.";
                bestTime.text = bestTimeString;
            }
            else
            {
                string bestTimeString = string.Format("Best time: {0:00}:{1:00}", minutes, seconds);
                bestTime.text = bestTimeString;
            }

            //Determine if a new best time:
            if (PlayerPrefs.GetInt("NewBest") == 1)
            {
                newHighScore.gameObject.SetActive(true);
                playerTime.text = string.Format("Your time: {0:00}:{1:00}", minutes, seconds);
                PlayerPrefs.SetInt("NewBest", 0); //Reset new best player preference to false
            }
            else
            {
                //Remove high score text, calculate player's best time
                newHighScore.gameObject.SetActive(false); //Disable the high score message if the player has not beaten the last highest time.
                playerTimeFloat = PlayerPrefs.GetFloat("PlayerTime");
                int playerminutes = Mathf.FloorToInt(playerTimeFloat / 60f);
                int playerseconds = Mathf.FloorToInt(playerTimeFloat - minutes * 60);
                playerTime.text = string.Format("Your time: {0:00}:{1:00}", playerminutes, playerseconds);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetBestTime()
    {
        PlayerPrefs.SetFloat("BestTime", 0);
        newHighScore.text = "Best time reset. It will take affect when a new time is recorded.";
        newHighScore.fontSize = 100;
        if (!newHighScore.enabled)
        {
            newHighScore.enabled = true;
        }
        //Resets the best time variable
    }
}
