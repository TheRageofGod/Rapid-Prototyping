using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hacking_Game : MonoBehaviour
{
    public GameObject miniGamePanel;
    bool hack = false;
    bool red = false;
    bool blue = false;
    public DoorHack LD;
    void Start()
    {
        hack = false;
        miniGamePanel.SetActive(false);
        Time.timeScale = 1;
    }


    void Update()
    {
        
    }
    public void hacking()
    {
        Cursor.lockState = CursorLockMode.None;
        hack = !hack;
        miniGamePanel.SetActive(hack);
        Time.timeScale = hack ? 0 : 1;
        DisableCursor();
    }
    public void Positive() // sucessfully completed 
    {
        if(red == true && blue == true)
        {
            LD.UnlockingDoor();
            hacking();
            Debug.Log("door opened");
        }
    }

    public void Red() 
    {
        red = true;
        Debug.Log("red triggered");
        Positive();
    }
    public void Blue()
    {
        blue = true;
        Debug.Log("blue triggered");
        Positive();
    }
    public void Negative()//unsucessful
    {
        hacking();
    }

    public void DisableCursor()
    {
        if (hack == false)
            Cursor.lockState = CursorLockMode.Locked;
    }
}
