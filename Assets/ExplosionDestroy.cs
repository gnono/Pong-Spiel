using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    private int hitCounter = 0;
    private int bricks= 2;
    public GameObject youWon;
    public GameObject gameOver;
    public GameObject ball;
    public GameObject paddle;


    public void CheckGameOver()
    { 

        if (bricks == 0)
        {
            youWon.SetActive(true);
            ball.SetActive(false);
            paddle.SetActive(false);

        } 
      
    }


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
                    bricks--;
                    CheckGameOver();

                    Debug.Log("Target clones destroyed from Explosion destroy");

                }
            }        
    }
   
}
