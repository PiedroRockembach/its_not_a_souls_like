using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalkState : State
{
    InputAction moveAction;
    InputAction jumpAction;
    Rigidbody rb;

    public PlayerWalkState(MonoBehaviour parent) : base(parent)
    {
    }

    public override void Enter()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }

    public override void StateFixedUpdate()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
    }

    public override void StateUpdate()
    {
        throw new System.NotImplementedException();
    }

}
