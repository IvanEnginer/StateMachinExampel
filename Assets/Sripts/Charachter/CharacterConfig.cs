using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runingStateConfig;
    [SerializeField] private AirbornStateConfig _airbornStateConfig;
    public RunningStateConfig RunningStateConfig => _runingStateConfig;
    public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
}
