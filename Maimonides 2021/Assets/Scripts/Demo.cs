using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public GameObject cam;
    public GameObject ball;
    public Vector3 cam_position; //  float, float, float

    private void Update()
    {
        cam.transform.position = ball.transform.position;
        cam.transform.localEulerAngles = ball.transform.localEulerAngles;
    }
}