using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compost : MonoBehaviour
{
    public Transform sp;
    public GameObject compost;

    public UI_Manager Ui;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pile")
        {
            //compost.SetActive(false);
            Ui.AddToComp();
            compost.transform.position = sp.position;
        }
        else
        compost.transform.position = sp.position;
    }

}
