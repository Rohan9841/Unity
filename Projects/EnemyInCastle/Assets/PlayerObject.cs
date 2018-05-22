using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour {

    //used to confirm if the player has entered inside the castle. This is used 
    //in the GameController script to change the infotext.
    public bool enteredCastle = false;

    //Store the destination of the player which we set using unity.
    public Vector3 PlayerDestination;

    //store the current position of the target
    public Vector3 targetPosition;

    // Use this for initialization
    void Start () {
        //the current position of the playerobject is stored in targetPosition
        targetPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //moving the player to the targetPosition which is currently its position.
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
	}

    //Once this method is called, the targetPosition is set to the playerDestination and enteredCastle is set to true.
    public void moveToCastle()
    {
        Debug.Log("Move Successful");
        targetPosition = PlayerDestination;
        enteredCastle = true;
    }
}
