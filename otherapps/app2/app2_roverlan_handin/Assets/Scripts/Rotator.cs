using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //rotate the coin each frame 
        transform.Rotate(new Vector3(90,0,0) * Time.deltaTime);
    }
}
