
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject[] lights;
    bool isActive = true;
    public float cooldown = 0;
    public float duration = 0.5f;

   void Update() 
   {
        SwitchLights();
        LightsCD();
        LightsDuration();
   }
    

    void SwitchLights()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true && cooldown <= 0) 
        {
            lights[0].SetActive(false);
            isActive = false;
            lights[1].SetActive(true);
            Debug.Log("Light 1");
        }

        if (Input.GetKeyDown(KeyCode.E) && cooldown >= 0) 
        {
            Debug.Log("FLASH COOLDOWN: " + cooldown);
        }
    }

    void LightsDuration()
    {
        if (isActive == false)
        {
            duration = duration - 1 * Time.deltaTime;
            cooldown = 10;

            if (duration <= 0)
            {
                lights[0].SetActive(true);
                isActive = true;
                lights[1].SetActive(false);
                duration = 1;
            }
        }
    }

    void LightsCD()
    {
        if (isActive == true)
        {   
            cooldown = cooldown - 1 * Time.deltaTime;
        }
        
    }
}
    