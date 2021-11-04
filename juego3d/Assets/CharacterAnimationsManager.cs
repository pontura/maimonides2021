using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationsManager : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        Idle();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Walk();
        if (Input.GetKeyDown(KeyCode.Q))
            Idle();
    }
    public void Idle()
    {
        anim.Play("Monster_anim|Idle_1");
    }
    public void Walk()
    {
        anim.Play("Monster_anim|Walk");
    }
}
