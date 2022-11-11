using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 100f;
    
    private void Awake() 
    {
      rb = GetComponent<Rigidbody>();
    }    
   
    void FixedUpdate() 
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hMov = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float vMov = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        rb.AddForce(new Vector3(hMov,0,0), ForceMode.Impulse);
        rb.AddForce(new Vector3(0,0,vMov), ForceMode.Impulse);
    }
}
    


    