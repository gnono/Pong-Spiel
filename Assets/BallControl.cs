﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Vector3 velocity;
    public float maxZ;
    public float maxX;
    public float maxY;




    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, maxZ, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= velocity * Time.deltaTime ;


    }





    private void OnTriggerEnter(Collider other)
    {


        if(other.CompareTag("Flipper"))
        {
        Transform ball = transform;
        Transform Flipper = other.transform;

        float maxDistance = other.transform.localScale.x * 1 * 0.5f + transform.localScale.x * 1 * 0.5f;
        float distance = ball.position.x - Flipper.position.y;
        float nDistance = distance - maxDistance;

        
            velocity = new Vector3(velocity.x, nDistance * maxY, velocity.z);
        }

        if (other.CompareTag("Wall"))
        {

            velocity = new Vector3(-velocity.x, -velocity.y, -velocity.z);
        }

        if (other.CompareTag("Target"))
        {

            velocity = new Vector3(-velocity.x, -velocity.y, -velocity.z);
        }





        gameObject.GetComponent<AudioSource>().Play();
    }


}
