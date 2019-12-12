using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float speed = 3f, upspeed = 3f;
    float moveX = 0f, positionY = 0f, moveZ = 0f;
    public Rigidbody rb;
    bool inputJumpButton = false;
    float oldy = 0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate()
    {

        Vector3 velocity = new Vector3(moveX, rb.velocity.y, moveZ);
        rb.velocity = transform.TransformDirection(velocity);
        inputJumpButton = false;

        Debug.Log(oldy);
        positionY = rb.position.y;
        Debug.Log(positionY);

        if (Input.GetButtonDown("Jump") && oldy == positionY)
        {
            inputJumpButton = true;
        }

        oldy = positionY;

        if (inputJumpButton)
        {
            rb.AddForce(transform.up * upspeed);
        }
    }

}
