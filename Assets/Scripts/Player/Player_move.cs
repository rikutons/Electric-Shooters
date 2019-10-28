using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float speed = 3f, upspeed = 3f,downspeed = 3f;
    float moveX = 0f;
    float moveZ = 0f;
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
        
        if (Input.GetButtonDown("Jump")&&oldy==rb.position.y)
        {
            inputJumpButton = true;
        }
        if (Input.GetButtonUp("Jump"))
        {
            inputJumpButton = false;
        }
        oldy = rb.position.y;

    }
    //void OnCollisionStay(Collision col)
    //{
        
    //    if (col.gameObject.tag == "Ground" && Input.GetButtonDown("Jump"))
    //    {
    //        inputJumpButton = true;
    //    }
    //}
    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX, 0, moveZ);
        if (inputJumpButton)
        {
            rb.AddForce(transform.up * upspeed);
        }
        if (!inputJumpButton)
        {
            rb.AddForce(transform.up * -downspeed);
        }
    
    }

}
