using System;
using UnityEngine;

public class AimInputProvider: IAimInputProvider
{
    public event Action OnLaunch;
    
    private Vector3 _aimTarget;
    
    public void OnUpdate()
    {
        ProccessLaunchInput();
        ProccesAimInput();
    }

    public Vector2 GetAimTarget()
    {
        return _aimTarget;
    }

    private void ProccesAimInput()
    {
        _aimTarget = Input.mousePosition;
    }
    
    private void ProccessLaunchInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnLaunch?.Invoke();
        }
    }
}
