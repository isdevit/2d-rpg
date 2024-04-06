﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class fireDamage : MonoBehaviour
{
    public int fireStrength;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post if two collider intersects than give player damage
     * @ return none
     */
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().harmPlayer(fireStrength);
        }
    }

    /*
     * @ pre none
     * @ param none
     * @ post disable collision when the animation is gone
     * @ return none
     */
    private void disableCollision()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post disable collision when the animation is gone
     * @ return none
     */
    private void enableCollision()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
