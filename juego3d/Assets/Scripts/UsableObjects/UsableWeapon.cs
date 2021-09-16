using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableWeapon : UsableObjects
{
    public override void UseIt()
    {
        ActionsManager am = GetComponentInParent<ActionsManager>();
        am.Attack();
    }
}
