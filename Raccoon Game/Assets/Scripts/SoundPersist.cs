using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundPersist : MonoBehaviour
{

    AudioSource currentSource;
    private static SoundPersist instance = null;
    public static SoundPersist Instance
    {
        get { return instance; }
    }
    private void Start()
    {
        currentSource = GetComponent<AudioSource>();  
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


    }
    private void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name != "StartingScene" && SceneManager.GetActiveScene().name != "BestTimes" && SceneManager.GetActiveScene().name != "LevelSelect")
        {
            while (currentSource.volume != 0)
            {
                currentSource.volume -= Time.deltaTime / 3;
            }
            Debug.Log("Destroyed!");
            Debug.Log(SceneManager.GetActiveScene().name);
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            DontDestroyOnLoad(this.gameObject);
        }
    }

}


