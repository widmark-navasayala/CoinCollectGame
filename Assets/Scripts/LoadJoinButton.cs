using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadJoinButton : MonoBehaviour {

    public void ChangeScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene("PlayerJoinScene");
    }
}
