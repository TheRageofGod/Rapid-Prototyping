using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameBehaviour : MonoBehaviour
{
    protected static Timer _TIMER { get { return Timer.INSTANCE; } }
    protected static UIManager _UI { get { return UIManager.INSTANCE; } }
    protected static Prototype4_Manager _P4 { get { return Prototype4_Manager.INSTANCE; } }

    /// <summary>
    /// Gets Random colour using the RGB colourWheel with an alpha of 1
    /// </summary>
    /// <returns>returns random colour</returns>
    public Color GetRandomColour()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
    /// <summary>
    /// Fades In Canvas
    /// </summary>
    /// <param name="cvg">The Canvas group to fade</param>
    /// <param name="tweenTime">Optional Time to Twean</param>
    public void FadeInCanvas(CanvasGroup cvg,Ease ease, float tweenTime = 1f)
    {
        cvg.DOFade(1, tweenTime).SetEase(ease);
        cvg.interactable = true;
        cvg.blocksRaycasts = true;
    }
    /// <summary>
    /// Fades out Canvas
    /// </summary>
    /// <param name="cvg">The Canvas group to fade</param>
    /// <param name="tweenTime">Optional Time to Twean</param>
    public void FadeoutCanvas(CanvasGroup cvg, Ease ease, float tweenTime = 2f)
    {
        cvg.DOFade(0, tweenTime).SetEase(ease);
        cvg.interactable = false;
        cvg.blocksRaycasts = false;
    }
}




/// <summary>
/// the code for a singleton
/// </summary>
/// <typeparam name="T"></typeparam>
public class GameBehaviour<T> : GameBehaviour where T : GameBehaviour
{
    private static T instance_;

    public static T INSTANCE
    {
        get
        {
            if(instance_ == null)
            {
                instance_ = GameObject.FindObjectOfType<T>();
                if(instance_ == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    singleton.AddComponent<T>();
                }

            }
            return instance_;
        }
    }

    protected virtual void Awake()
    {
        if(instance_ == null)
        {
            instance_ = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
