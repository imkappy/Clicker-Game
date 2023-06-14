using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoins : MonoBehaviour
{
    public static bool AutoDamage = false;
    public bool isDamaging = false;
    public static double DPSIncrease;
    public double InternalIncrease = 1;

    public HealthBar healthBar;

    public static double equipmentDamage = 0;
    public static double damage = 0;

    // Update is called once per frame
    void Update()
    {
        DPSIncrease = MainClick.dps;
        InternalIncrease = DPSIncrease;
        equipmentDamage = Equipment.equipmentTotalDamage;
        
        if(AutoDamage == true)
        {
            if (isDamaging == false)
            {
                isDamaging = true;
                StartCoroutine(AutoDamageEnemy());
            }
        }

    }

    IEnumerator AutoDamageEnemy()
    {
        damage = (HealthBar.totalHealth -= equipmentDamage);
        healthBar.SetHealth((int)damage);
        yield return new WaitForSeconds(1);
        isDamaging = false;
    }
}
