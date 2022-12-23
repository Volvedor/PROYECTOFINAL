using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject music;
       
    void Awake() 
    {
        DontDestroyOnLoad(music);
    }
    
    void Update()
    {
       YouWin();            
    }

    void YouWin()
    {
        RaycastHit hit;
                        
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 30f))
        {
              SceneManager.LoadScene(2);
        } 
    }
}
