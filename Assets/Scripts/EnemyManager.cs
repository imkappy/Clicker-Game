using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyManager : MonoBehaviour
{
    public Button enemyButton;
    public Sprite s0;
    public Sprite s1;
    public Sprite s2;
    public Sprite[] images;

    private bool canFillImages = true;

    public HealthBar healthBar;
    public static double maxHealth;
    private bool canSetMaxHealth = true;

    List<Enemy> enemies;

    public TextMeshProUGUI enemyName;

    public int tempDeathCount;
    public int imageNum = 0;
    public bool canIncreaseHealth = false;


    // Start is called before the first frame update
    void Start()
    {
        if (canFillImages == true)
        {
            images = new Sprite[3];
            images[0] = s0;
            images[1] = s1;
            images[2] = s2;

            canFillImages = false;
        }

        enemyButton.GetComponent<Image>().sprite = images[0];
        imageNum = 0;

        enemies = new List<Enemy>();

        enemies.Add(new Enemy("Chick", 10, 10, 0, 0, 5));
        enemies.Add(new Enemy("Dino", 25, 25, 0, 0, 50));
        enemies.Add(new Enemy("Knight", 50, 50, 0, 0, 100));
    }

    // Update is called once per frame
    void Update()
    {
        //runs when an enemy is killed and bool is set to true
        if (canSetMaxHealth == true)
        {
            int healthNow = (int)enemies[imageNum].maxHealth;
            healthBar.SetMaxHealth(healthNow);
            enemyName.SetText(enemies[imageNum].name);

            canSetMaxHealth = false;
        }
                
        if (HealthBar.totalHealth <= 0)
        {
            //increases coin amount by reward amount
            double rewardNow = enemies[imageNum].reward;
            GlobalTotal.ScoreCount += rewardNow;

            enemies[imageNum].deathCount += 1;
            Debug.Log("death count: " + enemies[imageNum].deathCount);



            if (enemies[imageNum].deathCount % 10 == 0) {
                tempDeathCount = enemies[imageNum].deathCount;
                enemies[imageNum].tempDeathCount = tempDeathCount;
                Debug.Log("manager tdc: " + tempDeathCount);
                Debug.Log("list tdc: " + enemies[imageNum].tempDeathCount);
            }

            if (tempDeathCount % 10 == 0 && tempDeathCount != 0)
            {
                enemies[imageNum].tempDeathCount = enemies[imageNum].deathCount;
                Debug.Log("2temp death count: " + tempDeathCount);
            }

            
            

            if (canIncreaseHealth == true)
            {
                enemies[imageNum].maxHealth += (double)Mathf.Ceil((float)(enemies[imageNum].maxHealth * .1));
                Debug.Log("max health: " + enemies[imageNum].maxHealth);
                canIncreaseHealth = false;
            }



            imageNum = changeImage();
            canSetMaxHealth = true;
        }       
    }


    public int changeImage()
    {
        int num = UnityEngine.Random.Range(0, images.Length);
        enemyButton.GetComponent<Image>().sprite = images[num];

        return num;
    }
}
