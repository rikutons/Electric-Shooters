using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundChecker : MonoBehaviour
{
    //接地した場合の処理
    [SerializeField]
    PlayerMover playerMover;

    private bool isCollisionStay;

    void Update()
    {
        isCollisionStay = false; 
    }

    void OnTriggerStay(Collider other)
    {
        playerMover.onGround = true;
    }
    
    void OnTriggerExit(Collider other)
    {
        playerMover.onGround = false;
    }
}
