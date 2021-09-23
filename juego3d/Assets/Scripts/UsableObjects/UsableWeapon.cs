using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableWeapon : UsableObjects
{
    public override void UseIt() // cuando aprieto atacar:
    {
        ActionsManager am = GetComponentInParent<ActionsManager>();
        am.Attack();
    }
}
