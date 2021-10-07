using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : EnemyState
{
    int limit = 4;
    public override void Init()
    {
        enemy.anim.Play("Attack");        
    }
    //public override void OnCharacterExitViewZone(Character character)
    //{
    //    enemy.SetNewState(states.IDLE);
    //}
    //private void Update()
    //{
    //    float distanceToCharacter = Vector3.Distance(transform.position, enemy.character.transform.position);
    //    if (distanceToCharacter > limit)
    //        enemy.SetNewState(states.FOLLOW);
    //}
}
