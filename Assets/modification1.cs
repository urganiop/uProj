using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modification1 : MonoBehaviour
{
	public float delay = 0.005f;
	public GameObject ball;
	public float stime;
	public bool activeState = true;
    // Start is called before the first frame update
    void Start()
    {	
		stime = Time.time;
        InvokeRepeating("CreateFog", 0.1f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - stime > 1) {
			activeState = false;
		}
    }
	
	void CreateFog()
	{
		if (activeState == true)
		{
			Vector3 cur = transform.position;
			GameObject fogParticle = Instantiate(ball, cur, Quaternion.identity);
			Vector3 direction = Random.insideUnitCircle.normalized;
			fogParticle.GetComponent<Rigidbody>().velocity = direction;
			Destroy(fogParticle, 0.5f);
		}
	}
}
