using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCount : MonoBehaviour
{
    List<string> bounces;
    public static int scoreCount;
        
    void Awake()
    {
        bounces = new List<string>();            
    }

    void Update()
    {
        GetPoint();
    }
    
    void OnCollisionEnter(Collision col)
        {
            if(col.transform.gameObject.tag == "Limits" && col.gameObject.GetComponent<Light>().color == gameObject.GetComponent<Light>().color)
            {
            bounces.Add("1 Point");
            }           
            
        }
    
    void GetPoint()
    {
        scoreCount = bounces.Count;
    }
    
}
