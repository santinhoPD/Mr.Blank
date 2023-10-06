using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //public GameObject player;

    // create a public reference to the player - we will assign this using the unity editor
    public Transform xAxis;
    public float speed;

    void Update()
    {
        //change our positionraeltive to the players position
        xAxis.transform.position = new Vector3(xAxis.transform.position.x + (speed * Time.deltaTime) ,0f, -10f);
        //transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z); 
    }
}