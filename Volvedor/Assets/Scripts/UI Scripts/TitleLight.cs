using UnityEngine;

public class TitleLight : MonoBehaviour
{
    private Light myLight;
    public Color[] color = new Color[4];
    private float timer = 1f;
   
    void Awake()
    {
     color[0] = Color.blue;
     color[1] = Color.red;
     color[2] = Color.yellow;
     color[3] = Color.magenta;            
     myLight = GetComponent<Light>();
    }        
         
    void Update()
    {
        ChangeTitleColor();
    }

    void ChangeTitleColor()
    {
       timer = timer - 1 * Time.deltaTime;
       if(timer <= 0)
       {
       myLight.color = color[Random.Range(0,4)];
       timer = 0.3f;
       }
    }
}
