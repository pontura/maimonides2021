using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : EnemyState
{
    int distanceStopFollow = 18;
    int limit = 4;
    public float speed = 2;
    Character character;


    public override void Init()
    {
        enemy.anim.Play("Walk");
        character = enemy.character;
    }
    private void Update()
    {
        if (character == null)
        {
            Alert();
            return;
        }
        enemy.lookAtTarget.LookAt(character);
        float distanceToCharacter = Vector3.Distance(transform.position, character.transform.position);
        if (enemy.isHelper)
        {

        }
        else
        {
            if (distanceToCharacter > distanceStopFollow)
                Alert();
            else if (distanceToCharacter < limit)
                enemy.SetNewState(states.TALK);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void Alert()
    {
        //enemy.SetNewState(states.ALERT);
    }
}
