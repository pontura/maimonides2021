using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public int score;

    public virtual void OnSomethingEnter(GameObject go)
    {
        print("gano " + score);
    }
    public virtual void OnSomethingExit(GameObject go)
    {

    }
}
