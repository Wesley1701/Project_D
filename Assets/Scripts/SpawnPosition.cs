using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    public static Transform target1;
    public static float posx;
    public static float posy;
    public static float posz;
    // Start is called before the first frame update
    void Start()
    {
        //var rand = new Random().Next(0, 1);
        //target1.position = new Vector3(posx,0.0f,0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        target1.position = new Vector3(posx, 0.0f, 0.0f);
    }
}
