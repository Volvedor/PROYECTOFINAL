using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShowTime : MonoBehaviour
{
    public TMP_Text ShowTimeUI;
    float totalSeconds = 0;  
          
    
    void Update()
    {
        TimeSpan timeEnlapsed = TimeSpan.FromSeconds(totalSeconds);
        ShowTimeUI.text = timeEnlapsed.ToString("hh':'mm':'ss");
        Count();
        Debug.Log(totalSeconds);
    }

    void Count()
    {
        totalSeconds = (totalSeconds + Time.deltaTime);
    }


}
