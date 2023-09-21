using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Create a reference to the RigidBody2D so we can manipulate it
    Rigidbody2D playerObjects;

    // Start is called before the first frame update
    void Start()
    {
        //Find the RigidBody2D component that is attached to the same object as this script
        playerObjects = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizintal");

        //Change the X velocity of the RigidBody2D to be equal to the movement value
        playerObjects.velocity = new Vector2 (movementValueX, playerObjects.velocity.y);
    }
}
