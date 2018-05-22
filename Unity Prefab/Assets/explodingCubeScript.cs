using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodingCubeScript : MonoBehaviour {
    public float explodingForce = 100f;
    public Vector3 explodingDirection;
    public float timeLeft;

	// Use this for initialization
	void Start () {
        explodingDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f).normalized);

        GetComponent<Rigidbody>().AddForce(explodingDirection * explodingForce);
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
	}
}
