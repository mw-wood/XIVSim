using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour, IInputHandler
{
    public float horizontal { get; private set; }
    public float vertical { get; private set; }



    // Axis, Value
    public Dictionary<string, float> abilityInputMap { get; private set; } = new Dictionary<string, float>
        {
            { "Sprint", 0f },
            { "Dash", 0f },
            { "Jump", 0f }
        };

    public void GetMovementAxis()
    {
        this.horizontal = Input.GetAxisRaw("Horizontal");
        this.vertical = Input.GetAxisRaw("Vertical");
    }

    public void GetAbilityAxis()
    {
        List<string> keys = new List<string>(abilityInputMap.Keys);
        foreach (string key in keys)
        {
            abilityInputMap[key] = Input.GetButtonDown(key) ? 1 : 0;
        }
    }

    void Update()
    {
        GetMovementAxis();
        GetAbilityAxis();
    }
}
