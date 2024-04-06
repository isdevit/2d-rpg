
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public SpriteRenderer item;

    /*
     * @ pre none
     * @ param none
     * @ post drop an item to desired location
     * @ return none
     */
    void itemDrop()
    {
        Instantiate(item, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
