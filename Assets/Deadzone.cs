using UnityEngine;
using System.Collections;



public class deadzone : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject ball;
    public GameObject paddle;


    public void OnTriggerEnter(Collider col)
        {
            gameOver.SetActive(true);
            ball.SetActive(false);
            paddle.SetActive(false);
        }
       
}