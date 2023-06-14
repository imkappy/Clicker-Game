using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalTotal : MonoBehaviour
{
    public static double ScoreCount;
    public double InternalScore;

    public static double DPSCount;
    public double InternalDPS;

    public static double DPCCount;
    public double InternalDPC;

    public TextMeshProUGUI CoinDisplay;
    public TextMeshProUGUI DPSDisplay;
    public TextMeshProUGUI DPCDisplay;

    // Update is called once per frame
    void Update()
    {
        InternalScore = ScoreCount;
        InternalDPS = DPSCount;
        InternalDPC = DPCCount;
        CoinDisplay.SetText(InternalScore.ToString("F0") + " Coins");
        DPSDisplay.SetText(InternalDPS.ToString("F0") + " DPS");
        DPCDisplay.SetText(InternalDPC.ToString("F0") + " DPC");
    }
}
