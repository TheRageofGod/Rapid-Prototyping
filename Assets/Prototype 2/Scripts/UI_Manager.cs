using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        fert = 50;
        water = 50;
        pest = 50;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (comp < 3)
        {
            comp = comp + 1;
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
        StartCoroutine(Delay());
       
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(12);
        pestStore = pestStore + 1;
    }
    public void GameOver()
    {

    }
}
