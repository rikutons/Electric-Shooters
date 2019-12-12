using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float speed = 3f, upspeed = 3f;
    float moveX = 0f, positionY = 0f, moveZ = 0f;
    public Rigidbody rb;
    bool inputJumpButton = false, can_jump = false;
    float oldy = 0f;
    bool is_fall = false;

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

    private void OnTriggerExit()
    {
        can_jump = false;
    }
    private void OnTriggerEnter()
    {
        can_jump = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //rb.velocity = Vector3.zero;
        is_fall = true;
    }

    void FixedUpdate()
    {
    
        Vector3 velocity = new Vector3(moveX, rb.velocity.y, moveZ);
        if (is_fall)
            velocity = new Vector3(0, -3, 0);
        is_fall = false;
        rb.velocity = transform.TransformDirection(velocity);
        inputJumpButton = false;

        //Debug.Log(oldy);
        //positionY = rb.position.y;
        //Debug.Log(positionY);

        if (Input.GetButtonDown("Jump") && can_jump == true)
        {
            inputJumpButton = true;
        }

        //oldy = positionY;

        if (inputJumpButton)
        {
            Debug.Log("Jumped!!");
            rb.AddForce(transform.up * upspeed);
            can_jump = false;
        }
    }

}
