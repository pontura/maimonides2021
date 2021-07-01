using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;
    public int id;

    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical" + id);
        horizontalAxis = Input.GetAxis("Horizontal" + id);
    }
}
