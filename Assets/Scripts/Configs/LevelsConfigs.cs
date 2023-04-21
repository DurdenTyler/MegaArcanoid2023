using UnityEngine;

// CreateAssetMenu позволяет создавать такой файл с правой кнопки мыши
[CreateAssetMenu(menuName = nameof(LevelsConfigs))]
public class LevelsConfigs: ScriptableObject
{
    public LevelConfig[] Levels => _levels;
    
    [SerializeField] private LevelConfig[] _levels;
}