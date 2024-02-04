using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runingStateConfig;
    
    public RunningStateConfig RunningStateConfig => _runingStateConfig;
}
