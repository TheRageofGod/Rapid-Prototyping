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

    public GameObject[] Locks;
    void Start()
    {
        locksOnDoor = Locks.Length;
    }
    private void Update()
    {
        UnlockingDoor();
    }

    public void UnlockingDoor()
    {
        if (locksOnDoor <= 0) 
        {
            transform.DOMove(open.position, duration, snapping);
        }
    }
}
