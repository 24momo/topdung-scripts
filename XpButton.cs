using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPButton : MonoBehaviour
{
    public LeveledEntity anotherLeveledGuy;

    public void Activate(LeveledEntity player){
        player.AddXP(20);
        anotherLeveledGuy.AddXP(15);
    }
}
