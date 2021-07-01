using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : InteractiveObject
{
    public override void OnSomethingEnter(GameObject go)
    {
        print("agarra");
        base.OnSomethingEnter(go);
    }
}
