using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetBestTime : MonoBehaviour
{
    public Text bestTime, newHighScore, playerTime;
    float bestTimeFloat, playerTimeFloat;
    // Start is called before the first frame update
    void Start()
    {
        {
            //Determine which floats to load.
            if (SceneManager.GetActiveScene().name == "lvl1Complete")
            {
                bestTimeFloat = PlayerPrefs.GetFloat("BestTime");
                playerTimeFloat = PlayerPrefs.GetFloat("PlayerTime");
                PlayerPrefs.SetInt("lvl2Unlock", 1);
            }
            else if (SceneManager.GetActiveScene().name == "lvl2Complete")
            {
                bestTimeFloat = PlayerPrefs.GetFloat("BestTimelvl2");
                playerTimeFloat = PlayerPrefs.GetFloat("PlayerTimelvl2");
                PlayerPrefs.SetInt("lvl3Unlock", 1);
            }
            else if (SceneManager.GetActiveScene().name == "lvl3Complete")
            {
                bestTimeFloat = PlayerPrefs.GetFloat("BestTimelvl3");
                playerTimeFloat = PlayerPrefs.GetFloat("PlayerTimelvl3");
            }
            
            int minutes = Mathf.FloorToInt(bestTimeFloat / 60f);
            int seconds = Mathf.FloorToInt(bestTimeFloat - minutes * 60);
            Debug.Log(minutes.ToString());
            Debug.Log(seconds.ToString());
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
                int playerminutes = Mathf.FloorToInt(playerTimeFloat / 60f);
                int playerseconds = Mathf.FloorToInt(playerTimeFloat - (playerminutes * 60));
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
