using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : EnemyState
{
    int distanceStopFollow = 18;
    int limit = 4;
    float speed = 5;

    public override void Init()
    {
        enemy.anim.Play("Walk");
    }
    private void Update()
    {
        if (enemy.character == null)
        {
            enemy.SetNewState(states.ALERT);
            return;
        }
        enemy.lookAtTarget.LookAt(enemy.character);
        float distanceToCharacter = Vector3.Distance(transform.position, enemy.character.transform.position);
        if (distanceToCharacter > distanceStopFollow)
            enemy.SetNewState(states.ALERT);
        else if(distanceToCharacter < limit)
        {
            enemy.SetNewState(states.ATTACK);
        } else
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
