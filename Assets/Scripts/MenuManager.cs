using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject CostAText;
    public double InternalCostA;
    public GameObject ValueAText;
    public double InternalValueA;
    public GameObject LevelAText;
    public int InternalLevelA;

    public GameObject CostBText;
    public double InternalCostB;
    public GameObject ValueBText;
    public double InternalValueB;
    public GameObject LevelBText;
    public int InternalLevelB;

    public GameObject CostCText;
    public double InternalCostC;
    public GameObject ValueCText;
    public double InternalValueC;
    public GameObject LevelCText;
    public int InternalLevelC;


    private int increments = 1;

    // Update is called once per frame
    void Update()
    {
        InternalCostA = Equipment.costA;
        InternalValueA = Equipment.dpcA;
        InternalLevelA = Equipment.levelA;
        CostAText.GetComponent<Text>().text = "Buy " + increments + " @ " + InternalCostA.ToString("F0");
        ValueAText.GetComponent<Text>().text = "+" + InternalValueA + " DPC";
        LevelAText.GetComponent<Text>().text = "Lv. " + InternalLevelA;

        InternalCostB = Equipment.costB;
        InternalValueB = Equipment.dpsB;
        InternalLevelB = Equipment.levelB;
        CostBText.GetComponent<Text>().text = "Buy " + increments + " @ " + InternalCostB.ToString("F0");
        ValueBText.GetComponent<Text>().text = "+" + InternalValueB + " DPS";
        LevelBText.GetComponent<Text>().text = "Lv. " + InternalLevelB;

        InternalCostC = Equipment.costC;
        InternalValueC = Equipment.dpsC;
        InternalLevelC = Equipment.levelC;
        CostCText.GetComponent<Text>().text = "Buy " + increments + " @ " + InternalCostC.ToString("F0");
        ValueCText.GetComponent<Text>().text = "+" + InternalValueC + " DPS";
        LevelCText.GetComponent<Text>().text = "Lv. " + InternalLevelC;

    }
}
