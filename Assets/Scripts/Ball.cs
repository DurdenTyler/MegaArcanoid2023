using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour
{
    [SerializeField] private BlockManager _blockManager;
    [FormerlySerializedAs("_ballsManager")] [SerializeField] private BallManager ballManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //var otherBlock = collision.transform.GetComponent<Block>();
        
        if (collision.transform.TryGetComponent<Block>(out var otherBlock))
        {
            _blockManager.DamageBlock(otherBlock);
        }
        
        if (collision.transform.TryGetComponent<KillPlane>(out KillPlane _))
        {
            ballManager.DestroyBall(this);
        }
        
    }
}
