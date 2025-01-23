using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    void Update()
    {
        transform.Translate(_direction, Space.Self);
    }
}
