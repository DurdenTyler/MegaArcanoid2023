using System;
using TMPro;
using UnityEngine;

public class MessageManager: MonoBehaviour
{
    [SerializeField] private GameStateManager _gameStateManager;
    
    [SerializeField] private TextMeshProUGUI _text;

    private void Awake()
    {
        _text.enabled = false;
        _gameStateManager.OnWin += Win;
        _gameStateManager.OnLose += Lose;
    }

    private void Win()
    {
        _text.text = "You Win";
        _text.enabled = true;
    }
    
    private void Lose()
    {
        _text.text = "You Lose";
        _text.enabled = true;
    }
}
