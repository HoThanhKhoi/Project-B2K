using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected StateMachine stateMachine;

    public Animator anim {  get; private set; }
    public Rigidbody2D rb {  get; private set; }

    protected virtual void Awake()
    {
        stateMachine = new StateMachine();

        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start() { }

    protected virtual void Update() { }

    protected virtual void FixedUpdate() { }
}
