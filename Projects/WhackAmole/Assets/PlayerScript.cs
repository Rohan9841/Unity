using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    //stores hit object
    RaycastHit hit;

    //stores the 'Mole' script
    Mole mole;
    
    //counts the number of hits
    public int hitCounter = 0;

    //counts the score of a player
    public int score = 0;

    public Hammer hammer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if the cardboard button is clicked or mouse button is clicked
        if (GvrPointerInputModule.Pointer.TriggerDown || Input.GetMouseButtonDown(0))
        {
            //if raycast hits an object
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                    //if the hit object has any component called Mole
                if (hit.transform.GetComponent<Mole>() != null)
                {
                    //storing the script in variable mole
                    mole = hit.transform.GetComponent<Mole>();

                    //calling OnHit() function from the Mole script
                    mole.OnHit();

                    //increase by one

                    hitCounter += 1;
                    score += 1;
                    Debug.Log(hitCounter);

                    //Calling the hammerHit function to move the hammer to the position of mole
                    hammer.hammerHit(mole.transform.position);
                }

            }
        }

	}
}
