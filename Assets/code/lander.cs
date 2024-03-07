using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lander : MonoBehaviour
{
    private bool press = false;
    public Rigidbody2D myrigidbody;
    public float jump = 2;
    private bool left = false;
    private bool right = false;
    public ParticleSystem thrust;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {

            press = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            press = false;
        }


        if (press)
        {
            myrigidbody.AddForce(transform.up*jump);
            thrust.Play();

        }
        else if (press  == false){
            thrust.Stop();
        }




        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }

        if (right)
        {
            transform.Rotate(0.0f, 0.0f, -0.5f, Space.Self);
        }
        else if (left)
        {
            transform.Rotate(0.0f, 0.0f, 0.5f, Space.Self);
        }


    }
}
