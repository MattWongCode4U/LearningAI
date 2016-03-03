using UnityEngine;
using System.Collections;

[System.Serializable]
public class Scripts : MonoBehaviour {

    //Mode for the program
    // 1 = Play mode (Random Level)
    // 2 = AI Static Level
    // 3 = AI Random Level
    public int mode = 0;

    public static int index = 0;

    public GameObject rocks;
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
        if (mode == 1)
        {
            Instantiate(rocks);
            score++;
        }

        if (mode == 2)
        {
            if (index < 6)
            {
                Instantiate(rocks);
                score++;
            }
        }
    }
}
