using UnityEngine;

public class IdleingState : MovementState
{
    public IdleingState(IStateSwitcher stateSwitcher,StateMachineData data ,Character character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        View.StartIdling();

        Data.Speed = 0;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopIdling();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontaleInpurZero())
            return;

        StateSwitcher.SwitchState<RuningState>();
    }


}
