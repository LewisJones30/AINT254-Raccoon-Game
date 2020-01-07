using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelSelectUI : MonoBehaviour
{

    public Image  level2, level3;
    public Image  lock2, lock3;
    Button level2btn, level3btn;
    // Start is called before the first frame update
    void Start()
    {
        //Get the buttons from the components
        level2btn = level2.GetComponent<Button>();
        level3btn = level3.GetComponent<Button>();
        
        //PlayerPrefs: If second level is unlocked "lvl2Unlock" = 1, if "lvl3unlock" = 1, then third level is unlocked.
        if (PlayerPrefs.GetInt("lvl2Unlock") == 1)
        {
            //100% opacity for the level icon, 0% opacity for the lock icon
            level2.color = new Color(255, 255, 255, 255);
            lock2.color = new Color(255, 255, 255, 0);
            level2btn.interactable = true;
            lock2.enabled = false;
        }
        else
        {
            //~40% opacity for the level icon, 100% opacity for lock icon
            level2.color = new Color(255, 255, 255, 100);
            lock2.color = new Color(255, 255, 255, 255);

            level2btn.interactable = false;
        }
        if (PlayerPrefs.GetInt("lvl3Unlock") == 1)
        {
            //100% opacity for the level icon, 0% opacity for the lock icon
            level3.color = new Color(255, 255, 255, 255);
            lock3.color = new Color(255, 255, 255, 0);
            lock3.enabled = false;
            level3btn.enabled = true;
        }
        else
        {
            //~40% opacity for the level icon, 100% opacity for lock icon
            level3.color = new Color(255, 255, 255, 100);
            lock3.color = new Color(255, 255, 255, 255);
            lock3.enabled = true;
            level3btn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1Start()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void level2Start()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void level3Start()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("StartingScene");
    }
}
