using UnityEngine;

public class GameOver : MonoBehaviour
{
    public CheckDistance check;
    public GameObject spawnPoint;
    public Rigidbody rb;

    void Update()
    {
        TooFar();
    }

    void TooFar()
    {
        if(check.distance > 45f || transform.position.y < -1f)
        {
            transform.position = spawnPoint.transform.position;
            rb.velocity = Vector3.zero;
            Debug.Log("You cant be that far apart!");
        }
    
    }
}
