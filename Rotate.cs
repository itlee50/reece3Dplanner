using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public KeyCode pressRight;
    public KeyCode pressLeft;
    public KeyCode pressUp;
    public KeyCode pressDown;
    public float rotationSpeed = 100.0F;

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(pressRight))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(pressLeft))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(pressUp))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(pressDown))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
