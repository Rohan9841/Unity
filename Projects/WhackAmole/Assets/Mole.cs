using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {

    //height of the mole when it's visible
    public float originalHeight = 6.4f;

    //height of mole when it's hidden
    public float hiddenHeight = 5f;

    //speed of the movement of the mole
    public float moleSpeed = 4f;

    //In 0.5 sec the mole will disappear
    public float disappearDuration = 0.5f;

    //Set to zero because we will hide all moles when until the rise method is called
    public float disappearTimer = 0f;

    //Variable to store the target position of the mole
    private Vector3 targetPosition;

    // Use this for initialization
    void Awake () { //awake because this class is called first for some reason.

        //setting targetPosition to be at hidden height
        Hide();

        //force the mole to be hidden at the start of the game
        transform.localPosition = targetPosition;
	}
	
	// Update is called once per frame
	void Update () {

        //disappear timer reducting per second
        disappearTimer -= Time.deltaTime;

        //since disappearTimer is zero at the beginning the moles will keep hiding
        if(disappearTimer <= 0f)
        {
            Hide();
        }
        //updating local position of the mole to targetPosition
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * moleSpeed);
	}

    //method to rise the mole
    public void Rise()
    {
        //setting targetPosition to original position
        targetPosition = new Vector3(
            transform.localPosition.x,
            originalHeight,
            transform.localPosition.z
            );
        
        //Once the mole rises, it should disappear after 0.5 sec.
        disappearTimer = disappearDuration;

    }

    //method to hide the mole
    public void Hide()
    {
        //hiding the moles
        targetPosition = new Vector3(
            transform.localPosition.x,
            hiddenHeight,
            transform.localPosition.z
            );
    }

    //method to hide when player hits the mole
    public void OnHit()
    {
        Debug.Log("Hit");
        Hide();
    }

}
