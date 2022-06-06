using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playtester : GameBehaviour
{
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            ChangePlayerColour();
        }
    }

    void ChangePlayerColour()
    {
        rend.material.color = GetRandomColour();
    }
}
