using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed = 2.5f;
    public float jumpingForce = 300f;
    private bool hitFloor = true;
    public float rotatingAngle = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, Vector3.up, rotatingAngle);
        }

        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotatingAngle);
        }

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown("space") && hitFloor)
        {
            hitFloor = false;
            GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);   
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Plane")
        {
            hitFloor = true;
        }
    }
}
