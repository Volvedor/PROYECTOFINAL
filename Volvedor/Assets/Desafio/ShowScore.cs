using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text Score;

    void Start()
    {
        
    }

    void Update()
    {
        Score.text = "SCORE = " + BounceCount.scoreCount;
    }
}
