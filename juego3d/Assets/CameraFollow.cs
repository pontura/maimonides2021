using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Character character;
    public Vector3 offset;
    public float smooth;

    void Update()
    {
        Vector3 dest = character.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, dest, smooth * Time.deltaTime);
    }
}
