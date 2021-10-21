using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : EnemyState
{
    public override void Init()
    {
        enemy.anim.Play("Idle_Battle");
    }
    public override void OnTryToAttack() {  }
    public override void OnCharacterEnterViewZone(Character character)
    {
        if(enemy.isHelper)
            enemy.SetNewState(states.FOLLOW);
        else
            enemy.SetNewState(states.ALERT);
    }
}
