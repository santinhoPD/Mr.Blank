using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject groundchecker;
    public LayerMask whatIsGround;
    public float jumpForce;

    public float maxSpeed = 10.0f;
    bool isOnGround = false;
    // Ablew to manipulate the body
    Rigidbody2D playerobject;
    // Start is called before the first frame update
    void Start()
    {
        //Attaches Code to body
        playerobject = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical input
        //float movementValueX = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 5.0f;
        }
        else
        {
            maxSpeed = 30.0f;
        }

        //create a 'float' that will be equal to the players horizontal iunput
        //float movementValueX = Input.GetAxis("Horizontal");

        //set movementValueX to 1.0f, so that we always run forward and no longer care about player input
        float movementValueX = 1.0f;
        //Velocity
        playerobject.velocity = new Vector2(movementValueX * maxSpeed, playerobject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundchecker.transform.position, 1.0f, whatIsGround);

        if ((isOnGround == true) && (Input.GetAxis("Jump") > 0.0f))
        {
            playerobject.AddForce(Vector2.up*jumpForce);
        }
        
    }
}
    