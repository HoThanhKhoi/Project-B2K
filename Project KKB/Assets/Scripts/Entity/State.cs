using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class State
{
    public StateMachine stateMachine;

    public State(Entity entity, StateMachine stateMachine, string animBoolName)
    {
        
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Update()
    {

    }

    public virtual void Exit()
    {

    }

    public virtual void FixedUpdate()
    {

    }

    public virtual void OnAnimationEnded()
    {

    }
}
