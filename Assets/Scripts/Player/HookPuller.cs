using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPuller : MonoBehaviour
{
    [SerializeField]
    new private Rigidbody rigidbody;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private Rigidbody playerRigidbody;
    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private PlayerMover playerMover;

    private float pullSecond;
    private bool is_pulling = false;
    private Vector3 velocity = Vector3.zero;
    private float time;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hook Pulling Start!");
            rigidbody.isKinematic = true;
            time = 0;
            is_pulling = true;
            //playerRigidbody.isKinematic = true;
            playerMover.enabled = false;
            playerRigidbody.useGravity = false;
        }
    }

    private void Update()
    {
        if (is_pulling)
        {
            var direction = (transform.position - playerTransform.position).normalized;
            playerRigidbody.velocity = direction * playerSpeed;
        }
    }

    public void Finish()
    {
        if(is_pulling)
        {
            Debug.Log("Hook Pulling End!");
            is_pulling = false;
            rigidbody.isKinematic = false;
            playerRigidbody.useGravity = true;
            playerMover.enabled = true;
            gameObject.SetActive(false);
        }
    }
}
