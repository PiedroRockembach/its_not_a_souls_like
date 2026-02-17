using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : State
{
    InputAction moveAction;
    InputAction jumpAction;


    public PlayerIdleState(MonoBehaviour parent) : base(parent) { }
    public override void Enter()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
       
    }


    public override void StateFixedUpdate()
    {
        return;
    }

    public override void StateUpdate()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        if (moveValue != Vector2.zero) {
            nextState = new PlayerWalkState(parent);
            this.ended = true;
            return;
        }
        if (jumpAction.IsPressed()){
            
        }
    }


    public override void Exit()
    {
        throw new System.NotImplementedException();
    }
}
