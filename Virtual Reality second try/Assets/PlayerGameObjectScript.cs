using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameObjectScript : MonoBehaviour {
    public Vector3 targetPosition;
    public Vector3 castlePosition;
    public float speed = 3f;
    public bool enteredCastle = false;

    // Use this for initialization
    void Start () {
        targetPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }

    public void moveToCastle()
    {
        enteredCastle = true;
        targetPosition = castlePosition;

    }
}
