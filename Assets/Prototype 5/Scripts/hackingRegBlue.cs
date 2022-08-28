using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hackingRegBlue : MonoBehaviour
{
    public Hacking_Game HG;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered1");
        if (collision.CompareTag("red"))
        {
            HG.Red();
            Debug.Log("red triggered1");
        }
    }
}
