using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public State currentState { get; private set; }
    
    public virtual void Initialize(State startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public virtual void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public virtual void DebugCurrentState()
    {

    }
}
