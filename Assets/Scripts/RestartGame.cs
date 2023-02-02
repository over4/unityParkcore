using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public GameManger gameManger;
   void OnCollisionEnter(Collision other) { 
       if(other.gameObject.tag == "Player"){
           gameManger.Failedgame();
       }
   }
}
