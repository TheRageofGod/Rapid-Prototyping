using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class TweenNumber : GameBehaviour
{
    float startValue = 0f;
    float toValue = 10f;
    public TMP_Text scoreText;
    public Ease scoreEase;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TweenScore();
        }
    }
    void TweenScore()
    {
        DOTween.To(() => startValue, x => startValue = x, toValue, 1).SetEase(scoreEase).OnUpdate(() =>
          {
              scoreText.text = "Score: " + startValue.ToString("F2");
          });
    }
}
