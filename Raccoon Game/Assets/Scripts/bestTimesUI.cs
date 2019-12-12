using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestTimesUI : MonoBehaviour
{
    public Text level1BestTime, level2BestTime, level3BestTime, level4BestTime;
    // Start is called before the first frame update
    void Start()
    {
        float bestTimeFloat = PlayerPrefs.GetFloat("BestTime");
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
