using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeGameUI;
    public GameObject FailedGameUI;
    public Text timeTakenEnd;
    public Text maxHeightEnd;
    public Text timeTaken;
    public Text maxHeight;
    public Rigidbody player;
    public AudioSource mainsong;
    
    public void Resume(){
        //set timescaale back
        Time.timeScale = 1f;
    }
    void Pause(){
        //set timescale to 0 so player doesnt move
        Time.timeScale = 0f;
    }
    public void Completegame(){
        mainsong.Pause();
        player.constraints = RigidbodyConstraints.FreezePosition;
        //assign the text to show the player how long it took for that run
        timeTakenEnd.text = "Time Taken: " + timeTaken.text;
        maxHeightEnd.text = "HeightReached: " + maxHeight.text + "m";
        //make the ui active
        completeGameUI.SetActive(true);
        //invoke the restart after some time
        Invoke("quitGame",10);
        
    }
    public void Failedgame(){
        mainsong.Pause();
        player.constraints = RigidbodyConstraints.FreezePosition;
        FailedGameUI.SetActive(true);
        Invoke("Restart",2);
    }
    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
    }
    void Restart(){
        SceneManager.LoadScene("MainGame");
    }
    void quitGame(){
        Debug.Log("Quit game");
        Application.Quit();
    }
}
