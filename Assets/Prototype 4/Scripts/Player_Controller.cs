using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    // Simple Player Conmtroller script Mainly for testing purposes
    public CharacterController controller;
    public Camera mainCamera;

    public float speed = 12;
    [SerializeField] private float crouchSpeed = 6f;// not used aved for later movement overhaul

    private bool ShouldCrouch => Input.GetKeyDown(crouchKey) && !duringCrouchAnimation;
    [SerializeField] private bool canCrouch = true;
    [SerializeField] private KeyCode crouchKey = KeyCode.LeftShift;
    [SerializeField] private float StandingHeight = 2f;
    [SerializeField] private float crouchHeight = 0.5f;
    [SerializeField] private float timeToCrouch = 0.25f;
    [SerializeField] private Vector3 crouchingCenter = new Vector3(0,0.5f,0);
    [SerializeField] private Vector3 standingCenter = new Vector3(0, 0, 0);
    private bool isCrouching;
    private bool duringCrouchAnimation;

    private void Update()
    {
        controller.Move(Physics.gravity * Time.deltaTime);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * x + transform.forward * z;

        controller.Move(direction * speed * Time.deltaTime);
        if(canCrouch == true)
        {
            HandleCrouch();
        }
    }
    private void HandleCrouch()
    {
        if (ShouldCrouch)
        {
            StartCoroutine(CrouchStand());
        }
    }

    private IEnumerator CrouchStand()
    {
        //this is for making it so that you cant stand up into objects however it breaks it for me so im leaving it out until i overhaul the movement system - Mitchell
       if(isCrouching && Physics.Raycast(mainCamera.transform.position, Vector3.up, 1f))
        {
            yield break;
        } 
        duringCrouchAnimation = true;

        float timeElapsed = 0;
        float targetHeight = isCrouching ? StandingHeight : crouchHeight;
        float currentHeight = controller.height;
        Vector3 targetCenter = isCrouching ? standingCenter : crouchingCenter;
        Vector3 currentCenter = controller.center;


        while(timeElapsed < timeToCrouch)
        {
            controller.height = Mathf.Lerp(currentHeight, targetHeight, timeElapsed / timeToCrouch);
            controller.center = Vector3.Lerp(currentCenter, targetCenter, timeElapsed / timeToCrouch);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        controller.height = targetHeight;
        controller.center = targetCenter;

        isCrouching = !isCrouching;

        duringCrouchAnimation = false;
    }
}
