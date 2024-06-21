using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _ground;
    [SerializeField, Range(0.01f, 1)] private float _distanceTocheck;

    public bool IsTouches { get; private set; }

    private void Update()=> IsTouches = Physics.CheckSphere(transform.position, _distanceTocheck, _ground);
}
