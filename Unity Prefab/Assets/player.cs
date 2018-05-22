using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))//when left mouse button is clicked.
        {
            //bulletObject is a variable of datatype GameObject which stores the bulletPrefab created by Instantiate method.
            GameObject bulletObject = Instantiate(bulletPrefab);

            //bulletVariable is a variable of class dataype called 'Bullet'. The instantiated bullet Prefab is then linked to the Bullet Component.
            //But the prefab already is linked to Bullet Script. I don't understand this properly.
            Bullet bulletVariable = bulletObject.GetComponent<Bullet>();

            //Then the bulletVariable acceses the shooting Direction of the Bullet component.
            //we create new vector for the shootingDirection as it is not initialized yet.
            bulletVariable.shootingDirection = new Vector3( 
                Random.Range(-0.2f, 0.2f),//Determining the range of x-direction
                Random.Range(0f, 0.15f),//Determining the range of y-direction
                1/*z-direction*/).normalized;//for calculations and no roundoff error, we have to normalize the vection. It makes the
                //direction with value one.
        }
	}
}
