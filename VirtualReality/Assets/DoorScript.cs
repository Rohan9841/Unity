using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Vector3 targetPosition;
    public Vector3 loweredPosition;

	// Use this for initialization
	void Start () {
        targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
       
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
	}

    public void LowerDoor()
    {
        targetPosition = loweredPosition;
        Debug.Log("door lowered");
    }
}
