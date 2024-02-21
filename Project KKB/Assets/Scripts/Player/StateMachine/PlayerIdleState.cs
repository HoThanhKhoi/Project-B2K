using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
        
    }

    public override void Update()
    {
        base.Update();
        if(player.moveInput != Vector2.zero)
        {
            stateMachine.ChangeState(player.movementState);
        }

        
    }
}
