using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementState : PlayerState
{
    public PlayerMovementState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {

    }
    public override void Update()
    {
        base.Update();
        player.transform.position += new Vector3(player.moveInput.x, 0, player.moveInput.y) * player.moveSpeed * Time.deltaTime;
        if(player.moveInput == Vector2.zero)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
