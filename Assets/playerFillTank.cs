using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFillTank : MonoBehaviour
{
    [SerializeField] private playerStat stat;
    [SerializeField] private lujaStat luja;
    
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
        luja = collider.GetComponent<lujaStat>();
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("luja") &&
            Input.GetKey(KeyCode.E))
        {
            print("luja");
            if (luja.Type != null && 
                stat.GasType != luja.Type)
            {
                stat.GasType = luja.Type;
                stat.Gas = 0;
            }

            stat.Gas += Time.deltaTime;
        }
    }
    
    
}
