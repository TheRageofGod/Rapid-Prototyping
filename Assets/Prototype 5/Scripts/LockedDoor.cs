using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LockedDoor : MonoBehaviour
{
    public Transform open;

    public float duration = 1;
    public bool snapping = true;
    public int locksOnDoor;
    bool unlocked = false;

    public GameObject[] Locks;
    void Start()
    {
        locksOnDoor = Locks.Length;
    }
    private void Update()
    {
        if (locksOnDoor <= 0 && unlocked == false)
            UnlockingDoor();
    }

    public void UnlockingDoor()
    {
       
            transform.DOMove(open.position, duration, snapping);
            unlocked = true;
    }
}
