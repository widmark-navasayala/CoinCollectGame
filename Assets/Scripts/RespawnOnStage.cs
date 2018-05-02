using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnStage : MonoBehaviour
{

    public Transform spawnPoint;
    public float threshold = -10;
    public GameObject player1;
    public GameObject player2;

    
	// Update is called once per frame
	void Update ()
    {
        if (player1.transform.position.y < threshold)
        {
            player1.transform.position = spawnPoint.position;
            player1.transform.rotation = spawnPoint.rotation;
        }

        if(player2.transform.position.y < threshold)
        {
            player2.transform.position = spawnPoint.position;
            player2.transform.rotation = spawnPoint.rotation;
        }
    }
    
}
