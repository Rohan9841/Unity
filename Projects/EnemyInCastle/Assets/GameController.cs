using System.Collections;
using UnityEngine.SceneManagement;//used for restarting the scene
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //textMesh is a datatype used to store 3d text
    public TextMesh infoText;
    public TextMesh enemyCount;

    //used to get reference to playerObject so that we can know if the player has entered castle
    public PlayerObject player;

    //all the enemies are inside enemyContainer in the hierarchy which we will use to count the children.
    public Transform enemyContainer;

    //used to store the enemies remaining
    private int enemyRemaining;

    //used to set time for restarting game
    private float restartTime = 6f;

	// Use this for initialization
	void Start () {
        //show these texts when the game starts
        infoText.text = "Hold Alt key and Look at the button to move inside Castle";
        enemyCount.text = "Enemies Remaining: ";
	}
	
	// Update is called once per frame
	void Update () {
        //In each update, the enemyRemaining will contain the total number of enemies that are left inside the enemycontainer.
        //GetComponentsInChildren<Enemy> will give you the array of elements with script 'Enemy'. We only need lenght, hence ".length"
        enemyRemaining = enemyContainer.GetComponentsInChildren<Enemy>().Length;

        //In each frame the enemyCount.text is updated 
        enemyCount.text = "Enemies Remaining: "+enemyRemaining;

        //If player.enteredCastle is set to true, the infoText is changed.
        if (player.enteredCastle)
        {
            infoText.text = "Shoot all the enemies.\nPress left mouse button to shoot.";

        }

        //if enemies remaining is 0 then the infotext is changed.
        if(enemyRemaining <= 0)
        {
            restartTime -= Time.deltaTime;
            infoText.text = "Good Job Commandar!" + "\nRestarting the game in:" + (int)System.Math.Ceiling(restartTime);//converting restartTime to int
            
            //loading new scene which is similar to the active scene.
            if(restartTime <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}
}
