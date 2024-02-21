using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity_SM
{
    private InputManager inputManager;
    public float moveSpeed = 10f;

    #region State Machine
    public PlayerMovementState movementState;
    public PlayerIdleState idleState;

    #endregion

    public Vector2 moveInput {  get; set; }

    protected override void Awake()
    {
        base.Awake();
        SetUpState();
    }

    protected override void Start()
    {
        base.Start();

        inputManager = InputManager.Instance;
        stateMachine.Initialize(idleState);
    }

    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();
        moveInput = inputManager.GetMoveInput();

        stateMachine.DebugCurrentState();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        stateMachine.currentState.FixedUpdate();
    }

    protected override void SetUpState()
    {
        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        movementState = new PlayerMovementState(this, stateMachine, "Movement");
    }
}
