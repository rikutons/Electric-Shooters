using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAimer : MonoBehaviour
{
    [SerializeField]
    new private GameObject camera;
    [SerializeField]
    private float cameraZdif;

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
        camera.transform.Translate(0, 0, cameraZdif);
        bulletShooter.isAiming = true;
    }

    private void FinishAiming()
    {
        camera.transform.Translate(0, 0, -cameraZdif);
        bulletShooter.isAiming = false;
    }
}
