using UnityEngine;

public abstract class MovementState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;


    private readonly Character _character;

    public MovementState(IStateSwitcher stateSwitcher,StateMachineData data, Character character)
    {
        StateSwitcher = stateSwitcher;
        _character = character;
        Data = data;
    }

    protected PlayerInput Input => _character.Input;
    protected CharacterController CharaccterController => _character.Controller;

    private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);
    private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public virtual void Exit() { }

    public virtual void HandelInput()
    {
        Data.XInput = ReadHorizontalInpute();  
        Data.XVelocity = Data.XInput * Data.Speed;
    }

    public virtual void Update()
    {
        Vector3 velocity = GetConvertedVelosity();

        CharaccterController.Move(velocity * Time.deltaTime);
        _character.transform.rotation = GetRotation(velocity);
    }

    protected bool IsHorizontaleInpurZero() => Data.XInput == 0;

    private Quaternion GetRotation(Vector3 velocity)
    {
        if(velocity.x > 0)
            return TurnRight;

        if (velocity.x < 0)
            return TurnLeft;

        return _character.transform.rotation;
    }

    private Vector3 GetConvertedVelosity() => new Vector3(Data.XVelocity, Data.YVelocity, 0);

    private float ReadHorizontalInpute() => Input.Movement.Move.ReadValue<float>();
}
