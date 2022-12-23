
using UnityEngine;

public class FlashControl : MonoBehaviour
{
    public GameObject[] lights;
    bool isAvailable = true;
    float cooldown = 0;
    float duration = 1.5f;

   void Update() 
   {
        Flash();
        FlashCD();        
   }
    

    void Flash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAvailable == true && cooldown <= 0) 
        {
            UseFlash();
        }

        if (Input.GetKeyDown(KeyCode.Space) && cooldown >= 0) 
        {
            Debug.Log("FLASH COOLDOWN: " + cooldown);
        }
    }

    void UseFlash()
    {
        
        Invoke("FlashActive",0);
        Invoke("FlashInactive",0.15f);
        Invoke("FlashActive",0.30f);
        Invoke("FlashInactive",0.45f);
        Invoke("FlashActive",0.60f);
        Invoke("FlashInactive",0.75f);
        Invoke("FlashActive",0.9f);
        Invoke("FlashInactive",1.05f);
        Invoke("FlashActive",1.20f);
        Invoke("FlashInactive",1.35f);
        Invoke("FlashActive",1.50f);
        Invoke("FlashInactive",1.65f);
        cooldown = 10;
    }            

    void FlashActive()
    {
        lights[1].SetActive(true);
    }   

    void FlashInactive()
    {
        lights[1].SetActive(false);
    }
           

    void FlashCD()
    {
        if (isAvailable == true)
        {   
            cooldown = cooldown - 1 * Time.deltaTime;
        }
        
    }
}
    