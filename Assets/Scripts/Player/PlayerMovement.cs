using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody RB3D;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey("w"))
        {
            RB3D.AddForce(0, 0, 2);
        }

        if (Input.GetKey("s"))
        {
            RB3D.AddForce(0, 0, -2);
        }

        if (Input.GetKey("a"))
        {
            RB3D.AddForce(-2, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            RB3D.AddForce(2, 0, 0);
        }
    }
}
