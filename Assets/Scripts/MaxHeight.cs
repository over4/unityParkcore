using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHeight : MonoBehaviour
{
    public Text maxHeightText;
    private GameObject player;
    private float startHeight = 0;
    private float currentHeight;
    private float Maxheight;
    void Start()
    {
        //get a reference to the player
        player = GameObject.FindGameObjectWithTag("Player");
        //set the max height
        Maxheight = startHeight;
    }

    
    void Update()
    {
        currentHeight = player.transform.position.y;
        if(currentHeight > Maxheight){
            Maxheight = currentHeight;
            maxHeightText.text = Maxheight.ToString() + "m";
        }
    }
}
