using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : BaseState
{
    public JumpState(BaseState superContext, BaseState subContext) : base(superContext, subContext) { }
    public override void EnterState()
    {
        Debug.Log("Entering Jump");
        // Jump Logic, ie. play animation
    }

    public override bool CheckStateSwitch(BaseState _nextState)
    {
        if (_nextState is GroundedState) { return true; }
        else { return false; }
    }

    public override void Logic()
    {

    }

    public override void ExitState()
    {
        Debug.Log("Exiting Jump");
    }
}
