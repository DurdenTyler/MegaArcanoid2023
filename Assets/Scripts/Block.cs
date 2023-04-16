using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private float _hp = 1;

    public bool isDestroyed { get; private set; } = false;

    public void Damage(int damage)
    {
        _hp -= damage;

        if (_hp <= 0)
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
