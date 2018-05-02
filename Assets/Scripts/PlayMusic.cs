using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

    public AudioSource elevatorMusicSource;

    // Use this for initialization
    void Start ()
    {
        PlayElevatorMusic();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void PlayElevatorMusic()
    {

        elevatorMusicSource.Play();
    }
}
