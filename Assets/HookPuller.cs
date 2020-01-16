using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPuller : MonoBehaviour
{
    [SerializeField]
    private float pullSecond;
    [SerializeField]
    new private Rigidbody rigidbody;
    [System.NonSerialized]
    public Transform playerTransform;
    [System.NonSerialized]
    public Rigidbody playerRigidbody;

    private bool is_pulling = false;
    private Vector3 velocity = Vector3.zero;
    private float time = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            is_pulling = true;
            rigidbody.isKinematic = true;
            Debug.Log(playerRigidbody);
            playerRigidbody.isKinematic = true;
        }
    }

    private void Update()
    {
        if (is_pulling)
        {
            time += Time.deltaTime;
            playerTransform.position = 
                Vector3.SmoothDamp(playerTransform.position, transform.position, ref velocity, pullSecond);
            if (time >= pullSecond * 2)
            {
                playerRigidbody.isKinematic = false;
                Destroy(gameObject);
            }
        }
    }
}
