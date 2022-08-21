using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public Rigidbody rb;
    public LockedDoor ld;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //ld.locksOnDoor = ld.locksOnDoor + 1;
    }

    
    void Update()
    {
        
    }
    public void ShotLock()
    {
        ld.locksOnDoor = ld.locksOnDoor - 1;
        Debug.Log("Do Thing To Lock");
        rb.useGravity = true;
    }
}
