using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseAbility
{
    public string axis { get; } = "None";
    public float cooldown { get; } = 0f;
    public Image icon;

    // particles
    // animations

    public abstract IEnumerator Logic();
}
