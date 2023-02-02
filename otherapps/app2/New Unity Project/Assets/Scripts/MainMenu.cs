using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame(){
        SceneManager.LoadScene("MainGame");
    }
    public void quitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
