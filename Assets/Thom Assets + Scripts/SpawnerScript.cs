using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] myObjects;
    public Transform[] spawnpoints;
    void Update()
    {
        if(Input.touches[0].phase == TouchPhase.Began)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            int randomIndexPoints = Random.Range(0, spawnpoints.Length);
            Transform neww = spawnpoints[randomIndexPoints];
            Vector3 spawnPos = neww.position;
            float radius = 0.01f;
            if (!Physics.CheckSphere(spawnPos, radius)) 
            {
                Instantiate(myObjects[0], neww.position, Quaternion.identity);
            }
        }
    }
}