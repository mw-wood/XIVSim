using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    private CharacterController controller;
    private Transform _transform;
    private BaseAbility ability;
    void Awake()
    {
        controller = this.GetComponent<CharacterController>();
        _transform = this.transform;
        Application.targetFrameRate = 120;
    }

    private void Start()
    {
        ability = new DashAbility(controller, _transform);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(ability.Logic());
        }
    }
}
