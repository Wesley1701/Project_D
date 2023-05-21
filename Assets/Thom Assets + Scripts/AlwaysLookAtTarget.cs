using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysLookAtTarget : MonoBehaviour
{

    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Target);
        Vector3 targetPostition = new Vector3( Target.position.x, 
                                        Target.position.y, 
                                        Target.position.z ) ;
        this.transform.LookAt( targetPostition ) ;
        transform.Rotate(0, 90, 0);
    }
}