using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    //It will store the final position of the door
    public Vector3 loweredPosition;
    public float doorSpeed = 3f;

    //It will be used to hold the door to its current position until the player looks at the button. 
    public Vector3 targetPosition;

	// Use this for initialization
	void Start () {
        //We set the targetPosition to the current position of the door.
        targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //the position of the door is moved to the the targetposition with animation. Until the lowerDoor method is called the targetposition will 
        //be the same as the current position of door.
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * doorSpeed);
	}

    //Once this method is called, the targetPosition is set to the loweredPosition which will let the update method to lerp the door to the loweredposition.
    public void LowerDoor()
    {
        Debug.Log("accessed LowerDoor");
        targetPosition = loweredPosition;
    }
}
