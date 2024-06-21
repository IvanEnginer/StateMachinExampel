using System;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class GroundedState : MovementState
{
    private readonly GroundChecker _groundChecker;

    public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    => _groundChecker = character.GroundChecker;

    public override void Update()
    {
        base.Update();

        if (_groundChecker.IsTouches == false)
            StateSwitcher.SwitchState<FollingState>();
    }

    protected override void AddInputActionCallbacks()
    {
        base.AddInputActionCallbacks();

        Input.Movement.Jump.started += OnJumpKeyPressed;
    }

    protected override void RemoveInputActionCallbacks()
    {
        base.RemoveInputActionCallbacks();

        Input.Movement.Jump.started -= OnJumpKeyPressed;
    }

    private void OnJumpKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<JumpingState>();
}
