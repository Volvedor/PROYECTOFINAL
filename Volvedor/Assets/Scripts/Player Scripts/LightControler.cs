using UnityEngine;

public class LightControler : MonoBehaviour
{
    public CheckDistance check;
    private Light light;

    
    private void Awake() 
    {
        light = GetComponent<Light>();
    }    

    void Update()
    {
        LightIntensity();
        LightCone();
    }

    void LightIntensity()
    {
        light.intensity = 14 - check.distance/4f;
    }
    void LightCone()
    {
        light.spotAngle = 149 - check.distance * 2f;
    }

}
