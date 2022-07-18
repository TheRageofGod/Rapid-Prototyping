using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : GameBehaviour
{
   float moveSpeed = 10;
    GenerateLevel _GL;

    private void Start()
    {
        _GL = FindObjectOfType<GenerateLevel>();
    }
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
        if (transform.position.z <= _GL.despawn)
        {
            _GL.Store(gameObject);
        }
    }
}
