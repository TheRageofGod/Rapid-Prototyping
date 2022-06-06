using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    /// <summary>
    /// Gets Random colour using the RGB colourWheel with an alpha of 1
    /// </summary>
    /// <returns>returns random colour</returns>
    public Color GetRandomColour()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}
