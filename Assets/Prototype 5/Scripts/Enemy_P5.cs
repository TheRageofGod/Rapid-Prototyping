using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy_P5 : MonoBehaviour
{
    public int health = 1;
    public Rigidbody rb;
    public Collider col;
    public void Shot()
    {
        health = health - 1;
        Debug.Log("Do Thing To Enemy");
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        rb.useGravity = true;
        StartCoroutine(Vanish());
    }
    public IEnumerator Vanish()
    {
        transform.GetComponent<Renderer>().material.DOFade(0, 2);
        yield return new WaitForSeconds(3);
        col.isTrigger = true;
        DestroyThis();
        
    }
    public IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
