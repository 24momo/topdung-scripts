using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeveledEntity : MonoBehaviour
{
    public int currentExperience = 0;

    public int firstLevelXP = 200;
    private int nextLevelXP = firstLevelXP;

    private float xpReqIncreaseRatio = 0.1; //10% increase in required experience per level

    public int currentLevel = 0;
    private const int MAX_LEVEL = 150;

    public void AddXP(int xpToAdd){
        currentExperience += xpToAdd;

        if (currentExperience >= nextLevelXP && currentLevel < MAX_LEVEL){
            LevelUp();
        }
    }
    public void LevelUp(){
        currentLevel += 1;
        nextLevelXP += Mathf.ceil((float)nextLevelXP * xpReqIncreaseRatio); 
    }
}