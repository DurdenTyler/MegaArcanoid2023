using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockManager: MonoBehaviour
{
    [SerializeField] private int _damagePerHit = 1;
    
    public HashSet<Block> _blocks = new HashSet<Block>();

    private void Awake()
    {
        _blocks = FindObjectsOfType<Block>().ToHashSet();
    }

    public void DamageBlock(Block otherBlock)
    {
        otherBlock.Damage(_damagePerHit);
        if (otherBlock.isDestroyed)
        {
            _blocks.Remove(otherBlock);
        }
        
        if (_blocks.Count == 0)
        {
            print("Ты выйграл!");
        }
    }
}