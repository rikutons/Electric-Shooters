using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float power;
    [SerializeField]
    private float bulletSpeed;
    [SerializeField]
    private float bulletIntervalSecond;

    private float timeElapsed = 0;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (Input.GetButton("Fire1") && timeElapsed >= bulletIntervalSecond)
        {
            ShootBullet();
            timeElapsed = 0;
        }
    }

    private void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        DamagertoEnemy damagertoEnemy = bullet.GetComponent<DamagertoEnemy>();
        damagertoEnemy.damage = power;
        bullet.transform.position = gameObject.transform.position;
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.up * bulletSpeed);
    }
}
