﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public static bool hasSword;
    
    /*
     * @ pre none
     * @ param none
     * @ post keep global control object from being destroyed when scene is loaded
     * @ return none
     */
    void Awake ()   
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
    }
    
}