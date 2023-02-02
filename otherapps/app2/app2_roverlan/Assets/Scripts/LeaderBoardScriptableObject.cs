using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LeaderBoardScriptableObject", order = 1)]
public class LeaderBoardScriptableObject : ScriptableObject {
    public static List<string> LeaderBoardlist = new List<string>();
}


