using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEnding : MonoBehaviour
{
    public GameObject player;
    public GameObject endscreen;
    
    bool m_IsPlayerAtExit;
    void Start(){
        endscreen.SetActive(false);
        Time.timeScale = 1f;
    }
    void OnTriggerEnter (Collider other) //if john reaches the collider, this method will enter
    {
        if (other.gameObject == player) //checking to make sure it is the player that collides
        {
            Time.timeScale = 0f;
            m_IsPlayerAtExit = true; //set the vasriable to say john made it
        }
    }
    void Update ()
    {
        if(m_IsPlayerAtExit) //check this bool every update
        {
            EndLevel(); //exit the level with this method
        }
    }
    void EndLevel () //this method decide what to do when player reaches the end
    {
        {
            endscreen.SetActive(true);
        }
    }
}
