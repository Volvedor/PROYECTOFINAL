
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject[] cameras;
    bool isActive = true;

   void Update() 
   {
        SwitchCamera();
   }
    

    void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && isActive == true) 
        {
            cameras[0].SetActive(false);
            isActive = false;
            cameras[1].SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && isActive == false) 
        {
            cameras[0].SetActive(true);
            isActive = true;
            cameras[1].SetActive(false);
        }
    }
}
    