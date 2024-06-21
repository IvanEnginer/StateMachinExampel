using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirbornState : MovementState
{
    private readonly AirbornStateConfig _config;
    public AirbornState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    => _config = character.Config.AirbornStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;
    }

    public override void Update()
    {
        base.Update();

        Data.YVelocity -= GetFravityMultiplier() * Time.deltaTime;
    }

    protected virtual float GetFravityMultiplier() => _config.BaseGravity;
}
