using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numberText;
    [SerializeField] private Button _button;

    private string _sceneName;
    
    public void DrawNumberText(string levelNumber, string sceneName, bool isCompleted)
    {
        _numberText.text = levelNumber;
        _sceneName = sceneName;
        _button.interactable = isCompleted;
        
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadSceneAsync(_sceneName);
    }
}
