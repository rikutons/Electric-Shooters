using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAimer : MonoBehaviour
{
    [SerializeField]
    new private GameObject camera;
    [SerializeField]
    private Vector3 cameraPosDefault;
    [SerializeField]
    private Vector3 cameraRotateDefault;
    [SerializeField]
    private Vector3 cameraPosAiming;
    [SerializeField]
    private Vector3 cameraRotateAiming;

    private BulletShooter bulletShooter;

    private void Start()
    {
        bulletShooter = GetComponent<BulletShooter>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Aim"))
        {
            StartAiming();
        }
        if (Input.GetButtonUp("Aim"))
        {
            FinishAiming();
        }
    }

    private void StartAiming()
    {
        camera.transform.localPosition = cameraPosAiming;
        camera.transform.rotation = new Quaternion(0, 0, 0, 0);
        camera.transform.Rotate(cameraRotateAiming);
        bulletShooter.isAiming = true;
    }

    private void FinishAiming()
    {
        camera.transform.localPosition = cameraPosDefault;
        camera.transform.rotation = new Quaternion(0,0,0,0);
        camera.transform.Rotate(cameraRotateDefault);
        bulletShooter.isAiming = false;
    }
}
