using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera : MonoBehaviour
{

    public Transform target;
    public float offset = 10;
    // Start is called before the first frame update
    void Start()
    {
        target.position = transform.position + transform.forward * offset;
        target.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
    }

    // Update is called once per frame
    void Update()
    {
        target.position = transform.position + transform.forward * offset;
        target.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
    }
}