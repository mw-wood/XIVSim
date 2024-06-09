using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public float health { get; private set; }
    public float maxMovementSpeed { get; private set; }
    public float currentMovementSpeed { get; private set; }
    public float acceleration { get; private set; }
}
