using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Character : MonoBehaviour
{
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _characterController;

    public PlayerInput Input => _input;
    public CharacterController Controller => _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _input = new PlayerInput();
        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.HandelInput();
        _stateMachine.Update();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();
}
