using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeApplication()
    {
        Application.Quit();
    }
    public void bestTimesScreen()
    {
        //SceneManager navigate to best times table here
    }
    public void levelSelectNav()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
