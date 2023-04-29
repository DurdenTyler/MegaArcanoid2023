using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Block : MonoBehaviour
{
    public ElementName ElementName => _elementName;
    
    [SerializeField] private float _hp = 1;
    [SerializeField] private ElementName _elementName;
    [SerializeField] private TextMeshPro _hpText;

    private void Awake()
    {
        _hpText.text = _hp.ToString();
    }

    public bool isDestroyed { get; private set; } = false;

    public void Damage(int damage)
    {
        _hp -= damage;
        _hpText.text = _hp.ToString();

        if (_hp <= 0)
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
