using System;
using UnityEngine;
using UnityEngine.WSA;
using Application = UnityEngine.Application;

public class BallLauncher: MonoBehaviour
{
    public event Action OnLaunched;
    
    [SerializeField] private float _launchSpeed = 1f;
    [SerializeField] private Rigidbody2D _ball;
    [SerializeField] private AimInputProviderBase _inputProvider;

    private void Start()
    {
        _inputProvider.OnLaunch += Launch;

        _ball.transform.parent = transform;

    }

    private void Launch()
    {
        _inputProvider.OnLaunch -= Launch;
        var shootDirection = _inputProvider.GetAimTarget() - _ball.position;
        shootDirection.Normalize();
        shootDirection *= _launchSpeed;
        _ball.transform.parent = null;
        _ball.AddForce(shootDirection, ForceMode2D.Impulse);
        OnLaunched?.Invoke();
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        
        Gizmos.color = Color.red;

        var initialPos = transform.position;
        
        var targetPos = _inputProvider.GetAimTarget();
        
        Gizmos.DrawLine(initialPos, targetPos);
        
    }
}
