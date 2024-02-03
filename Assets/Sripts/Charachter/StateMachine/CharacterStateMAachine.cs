using System.Collections.Generic;
using System.Linq;

public class CharacterStateMAachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentsState;

    public CharacterStateMAachine()
    {
        _states = new List<IState>()
        {

        };

        _currentsState = _states[0];
        _currentsState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);

        _currentsState.Exit();
        _currentsState = state;
        _currentsState.Enter();
    }

    public void HandelInput() => _currentsState.HandelInput();

    public void Update() => _currentsState.Update();
}
