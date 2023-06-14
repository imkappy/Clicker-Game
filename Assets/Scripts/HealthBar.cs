using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI healthCount;
    public static double totalHealth;

    public void SetMaxHealth(int health)
    {
        totalHealth = health;

        slider.maxValue = (float)totalHealth;
        slider.value = (float)totalHealth;

        healthCount.SetText("" + (float)totalHealth);
    }

    public void SetHealth(int health)
    {
        totalHealth = health;

        slider.value = (float)totalHealth;

        healthCount.SetText("" + (float)totalHealth);
    }
    
}
