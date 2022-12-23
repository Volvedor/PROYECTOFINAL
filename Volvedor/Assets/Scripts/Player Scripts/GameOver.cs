using UnityEngine;

public class GameOver : MonoBehaviour
{
    public CheckDistance check;
    public GameObject spawnPoint;
    public Rigidbody rb;
    public GameObject sfx;

    void Update()
    {
        TooFar();
    }

    void TooFar()
    {
        if(check.distance > 55f || transform.position.y < -1f)
        {
            transform.position = spawnPoint.transform.position;
            rb.velocity = Vector3.zero;
            Debug.Log("You cant be that far apart!");
            Invoke("playsfx",0);
            Invoke("stopsfx",1);
        }
    
    }

    void playsfx()
    {
        sfx.SetActive(true);
    }

        void stopsfx()
    {
        sfx.SetActive(false);
    }

}

