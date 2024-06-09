using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseState
{
    public WalkState(BaseState superContext, BaseState subContext) : base(superContext, subContext) { }
    public override void EnterState()
    {
        Debug.Log("Entering Walk");
    }

    public override bool CheckStateSwitch(BaseState _nextState)
    {
        if ((_nextState is IdleState) && (this.subContext is not JumpState)) { return true; }
        else { return false; }
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Walk");
    }
}
