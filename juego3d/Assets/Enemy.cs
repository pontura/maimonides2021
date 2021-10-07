using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<EnemyState> allStates;
    EnemyState currentState;
    public Animator anim;
    public Character character;
    public LookAtTarget lookAtTarget;

    private void Start()
    {
        SetNewState(EnemyState.states.IDLE);
    }
    public void SetNewState(EnemyState.states stateType) // solo puede ser llamado desde un estado:
    {
        foreach (EnemyState enemyState in allStates)
        {
            if (enemyState.state == stateType)
            {
                this.currentState = enemyState;
                currentState.enabled = true;
                currentState.Init();
            }
            else
            {
                enemyState.enabled = false;
            }
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            currentState.OnTryToAttack();
        }
    }
    public void OnCharacterEnterViewZone(Character character)
    {
        this.character = character;
        if (character == null)
            currentState.OnCharacterExitViewZone(character);
        else
            currentState.OnCharacterEnterViewZone(character);
    }
}
