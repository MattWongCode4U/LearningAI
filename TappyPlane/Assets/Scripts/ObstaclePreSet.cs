using UnityEngine;
using System.Collections;

public class ObstaclePreSet : MonoBehaviour {

    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;

    //Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;

        float[] arr = { transform.position.y - range * 0.5f, transform.position.y - range * 0.3f, transform.position.y - range * 0.7f, transform.position.y - range * 0.4f, transform.position.y - range * 0.7f, transform.position.y - range * 0.4f };

        //random height
        if (ScriptsPreSet.index < arr.Length)
        {
            transform.position = new Vector3(transform.position.x, arr[ScriptsPreSet.index++], transform.position.z);
        }
    }
}
