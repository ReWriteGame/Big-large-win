using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotationDirection;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Rotate(rotationDirection.normalized * speed );
    }
}
