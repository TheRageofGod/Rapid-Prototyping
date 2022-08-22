using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacking_Game : MonoBehaviour
{
    public GameObject miniGamePanel;
    bool hack = false;
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
