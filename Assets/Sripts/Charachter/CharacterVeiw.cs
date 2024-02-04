using UnityEngine;

[RequireComponent (typeof(Animator))]
public class CharacterVeiw : MonoBehaviour
{
    private const string IsIdlinge = "IsIdling";
    private const string IsRunning = "IsRunning";

    private Animator _animator;

    public void Initialize() => _animator = GetComponent<Animator>();

    public void StartIdling() => _animator.SetBool (IsIdlinge, true);
    public void StopIdling()=> _animator.SetBool(IsIdlinge, false);

    public void StarRunning()=> _animator.SetBool(IsRunning, true);
    public void StopRunning()=> _animator.SetBool(IsRunning, false);
}
