using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JumpingStateConfig
{
    [SerializeField, Range(0, 10)] private float _maxHeight;
    [SerializeField, Range(0, 10)] private float _timeToREachMaxHeight;

    public float StartYVelocity => 2 * _maxHeight / _timeToREachMaxHeight;
    public float MaxHeight => _maxHeight;
    public float TimeToReachMaxHeight => _timeToREachMaxHeight;

}
