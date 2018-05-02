using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerController: MonoBehaviour
{
    //private bool m_isAxisInUse = false;

    //public bool OnGround;

    //private bool Player1Win;
    //private bool Player2Win;
    //private float jumpPressure;
    //private float minJump;
    //private float maxJumpPressure;

 //   private bool Player1Lose;
   // private bool Player2Lose;



    public float moveSpeed;

    private Rigidbody rb;
    private float winnerCountDown = 5;

    // public int forceConst = 50;
   // private float jumpHeight = 500f;


 //   private bool canJump;
    private int count;
    

    public Text countText;
    public Text winText;

  //  public GameObject player;

    void Start()
    {
        //OnGround = true;
        //jumpPressure = 0f;
        //minJump = 2f;
        //maxJumpPressure = 10f;


        //Player1Win = false;
        //Player2Win = false;
        

        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        winnerCountDown = 5;
    }

    void Update()
    {
      //  jump();
        Move();
      //  Jump();
        LoadGameOverScreen();
        Timer();
        //    NewJump();

 //       Winner();
    }

    
    void Move()
    {
        if (gameObject.CompareTag("Player 1"))
        {
            transform.Translate(moveSpeed * Input.GetAxis("Horizontal1") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical1") * Time.deltaTime);
        }

        if (gameObject.CompareTag("Player 2"))
        {
            transform.Translate(moveSpeed * Input.GetAxis("Horizontal2") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical2") * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
       //     OnGround = true;
        }

        if (other.gameObject.CompareTag("Pick Up")) // checks to see if if the object the player has collided with is tagged as "Pick Up"
        {

            other.GetComponent<Renderer>().enabled = false; //unenables the Pick Up's Renderer
            other.GetComponent<Collider>().enabled = false; //unenables the Pick Up's Collider
            count = count + 1;
            SetCountText();
        }

    }

    void FixedUpdate()
    {
       // JumpTry();
    }

    //void JumpTry()
    //{
    //    if (canJump)
    //    {
    //        canJump = false;
    //        //  rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Force);
    //    }
    //}


    //void Jump()
    //{
    //    if (gameObject.CompareTag("Player 1"))
    //    {
    //        if (Input.GetAxis("Jump1") != 0)
    //        {
    //            canJump = true;
    //        }
    //    }

    //    if (gameObject.CompareTag("Player 2"))
    //    {
    //        if (Input.GetAxis("Jump2") != 0)
    //        {
    //            canJump = true;
    //        }
    //    }

    //    if (Input.GetKeyUp(KeyCode.Space))
    //    {
    //        canJump = true;
    //    }



    //}

//    void jump()             
//    {
//        if (gameObject.CompareTag("Player 1"))
//        {
//            if (OnGround)
//            {
//                if (Input.GetAxis("Jump1") != 0)
//                {
//                    if (jumpPressure<maxJumpPressure)
//                    {
//                        jumpPressure += Time.deltaTime* 10f;
//                    }
//                    else
//                    {
//                        jumpPressure = maxJumpPressure;
//                    }
//                }
//                else
//                {
//                    if (jumpPressure > 0f)
//                        jumpPressure = jumpPressure + minJump;
//                    rb.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
//jumpPressure = 0f;
//                    OnGround = false;
//                }
//            }
//        }

//        if (gameObject.CompareTag("Player 2"))
//        {
//            if (OnGround)
//            {
//                if (Input.GetButtonDown("Jump2"))
//                {
//                    if (jumpPressure<maxJumpPressure)
//                    {
//                        jumpPressure += Time.deltaTime* 10f;
//                    }
//                    else
//                    {
//                        jumpPressure = maxJumpPressure;
//                    }
//                }
//                else
//                {
//                    if (jumpPressure > 0f)
//                        jumpPressure = jumpPressure + minJump;
//                    rb.velocity = new Vector3(jumpPressure / 10f, jumpPressure, 0f);
//jumpPressure = 0f;
//                    OnGround = false;
//                }
//            }

//        }
//    }

    void SetCountText()
    {
        if (gameObject.CompareTag("Player 1")) // check if it's player 1
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 35)
            {
               
                winText.text = "Player 1 Wins!";
                winnerCountDown -= Time.deltaTime;

            }
        }

        if(gameObject.CompareTag("Player 2")) // checks if it's player 2
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 35)
            {
                //Player2Win = true;
                //Player1Lose = true;
                winText.text = "Player 2 Wins!";
                winnerCountDown -= Time.deltaTime;
                   
            }
        }
        
    }

    void LoadGameOverScreen()
    {
        if (winnerCountDown <= 1)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
    
    void Timer()
    {
        if (winnerCountDown < 5)
        {
            winnerCountDown -= Time.deltaTime;
        }
    }
    
}
