using UnityEngine;

public class Gate : MonoBehaviour

{
  float timeTouching = 0;  
  public GameObject pared;
  
  void OnTriggerExit(Collider coll)
  {
    if(coll.transform.gameObject.name == "Umbral")
    {      
        if(transform.localScale.y == 3)
        {
            transform.localScale = new Vector3 (0.5f,1.5f,0.5f);
            Debug.Log("Small Guy");
        }
        else
        {
            transform.localScale = new Vector3 (1,3,1);
            Debug.Log("Big Guy");
        }        
    }

  }
       

    void OnTriggerStay(Collider coll)
    {
        float randomPosX = Random.Range (-10,10);
        float randomPosY = Random.Range (0,5);
        float randomPosZ = Random.Range (-10,10);
        float randomRotX = Random.Range (0,0);
        float randomRotY = Random.Range (0,360);
        float randomRotZ = Random.Range (0,360);
        
        if(coll.transform.gameObject.name == "ParedDorada")
        {
            timeTouching += Time.deltaTime;
            
            if(timeTouching > 2)
            {
                pared.transform.position = new Vector3 (randomPosX,randomPosY,randomPosZ);
                pared.transform.rotation = new Quaternion (randomRotX,randomRotY,randomRotZ,0);
                Debug.Log("*blink*");
                timeTouching = 0;
            }
        }

    }



  
}

  
  

