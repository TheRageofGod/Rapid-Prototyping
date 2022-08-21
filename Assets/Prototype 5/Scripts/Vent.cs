using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour
{
    public Collider col;
    public Rigidbody rb;

    public void OpenVent()
    {
        Debug.Log("Open Vent");
        rb.useGravity = true;
        //col.isTrigger = true;
    }
}
