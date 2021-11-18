using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class shootScript : MonoBehaviour
{
	public GameObject bullet;
	List<GameObject> bulletsList = new List<GameObject>();
	public int maxBullets = 10;
	public int torque = 5000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
			Vector3 cur = transform.position;
			GameObject bulletInstance = Instantiate(bullet, cur, Quaternion.identity);
			// удаление старых объектов, чтобы не плодить
			bulletsList.Add(bulletInstance);
			if(bulletsList.Count > maxBullets) 
			{
				 GameObject first = bulletsList[0];
				bulletsList.Remove(first);
				Destroy(first);
			};
			Vector3 bulletVec = new Vector3(1f, 1f, 1f); 
			print(transform.forward);
			bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * torque);
		}
			
    }
}
