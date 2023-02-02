using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timer = 0f;
    public static float seconds = 0f;
    public Text timerText;
    
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = timer % 60;
        timerText.text = "Seconds: " + seconds.ToString();
    }
}
