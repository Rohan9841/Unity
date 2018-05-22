using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

    //gameobject where the moleContainer in the hierarchy will be dragged to
    public GameObject MoleContainer;

    //This is used to access the score and hitCount variable in playerScript.
    public PlayerScript player;

    //The moles will rise after 1.5 sec
    public float spawnDuration = 1.5f;

    //The spawnDuration will be reduced by this value so that the moles can spawn faster
    public float decreaseSpawnDuration = 0.1f;

    //The minimum time at which the mole can appear
    public float minimumSpawnDuration = 0.5f;

    //array that contains Mole script
    public Mole[] moleArray;

    //Texts wil be dragged to these textMest
    public TextMesh infoText;
    public TextMesh timerText;

    //The timer to end the game
    public float timer = 60f;

    //The timer to restart the game
    private float restartTimer = 6f;

    //Timer to rise the mole. This will be reduced in update method
    private float spawnTimer = 0f;

	// Use this for initialization
	void Start () {
        //putting all the moles from moleContainer in the moleArray
        moleArray = MoleContainer.GetComponentsInChildren<Mole>();
	}
	
	// Update is called once per frame
	void Update () {
        //start the game timer
        timer -= Time.deltaTime;

        if (timer > 0)
        {
            //Timer to rise the mole is decreased. It is set to '0' at first because we need to rise the mole immediately. 
            spawnTimer -= Time.deltaTime;

            if (spawnTimer <= 0)
            {
                //once the spawnTimer hits '0', rise any random mole from moleArray.
                moleArray[Random.Range(0, moleArray.Length)].Rise();

                //if the plaer hits the mole 10 times
                if (player.hitCounter >= 5)
                {
                    //Decrease the time needed to rise the mole by 0.1
                    spawnDuration -= decreaseSpawnDuration;

                    //then reset the hitCounter in playerScript to '0'
                    player.hitCounter = 0;
                }

                //if the spawnDuration becomes equal or less than 0.5
                if (spawnDuration <= minimumSpawnDuration)
                {
                    //set the time to rise the mole to 0.5. So, in every 0.5 sec new mole will rise
                    spawnDuration = minimumSpawnDuration;
                }

                //set SpawnTimer to spawnDuration. 
                spawnTimer = spawnDuration;
            }

            //format the text as required
            infoText.text = "Score: " + player.score;
            timerText.text = "Time Left: " + Mathf.Floor(timer);
        }

        else
        {
            //if the game timer hits zero
            infoText.text = "Game over! Your Score is: " + player.score;
            

            //start decreasing the restart timer
            restartTimer -= Time.deltaTime;

            timerText.text = "Restarting game in " + Mathf.Floor(restartTimer);

            //load new scene if the restart time hits zero
            if (restartTimer<=0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
