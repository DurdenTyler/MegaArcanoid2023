using System;
using UnityEngine;

public class AimInputProvider: AimInputProviderBase
{
    public override event Action OnLaunch;
    
    private Vector3 _aimTarget;
    
    public void Update()
    {
        ProccessLaunchInput();
        ProccesAimInput();
    }

    public override Vector2 GetAimTarget()
    {
        return _aimTarget;
    }

    private void ProccesAimInput()
    {
        _aimTarget = Input.mousePosition;
        _aimTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    
    private void ProccessLaunchInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnLaunch?.Invoke();
        }
    }
}
