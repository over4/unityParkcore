using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionSound : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

void Start () {
    audioSource = gameObject.AddComponent<AudioSource>();
}

private void OnCollisionEnter(Collision collision)
{
    //set the audio level based on how fast the player was moving
    float audioLevel = collision.relativeVelocity.magnitude / 40.0f;
    //play the audio clip once
    audioSource.PlayOneShot(audioClip, audioLevel);
}
}
