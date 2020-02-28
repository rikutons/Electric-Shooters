using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookFinisher : MonoBehaviour
{
    [SerializeField]
    private HookPuller hookPuller;
    [SerializeField]
    private PlayerMover playerMover;
    private void OnCollisionEnter(Collision collision)
    {
        hookPuller.Finish();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Hook"){
            hookPuller.Finish();
        }
    }
}
