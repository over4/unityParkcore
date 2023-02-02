using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LeaderBoardController : MonoBehaviour
{
    public Text inputText;
    private string stringBuilder;
    public TextAsset textfile;
    public void Submit(){
    //push the time and the 3 letter name
    Debug.Log("Name: " + inputText.text.ToString()+ " Time: "+ (Timer.seconds).ToString());
    stringBuilder = "Name: " + inputText.text.ToString()+ " Time: "+ (Timer.seconds).ToString();
    RuntimeText.WriteString(stringBuilder);
    SceneManager.LoadScene("MainMenu");
    }
}
