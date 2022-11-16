using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsColor : MonoBehaviour
{
    private Light myLight;
    public Color[] color = new Color[4];
    private float timer = 1.5f;
   
    void Awake()
    {
     color[0] = Color.blue;
     color[1] = Color.red;
     color[2] = Color.yellow;
     color[3] = Color.magenta;         
     myLight = GetComponent<Light>();
    }        
    
    void Start() 
    {
        
    }
   
    void Update()
    {
        ChangeObsColor();
    }

    void ChangeObsColor()
    {
       timer = timer - 1 * Time.deltaTime;
       if(timer <= 0)
       {
       myLight.color = color[Random.Range(0,3)];
       timer = 1.5f;
       }
    }
}
