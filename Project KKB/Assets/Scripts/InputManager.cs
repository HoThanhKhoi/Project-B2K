using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance 
    {  
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<InputManager>();

                if(instance == null)
                {
                    GameObject inputManagerObject = new GameObject("InputManager");
                    instance = inputManagerObject.AddComponent<InputManager>();
                }
            }

            return instance;
        }
    }
    public GameInputActions gameInputActions {  get; private set; }

    private Camera mainCamera;

    private void Awake()
    {
        SetUpSingleton();

        SetUpInput();
    }

    private void SetUpSingleton()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
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

        gameInputActions.Player.Enable();
        
    }

    public Vector2 GetMoveInput()
    {
        return gameInputActions.Player.Move.ReadValue<Vector2>();
    }
   
}
