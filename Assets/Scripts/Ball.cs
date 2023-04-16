using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BlockManager _blockManager;
    [SerializeField] private BallsManager _ballsManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //var otherBlock = collision.transform.GetComponent<Block>();
        
        if (collision.transform.TryGetComponent<Block>(out var otherBlock))
        {
            _blockManager.DamageBlock(otherBlock);
        }
        
        if (collision.transform.TryGetComponent<KillPlane>(out KillPlane _))
        {
            _ballsManager.DestroyBall(this);
        }
        
    }
}
