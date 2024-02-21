using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class State
{
    protected Entity_SM entity;
    protected StateMachine stateMachine;
    public string animBoolName {  get; protected set; }
    public State(Entity_SM _entity, StateMachine _stateMachine, string _animBoolName)
    {
        entity = _entity;
        stateMachine = _stateMachine;
        animBoolName = _animBoolName;
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
