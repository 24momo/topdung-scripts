using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    protected bool doorOpen = false;
    public Sprite openedDoor;
    public Sprite closedDoor;

    protected void OnMouseUp()
    {

        if (doorOpen == false)
        {
            GetComponent<SpriteRenderer>().sprite = openedDoor;
            gameObject.layer = 0;
            doorOpen = true;
        }

        else {
            doorOpen = false; 
            GetComponent<SpriteRenderer>().sprite = closedDoor;
            gameObject.layer = 10;
         }
    }
}
