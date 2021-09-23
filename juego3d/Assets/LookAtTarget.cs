using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 0.7f;
    private Vector3 targetPosition;
    Enemy enemy;
    // Update is called once per frame

    void Start()
    {
        enemy = GetComponent<Enemy>();
        targetPosition = transform.position + (transform.forward * 10);
    }
    void Update()
    {
        if (target == null) return;

        Vector3 direction = target.position;
        direction.y = transform.position.y;
        targetPosition = Vector3.Lerp(targetPosition, direction, speed * Time.deltaTime);
        transform.LookAt(targetPosition);
    }
    public void OnTarget(Transform target)
    {
        this.target = target;
        if (target == null)
            enemy.SetNewState(Enemy.states.IDLE);
        else
            enemy.SetNewState(Enemy.states.ALERT);
    }

}