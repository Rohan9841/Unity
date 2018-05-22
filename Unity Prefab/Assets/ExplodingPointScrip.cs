using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingPointScrip : MonoBehaviour {
    public GameObject[] explodingCubes;
    public int numOfCubes = 5;


	// Use this for initialization
	void Start () {
        for (int i = 0; i<numOfCubes; i++)
        {
           GameObject storePrefab = Instantiate(explodingCubes[Random.Range(0, explodingCubes.Length)]);
            storePrefab.transform.position = transform.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
