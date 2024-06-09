using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public BaseState superContext {  get; private set; }
    public BaseState subContext { get; private set; }

    public IInputHandler movementHandler;

    private void SwitchSuperState(BaseState _nextState)
    {
        if (this.superContext.GetType() != _nextState.GetType()) { this.superContext.ExitState(); }
        this.superContext = _nextState;
        this.superContext.EnterState();
    }
    private void SwitchSubState(BaseState _nextState)
    {
        if (this.subContext.GetType() != _nextState.GetType()) { this.subContext.ExitState(); }
        this.subContext = _nextState;
        this.subContext.EnterState();
    }

    private void StateHandler()
    {
        // Movement
        BaseState _nextSuperState;
        BaseState _nextSubState;

        if (this.movementHandler.horizontal != 0 || this.movementHandler.vertical != 0) 
        { 
            _nextSuperState = new WalkState(this.superContext, this.subContext);
        }

        else 
        { 
            _nextSuperState = new IdleState(this.superContext, this.subContext);
        }

        //Debug.Log(_nextSuperState);

        if (this.superContext.CheckStateSwitch(_nextSuperState)) 
        { 
            SwitchSuperState(_nextSuperState);
        }
        
        // Abilities

        if (movementHandler.abilityInputMap["Jump"] == 1) 
        { 
            _nextSubState = new JumpState(this.superContext, this.subContext);
        }

        else { _nextSubState = new GroundedState(this.superContext, this.subContext); }

        if (this.subContext.CheckStateSwitch(_nextSubState)) 
        { 
            SwitchSubState(_nextSubState);
        }
    }

    private void Awake()
    {
        movementHandler = this.GetComponent<IInputHandler>();
    }

    void Start()
    {
        this.subContext = new GroundedState(this.superContext, this.subContext);
        this.superContext = new IdleState(this.superContext, this.subContext);
    }

    void Update()
    {
        StateHandler();
    }
}
