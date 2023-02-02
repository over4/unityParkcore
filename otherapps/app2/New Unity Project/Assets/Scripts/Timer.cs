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
        //update the timer
        timer += Time.deltaTime;
        //set a span
        var timeSpan = System.TimeSpan.FromSeconds(timer);
        //update the text
        timerText.text = timeSpan.Hours.ToString("00") + ":" + timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00") + "." + timeSpan.Milliseconds/100;
    }
}
