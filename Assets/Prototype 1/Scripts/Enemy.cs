using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    void Awake()
    {
        enemyRb = GetComponent<Rigidbody>();
       player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
        enemyRb.AddForce(transform.position * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }
}
 
