using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleSpawner : MonoBehaviour
{
    public GameObject puddlePrefab;
    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(puddlePrefab, 
                new Vector3(
                    Random.Range(-100.0f, 100.0f),
                    4f, 
                    Random.Range(-100.0f, 100.0f)
                ),
                Quaternion.identity);
        }
        
    }

}
