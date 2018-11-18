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
        if (Input.GetKey("d"))
        {

            rb.AddForce(ForcaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-ForcaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }

    }

}
