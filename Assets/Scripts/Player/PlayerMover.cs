using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public bool onGround = true;

    [SerializeField]
    private float speed, upspeed;
    [SerializeField]
    new private Rigidbody rigidbody;

    float powerX = 0f, powerZ = 0f;
    bool is_fall = false;

    void Update()
    {
        powerX = Input.GetAxis("Horizontal") * speed;
        powerZ = Input.GetAxis("Vertical") * speed;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.contacts[0].normal.y < 0.01) //衝突の法線情報
            is_fall = true;
        else
            is_fall = false;
    }

    void FixedUpdate()
    {
        //Debug.Log("is_fall : " + is_fall);
        //Debug.Log("onGround : " + onGround);
        Vector3 velocity = new Vector3(powerX, rigidbody.velocity.y, powerZ);
        if (is_fall && !onGround)
        {
            velocity.x = velocity.z = 0;
        }
        rigidbody.velocity = transform.TransformDirection(velocity);

        if (Input.GetButtonDown("Jump") && onGround == true && rigidbody.velocity.y < 1)
        {
            Debug.Log("Jumped");
            rigidbody.AddForce(transform.up * upspeed);
            onGround = false;
        }
    }

}
