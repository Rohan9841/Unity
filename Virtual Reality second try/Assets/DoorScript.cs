using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public Vector3 targetPosition;
    public Vector3 loweredPosition;

	// Use this for initialization
	void Start () {
        targetPosition = transform.position;
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime*3f);
	}

    public void LowerDoor()
    {
        targetPosition = loweredPosition;
    }
}
