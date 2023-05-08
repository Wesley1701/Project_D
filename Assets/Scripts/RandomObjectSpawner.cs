using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject MyObject;

    void Start()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-10,11), 5, Random.Range(-10,11));

        Instantiate(MyObject, randomSpawn, Quaternion.identity);
    }
}
