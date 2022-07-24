using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text PointsDis;
    public int points = 0;

    void Update()
    {
        PointsDis.text = "Score:" + points;

        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            points = points + 10;
        }
    }
}
