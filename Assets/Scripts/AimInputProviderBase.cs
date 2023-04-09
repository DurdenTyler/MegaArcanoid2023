using System;
using UnityEngine;

public abstract class AimInputProviderBase: MonoBehaviour
{
    public abstract event Action OnLaunch;

    public abstract Vector2 GetAimTarget();
}