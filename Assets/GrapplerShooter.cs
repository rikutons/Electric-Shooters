using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplerShooter : MonoBehaviour
{
    [System.NonSerialized]
    public bool isAiming = false;

    [SerializeField]
    private GameObject hookPrefab;
    [SerializeField]
    private float hookSpeed;
    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private Rigidbody playerRigidbody;
    private float timeElapsed = 0;
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ShootGlappler();

            timeElapsed = 0;
        }
        //Debug.DrawRay(transform.position, transform.up, Color.red);
    }

    private void ShootGlappler()
    {
        var hook = Instantiate(hookPrefab, transform.position, Quaternion.identity);
        var hookPuller = hook.GetComponent<HookPuller>();
        hookPuller.playerTransform = playerTransform;
        hookPuller.playerRigidbody = playerRigidbody;

        var hook_rb = hook.GetComponent<Rigidbody>();
        var hookForce = transform.forward;
        hookForce = hookForce.normalized;
        hook_rb.AddForce(hookForce * hookSpeed);
    }
}
