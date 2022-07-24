using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{

    public float sideSpeed = 4;


    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundry.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundry.rightSide)
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed * -1);
        }
    }
}

  
