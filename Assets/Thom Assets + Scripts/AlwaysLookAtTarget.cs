using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectD.Scripts;

public class AlwaysLookAtTarget : MonoBehaviour
{

    Transform a;
    //public GameObject doos;
    void Start()
    {
        a = SpawnerScript.targot;
        this.transform.LookAt(a.position);
        this.transform.Rotate(0,90,0);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Target);
        // Vector3 targetPostition = new Vector3( a.position.x, 
        //                                 a.position.y, 
        //                                 a.position.z ) ;
        a = SpawnerScript.targot;
        this.transform.LookAt(a.position);
        this.transform.Rotate(0,90,0);
    }
}