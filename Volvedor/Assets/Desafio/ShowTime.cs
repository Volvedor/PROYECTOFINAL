using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public Text Timetxt;
    public float timeEnlapsed = 0;

    void Update()
    {
        Temp();
        Debug.Log(timeEnlapsed);
        Timetxt.text = "TIME = " + timeEnlapsed;
    }

    void Temp()
    {
        timeEnlapsed = timeEnlapsed + 1 * Time.deltaTime;
    }
}
