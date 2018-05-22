using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    //variable with type of Door
    public Door door;

    //variable with type PlayerObject
    public PlayerObject playerObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //method to order door to go down. 
    public void OnLook()
    {
        Debug.Log("accessed OnLook");
        door.LowerDoor();
        playerObj.moveToCastle();
    }
}
