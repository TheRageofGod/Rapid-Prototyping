using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gate : MonoBehaviour
{
    public Transform open;
    public Transform close;

    public float duration = 1;
    public bool snapping = true;
    public void Move()
    {
        transform.DOMove(open.position, duration, snapping);
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {
        
        yield return new WaitForSeconds(2);
        transform.DOMove(close.position, duration, snapping);
        StartCoroutine(MonsterOpen());
        EndCoroutine();
        

    }
    IEnumerator MonsterOpen()
    {
        yield return new WaitForSeconds(60);
        transform.DOMove(open.position, duration, snapping);
    }
    public void EndCoroutine()
    {
        StopCoroutine(Close());
    }
    
}
