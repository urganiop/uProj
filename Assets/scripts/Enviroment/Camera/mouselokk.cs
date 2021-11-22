using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselokk : MonoBehaviour
{
	public float mouseSensitivity = 1f;
	public Transform playerBody;

	public float mouseX;
	public float mouseY;
	
	float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        this.mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		this.mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		
		xRotation -= this.mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		playerBody.Rotate(Vector3.up * this.mouseX);
    }
}
