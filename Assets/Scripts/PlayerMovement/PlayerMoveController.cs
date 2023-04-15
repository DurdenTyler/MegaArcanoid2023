using System;
using UnityEngine;

public class PlayerMoveController: MonoBehaviour
{
    [SerializeField] private InputProviderBase _inputProvider;

    [SerializeField] private float _speed = 1f;

    [SerializeField] private float _levelBorderX;

    private void FixedUpdate()
    {
        var pos = transform.position;
        pos.x += _inputProvider.GetCurrentInput() * _speed;
        pos.x = Mathf.Clamp(pos.x, -_levelBorderX, _levelBorderX); // Ограничиваем диапазон
        transform.position = pos;
    }
}
