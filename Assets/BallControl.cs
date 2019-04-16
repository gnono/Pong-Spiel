using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public Vector3 velocity;
    public float maxZ;
    public float maxX;
    private int hitCounter;
    private int hitCounterGameOver =3;
    [SerializeField] Text Points;
    [SerializeField] Text Timer;
    [SerializeField] Text Lives;
    [SerializeField] Text WinMessage;
    [SerializeField] Text GameOverMessage;
    public GameObject ball;
    public Transform paddle;
    public bool inPlay;
    public AudioSource beep;
    public AudioSource gameO;
    public AudioSource win;
    bool beepPlay=false;

  

    // Start is called before the first frame update
    void Start()
    {
        
        
        //velocity = new Vector3(0, 0, maxZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        if (!inPlay)
        {
            transform.position = paddle.position;
        }

        if (Input.GetButtonDown("Jump") )
       {
           inPlay = true;
           velocity = new Vector3(0, 0, maxZ);
            beepPlay = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!beepPlay)
        {
            beep.Stop();
        }
        

        if (other.CompareTag("Flipper"))
        {
        Transform ball = transform;
        Transform Flipper = other.transform;

        float maxDistance = other.transform.localScale.x * 1 * 0.5f + transform.localScale.x * 1 * 0.5f;
        float distance = ball.position.x - Flipper.position.x;
        float nDistance = distance / maxDistance;

        velocity = new Vector3(nDistance * maxX, velocity.y, -velocity.z);
        }

        if (other.CompareTag("Wall"))
        {
            velocity = new Vector3(-velocity.x, velocity.y, velocity.z);
        }

        if (other.CompareTag("Target"))
        {
            velocity = new Vector3(velocity.x, velocity.y, -velocity.z);
            hitCounter++;

            Points.text = "Points: " + (hitCounter).ToString();
            Debug.Log("Points registered");


            if(hitCounter >= 81) 
            {
                WinMessage.gameObject.SetActive(true);
                ball.SetActive(false);
                win.Play();
               // paddle.SetActive(false);
                Timer.gameObject.SetActive(false);

             
              }


        }

        if (other.CompareTag("deadzone"))
        {
           // velocity = new Vector3(velocity.x, velocity.y, -velocity.z);
            
            inPlay = false;
            beepPlay = false;
            beep.Stop();

            hitCounterGameOver--;
            Lives.text = "Lives: " + hitCounterGameOver.ToString();

            if (hitCounterGameOver == 0)
            {
                GameOverMessage.gameObject.SetActive(true);
                ball.SetActive(false);
                gameO.Play();
                
                //paddle.SetActive(false);
                Timer.gameObject.SetActive(false);
            }


        }
        if (beepPlay==true)
        {
            beep.Play();
        }
       // 
    }
}
