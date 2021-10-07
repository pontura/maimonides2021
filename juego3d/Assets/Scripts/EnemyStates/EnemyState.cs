using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public Enemy enemy;
    public states state;
    public enum states
    {
        IDLE,
        ATTACK,
        ALERT,
        FOLLOW,
        TALK
    }
    void Awake() {
        enemy = GetComponent<Enemy>();
    }
    private void Start()
    {
        
    }
    public virtual void Init() {}

    public virtual void OnTryToAttack()
    {
        enemy.SetNewState(states.ATTACK);
    }
    public virtual void OnCharacterEnterViewZone(Character character)
    {
        print("entro y soy EnemyState : " + character);
    }
    public virtual void OnCharacterExitViewZone(Character character)
    {
        print("salio y soy EnemyState : " + character);
    }
}
