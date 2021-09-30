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
        Character character = other.gameObject.GetComponent<Character>();
        if (character != null)
            enemy.OnCharacterEnterViewZone(character);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            enemy.OnCharacterEnterViewZone(null);
    }
}
