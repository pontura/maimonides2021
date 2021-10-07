using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public float speed = 0.7f;
    private Vector3 targetPosition;
    Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();
        targetPosition = transform.position + (transform.forward * 2);
    }
    public void LookAt(Character character)
    {
        if (character == null) return;

        Vector3 direction = character.transform.position;
        direction.y = transform.position.y;
        targetPosition = Vector3.Lerp(targetPosition, direction, speed * Time.deltaTime);
        transform.LookAt(targetPosition);
    }

}