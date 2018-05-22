using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
    public DoorScript door;
    public PlayerGameObjectScript movePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnLook()
    {
        door.LowerDoor();
        movePlayer.moveToCastle();
    }

}
