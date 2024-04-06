

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObjectSound : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioClip[] buttonAudio;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post play moving sound 
     * @ return none
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
    /*
    * @ pre none
    * @ param a 2d collider
    * @ post play moving sound
    * @ return none
    */
    private void OnCollisionExit2D(Collision2D other)
    {
        buttonClick.PlayOneShot(buttonAudio[2]);      
    }
    
}
