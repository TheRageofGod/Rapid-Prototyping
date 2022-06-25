using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public GameObject CanvasObject;
  void OnTriggerEnter(Collider other)
  {
        if (other.tag == "Player")
        CanvasObject.SetActive(true);
  }
}
