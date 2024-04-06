

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public string loadScene;
    public Vector2 playerLocation;
    public objectVector playerTemp;
    public GameObject player;
    public saveData playerSave; 
    
    /*
     * @ pre none
     * @ param a collider2D object
     * @ post if player collider intersect with other collider function got called and load the next scene
     * @ return none
     */
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerTemp.initial = playerLocation;
            SceneManager.LoadScene(loadScene);
            player.GetComponent<Transform>().position = playerLocation;
        }
    }
}