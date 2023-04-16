using System;
using UnityEngine;

public class GameStateManager: MonoBehaviour
{
    public event Action OnWin;
    public event Action OnLose;

    public void Win()
    {
        OnWin?.Invoke();
    }
    
    public void Lose()
    {
        OnLose?.Invoke();
    }

}
