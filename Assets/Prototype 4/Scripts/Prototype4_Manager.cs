using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Prototype4_Manager : GameBehaviour<Prototype4_Manager>
{
    public TMP_Text[] E1;
    public TMP_Text[] A1;
    public TMP_Text[] A2;
    public int roomCounter = 0;

    private void Update()
    {
        if (roomCounter == roomCounter +1)
        {
            EQ.GenerateAddition();
        }
    }
    public void Display(string E, int A, int FA)
    {
        E1[roomCounter].text = E.ToString();
        A1[roomCounter].text = A.ToString();
        A2[roomCounter].text = FA.ToString();
        roomCounter = roomCounter + 1;
    }
}
