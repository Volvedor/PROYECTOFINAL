using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect1 : MonoBehaviour
{
    public Light colorControl1;
    public Color[] color = new Color[4];
     
    private void Awake() 
    {
        colorControl1 = GetComponent<Light>();
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.green;
        
    }    

    void Start() 
    {
        colorControl1.color = color[0];        
    }
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            ChangeP1Color();
        }
              
    }
   
    void ChangeP1Color()
    {
        Debug.Log(colorControl1.color);
        
        if(colorControl1.color == color[0])
        {
            colorControl1.color = color[1];
            Debug.Log("ROJO");
        }

        else if(colorControl1.color == color[1])
        {
            colorControl1.color = color[2];
            Debug.Log("AMARILLO");
        }

        else if(colorControl1.color == color[2])
        {
            colorControl1.color = color[3];
            Debug.Log("VERDE");
        }

        else if(colorControl1.color == color[3])
        {
            colorControl1.color = color[0];
            Debug.Log("AZUL");
        }

    }
    
}
    
     
