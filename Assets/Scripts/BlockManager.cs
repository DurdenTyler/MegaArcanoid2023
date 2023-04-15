using UnityEngine;

public class BlockManager: MonoBehaviour
{
    [SerializeField] private int _damagePerHit = 1;
    
    public void DamageBlock(Block otherBlock)
    {
        otherBlock.Damage(_damagePerHit);
    }
}