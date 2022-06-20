using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum MoveDirection
{
    UP, DOWN, LEFT, RIGHT
}

public class Playtester : GameBehaviour
{
    public float moveDistance = 2f;
    public float moveSpeed = 1f;
    Renderer rend;
    public Ease moveEase;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        _TIMER.StartTimer();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            ChangePlayerColour();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovePlayer(MoveDirection.UP);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovePlayer(MoveDirection.DOWN);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovePlayer(MoveDirection.LEFT);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovePlayer(MoveDirection.RIGHT);
        }
    }

    void ChangePlayerColour()
    {
        //rend.material.color = GetRandomColour();
        rend.material.DOColor(GetRandomColour(), 1f);
    }
    void MovePlayer(MoveDirection _direction)
    {
        switch (_direction)
        {
            case MoveDirection.UP:
                transform.DOMoveZ(transform.position.z + moveDistance, moveSpeed).SetEase(moveEase)
                    .OnComplete(() =>
                    CameraShake());
                break;
            case MoveDirection.DOWN:
                transform.DOMoveZ(transform.position.z - moveDistance, moveSpeed).SetEase(moveEase)
                    .OnComplete(() =>
                    CameraShake());
                break;
            case MoveDirection.LEFT:
                transform.DOMoveX(transform.position.x - moveDistance, moveSpeed).SetEase(moveEase)
                    .OnComplete(() =>
                    CameraShake());
                break;
            case MoveDirection.RIGHT:
                transform.DOMoveX(transform.position.x + moveDistance, moveSpeed).SetEase(moveEase)
                    .OnComplete(() =>
                    CameraShake());
                break;
        }
        ChangePlayerColour();
        //ChangePlayerScale();
        
    }
    void ChangePlayerScale()
    {
        transform.DOScale(Vector3.one * 2, moveSpeed / 2)
            .OnComplete(()=> //makes it run the next line
        transform.DOScale(Vector3.one, moveSpeed / 2));
        

    }
    void CameraShake()
    {
        Camera.main.DOShakePosition(moveSpeed, 0.4f);
    }
}
