using UnityEngine;
using System.Collections;

[System.Serializable]
public class Obstacle : MonoBehaviour {

    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;

    //Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        GameObject theScript = GameObject.Find("Scripts");

        Scripts script = theScript.GetComponent<Scripts>();
        if (script.mode == 1)
        {
            //random height
            transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
        } else if(script.mode == 2)
        {
            float[] arr = { transform.position.y - range * 0.5f, transform.position.y - range * 0.3f, transform.position.y - range * 0.7f, transform.position.y - range * 0.4f, transform.position.y - range * 0.7f, transform.position.y - range * 0.4f };

            if (Scripts.index < arr.Length)
            {
                transform.position = new Vector3(transform.position.x, arr[Scripts.index], transform.position.z);
                Scripts.index++;
            }
        }
    }
}
