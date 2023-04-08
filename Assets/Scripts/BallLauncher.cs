using System;
using UnityEngine;
using UnityEngine.WSA;

public class BallLauncher: MonoBehaviour
{
    [SerializeField] private float _launchSpeed = 1f;
    [SerializeField] private Rigidbody2D _ball;
    private IAimInputProvider _inputProvider;

    private void Start()
    {
        _inputProvider = new AimInputProvider();
        
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
    }

    private void Update()
    {
        _inputProvider.OnUpdate();
    }
}
