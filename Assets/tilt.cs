using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    public float rotateSpeed = 0.5f;

    public Vector3 currentRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentRotation = GetComponent<Transform>().eulerAngles;

        if(Input.GetAxis("Horizontal") > .2  && (currentRotation.z <= 10 || currentRotation.z > 348)   )
        {
            transform.Rotate(0, 0, rotateSpeed);
        }

        if (Input.GetAxis("Horizontal") <  -.2  && (currentRotation.z >= 349 || currentRotation.z <= 11))
        {
            transform.Rotate(0, 0, -rotateSpeed);
        }


        if (Input.GetAxis("Vertical") > .2   && (currentRotation.x <= 10 || currentRotation.x >= 348))
        {
            transform.Rotate(rotateSpeed, 0, 0);
        }


        if (Input.GetAxis("Vertical") < -.2  && (currentRotation.x >= 349 || currentRotation.x <= 11))
        {
            transform.Rotate(-rotateSpeed, 0, 0);
        }


    }
}
