﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    private int hitCounter = 0;


    void OnTriggerEnter(Collider col)
    {


        if (gameObject.CompareTag("Target"))
        {
            hitCounter++;
            Debug.Log("Hit registered");


            if (hitCounter == 1)
            {

                GetComponent<Renderer>().material.color = Color.cyan;
            }

            if (hitCounter == 2)
            {

                GetComponent<Renderer>().material.color = Color.red;
            }


            if (hitCounter >= 3)
            {
                Destroy(this.gameObject);

                Debug.Log("Target clones destroyed from Explosion destroy");

            }


        }
    }
}
