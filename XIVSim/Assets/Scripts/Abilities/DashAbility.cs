using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashAbility : BaseAbility
{
    public string axis { get; } = "None";
    public float cooldown { get; } = 0f;
    public Image icon;

    private CharacterController controller;
    private Transform playerTransform;

    public float distance { get; private set; } = 10f;
    public int numberOfFrames { get; } = 30;

    public DashAbility(CharacterController _controller, Transform _transform)
    {
        this.controller = _controller;
        this.playerTransform = _transform;
    }

    public override IEnumerator Logic()
    {
        float startTime = Time.time;
        float duration = numberOfFrames / 60.0f; // 60fps magic number

        Vector3 distancePerSecond = playerTransform.forward * distance / duration;

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float deltaTime = Time.deltaTime;

            this.controller.Move(distancePerSecond * deltaTime);

            elapsedTime += deltaTime;

            yield return null;
        }

        this.controller.Move(playerTransform.forward * (distance - (elapsedTime * distancePerSecond.magnitude)));
        Debug.Log(Time.time - startTime);
    }
}

