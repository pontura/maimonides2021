using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("ViewController OnTriggerEnter: " + other.name);
    }
}
