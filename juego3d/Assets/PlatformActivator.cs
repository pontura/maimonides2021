using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivator : MonoBehaviour
{
    public Door door;
    public int totalObjects;
    public int qty = 3;

    private void OnCollisionEnter(Collision collision)
    {
        totalObjects++;
        if(totalObjects>=qty)
            door.Open();
    }
    private void OnCollisionExit(Collision collision)
    {
        totalObjects--;
        if (totalObjects < qty)
            door.Close();
    }
}
