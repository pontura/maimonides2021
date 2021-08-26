using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{
    public Animator anim;
    public void SetSpeed(float speed)
    {
        anim.SetFloat("speed", speed);
    }
    public void Attack()
    {
        anim.SetBool("attack", true);
    }
    public void EndAttack()
    {
        anim.SetBool("attack", false);
    }
    public void PlayAttackSound()
    {
        print("sound");
    }
}
