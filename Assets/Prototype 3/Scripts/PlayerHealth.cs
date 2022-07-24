using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text HealthDis;
    public int health = 100;
 
    void Update()
    {
        HealthDis.text = "HP:" + health;
        
        if (health <= 0)
        {
            GameOver();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health = health - 5;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
