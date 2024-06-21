using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FollingState : AirbornState
{
    public FollingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }
}
