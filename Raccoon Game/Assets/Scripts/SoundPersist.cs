using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundPersist : MonoBehaviour
{


    private static SoundPersist instance = null;
    public static SoundPersist Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        if (SceneManager.GetActiveScene().name != "StartingScene" && SceneManager.GetActiveScene().name != "BestTimes" && SceneManager.GetActiveScene().name != "LevelSelect")
        {
            Debug.Log("Destroyed!");
            Debug.Log(SceneManager.GetActiveScene().name);
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }

}


