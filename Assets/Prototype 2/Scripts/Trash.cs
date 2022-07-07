using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public Transform sp;
    public GameObject trash;

    public UI_Manager Ui;


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        trash.SetActive(false);

        trash.transform.position = sp.position;
    }

}
