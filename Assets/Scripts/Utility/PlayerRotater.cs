using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotater : MonoBehaviour
{
    [SerializeField]
    private GameObject yController;

    void Update()
    {
        float xRotation = Input.GetAxis("RStick X");
        float yRotation = Input.GetAxis("RStick Y");
        transform.Rotate(0, -xRotation, 0);
        yController.transform.transform.Rotate(yRotation, 0, 0);
    }
}
