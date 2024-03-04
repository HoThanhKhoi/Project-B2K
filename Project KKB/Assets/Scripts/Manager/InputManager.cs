using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    public GameInputActions gameInputActions {  get; private set; }

    private Camera mainCamera;

    protected override void Awake()
    {
        base.Awake();

        SetUpInput();
    }


    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        gameInputActions.Enable();
    }

    private void OnDisable()
    {
        gameInputActions.Disable();
    }

    private void SetUpInput()
    {
        gameInputActions = new GameInputActions();

        gameInputActions.RPGController.Enable();
        
    }

    public Vector2 GetMoveInput()
    {
        return gameInputActions.RPGController.Move.ReadValue<Vector2>();
    }
   
}
