using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneNav : MonoBehaviour
{
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
    public void WinGame()
    {
        SceneManager.LoadScene("GameWinScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Starting Scene");
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("GameLoseScene");
    }
}
