using System;
using UnityEngine;

public interface IAimInputProvider
{
    public event Action OnLaunch; 

    public void OnUpdate();

    public Vector2 GetAimTarget();
}