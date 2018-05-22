using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int gameCameraIndex = 0;
    public GameObject[] gameCameras;

	// Use this for initialization
	void Start () {
        focusOnCamera(gameCameraIndex);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            changeCamera(1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            changeCamera(-1);
        }
        
    }

    void focusOnCamera(int index)
    {
        for(int i = 0; i < gameCameras.Length; i++)
        {
            gameCameras[i].SetActive(i == index);
        }
    }

    void changeCamera(int increaseGameCameraIndex)
    {
        gameCameraIndex += increaseGameCameraIndex;

        if (gameCameraIndex >= gameCameras.Length)
        {
            gameCameraIndex = 0;
        }
        if (gameCameraIndex < 0)
        {
            gameCameraIndex = gameCameras.Length - 1;
        }

        focusOnCamera(gameCameraIndex);
    }
}
