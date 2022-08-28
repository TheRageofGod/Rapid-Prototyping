using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hackingRegRed : MonoBehaviour
{
    public Hacking_Game HG;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered1");
        if (collision.CompareTag ( "blue"))
        {
            HG.Blue();
            Debug.Log("blue triggered 1");
        }
    }
}
