using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform p1Spawn;
    public Transform p2Spawn;
    Vector3 newP1Spawn;
    Vector3 newP2Spawn;

    void Awake()
    {
        newP1Spawn = new Vector3(p1Spawn.position.x , p1Spawn.position.y , gameObject.transform.position.z);
        newP2Spawn = new Vector3(p2Spawn.position.x , p2Spawn.position.y , gameObject.transform.position.z);
    } 
      
    void Update()
    {
       SpawnChange();            
    }

    void SpawnChange()
    {
        RaycastHit hit;
                        
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 30f))
        {
            Debug.Log("Checkpoint!");
            p1Spawn.position = newP1Spawn;
            p2Spawn.position = newP2Spawn;
        } 
    }
}
