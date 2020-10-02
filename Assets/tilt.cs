using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    public float rotateSpeed = 1;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > .2)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }

        if (Input.GetAxis("Horizontal") <  -.2)
        {
            transform.Rotate(0, 0, -rotateSpeed);
        }


        if (Input.GetAxis("Vertical") > .2)
        {
            transform.Rotate(rotateSpeed, 0, 0);
        }


        if (Input.GetAxis("Vertical") < -.2)
        {
            transform.Rotate(-rotateSpeed, 0, 0);
        }


    }
}
