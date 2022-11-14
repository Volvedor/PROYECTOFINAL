using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect2 : MonoBehaviour
{
    public Light colorControl2;
    public Color[] color = new Color[4];
    public bool activePlayer = false;
     
    private void Awake() 
    {
        colorControl2 = GetComponent<Light>();
        color[0] = Color.blue;
        color[1] = Color.red;
        color[2] = Color.yellow;
        color[3] = Color.magenta;
        
    }    

    void Start() 
    {
        colorControl2.color = color[1];        
    }
       
    void Update()
    {
        
        PlayerSwitch();

        if(activePlayer == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                ChangeP2ColorUp();
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                ChangeP2ColorDown();
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
    
    void ChangeP2ColorUp()
    {
        Debug.Log(colorControl2.color);
        
        if(colorControl2.color == color[0])
        {
            colorControl2.color = color[1];            
        }

        else if(colorControl2.color == color[1])
        {
            colorControl2.color = color[2];
        }

        else if(colorControl2.color == color[2])
        {
            colorControl2.color = color[3];  
        }

        else if(colorControl2.color == color[3])
        {
            colorControl2.color = color[0];
        }

    }

    void ChangeP2ColorDown()
    {
        Debug.Log(colorControl2.color);
        
        if(colorControl2.color == color[0])
        {
            colorControl2.color = color[3];
        }

        else if(colorControl2.color == color[1])
        {
            colorControl2.color = color[0];
        }

        else if(colorControl2.color == color[2])
        {
            colorControl2.color = color[1];
        }

        else if(colorControl2.color == color[3])
        {
            colorControl2.color = color[2];
        }

    }
    
}
    
     
