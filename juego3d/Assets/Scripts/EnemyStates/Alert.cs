using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : EnemyState
{
    int distanceToFollow = 15;

    private void Update()
    {
        if (enemy != null && enemy.character != null)
        {
            enemy.lookAtTarget.LookAt(enemy.character);
            float distanceToCharacter = Vector3.Distance(transform.position, enemy.character.transform.position);
            if (distanceToCharacter < distanceToFollow)
                enemy.SetNewState(states.FOLLOW);
        }
        else
        {
            enemy.SetNewState(states.IDLE);
        }
    }
    public override void Init()
    {
        enemy.anim.Play("Dizzy");
    }
    public override void OnCharacterExitViewZone(Character character)
    {
        enemy.SetNewState(states.IDLE);
    }
}
