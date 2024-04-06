
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    /*
     * @ pre none
     * @ param none
     * @ post exit the application
     * @ return none
     */
    public void exitGame()
    {
//    Debug.Log("Exiting game");
        Application.Quit();
    }
}
