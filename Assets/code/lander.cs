using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lander : MonoBehaviour
{
    private bool press = false;
    public Rigidbody2D myrigidbody;
    public float jump = 2;
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
                myrigidbody.velocity += Vector2.up * jump;

            }
    }
}
