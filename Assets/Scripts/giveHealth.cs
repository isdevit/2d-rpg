
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveHealth : MonoBehaviour
{
    private int health;
    private int numOfHearts;
    
    /*
     * @ pre none
     * @ param a 2d collider
     * @ post give player health by using hearts that drops after mod dies
     * @ return none
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<playerHealth>().giveHealth(4);
            Destroy(gameObject);        //destroy the heart

        }
    }
    
}
