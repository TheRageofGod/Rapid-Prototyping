using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorHack : MonoBehaviour
{
    public Transform open;

    public float duration = 1;
    public bool snapping = true;
    public void UnlockingDoor()
    {

        transform.DOMove(open.position, duration, snapping);
        
    }
}
