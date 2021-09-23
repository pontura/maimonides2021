using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum states
    {
        IDLE,
        ALERT,
        RUN,
        ATTACKING
    }
    public List<EnemyState> allStates;
    public states state;

    public void SetNewState(states state)
    {
        this.state = state;
    }
}
