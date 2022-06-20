using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : GameBehaviour<UIManager>
{
    public TMP_Text bestTimeText;
    public TMP_Text currentTimeText;
  
    public void UpdateCurrentTime(float _time)
    {
        currentTimeText.text = "Current Time: " + _time.ToString("F2");
    }
    public void UpdateBestTime(float _time, bool _firstTime = false)
    {
        if (_firstTime)
        {
            bestTimeText.text = "Best Time:" + "0.00" ;
        }
        else
        bestTimeText.text = "Best Time:" + _time.ToString("F2");
    }
}
