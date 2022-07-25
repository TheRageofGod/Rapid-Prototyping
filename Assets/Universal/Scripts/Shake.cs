using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shake : MonoBehaviour
{
    public float duration = 0.01f; //The duration of the tween
    public float strength =0.1f; //The shake strength. Using a Vector3 instead of a float lets you choose the strength for each axis.
    public int vibrate =1; //Indicates how much will the shake vibrate. 
    public float randomness =90f; //Indicates how much the shake will be random (0 to 180 - values higher than 90 kind of suck, so beware). Setting it to 0 will shake along a single direction.
    public bool snaping = false; //If TRUE the tween will smoothly snap all values to integers.
    public bool fade = true; // (default: true) If TRUE the shake will automatically fadeOut smoothly within the tween's duration, otherwise it will not.

    Collider col;
    void Start()
    {
        col = GetComponent<Collider>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.DOShakePosition(duration, strength, vibrate, randomness, snaping, fade);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.DOShakePosition(duration, strength, vibrate, randomness, snaping, fade);
        col.enabled = !col.enabled;
    }
}
