using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplerShooter : MonoBehaviour
{
    [System.NonSerialized]
    public bool isAiming = false;

    [SerializeField]
    private GameObject hook;
    [SerializeField]
    private Rigidbody hook_rb;
    [SerializeField]
    private float hookSpeed;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ShootGlappler();
        }
        //Debug.DrawRay(transform.position, transform.up, Color.red);
    }

    private void ShootGlappler()
    {
        hook.SetActive(true);
        hook.transform.position = transform.position;
        
        var hookForce = transform.forward;
        hookForce = hookForce.normalized;

        hook_rb.velocity = Vector3.zero;
        hook_rb.AddForce( hookForce * hookSpeed);
    }
}
