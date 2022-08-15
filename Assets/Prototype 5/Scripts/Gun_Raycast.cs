using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun_Raycast : MonoBehaviour
{

    [SerializeField] private int rayLength = 5;
    [SerializeField] private int MeleeRange = 2;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    [SerializeField] private KeyCode code = KeyCode.Mouse0;
    [SerializeField] private KeyCode Melee = KeyCode.E;

    [SerializeField] private Image crosshair = null;
 

    private const string Tag1 = "Enemy";
    private const string Tag2 = "DoorPanel";
    private const string Tag3 = "Lock";

    private const string MeleeTag1 = "HackPanel"; 
    private const string MeleeTag2 = "Vent";

    void Update()
    {
        if (Input.GetKeyDown(code))
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

            if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
            {
                if (hit.collider.CompareTag(Tag1)) // enemy 
                {
                    if (hit.collider.gameObject.GetComponent<Enemy_P5>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Enemy_P5>().Shot();
                    }
             
                }
                if (hit.collider.CompareTag(Tag2))// door panel
                {
                    if (hit.collider.gameObject.GetComponent<DoorPanel>() != null)
                    {
                        hit.collider.gameObject.GetComponent<DoorPanel>().CloseDoor();
                    }
                }
                if (hit.collider.CompareTag(Tag3)) // lock
                {
                    if (hit.collider.gameObject.GetComponent<Lock>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Lock>().ShotLock();
                    }
                }
                
            }
        }
        if (Input.GetKeyDown(Melee))
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

            if (Physics.Raycast(transform.position, fwd, out hit, MeleeRange, mask))
            {
                if (hit.collider.CompareTag(MeleeTag1)) // HackPanel
                {
                    if (hit.collider.gameObject.GetComponent<HackPanel>() != null)
                    {
                        hit.collider.gameObject.GetComponent<HackPanel>().Hack();
                    }

                }
                if (hit.collider.CompareTag(MeleeTag2))// Vent
                {
                    if (hit.collider.gameObject.GetComponent<Vent>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Vent>().OpenVent();
                    }
                }
               

            }
        }
    }
}
