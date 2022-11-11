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
        color[3] = Color.green;
        
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
            Debug.Log("ROJO");
        }

        else if(colorControl.color == color[1])
        {
            colorControl.color = color[2];
            Debug.Log("AMARILLO");
        }

        else if(colorControl.color == color[2])
        {
            colorControl.color = color[3];
            Debug.Log("VERDE");
        }

        else if(colorControl.color == color[3])
        {
            colorControl.color = color[0];
            Debug.Log("AZUL");
        }

    }

    void ChangeColorDown()
    {
        Debug.Log(colorControl.color);
        
        if(colorControl.color == color[0])
        {
            colorControl.color = color[3];
            Debug.Log("VERDE");
        }

        else if(colorControl.color == color[1])
        {
            colorControl.color = color[0];
            Debug.Log("AZUL");
        }

        else if(colorControl.color == color[2])
        {
            colorControl.color = color[1];
            Debug.Log("ROJO");
        }

        else if(colorControl.color == color[3])
        {
            colorControl.color = color[2];
            Debug.Log("AMARILLO");
        }

    }
    
}
    
     
