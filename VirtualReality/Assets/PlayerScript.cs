using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.transform.GetComponent<ButtonScript>()!=null) 
            {
                Debug.Log("RayCast Working");
                hit.transform.GetComponent<ButtonScript>().OnLook();
            }
        }
	}
}
