using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestTimesUI : MonoBehaviour
{
    public Text level1BestTime, level2BestTime, level3BestTime;
    // Start is called before the first frame update
    void Start()
    {
        float bestTimeFloat = PlayerPrefs.GetFloat("BestTime");
        float bestTimeFloatlvl2 = PlayerPrefs.GetFloat("BestTimelvl2");
        float bestTimeFloatlvl3 = PlayerPrefs.GetFloat("BestTimelvl3");
        int minutes = Mathf.FloorToInt(bestTimeFloat / 60f);
        int seconds = Mathf.FloorToInt(bestTimeFloat - minutes * 60);
        Debug.Log(minutes.ToString());
        Debug.Log(seconds.ToString());
        Debug.Log(PlayerPrefs.GetFloat("BestTime").ToString());
        if (minutes + seconds == 0)
        {
            string bestTimeString = "Level 1 best time: N/A. Go set a time!";
            level1BestTime.text = bestTimeString;
        }
        else
        {
            string bestTimeString = string.Format("Level 1 best time: " + "{0:00}:{1:00}", minutes, seconds);
            level1BestTime.text = bestTimeString;
        }
         minutes = Mathf.FloorToInt(bestTimeFloatlvl2 / 60f);
         seconds = Mathf.FloorToInt(bestTimeFloatlvl2 - minutes * 60);
        if (minutes + seconds == 0)
        {
            string bestTimeString = "Level 2 best time: N/A. Go set a time!";
            level2BestTime.text = bestTimeString;
        }
        else
        {
            string bestTimeString = string.Format("Level 2 best time: " + "{0:00}:{1:00}", minutes, seconds);
            level2BestTime.text = bestTimeString;
        }
        minutes = Mathf.FloorToInt(bestTimeFloatlvl3 / 60f);
        seconds = Mathf.FloorToInt(bestTimeFloatlvl3 - minutes * 60);
        if (minutes + seconds == 0)
        {
            string bestTimeString = "Level 3 best time: N/A. Go set a time!";
            level3BestTime.text = bestTimeString;
        }
        else
        {
            string bestTimeString = string.Format("Level 3 best time: " + "{0:00}:{1:00}", minutes, seconds);
            level3BestTime.text = bestTimeString;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
