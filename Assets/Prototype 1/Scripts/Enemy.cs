using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    public float strength =15f;

    void Awake()
    {
        enemyRb = GetComponent<Rigidbody>();
       
    }
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromEnemy = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Collided with" + collision.gameObject.name );
            playerRigidbody.AddForce(awayFromEnemy * strength, ForceMode.Impulse );
        }
    }
}
 
