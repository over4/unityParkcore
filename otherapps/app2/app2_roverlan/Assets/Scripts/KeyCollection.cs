using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    private GameObject yellowDoor;
    private GameObject redDoor;
    private GameObject blueDoor;
    public AudioSource coinAudio;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("YellowKey")){
            other.gameObject.SetActive(false);
            yellowDoor = GameObject.FindGameObjectWithTag("YellowDoor");
            yellowDoor.SetActive(false);
            coinAudio.Play();
        }
        if(other.gameObject.CompareTag("RedKey")){
            other.gameObject.SetActive(false);
            redDoor = GameObject.FindGameObjectWithTag("RedDoor");
            redDoor.SetActive(false);
            coinAudio.Play();
        }
        if(other.gameObject.CompareTag("BlueKey")){
            other.gameObject.SetActive(false);
            blueDoor = GameObject.FindGameObjectWithTag("BlueDoor");
            blueDoor.SetActive(false);
            coinAudio.Play();
        }
    }
}
