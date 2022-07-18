using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    
    public GameObject[] section;
    public int zPos = 250;
    
    public int secNum;
    public float despawn = -100;
    


    public void Store(GameObject _go)
    {
        Destroy(_go);
        Build();
    }
    void Build()
    {
        secNum = Random.Range(0, section.Length);
        GameObject go = Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        //zPos += 50;
        //creatingSection = false;
    }
}
