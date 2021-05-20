using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 50;
    public float limit = 18;

    void Update()
    {
        float x = transform.position.x;
        print(x);

        float dir = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -1;
        }

        transform.Translate(Vector3.right * dir * speed * Time.deltaTime);
    }

    void Update2()
    {
        float x = transform.position.x;
        print(x);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            x = transform.position.x;
            if (x > limit)
                transform.position = new Vector3(limit, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
            x = transform.position.x;
            if (x < -limit)
                transform.position = new Vector3(-limit, transform.position.y, transform.position.z);
        }
    }
    public void DoSomething()
    {
        print("character hace algo!");
    }
}
