﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public DoorScript openDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnLook()
    {
        Debug.Log("Button Looked");
        openDoor.LowerDoor();
    }
}
