using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject target = null;
    public bool orbitY = false;

	
	void Update ()
    {
	    if (target != null)
        {
            transform.LookAt(target.transform);

            if (orbitY)
            {
                transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 10);
            }
        }	
	}
}
