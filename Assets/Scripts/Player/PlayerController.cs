using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private CharacterController _charactereController;

    private State currentState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _charactereController = GetComponent<CharacterController>();
        currentState = new PlayerIdleState(this);
        currentState.Enter();
    }

    // Update is called once per frame
    void Update()
    {
        HandleStates();
        currentState.StateUpdate();
    }
    private void FixedUpdate()
    {
        currentState.StateFixedUpdate();
    }
    private void HandleStates() {
        
        if (currentState.isEnded())
        {
            try
            {
                currentState.Exit();
                
            } catch(NotImplementedException e) {
                Debug.LogError("State " + currentState.GetType().Name + " has not implemented methods");
            }
            currentState = currentState.GetNextState();
        }
    }
}
