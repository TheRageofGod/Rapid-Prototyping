using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy_Follow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    
    void Start()
    {
       
    }
    void Update()
    {
        enemy.SetDestination(player.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
