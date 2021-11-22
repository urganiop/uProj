using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageReciever : MonoBehaviour
{
	public int totatlHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(totatlHealth <= 0) {
			Destroy(gameObject);
		}
    }
	
	void OnCollisionEnter(Collision collision) 
	{
		totatlHealth -= 1;
		print("collision");
	}
}
