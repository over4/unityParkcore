﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManger gameManger;
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){gameManger.Completegame();}
    }
}
