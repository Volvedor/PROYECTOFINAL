using UnityEngine;

public class CheckDistance : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float distance; 

    void Update() 
    {
        distance = Vector3.Distance(player1.position , player2.position);
        Checker();
    }

    public void Checker()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log(distance);
        }
    }

}
