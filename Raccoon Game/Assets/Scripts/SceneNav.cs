using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneNav : MonoBehaviour
{
    public Timer timerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void levelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void introduction()
    {
        SceneManager.LoadScene("IntroScene");
    }
    public void StartGame()
    {
        //Load the first level
        SceneManager.LoadScene("Level 1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void level1Complete() //Runs when the player gets the objective completed.
    {
        PlayerPrefs.SetFloat("PlayerTime", timerScript.timeTaken); //Set player's time to be read in the new scene.
        if (PlayerPrefs.GetFloat("BestTime") > PlayerPrefs.GetFloat("PlayerTime"))
        {

            PlayerPrefs.SetFloat("BestTime", PlayerPrefs.GetFloat("PlayerTime")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBest", 1); //Boolean to say if new high score, to inform user of this.
        }
        else if (PlayerPrefs.GetFloat("BestTime") == 0) //if no time has been recorded
        {
            PlayerPrefs.SetFloat("BestTime", PlayerPrefs.GetFloat("PlayerTime")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBest", 1); //Boolean to say if new high score, to inform user of this.
        }
        SceneManager.LoadScene("lvl1Complete");
    }
    public void level2Complete()
    {
        PlayerPrefs.SetFloat("PlayerTimelvl2", timerScript.timeTaken); //Set player's time to be read in the new scene.
        if (PlayerPrefs.GetFloat("BestTimelvl2") > PlayerPrefs.GetFloat("PlayerTimelvl2"))
        {

            PlayerPrefs.SetFloat("BestTimelvl2", PlayerPrefs.GetFloat("PlayerTimelvl2")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBestlvl2", 1); //Boolean to say if new high score, to inform user of this.
        }
        else if (PlayerPrefs.GetFloat("BestTimelvl2") == 0) //if no time has been recorded
        {
            PlayerPrefs.SetFloat("BestTimelvl2", PlayerPrefs.GetFloat("PlayerTimelvl2")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBestlvl2", 1); //Boolean to say if new high score, to inform user of this.
        }
        PlayerPrefs.SetInt("lvl2Complete", 1); //Level completion recorded.
        SceneManager.LoadScene("lvl2Complete");

    }
    public void level3Complete()
    {
        PlayerPrefs.SetFloat("PlayerTimelvl3", timerScript.timeTaken); //Set player's time to be read in the new scene.
        if (PlayerPrefs.GetFloat("BestTimelvl3") > PlayerPrefs.GetFloat("PlayerTimelvl3"))
        {

            PlayerPrefs.SetFloat("BestTimelvl3", PlayerPrefs.GetFloat("PlayerTimelvl3")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBestlvl3", 1); //Boolean to say if new high score, to inform user of this.
        }
        else if (PlayerPrefs.GetFloat("BestTimelvl3") == 0) //if no time has been recorded
        {
            PlayerPrefs.SetFloat("BestTimelvl3", PlayerPrefs.GetFloat("PlayerTimelvl3")); //Set the best time as the player time
            PlayerPrefs.SetInt("NewBestlvl3", 1); //Boolean to say if new high score, to inform user of this.
        }
        PlayerPrefs.SetInt("lvl3Complete", 1); //Level completion recorded.
        SceneManager.LoadScene("lvl3Complete");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartingScene");
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("GameLoseScene");
    }
}
