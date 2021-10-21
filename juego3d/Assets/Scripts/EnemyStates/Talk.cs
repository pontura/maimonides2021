using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Talk : EnemyState
{
    public ChatUI chatUI;
    Character character;
    int limit = 5;
    public SpeachData[] speach;
    int id;

    [Serializable]
    public class SpeachData
    {
        public int id;
        public int gotoId;
        public string text;
        public moods mood;
        public MultiplechoiceData[] multiplechoice;
    }
    [Serializable]
    public class MultiplechoiceData
    {
        public string text;
        public int gotoId;
    }
    public enum moods
    {
        idle,
        angry,
        happy
    }


    public override void Init()
    {
        id = 0;
        character = enemy.character;
        enemy.anim.Play("Idle_Battle");
        chatUI.Init(speach, this);
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
    public void Idle()
    {
        enemy.anim.Play("Idle_Battle");
    }
    public void ChangeMood(moods mood)
    {
        switch(mood)
        {
            case moods.idle:
                enemy.anim.Play("Idle_Battle");
                break;
            case moods.happy:
                enemy.anim.Play("GetHit");
                break;
            case moods.angry:
                enemy.anim.Play("Defend");
                break;
        }
    }
}
