using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForcaFrontal = 1000f;
    public float ForcaLateral = 600f;

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, ForcaFrontal * Time.deltaTime);

        // Input.GetAxis("horizontal")
 
        if (Input.GetKey("w"))
        {

            rb.AddForce(0, 50 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }

        if(rb.position.y > 5f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }

    }

}
