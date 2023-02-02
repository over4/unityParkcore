using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float speedMulti = 1f;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    void Start()
    {
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
        m_AudioSource = GetComponent<AudioSource>();
    }
    void FixedUpdate() //this needs to be called before onanimatormove to give quaternion a value
    {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");

        m_Movement.Set(horizontal*speedMulti,0f,vertical*speedMulti); //set the valuses to the vector
        //m_Movement.Normalize(); //normalize the vector so diagonal isnt faster

        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f); //bool for moving horizontal
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f); //bool for moving vertical
        bool isWalking = hasHorizontalInput || hasVerticalInput; //new bool for if movement is happening
        m_Animator.SetBool ("IsWalking", isWalking);
        if(isWalking)
        {
            if(!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play ();
            }
        }
        else
        {
            m_AudioSource.Stop ();
        }

        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f); //face john in the direction of movement
        m_Rotation = Quaternion.LookRotation (desiredForward); //store the rotation in a variable
    }
    //need this method since the movement may be overiden by the animator since there is no animation for turning and turning the rigid body may cause problems
    void OnAnimatorMove(){ 
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation (m_Rotation);
    }
}

