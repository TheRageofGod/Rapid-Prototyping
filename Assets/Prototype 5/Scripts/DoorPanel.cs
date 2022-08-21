using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPanel : MonoBehaviour
{
    public OpenDoor od;
    public void CloseDoor()
    {
        od.Close();
        Debug.Log("Do Thing To Door");
        //triggeranimation 
        //freeze enemy
    }
}
