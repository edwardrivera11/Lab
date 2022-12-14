using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 45.5f;

    private float HorizontalInput;
    private float forwardInput;

    private float xRange = 5.0f;
    private float zRange = 5.0f;

    public float RotateSpeed = 3.0f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //rotate player
        transform.Rotate(Vector3.up * HorizontalInput * turnSpeed * Time.deltaTime);

        //move player forwards and backwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //move left to right
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * turnSpeed);

        //keep player inbounds on x axis
        if (transform.position.x < -xRange)
        {
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
       else if (transform.position.x > xRange)
        {
          transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
   
   
   
   
   
   
   
   
   
    }


        
}
