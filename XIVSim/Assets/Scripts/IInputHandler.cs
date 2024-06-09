using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputHandler
{
    float horizontal { get; }
    float vertical { get; }

    // Axis, Value
    Dictionary<string, float> abilityInputMap { get; }

    void GetMovementAxis();
    void GetAbilityAxis();
}
