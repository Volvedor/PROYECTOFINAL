using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCount : MonoBehaviour
{
    List<string> bounces;
        
    void Awake()
    {
       bounces = new List<string>();              
    }

    void OnCollisionEnter(Collision col)
        {
            if(col.transform.gameObject.tag == "Limits" )
            {
            bounces.Add("Has rebotado" + (bounces.Count) + "Veces");
            Debug.Log(bounces.Count);
            }
        }
    
}
