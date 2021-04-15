using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //cada frame mientras se apriete derecha:

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

        }
    }
    public void DoSomething()
    {
        print("character hace algo!");
    }
}
