﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableSpikes : MonoBehaviour
{
    public GameObject player;
    public Animator spike1;
    public Animator spike2;

    /*
     * @ pre none
     * @ param a 2d collider
     * @ post enable the spike when two collider intersects
     * @ return none
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spike1.SetBool("spawningEnemies", true);
            spike2.SetBool("spawningEnemies", true);
        }
    }
   
}