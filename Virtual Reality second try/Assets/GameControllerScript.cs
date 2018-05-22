using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

    public TextMesh infoText;
    public PlayerGameObjectScript player;
    public Transform enemyContainer;
    public float restartTimer = 3f;

	// Use this for initialization
	void Start () {
        infoText.text = "Find the button and \nEnter the castle";	
	}
	
	// Update is called once per frame
	void Update () {
        if (player.enteredCastle)
        {
            int enemyLeft = enemyContainer.GetComponentsInChildren<EnemyScript>().Length;
            if (enemyLeft > 0) { 
                infoText.text = "Kill all the enemies!";
                infoText.text += "\nEnemies Remaining:" + enemyLeft;
            }
            else
            {
                infoText.text = "You win!";
                restartTimer -= Time.deltaTime;

                if (restartTimer <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
	}
}
