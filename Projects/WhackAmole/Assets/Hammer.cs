using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    //To store the initial position of the hammer so that we can return it in that position
    public Vector3 initialPosition;

	// Use this for initialization
	void Start () {
        //setting initial position to the position in the unity window
        initialPosition = transform.position;
	}
	
    //method to move the hammer to the targetPosition
    public void hammerHit(Vector3 targetPosition)
    {
        //targetPosition is where mole is. But we need hammer to be slightly up. 
        transform.position = new Vector3 (targetPosition.x, targetPosition.y+1,targetPosition.z);
    }
	// Update is called once per frame
	void Update () {
        //during each frame the hammer's position to lerping back to the initial position.
        transform.position = Vector3.Lerp(transform.position, initialPosition, Time.deltaTime);
	}
}
