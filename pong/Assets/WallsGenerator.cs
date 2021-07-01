using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsGenerator : MonoBehaviour
{
    public float speed = 10;
    public int totalBricks = 20;
    public GameObject brick;
    // instanciar multiples Bricks (fragmento)
    // roto cada uno:

    void Start()
    {
        float angle = 360 / totalBricks;
        for (int a = 0; a < totalBricks; a++)
        {
            GameObject newBrick = Instantiate(brick, transform);
            float _y = angle*a;
            newBrick.transform.localEulerAngles = new Vector3(0, _y, 0);
        }
    }
    private void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }
}
