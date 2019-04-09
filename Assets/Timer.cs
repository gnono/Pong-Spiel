using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject FirstBall;
    //public GameObject SecondBall;
    private float currentTime = 0f;
    private float startingTime = 05f;
    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (countdownText != null)
        {
            countdownText.text = currentTime.ToString("00:00");
        }

        if ((GameOver != null) && (currentTime <= 0))
        {
            currentTime = 0;
            GameOver.SetActive(true);
            FirstBall.SetActive(false);
            //SecondBall.SetActive(false);
        }

        if ((GameOver != null) && (currentTime <= 50))
        {

            //SecondBall.SetActive(true);

        }


    }
}
