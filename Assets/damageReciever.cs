using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageReciever : MonoBehaviour
{
	public int totatlHealth;
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
		print(collision);
	}
}
