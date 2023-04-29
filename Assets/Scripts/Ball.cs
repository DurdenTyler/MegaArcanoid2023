using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour
{
    [SerializeField] private ElementsConfigs _elements;
    [SerializeField] private ElementName _firstElement = ElementName.Fire;
    private ElementConfig _currentElement;
    [SerializeField] private float _constansSpeed = 10f;
    private Rigidbody2D _rigidbody;
    [SerializeField] private TextMeshPro _hpText;

    private void Awake()
    {
        ChangeElement(_firstElement);
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var currentVelocity = _rigidbody.velocity;

        if (currentVelocity.magnitude < _constansSpeed)
        {
            _rigidbody.velocity = (_rigidbody.velocity / currentVelocity.magnitude) * _constansSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<Block>(out var otherBlock))
        {

            if (_currentElement.Name == otherBlock.ElementName || otherBlock.ElementName == ElementName.None)
            {
                BlockManager.Instance.DamageBlock(otherBlock);
            }
            else
            {
                ChangeElement(otherBlock.ElementName);
            }
        }
        
        if (collision.transform.TryGetComponent<KillPlane>(out KillPlane _))
        {
            BallManager.Instance.DestroyBall(this);
        }
    }

    private void ChangeElement(ElementName otherElement)
    {
        var allElements = _elements.Elements;

        ElementConfig newElementConfig = null;

        // Поиск через Linq
        // То есть присвоится первый элемент что будет соответствовать
        newElementConfig = allElements.FirstOrDefault(el => el.Name == otherElement);

        if (newElementConfig == null) return;

        var renderer = gameObject.GetComponent<Renderer>();
        renderer.sharedMaterial = newElementConfig.Material;

        _currentElement = newElementConfig;
    }
}
