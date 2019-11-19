using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelectUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void level2()
    {

    }
    public void level3()
    {

    }
    public void level4()
    {

    }
    public void mainmenu()
    {
        SceneManager.LoadScene("StartingScene");
    }
}
