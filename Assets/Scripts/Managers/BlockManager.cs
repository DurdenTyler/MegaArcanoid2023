using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BlockManager: MonoBehaviour
{
    [SerializeField] private GameStateManager _gameStateManager;
    
    [SerializeField] private int _damagePerHit = 1;

    public HashSet<Block> _blocks = new HashSet<Block>();

    public static BlockManager Instance => _instance;
    private static BlockManager _instance;
    
    

    private void Awake()
    {
        _instance = this;
        _blocks = Enumerable.ToHashSet(FindObjectsOfType<Block>());
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
            _gameStateManager.Win();
        }
    }
}