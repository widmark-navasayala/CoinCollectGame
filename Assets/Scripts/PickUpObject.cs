using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpObject : MonoBehaviour {

    
    public AudioSource elevatorMusicSource;

    private float respawnTimer = 5;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        CoinRotate();
        RespawnCountDown();
        Respawn();
    }

    void CoinRotate()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime); // rotates the coin
    }


    void RespawnCountDown()
    {
        if (this.GetComponent<Collider>().enabled == false && this.GetComponent<Renderer>().enabled == false) // checks to see if the collider and Renderer are not enabled
        {
            respawnTimer -= Time.deltaTime; //starts the respawn countdown 
        }
    }

    void Respawn()
    {
        if (respawnTimer <= 1) //checks if the respawn countdown is less than 1
        {
            respawnTimer = 5;  // resets the respawn timer to 5
            this.GetComponent<Collider>().enabled = true; //re-enables collider
            this.GetComponent<Renderer>().enabled = true; //re-enables renderer
        }
    }
}
