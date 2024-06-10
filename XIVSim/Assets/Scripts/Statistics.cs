using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public float health { get; private set; }
    public float maxMovementSpeed = 1f;
    public float currentMovementSpeed = 1f;
    public float acceleration = 1f;
}
