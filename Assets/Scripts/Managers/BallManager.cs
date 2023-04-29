using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallManager: MonoBehaviour
{
    public static BallManager Instance => _instance;
    private static BallManager _instance;
    
    public HashSet<Ball> _balls = new HashSet<Ball>();

    [SerializeField] private GameStateManager _gameStateManager;
 
    private void Awake()
    {
        _instance = this;
        _balls = FindObjectsOfType<Ball>().ToHashSet();
    }

    public void DestroyBall(Ball ball)
    {
        Destroy(ball.gameObject);
        _balls.Remove(ball);

        if (_balls.Count == 0)
        {
            _gameStateManager.Lose();
        }
    }
}
