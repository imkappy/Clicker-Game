using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    public string name;
    public double maxHealth;
    public double currentHealth;
    public int deathCount;
    public int tempDeathCount;
    public double reward;

    public Enemy(string newName, double newHealth, double newCurrentHealth, int newDeathCount,
        int newTempDeathCount, double newReward)
    {
        name = newName;
        maxHealth = newHealth;
        currentHealth = newCurrentHealth;
        deathCount = newDeathCount;
        tempDeathCount = newTempDeathCount;
        reward = newReward;
    }

}
