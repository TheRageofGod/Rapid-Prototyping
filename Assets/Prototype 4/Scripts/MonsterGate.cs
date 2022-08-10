using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MonsterGate : MonoBehaviour
{
    public Transform open;
    

    public float duration = 1;
    public bool snapping = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MonsterOpen());
    }

    IEnumerator MonsterOpen()
    {
        yield return new WaitForSeconds(60);
        transform.DOMove(open.position, duration, snapping);
    }
}
