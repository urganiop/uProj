using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFillTank : MonoBehaviour
{
    [SerializeField] private playerStat stat;
    [SerializeField] private puddleStats puddle;
    
    void Start()
    {
        stat = gameObject.GetComponent<playerStat>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        puddle = collider.GetComponent<puddleStats>();
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("puddle") &&
            Input.GetKey(KeyCode.E))
        {
            print("puddle");
            if (puddle.Type != null && 
                stat.GasType != puddle.Type)
            {
                stat.GasType = puddle.Type;
                stat.Gas = 0;
            }

            stat.Gas += Time.deltaTime;
        }
    }
    
    
}
