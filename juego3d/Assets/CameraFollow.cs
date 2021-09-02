using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Character character;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = character.transform.position + offset;
    }
}
