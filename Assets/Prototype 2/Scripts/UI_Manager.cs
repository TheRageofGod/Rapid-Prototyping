using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : GameBehaviour
{
    public int health;
    public int fert;
    public int water;
    public int pest;
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
    // Start is called before the first frame update
    void Start()
    {
        waterLevel.value = 50f;
        waterLevel.maxValue = 100f;
        fertLevel.value = 50f;
        fertLevel.maxValue = 100f;
        pestLevel.value = 50f;
        pestLevel.maxValue = 50f;


        health = 100;
        fert = 50;
        water = 50;
        pest = 50;

        time.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        HealthDis.text = "HP:" + health;
        fertStoreDis.text = "Compost:" + fertStore + "Kg";
        waterStoreDis.text = "Water:" + waterStore + "L";
        pestStoreDis.text = "Pestecide" + pestStore + "g";


        if (health <= 0)
        {
            GameOver();
        }
        if (fert >= 95)
        {
            GameOver();
        }
        if (pest >= 95)
        {
            GameOver();
        }
        if (water >= 95)
        {
            GameOver();
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
            waterLevel.value = waterLevel.value + 1f;
            waterStore = waterStore - 1;
        }
    }
    public void AddCompost()
    {
        if (fertStore > 0f)
        {
            fertLevel.value = fertLevel.value + 1f;
            fertStore = fertStore - 1;
        }
    }
    public void AddPest()
    {
        if (pestStore > 0)
        {
            pestLevel.value = pestLevel.value + 1f;
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
