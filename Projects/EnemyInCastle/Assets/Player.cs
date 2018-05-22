using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    //hit is the variable with datatype RaycastHit
    private RaycastHit hit;
    private RaycastHit enemyHit;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        //Raycast method from Physics class. 
        //transform.position = source of raycast
        //transform.forward = direction of ray
        //out hit = store the object hit by raycast in hit variable
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            //the object hit by the raycast is button cube. If it has component Button (script)
            if (hit.transform.GetComponent<Button>() != null)
            {
                Debug.Log("Raycast good");
                //get the Button script and set the OnLook() method. The OnLook() method will set the LowerDoor() method. The LowerDoor() method 
                //will set the value of targetPosition to LoweredPosition.
                hit.transform.GetComponent<Button>().OnLook();
            }

            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
            {
                if (hit.transform.GetComponent<Enemy>() != null)
                {
                    Debug.Log("Enemy Hit succesful");
                    Destroy(hit.transform.gameObject);
                }
            }
        }

        
	}

}
