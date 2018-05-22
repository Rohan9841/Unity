using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {

        //looking at the door
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.transform.GetComponent<ButtonScript>() != null)
            {
                hit.transform.GetComponent<ButtonScript>().OnLook();
            }
        }

        //looking at the enemy

        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            RaycastHit enemyHit;
            if (Physics.Raycast(transform.position, transform.forward, out enemyHit))
            {
                if (enemyHit.transform.GetComponent<EnemyScript>() != null)
                {
                    Destroy(enemyHit.transform.gameObject);
                }
            }
        }
        
	}
}
