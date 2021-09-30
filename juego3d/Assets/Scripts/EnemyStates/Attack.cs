using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : EnemyState
{
    public override void Init()
    {
        enemy.anim.Play("Attack");        
    }
}
