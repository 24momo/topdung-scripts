using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectible
{
    public Sprite emptyChest;
    public int goldAmount = 10;

    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+" + goldAmount + " Gold.", 14, Color.yellow, transform.position, Vector3.up * 25, 1.50f);
        }              
    }
}
