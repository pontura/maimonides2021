using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearableObject : MonoBehaviour
{
    public types type;
    public enum types
    {
        HEAD,
        FOOT,
        BODY,
        ARMS
    }
    public void Wear()
    {
        print("wear");
    }
}
