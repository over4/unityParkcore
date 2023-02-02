using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public Text leaderboardtext;
    public TextAsset textfile;
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    public void populate(){
        string path = Application.persistentDataPath + "/LeaderBoard.txt";
       //Read the text from directly from the test.txt file
       StreamReader reader = new StreamReader(path);
        leaderboardtext.text = reader.ReadToEnd();
        reader.Close();
    }
}
