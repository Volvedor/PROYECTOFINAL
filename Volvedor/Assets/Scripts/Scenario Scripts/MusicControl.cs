using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public CheckDistance check;
    private AudioSource AS;
    
    private void Awake() 
    {
        AS = GetComponent<AudioSource>();
    }
       
    
    void Update()
    {
        MusicMix();
    }


    void MusicMix()
    {
        AS.pitch = 1.08f - check.distance/300;
    }

}

