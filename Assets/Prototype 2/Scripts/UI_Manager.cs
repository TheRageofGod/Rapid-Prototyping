using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : GameBehaviour
{
    public float health;
    public float fert;
    public float water;
    public float pest;

    public int fertStore;
    public int waterStore;
    public int pestStore;
    
    public int comp;

    public TMP_Text HealthDis;
    public TMP_Text fertStoreDis;
    public TMP_Text waterStoreDis;
    public TMP_Text pestStoreDis;

    public Slider waterLevel;
    public Slider fertLevel;
    public Slider pestLevel;

    public Timer time;
    float currentTime;
    float healthTimer;
    // Start is called before the first frame update
    void Start()
    {
   


        health = 100;
        fert = 50;
        water = 50;
        pest = 25;

        waterLevel.value = water;
        waterLevel.maxValue = 100f;
        fertLevel.value = fert;
        fertLevel.maxValue = 100f;
        pestLevel.value = pest;
        pestLevel.maxValue = 50f;

        time.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        waterLevel.value = water;
        fertLevel.value = fert;
        pestLevel.value = pest;

        HealthDis.text = "HP:" + health;
        fertStoreDis.text = "Compost:" + fertStore + "Kg";
        waterStoreDis.text = "Water:" + waterStore + "L";
        pestStoreDis.text = "Pestecide" + pestStore + "g";

        if (time.TimeExpired())
        {
            pest = pest - 10;
            fert = fert - 5;
            time.StartTimer();
        }
        if (time.IsTiming())
        {
           
        }
        currentTime += Time.deltaTime;
        if(currentTime > 1)
        {
            water -= 1;
            currentTime = 0;
        }
        
  
        if (fert >= 95 || pest >= 95 || water >= 95 || health <= 0)
        {
            GameOver();
        }
        if (fert <= 0 || pest <= 0 || water <= 0 )
        {
            healthTimer += Time.deltaTime;
            if (healthTimer > 1)
            {
                health = health - 1;
                healthTimer = 0;
            }
        }


    }

    public void AddToComp()
    {
        comp = comp + 1;
    }

    public void WaterPlant()
    {
        if (waterStore > 0f)
        {
            water = water + 4f;
            waterStore = waterStore - 1;
        }
    }
    public void AddCompost()
    {
        if (fertStore > 0f)
        {
            fert = fert + 1f;
            fertStore = fertStore - 1;
        }
    }
    public void AddPest()
    {
        if (pestStore > 0)
        {
            pest = pest + 1f;
            pestStore = pestStore - 1;
        }
    }

    public void PumpWater()
    {
        waterStore = waterStore + 1;
    }
    public void CollectFert()
    {
        if (comp >= 3)
        fertStore = fertStore + 1;
    }
    public void GetPest()
    {
        Debug.Log("click");
        StartCoroutine(Delay());
       
    }
    IEnumerator Delay()
    {
        Debug.Log("delayed");
        yield return new WaitForSeconds(12);
        Debug.Log("added");
        pestStore = pestStore + 1;
        StopCoroutine(Delay());
    }
    public void GameOver()
    {

    }
}
