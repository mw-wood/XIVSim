using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : BaseState
{
    public GroundedState(BaseState superContext, BaseState subContext) : base(superContext, subContext) { }
    public override void EnterState()
    {
        Debug.Log("Entering Grounded");
    }

    public override bool CheckStateSwitch(BaseState _nextState)
    {
        if (_nextState is JumpState) { return true; }
        else { return false; }
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Grounded");
    }
}
