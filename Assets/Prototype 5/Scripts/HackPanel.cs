using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackPanel : MonoBehaviour
{
    public Rigidbody rb;
    public Hacking_Game HG;

    public void Hack()
    {
        Debug.Log("hacked");
        rb.useGravity = true;
        HG.hacking();
    }
}
