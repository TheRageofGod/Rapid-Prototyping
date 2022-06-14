using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackgroundFader : GameBehaviour
{
    public Ease ease;
    public CanvasGroup background;
    // Start is called before the first frame update
    void Start()
    {
        background.alpha = 1;
        FadeoutCanvas(background, ease);
    }


}
