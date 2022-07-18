using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    
    public float sideSpeed = 4;
    public int health = 100;

    void Update()
    {
         
        if(Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundry.leftSide)
            transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundry.rightSide)
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed *-1);
        }

        if (health <= 0)
        {
            GameOver();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag( "Enemy"))
        {
            health = health - 5;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
