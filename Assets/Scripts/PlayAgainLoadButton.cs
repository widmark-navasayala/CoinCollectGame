using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgainLoadButton : MonoBehaviour
{
 
    
   public void ChangeScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene("LevelOne");
    }

}
