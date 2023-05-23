using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectD.Scripts;

public class AlwaysLookAtTarget : MonoBehaviour
{

    GameObject a = SpawnerScript.targot;

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Target);
        // Vector3 targetPostition = new Vector3( a.position.x, 
        //                                 a.position.y, 
        //                                 a.position.z ) ;
        this.transform.LookAt(a.transform);
    }
}