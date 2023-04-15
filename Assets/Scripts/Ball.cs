using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BlockManager _blockManager;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //var otherBlock = collision.transform.GetComponent<Block>();
        
        if (collision.transform.TryGetComponent<Block>(out var otherBlock))
        {
            _blockManager.DamageBlock(otherBlock);
        }
        
    }
}
