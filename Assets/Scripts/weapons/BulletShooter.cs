using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public bool isAiming = false;

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float power;
    [SerializeField]
    private int bulletNum;
    [SerializeField]
    private float bulletSpeed;
    [SerializeField]
    private float bulletIntervalSecond;
    [SerializeField]
    private float blur; //割合指定 0でブレなし 1のとき、最高45度ずれ
    [SerializeField]
    private float blurInAiming;

    private float timeElapsed = 0;
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (Input.GetButton("Fire1") && timeElapsed >= bulletIntervalSecond)
        {
            for (int i = 0; i < bulletNum; i++)
            {
                ShootBullet();
            }

            timeElapsed = 0;
        }
        Debug.DrawRay(transform.position, transform.up, Color.red);
    }

    private void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        DamagertoEnemy damagertoEnemy = bullet.GetComponent<DamagertoEnemy>();
        damagertoEnemy.damage = power;
        bullet.transform.position = gameObject.transform.position;
        Rigidbody bullet_rb = bullet.GetComponent<Rigidbody>();
        float bl = (isAiming ? blurInAiming : blur);
        Vector3 bulletForce = transform.forward +
            transform.right * Random.Range(-bl, bl) +
            transform.up * Random.Range(-bl, bl);
        bulletForce = bulletForce.normalized;
        bullet_rb.AddForce(bulletForce * bulletSpeed);
    }
}
