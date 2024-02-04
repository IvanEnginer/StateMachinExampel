using UnityEngine;

public class RuningState : MovementState
{
    public RuningState(IStateSwitcher stateSwitcher,StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = 5;
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontaleInpurZero())
            StateSwitcher.SwitchState<IdleingState>();
    }
}
