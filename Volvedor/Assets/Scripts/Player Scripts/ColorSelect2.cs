using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect2 : MonoBehaviour
{
    public Light colorControl2;
    public Color[] color = new Color[4];
     
    private void Awake() 
    {
        colorControl2 = GetComponent<Light>();
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.green;
        
    }    

    void Start() 
    {
        colorControl2.color = color[1];        
    }
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            ChangeP1Color();
        }
              
    }
   
    void ChangeP1Color()
    {
        Debug.Log(colorControl2.color);
        
        if(colorControl2.color == color[0])
        {
            colorControl2.color = color[1];
            Debug.Log("ROJO");
        }

        else if(colorControl2.color == color[1])
        {
            colorControl2.color = color[2];
            Debug.Log("AMARILLO");
        }

        else if(colorControl2.color == color[2])
        {
            colorControl2.color = color[3];
            Debug.Log("VERDE");
        }

        else if(colorControl2.color == color[3])
        {
            colorControl2.color = color[0];
            Debug.Log("AZUL");
        }

    }
    
}
    
     
