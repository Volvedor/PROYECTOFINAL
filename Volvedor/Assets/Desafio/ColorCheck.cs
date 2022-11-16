using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{
    public Light spotlight;
    private Light myLightColor;

    void Awake() 
    {
        myLightColor = GetComponent<Light>();
    }
  
    void Update()
    {
        ColorCheckChange();
    }

    void ColorCheckChange()
    {
        myLightColor.color = spotlight.GetComponent<Light>().color;
    }
}
