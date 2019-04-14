using UnityEngine;
using System.Collections;



public class Deadzone : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject ball;
    public GameObject paddle;


    public void OnTriggerEnter(Collider col)
        {
        //if (col.CompareTag("deadzone")) 
        //{
        //    gameOver.SetActive(true);
        //    ball.SetActive(false);
        //    paddle.SetActive(false);
        //}
    }
       
}