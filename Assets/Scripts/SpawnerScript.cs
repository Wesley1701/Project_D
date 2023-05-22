using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectD.Scripts;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] myObjects;
    public GameObject[] myObjectsHighlighted;
    public Transform[] spawnpoints;
    GameObject final;
    int counter = 0;

    GameObject CHOsen = StateNameController.Chosen;
    
    void Update()
    {
        if(Input.touches[0].phase == TouchPhase.Began && counter == 1)
        {
            //int randomIndex = Random.Range(0, myObjects.Length);

            int randomIndexPoints = Random.Range(0, spawnpoints.Length);
            Transform neww = spawnpoints[randomIndexPoints];
            Vector3 spawnPos = neww.position;
            float radius = 0.01f;
            if (!Physics.CheckSphere(spawnPos, radius)) 
            {
                Instantiate(myObjects[0], neww.position, Quaternion.identity);
            }
        }

        if(Input.touches[0].phase == TouchPhase.Began && counter == 0)
        {
            for (int i = 0; i < myObjects.Length; i++)
            {
                if(myObjects[i] == CHOsen){
                    final = myObjectsHighlighted[i];
                }
            }
            //int randomIndex = Random.Range(0, myObjects.Length);

            int randomIndexPoints = Random.Range(0, spawnpoints.Length);
            Transform neww = spawnpoints[randomIndexPoints];
            Instantiate(myObjectsHighlighted[0], neww.position, Quaternion.identity);
            counter = counter + 1;
        }
    }
}