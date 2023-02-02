using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningCyclinder : MonoBehaviour
{
    // Update is called once per frame
    private Rigidbody rb;
    public float spinSpeed = 180;
    public int direction = 1;
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    
    void Start(){
        // rb = GetComponent<Rigidbody>();
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        m_EulerAngleVelocity = new Vector3(spinSpeed * direction, 0, 0);
    }
    void FixedUpdate()
    {
        

        //set the rotation
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        //apply the rotation
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}
