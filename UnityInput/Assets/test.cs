using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject[] gameCameras;
    public int cameraNum;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            changeCamera(1);
        }

        if(Input.GetMouseButtonDown(1))
        {
            changeCamera(-1);
        }
	}

    void activeCamera(int cameraNum)
    {
        for (int i = 0; i < gameCameras.Length; i++)
        {
            gameCameras[i].SetActive(i == cameraNum);
        }
    }

    void changeCamera(int addOne)
    {
        cameraNum += addOne;

        if (cameraNum >= gameCameras.Length)
        {
            cameraNum = 0;
        }
        if (cameraNum < 0)
        {
            cameraNum = gameCameras.Length - 1;
        }
        activeCamera(cameraNum);
    }
}
