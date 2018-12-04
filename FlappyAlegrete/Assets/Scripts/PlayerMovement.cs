using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForcaFrontal = 500f;
    public LayerMask groundLayers;
    public float jumpForce = 18;


    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, ForcaFrontal * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space)) {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (rb.position.y > 50f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }
  
    }

}
