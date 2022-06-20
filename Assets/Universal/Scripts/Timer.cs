using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : GameBehaviour<Timer>
{
    public enum TimerDirection
    {
        CountUp, CountDown
    }
    public TimerDirection timerDirection;
    public float startTime = 0f;
    float currentTime;
    bool isTiming = false;

    void Update()
    {
        if (isTiming)
        {
            if (timerDirection == TimerDirection.CountUp)
                currentTime += Time.deltaTime;
            else
                currentTime -= Time.deltaTime;
        }
    }
    /// <summary>
    /// Starts the timer and increments it in real time seconds
    /// </summary>
    public void StartTimer()
    {
        isTiming = true;
        currentTime = startTime;
    }
    /// <summary>
    /// starts the timer at whatever the current time is
    /// </summary>
    public void ResumeTimer()
    {
        isTiming = true;
    }
    /// <summary>
    /// stops the timer with intention of resuming
    /// </summary>
    public void PauseTimer()
    {
        isTiming = false;
    }
    /// <summary>
    /// stops the Timer
    /// </summary>
    public void StopTimer()
    {
        isTiming = false;
    }
    /// <summary>
    /// increments our timer by a set amount
    /// </summary>
    /// <param name="_increment">amount to increment</param>
    public void IncrementTimer(float _increment)
    {
        currentTime += _increment;
    }
    /// <summary>
    /// Decrements our timer by a set amount
    /// </summary>
    /// <param name="_decrement">amount to increment</param>
    public void DecrementTimer(float _decrement)
    {
        currentTime -= _decrement;
    }
    /// <summary>
    /// Getes the Current Time value
    /// </summary>
    /// <returns>current Time</returns>
    public float GetTime()
    {
        return currentTime;
    }
    /// <summary>
    /// Status of the timer
    /// </summary>
    /// <returns>true or false</returns>
    public bool IsTiming()
    {
        return isTiming;
    }
    /// <summary>
    /// checks if timer has expired
    /// </summary>
    /// <returns>returns true if timer is less than 0</returns>
    public bool TimeExpired()
    {
        return currentTime < 0f;
    }
}
