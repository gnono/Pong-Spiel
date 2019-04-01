using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public float speed;
    public Transform PlayingSurface;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dir = 0;
        //if (Input.GetKey(KeyCode.A))
        //{
        //    dir = -1;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    dir = 1;
        //}


        dir = Input.GetAxis("Horizontal");
        float newPositionX = transform.position.x + dir*speed*Time.deltaTime;
       // float maxX= (0.5f * PlayingSurface.localScale.x * 10) - 0.5f * transform.localScale.x * 1;
       //float clampedX = Mathf.Clamp(newPositionX, --maxX, maxX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);


    }
}
