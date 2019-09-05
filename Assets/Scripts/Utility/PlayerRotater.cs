using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotater : MonoBehaviour
{
    [SerializeField]
    private GameObject yController;

    [SerializeField]
    private float ySensitivity;

    [SerializeField]
    private float xSensitivity;
    void Update()
    {
        float xRotation = Input.GetAxis("RStick X");
        float yRotation = Input.GetAxis("RStick Y");
        transform.Rotate(0, -xRotation * xSensitivity, 0);
        yController.transform.transform.Rotate(-yRotation * ySensitivity, 0, 0);
    }
}
