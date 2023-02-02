using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Camera cam;
    public int speed = 10;
    private int SavedSpeed;
    private Rigidbody rb;
    private Transform playerTrans;
    private bool inTriggerJumpPad = false;
    private int inTriggerInverse = 1;
    public int jumpForce = 1000;
    private int control = 1;
    void Start()
    {
        //get reference to the rigid body of the player to apply some forces
        rb = GetComponent<Rigidbody>();
        playerTrans = GetComponent<Transform>();
        SavedSpeed = speed;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (inTriggerJumpPad == true){
                rb.AddForce(Vector3.up * jumpForce);
            }
        }
        //get inputs
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //multiply by the inverse variable which will be either 1 or -1 for when in inverse areas
        
        Vector3 targetDirection = new Vector3(horizontal * inTriggerInverse * control, 0f, vertical* inTriggerInverse * control).normalized;
        targetDirection = Camera.main.transform.TransformDirection(targetDirection);
        targetDirection.y = 0.0f;
        
        //apply the force
        if(control != 0){
            rb.AddForce(targetDirection * speed * control);
        }
        
    }
    void OnTriggerEnter(Collider other) { 
        //set the values for when in specific area
        if(other.tag == "JumpPad"){inTriggerJumpPad = true;}
        if(other.tag == "Inverse"){inTriggerInverse = -1;}
        if(other.tag == "SuperSpeed"){speed = 50;}
        if(other.tag == "NoControl"){control = 0;}
    }
    void OnTriggerExit(Collider other){
        //undo the values when exiting the collider
        if(other.tag == "JumpPad"){inTriggerJumpPad = false;}
        if(other.tag == "Inverse"){inTriggerInverse = 1;}
        if(other.tag == "SuperSpeed"){speed = SavedSpeed;}
        if(other.tag == "NoControl"){control = 1;}
    }
}
