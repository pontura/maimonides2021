using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : EnemyState
{
    public ChatUI chatUI;
    Character character;
    int limit = 5;
    public string[] speach;
    int id;

    public override void Init()
    {
        id = 0;
        character = enemy.character;
        enemy.anim.Play("Idle_Battle");
        TalkNext();
    }
    private void Update()
    {
        if (character == null)  return;

        enemy.lookAtTarget.LookAt(character);
        float distanceToCharacter = Vector3.Distance(transform.position, character.transform.position);
        if (distanceToCharacter > limit)
        {
            enemy.SetNewState(states.FOLLOW);
            chatUI.Hide();
        }
    }
    void TalkNext()
    {
        if (id > speach.Length - 1)
        {
            chatUI.Hide();
        }
        else
        {
            string say = speach[id];
            chatUI.Init(say, this);
        }
    }
    public void Idle()
    {
        enemy.anim.Play("Idle_Battle");
    }
    public void Happy()
    {
        id++;
        enemy.anim.Play("GetHit");
        TalkNext();
    }
    public void Angry()
    {
        id++;
        enemy.anim.Play("Defend");
        TalkNext();
    }
}
