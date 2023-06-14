using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainClick : MonoBehaviour
{
    //starting cps value
    public static float dps = 0;
    public static double dpc = 1;
    public Button button;
    public Button devButton;

    public HealthBar healthBar;
    public static double damage = 0;

    private void Start()
    {
        button.onClick.AddListener(TaskOnClick);
        devButton.onClick.AddListener(TaskOnClick2);
    }
    void TaskOnClick()
    {
        Debug.Log(HealthBar.totalHealth);
        if (HealthBar.totalHealth != 0)
        {
            damage = (HealthBar.totalHealth -= dpc);
            healthBar.SetHealth((int)damage);
        }
    }

    void TaskOnClick2()
    {
        GlobalTotal.ScoreCount += 1000;
    }


    void Update()
    {
        GlobalTotal.DPSCount = dps;
        GlobalTotal.DPCCount = dpc;
    }
}
