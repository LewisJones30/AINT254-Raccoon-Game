﻿using UnityEngine;
using System.Collections;

public class Group : MonoBehaviour
{
    private CanvasGroup m_group;
    [SerializeField]
    private SoundManager m_soundManager;

	// Use this for initialization
	void Start ()
    {
        m_group = GetComponent<CanvasGroup>();

        m_group.alpha = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(m_group.alpha == 0)
            {
                m_group.alpha = 1;
                m_soundManager.MenuModeAudio();
            }
            else
            {
                m_group.alpha = 0;
                m_soundManager.GameModeAudio();
            }
        }
	}
}
