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
    public void StartGame()
    {
        //Load the first level
        SceneManager.LoadScene("Level 1");
    }
    public void WinGame() //Runs when the player gets the objective completed.
    {
        PlayerPrefs.SetFloat("PlayerTime", timerScript.timeTaken); //Set player's time to be read in the new scene.
        Debug.Log(PlayerPrefs.GetFloat("BestTime") + "from game");
        Debug.Log(PlayerPrefs.GetFloat("PlayerTime") + "player time");
        if (PlayerPrefs.GetFloat("BestTime") > PlayerPrefs.GetFloat("PlayerTime"))
        {

            PlayerPrefs.SetFloat("BestTime", PlayerPrefs.GetFloat("PlayerTime")); //Set the best time as the player time
            Debug.Log(PlayerPrefs.GetFloat("BestTime") +  " After setting");
            PlayerPrefs.SetInt("NewBest", 1); //Boolean to say if new high score, to inform user of this.
        }
        else if (PlayerPrefs.GetFloat("BestTime") == 0) //if no time has been recorded
        {
            PlayerPrefs.SetFloat("BestTime", PlayerPrefs.GetFloat("PlayerTime")); //Set the best time as the player time
            Debug.Log(PlayerPrefs.GetFloat("BestTime") + " After setting");
            PlayerPrefs.SetInt("NewBest", 1); //Boolean to say if new high score, to inform user of this.
        }
        SceneManager.LoadScene("GameWinScene");
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
