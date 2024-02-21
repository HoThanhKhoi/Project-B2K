using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : State
{
    protected Player player;
    public PlayerState(Player _player, StateMachine _stateMachine, string _animBoolName): base(_player, _stateMachine, _animBoolName)
    {
        player = _player;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void OnAnimationEnded()
    {
        base.OnAnimationEnded();
    }
}
