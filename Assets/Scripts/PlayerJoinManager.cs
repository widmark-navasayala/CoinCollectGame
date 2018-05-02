using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerJoinManager : MonoBehaviour {

    private bool playerOneJoined;
    private bool playerTwoJoined;

    public float levelLoad = 10;
    public Text timerText;


    public Text playerOneJoinedText;
    public Text playerTwoJoinedText;

    // Use this for initialization
    void Start ()
    {
        playerOneJoined = false;
        playerTwoJoined = false;
        timerText.text = "";
        playerOneJoinedText.text = "";
        playerTwoJoinedText.text = "";
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerOneJoin();
        PlayerTwoJoin();
        GameStartCountDown();
        LoadGame();
	}

    void PlayerOneJoin()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            playerOneJoined = true;
            playerOneJoinedText.text = "Player 1 has joined!";
        }
    }

    void PlayerTwoJoin()
    {
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            playerTwoJoined = true;
            playerTwoJoinedText.text = "Player 2 has joined!";
        }
    }

    void GameStartCountDown()
    {
        if (playerOneJoined == true && playerTwoJoined == true)
        {
            levelLoad -= Time.deltaTime;
            timerText.text = "Game Starts in: " + levelLoad.ToString("f0");
            print(levelLoad);
        }
    }

    void LoadGame()
    {
        if (levelLoad <= 1)
        {
            SceneManager.LoadScene("LevelOne");
        }
    }
}
