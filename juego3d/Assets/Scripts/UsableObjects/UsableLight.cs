using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableLight : UsableObjects
{
    bool flashlightOn;
    public override void UseIt()
    {
        flashlightOn = !flashlightOn;
        GetComponentInChildren<Light>().enabled = flashlightOn;
    }
}
