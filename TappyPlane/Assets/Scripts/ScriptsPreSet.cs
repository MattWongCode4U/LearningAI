using UnityEngine;
using System.Collections;

public class ScriptsPreSet : MonoBehaviour {

    public GameObject rocks;
    public static int index = 0;
    int score = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    //Update is called once per frame
    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());
    }

    void CreateObstacle()
    {
        if (index < 6)
        {
            Instantiate(rocks);
            score++;
        }
    }
}
