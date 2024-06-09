using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public IdleState(BaseState superContext, BaseState subContext) : base(superContext, subContext) { }

    public override void EnterState()
    {
        Debug.Log("Entering Idle");
    }

    public override bool CheckStateSwitch(BaseState _nextState)
    {
        if ((_nextState is WalkState) && (this.subContext is not JumpState)) { return true; }
        else { return false; }
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Idle");
    }
}
