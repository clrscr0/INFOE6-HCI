using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody ball_Rigidbody;
    public float force = 500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ball_Rigidbody.AddForce(transform.forward * force);
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 arrowInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            ball_Rigidbody.MovePosition(transform.position + arrowInput * Time.deltaTime * 5f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cylinder")
        {
            print("Good job!");
        }
    }
}
