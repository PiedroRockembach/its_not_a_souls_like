using UnityEngine;

public abstract class State: MonoBehaviour
{

    protected MonoBehaviour parent;
    protected bool ended;
    protected State nextState;
    public State(MonoBehaviour parent)
    {
        this.parent = parent;
    }
    public State GetNextState() => nextState;
    public bool isEnded() => ended;
    public abstract void StateUpdate();
    public abstract void StateFixedUpdate();
    public abstract void Enter();
    public abstract void Exit();
}
