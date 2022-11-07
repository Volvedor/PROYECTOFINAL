using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public bool activePlayer = true;
    Rigidbody rb;
    public float speed = 30f;
    private CheckDistance check;

    private void Awake() 
    {
        check = GetComponent<CheckDistance>();
        rb = GetComponent<Rigidbody>();
    }    
    void Update()
    {
        PlayerSwitch();
        SpeedCalculator();
    }

    void FixedUpdate() 
    {
        PlayerMovement();
        PlayerJump();
    }

    void PlayerSwitch()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && activePlayer == true)
        {
            activePlayer = false;
        }
        
        else if(Input.GetKeyDown(KeyCode.Tab) && activePlayer == false) 
        {
            activePlayer = true;
        }

    }

    void PlayerMovement()
    {
        if(activePlayer == true)
        {
            float hMov = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
            float vMov = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
            rb.AddForce(new Vector3(hMov,0,0), ForceMode.Impulse);
            rb.AddForce(new Vector3(0,0,vMov), ForceMode.Impulse);
        }
    }

    void PlayerJump()
    {
        if(activePlayer == true)
        {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.6f )
            {
                rb.AddForce(new Vector3 (0,speed / 4,0), ForceMode.Impulse);
            }
        }
    }


    void SpeedCalculator()
    {
        speed = 36f - check.distance / 2f;
    }
}