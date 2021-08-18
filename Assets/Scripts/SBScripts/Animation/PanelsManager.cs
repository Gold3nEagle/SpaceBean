using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class PanelsManager : MonoBehaviour
{

    public LeanTweenType inType;
    public LeanTweenType outType;
    public float delay; 

  
    public void PanelIn()
    {
        LeanTween.moveLocalY(gameObject, 0f, delay).setEase(inType);
    }

    public void PanelOut()
    {
        LeanTween.moveLocalY(gameObject, 1500f, delay).setEase(outType);
    }

}
