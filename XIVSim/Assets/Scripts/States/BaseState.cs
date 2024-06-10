using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public BaseState superContext { get; set; }
    public BaseState subContext { get; set; }
    public BaseState(BaseState _superContext, BaseState _subContext)
    {
        this.superContext = _superContext;
        this.subContext = _subContext;
    }
    public abstract void EnterState();
    public abstract bool CheckStateSwitch(BaseState _nextState);

    public abstract void Logic();
    public abstract void ExitState();
}
