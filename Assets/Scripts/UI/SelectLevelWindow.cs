using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevelWindow : MonoBehaviour
{
    [SerializeField] private LevelButton _levelButtonPrefab;
    [SerializeField] private RectTransform _content;
    [SerializeField] private LevelsConfigs _levelsConfigs;

    private void Awake()
    {
        for (int i = 0; i < _levelsConfigs.Levels.Length; i++)
        {
            var buttonInstance = Instantiate(_levelButtonPrefab, _content);

            var levelConfig = _levelsConfigs.Levels[i];

            bool active = levelConfig.isCompleted ||
                          (i - 1 >= 0 && _levelsConfigs.Levels[i - 1].isCompleted) || i == 0;
            
            buttonInstance.DrawNumberText((i + 1).ToString(), levelConfig.SceneName, active);
        }
    }
}
