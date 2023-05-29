using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectD.Scripts;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] myObjects;
    public GameObject[] myObjectsHighlighted;
    public Transform[] spawnpoints;
    int nummer;

    public static Transform targot;
    string CHOsen;
    
    void Start()
    {
        CHOsen = StateNameController.item.name;
        for (int i = 0; i < myObjects.Length; i++)
        {
            if(myObjects[i].name == CHOsen){
                nummer = i;
            }
        }
        int randomIndexPoints = Random.Range(0, spawnpoints.Length);
        Transform new1 = spawnpoints[randomIndexPoints];
        Instantiate(myObjectsHighlighted[nummer], new1.position, Quaternion.identity);
        targot = new1;

        for(int j = 0; j < spawnpoints.Length;j++)
        {
            int randomIndex = Random.Range(0, myObjects.Length);

            //int randomIndexPoints = Random.Range(0, spawnpoints.Length);
            Transform new2 = spawnpoints[j];
            Vector3 spawnPos = new2.position;
            float radius = 0.01f;
            if (!Physics.CheckSphere(spawnPos, radius)) 
            {
                Instantiate(myObjects[randomIndex], new2.position, Quaternion.identity);
            }
        }
    }
}