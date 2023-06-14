using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{

    public GameObject EquipmentA;
    public static int levelA = 0;
    public static double costA = 10;
    public static double dpcA = 0;

    public GameObject EquipmentB;
    public static int levelB = 0;
    public static double costB = 500;
    public static double dpsB = 0;

    public GameObject EquipmentC;
    public static int levelC = 0;
    public static double costC = 2500;
    public static double dpsC = 0;

    public static double equipmentTotalDamage;

    public static double EquipmentCostPer = 0.1;


    public void Equipment1()
    {
        if (GlobalTotal.ScoreCount >= costA)
        {
            GlobalTotal.ScoreCount -= costA;
            MainClick.dpc += 1;
            costA += (costA * EquipmentCostPer);
            dpcA += 1;
            levelA += 1;
            Debug.Log(costA);
        }
    }

    public void Equipment2()
    {
        
        if (GlobalTotal.ScoreCount >= costB)
        {
            GlobalTotal.ScoreCount -= costB;
            MainClick.dps += 5;
            equipmentTotalDamage += 5;
            costB += (costB * EquipmentCostPer);
            dpsB += 5;
            levelB += 1;
            Debug.Log(costB);
        }
        if (levelB == 1)
        {
            AutoCoins.AutoDamage = true;
        }
    }

    public void Equipment3()
    {
        if (GlobalTotal.ScoreCount >= costC)
        {
            GlobalTotal.ScoreCount -= costC;
            MainClick.dps += 25;
            equipmentTotalDamage += 25;
            costC += (costC * EquipmentCostPer);
            dpsC += 25;
            levelC += 1;
            Debug.Log(costC);
        }
        if (levelC == 1)
        {
            AutoCoins.AutoDamage = true;
        }
    }
}
