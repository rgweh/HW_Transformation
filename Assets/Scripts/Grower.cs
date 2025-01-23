using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        transform.localScale += new Vector3.up * _speed;
    }
}
