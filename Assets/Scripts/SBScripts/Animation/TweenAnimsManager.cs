using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenAnimsManager : MonoBehaviour
{
    public LeanTweenType inType;
    public LeanTweenType outType;
    public Vector2 objectOut, objectIn;
    public float delay;
     
    public void PanelIn()
    {
        LeanTween.moveLocalY(gameObject, objectIn.y, delay).setEase(inType);
        LeanTween.moveLocalX(gameObject, objectIn.x, delay).setEase(inType);
    }

    public void PanelOut()
    {
        LeanTween.moveLocalY(gameObject, objectOut.y, delay).setEase(outType);
        LeanTween.moveLocalX(gameObject, objectOut.x, delay).setEase(outType);
    }
}
