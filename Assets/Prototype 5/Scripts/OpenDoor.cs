using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenDoor : MonoBehaviour
{
    public Transform close;

    public float duration = 0.2f;
    public bool snapping = true;
   
   
    public void Close()
    {
        transform.DOMove(close.position, duration, snapping);
    }
}
