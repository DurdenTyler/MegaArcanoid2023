using System;
using UnityEngine;

public class LaserPointerView: MonoBehaviour
{
    [SerializeField] private AimInputProviderBase _aimInputProvider;
    [SerializeField] private BallLauncher _ballLauncher;

    private void Awake()
    {
        _ballLauncher.OnLaunched += Hide;
    }

    private void Hide()
    {
        _ballLauncher.OnLaunched -= Hide;
        Destroy(gameObject);
    }

    private void Update()
    {
        Vector3 targetPoint = _aimInputProvider.GetAimTarget();

        var direction = targetPoint - transform.position;

        transform.up = direction;
    }
}