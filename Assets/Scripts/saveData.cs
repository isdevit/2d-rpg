﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour
{
    public bool hasSword;
    /*
     * @ pre none
     * @ param none
     * @ post save player's status to global control object
     * @ return none
     */
    public void playerData()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            hasSword = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().ActiveSword();
        }
    }

    /*
     * @ pre none
     * @ param none
     * @ post copy player's inventory from global object to next scene's player
     * @ return none
     */
    public void moveInventory()
    {
        GlobalControl.hasSword = ApplicationData.hasSword;
        GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().giveSword();
    }
}
