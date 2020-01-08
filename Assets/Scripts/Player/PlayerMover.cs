using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    [SerializeField]
    private float speed, upspeed;
    [SerializeField]
    new private Rigidbody rigidbody;

    float powerX = 0f, powerZ = 0f;
    bool canJump = false;
    bool is_fall = false;

    void Update()
    {
        powerX = Input.GetAxis("Horizontal") * speed;
        powerZ = Input.GetAxis("Vertical") * speed;
    }

    private void OnTriggerStay()
    {
        canJump = true;
    }

    private void OnTriggerExit()
    {
        canJump = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y < 0.01)
            is_fall = true;

        else
            is_fall = false;
    }

    void FixedUpdate()
    {
        Vector3 velocity = new Vector3(powerX, rigidbody.velocity.y, powerZ);
        if (is_fall && !canJump)
        {
            velocity.x = velocity.z = 0;
        }
        rigidbody.velocity = transform.TransformDirection(velocity);

        if (Input.GetButtonDown("Jump") && canJump == true && rigidbody.velocity.y < 1)
        {
            rigidbody.AddForce(transform.up * upspeed);
            canJump = false;
        }
    }

}
