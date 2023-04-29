using UnityEngine;

[CreateAssetMenu(menuName = nameof(ElementsConfigs))]
public class ElementsConfigs: ScriptableObject
{
    public ElementConfig[] Elements => _elements;
    
    [SerializeField] private ElementConfig[] _elements;
}