using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewJumpScript : MonoBehaviour
{
    public bool OnGround;
    private float jumpPressure;
    private float minJump;
    private float maxJumpPressure;
    private Rigidbody rigidBody;

    
	// Use this for initialization
	void Start ()
    {
        OnGround = true;
        jumpPressure = 0f;
        minJump = 2f;
        maxJumpPressure = 10f;
        rigidBody = GetComponent<Rigidbody>();
	}
	

	// Update is called once per frame
	void Update ()
    {
        if (gameObject.CompareTag("Player 1"))
        {
            if (OnGround)
            {
                if (Input.GetButton("Jump1"))
                {
                    if (jumpPressure < maxJumpPressure)
                    {
                        jumpPressure += Time.deltaTime * 10f;
                    }
                    else
                    {
                        jumpPressure = maxJumpPressure;
                    }
                }
                else
                {
                    if (jumpPressure > 0f)
                        jumpPressure = jumpPressure + minJump;
                    rigidBody.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
                    jumpPressure = 0f;
                    OnGround = false;
                }
            }
        }

        if (gameObject.CompareTag("Player 2"))
        {
            if (OnGround)
            {
                if (Input.GetButton("Jump2"))
                {
                    if (jumpPressure < maxJumpPressure)
                    {
                        jumpPressure += Time.deltaTime * 10f;
                    }
                    else
                    {
                        jumpPressure = maxJumpPressure;
                    }
                }
                else
                {
                    if (jumpPressure > 0f)
                        jumpPressure = jumpPressure + minJump;
                    rigidBody.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
                    jumpPressure = 0f;
                    OnGround = false;
                }
            }

        }
    }

    void jump()
    {
        if (gameObject.CompareTag("Player 1"))
        {
            if (OnGround)
            {
                if (Input.GetAxis("Jump1") != 0)
                {
                    if (jumpPressure < maxJumpPressure)
                    {
                        jumpPressure += Time.deltaTime * 10f;
                    }
                    else
                    {
                        jumpPressure = maxJumpPressure;
                    }
                }
                else
                {
                    if (jumpPressure > 0f)
                        jumpPressure = jumpPressure + minJump;
                    rigidBody.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
                    jumpPressure = 0f;
                    OnGround = false;
                }
            }
        }

        if (gameObject.CompareTag("Player 2"))
        {
            if (OnGround)
            {
                if (Input.GetButtonDown("Jump2"))
                {
                    if (jumpPressure < maxJumpPressure)
                    {
                        jumpPressure += Time.deltaTime * 10f;
                    }
                    else
                    {
                        jumpPressure = maxJumpPressure;
                    }
                }
                else
                {
                    if (jumpPressure > 0f)
                        jumpPressure = jumpPressure + minJump;
                    rigidBody.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
                    jumpPressure = 0f;
                    OnGround = false;
                }
            }

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            OnGround = true;
        }
    }

}
