using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallsManager: MonoBehaviour
{
    private List<Ball> _balls = new List<Ball>();

    private void Awake()
    {
        _balls = FindObjectsOfType<Ball>().ToList();
    }

    public void DestroyBall(Ball ball)
    {
        Destroy(ball.gameObject);
        _balls.Remove(ball);

        if (_balls.Count == 0)
        {
            print("Игра окончена!");
        }
    }
}
