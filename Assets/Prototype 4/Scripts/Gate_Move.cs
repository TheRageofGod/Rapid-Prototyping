using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate_Move : MonoBehaviour
{

    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private Gate gate;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    [SerializeField] private Image crosshair = null;
    private bool isCrossHairActive;
    private bool doOnce;

    private const string interactableTag = "Gate";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    gate = hit.collider.gameObject.GetComponent<Gate>();
                    Debug.Log("hit gate");
                    // CrosshairChange(true);
                }

                isCrossHairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    gate.Move();
                    Debug.Log("hit gate");
                    //CrosshairChange(true);
                }
            }
        }
        else
        {
            if (isCrossHairActive)
            {
                //CrosshairChange(false);
                doOnce = false;
            }
        }
    }

   /* void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrossHairActive = false;
        }
    }*/
}
