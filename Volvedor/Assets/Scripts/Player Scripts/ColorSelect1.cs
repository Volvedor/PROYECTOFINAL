using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect1 : MonoBehaviour
{
    public Light colorControl1;
    public Color[] color = new Color[4];
    public bool activePlayer = true;
     
    private void Awake() 
    {
        colorControl1 = GetComponent<Light>();
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.magenta;
        
    }    

    void Start() 
    {
        colorControl1.color = color[0];        
    }
       
    void Update()
    {
        
        PlayerSwitch();

        if(activePlayer == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                ChangeP1ColorUp();
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                ChangeP1ColorDown();
            }
        }
              
    }
   
    void PlayerSwitch()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && activePlayer == true)
        {
            activePlayer = false;
        }
        
        else if(Input.GetKeyDown(KeyCode.Tab) && activePlayer == false) 
        {
            activePlayer = true;
        }

    }
    
    void ChangeP1ColorUp()
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

    void ChangeP1ColorDown()
    {
        Debug.Log(colorControl1.color);
        
        if(colorControl1.color == color[0])
        {
            colorControl1.color = color[3];
            //Debug.Log("ROJO");
        }

        else if(colorControl1.color == color[1])
        {
            colorControl1.color = color[0];
            //Debug.Log("AMARILLO");
        }

        else if(colorControl1.color == color[2])
        {
            colorControl1.color = color[1];
            //Debug.Log("VERDE");
        }

        else if(colorControl1.color == color[3])
        {
            colorControl1.color = color[2];
            //Debug.Log("AZUL");
        }

    }
    
}
    
     
