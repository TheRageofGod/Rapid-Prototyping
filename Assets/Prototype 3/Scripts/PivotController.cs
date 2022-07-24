using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PivotController : MonoBehaviour
{
    public enum PivotDirection { Left, Right}
    public Transform pivotPoint;
    public Transform pivotObject;
    public float pivotTweenTime = 0.4f;
    public float pivotRotation;
    public Ease ease;

    PivotDirection pivotDirection;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Pivot(PivotDirection.Left);
        if (Input.GetKeyDown(KeyCode.E))
            Pivot(PivotDirection.Right);
    }

    void Pivot(PivotDirection _dir)
    {
         if (_dir == PivotDirection.Right)
            {
            transform.DOLocalRotate(new Vector3(0, pivotRotation, 0), pivotTweenTime).SetEase(ease);
        }
        if (_dir == PivotDirection.Left)
        {
            transform.DOLocalRotate(new Vector3(0, 270 + pivotRotation, 0), pivotTweenTime).SetEase(ease);
        }
    }  
}
