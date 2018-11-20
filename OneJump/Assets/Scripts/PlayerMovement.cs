﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForcaFrontal = 500f;
    public LayerMask groundLayers;
    public float jumpForce = 20;


    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, ForcaFrontal * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space)) {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }

        if (rb.position.y > 20f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }


    }

}
