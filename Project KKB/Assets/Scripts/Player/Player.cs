using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private InputManager inputManager;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();

        inputManager = InputManager.Instance;
    }


    protected override void Update()
    {
        base.Update();

        Debug.Log(inputManager.GetMoveInput());
    }
}
