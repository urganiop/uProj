using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lujaSpawner : MonoBehaviour
{
    public GameObject LujaPrefub;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(LujaPrefub, 
                new Vector3(
                    Random.Range(-100.0f, 100.0f),
                    4f, 
                    Random.Range(-100.0f, 100.0f)
                ),
                Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
