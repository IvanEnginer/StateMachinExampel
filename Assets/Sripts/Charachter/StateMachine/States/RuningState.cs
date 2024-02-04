using UnityEngine;

public class RuningState : MovementState
{
    private readonly RunningStateConfig _config;

    public RuningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    => _config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StarRunning();

        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontaleInpurZero())
            StateSwitcher.SwitchState<IdleingState>();
    }
}
