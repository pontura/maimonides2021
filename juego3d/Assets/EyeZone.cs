using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeZone : MonoBehaviour
{
    Enemy enemy;
    private void Start()
    {
        enemy = GetComponentInParent<Enemy>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            enemy.GetComponent<LookAtTarget>().OnTarget(other.transform);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            enemy.GetComponent<LookAtTarget>().OnTarget(null);
    }
}
