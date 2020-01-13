using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyLoiterer : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float changeDirInterval;
    [SerializeField]
    private float changeDirTime;
    [SerializeField]
    new private Rigidbody rigidbody;
    [SerializeField]
    private bool isMoveY;
    [SerializeField]
    private Vector3 correctionAngle;
    private Vector3 direction;
    private float time = 0;

    void Start()
    {
        direction = Random.insideUnitSphere;
        if (!isMoveY)
            direction.y = 0;
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= changeDirInterval)
        {
            Vector3 next_direction = Random.insideUnitSphere;
            if (!isMoveY)
                next_direction.y = 0;
            DOTween.To(
                () => direction,
                num => direction = num,
                next_direction,
                changeDirTime
            );
            time = 0;
        }
        Vector3 velocity = direction * speed;
        if (!isMoveY)
            velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
        transform.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.Rotate(correctionAngle);
    }
}
