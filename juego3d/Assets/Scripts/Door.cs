using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    public override void OnSomethingEnter(GameObject go)
    {
        print("abre");
        base.OnSomethingEnter(go);
    }
    public override void OnSomethingExit(GameObject go)
    {
        print("ciera");
    }
}
