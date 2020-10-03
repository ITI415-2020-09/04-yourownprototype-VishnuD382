using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    public Text scoreGT1;

    public float maxSpeed = 0.5f;//Replace with your max speed


    void Start()
    {
        GameObject finish_1 = GameObject.Find("finish");
        GameObject finish_2 = GameObject.Find("Time");

        scoreGT1 = finish_2.GetComponent<Text>();
        scoreGT = finish_1.GetComponent<Text>();
        scoreGT.text = "Nice Work!";
    }



    void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject collidedWith = other.gameObject;
        if (collidedWith.tag == "goal")
        {
            Destroy(collidedWith);
            scoreGT.enabled = true;

            scoreGT1.enabled = false;
        }
    }


}
