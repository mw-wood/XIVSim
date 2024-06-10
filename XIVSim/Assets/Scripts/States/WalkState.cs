using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseState
{
    public CharacterController controller;
    public Statistics stats;
    public IInputHandler inputHandler;
    private Vector3 currentMovementDirection = new Vector3(0,0,0);
    public Transform _transform;
    public WalkState(BaseState superContext, BaseState subContext, CharacterController _controller, Statistics _stats, IInputHandler _inputHandler, Transform __transform) : base(superContext, subContext) 
    {
        this.controller = _controller;
        this.stats = _stats;
        this.inputHandler = _inputHandler;
        this._transform = __transform;
    }

    public override void EnterState()
    {
        Debug.Log("Entering Walk");
    }

    public override bool CheckStateSwitch(BaseState _nextState)
    {
        if ((_nextState is IdleState) && (this.subContext is not JumpState)) { return true; }
        else { return false; }
    }

    public override void Logic()
    {
        this.currentMovementDirection = ((_transform.right * inputHandler.horizontal) + (_transform.forward * inputHandler.vertical));
        this.currentMovementDirection = this.currentMovementDirection.normalized * stats.currentMovementSpeed;
        this.controller.Move(currentMovementDirection * Time.deltaTime);
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Walk");
    }
}
