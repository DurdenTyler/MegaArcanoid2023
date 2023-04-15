 

using System;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class MouseInputController : InputProviderBase
{
    private Vector3 _mousePosOld;

    [SerializeField] private BallLauncher _ballLauncher;
    private bool _ballWaslaunched = false;

    private void Awake()
    {
        _ballLauncher.OnLaunched += StartMove;
    }

    private void StartMove()
    {
        _ballWaslaunched = true;
    }

    private void Update()
    {
        _mousePosOld = Input.mousePosition;
    }

    public override float GetCurrentInput()
    {
        if (!_ballWaslaunched) return 0f;

        return -(_mousePosOld - Input.mousePosition).x;

    }
}
