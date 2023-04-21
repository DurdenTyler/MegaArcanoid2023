using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager: MonoBehaviour
{
    [SerializeField] private LevelsConfigs _levelsConfigs;
    [SerializeField] private GameStateManager _gameStateManager;

    private void Awake()
    {
        _gameStateManager.OnWin += SetCurrentLevelAsCompleted;
    }

    private void SetCurrentLevelAsCompleted()
    {
        var currentScene = SceneManager.GetActiveScene().name;

        foreach (var level in _levelsConfigs.Levels)
        {
            if (level.SceneName == currentScene)
            {
                level.isCompleted = true;
                return;
            }
        }
    }

}
