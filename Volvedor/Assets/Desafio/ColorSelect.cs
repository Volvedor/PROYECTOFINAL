using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour
{
    public Light colorControl;
    public Color[] color = new Color[4];
     
    private void Awake() 
    {
        colorControl = GetComponent<Light>();
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.magenta;
        
    }    

    void Start() 
    {
        colorControl.color = color[0];        
    }
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ChangeColorUp();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangeColorDown();
        }

              
    }
   
    void ChangeColorUp()
    {
        Debug.Log(colorControl.color);
        
        if(colorControl.color == color[0])
        {
            colorControl.color = color[1];
        }

        else if(colorControl.color == color[1])
        {
            colorControl.color = color[2];
        }

        else if(colorControl.color == color[2])
        {
            colorControl.color = color[3];
        }

        else if(colorControl.color == color[3])
        {
            colorControl.color = color[0];
        }

    }

    void ChangeColorDown()
    {
        Debug.Log(colorControl.color);
        
        if(colorControl.color == color[0])
        {
            colorControl.color = color[3];
        }

        else if(colorControl.color == color[1])
        {
            colorControl.color = color[0];
        }

        else if(colorControl.color == color[2])
        {
            colorControl.color = color[1];
        }

        else if(colorControl.color == color[3])
        {
            colorControl.color = color[2];
         }

    }
    
}
    
     
