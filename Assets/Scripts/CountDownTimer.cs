using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

    public float myCoolTimer = 60;
    public float levelLoad = 5;
    public Text timerText;
    public Text gameOverText;



    void Start()
    {
        timerText = GetComponent<Text>();
        gameOverText.text = "";
    }

    void Update()
    {
        TimerCountDown();
        GameOver();
        NextSceneCountDown();
        LoadLevel();

    }

    void GameOver()
    {
        if (myCoolTimer <= 1)
        {
            myCoolTimer = 0;
            gameOverText.text = "TIME UP";
        }
    }

    void TimerCountDown()
    {
        myCoolTimer -= Time.deltaTime;
        timerText.text = myCoolTimer.ToString("f0");
        print(myCoolTimer);
    }

    void NextSceneCountDown()
    {
        if (myCoolTimer == 0)
        {
            levelLoad -= Time.deltaTime;
        }
    }

    void LoadLevel()
    {
        if (levelLoad <= 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
